using BussinesLayer.Abstract;
using DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class Order : BaseOrder
	{
		private static DbInfoTechSales_NewEntities Context;

		public Order()
		{
			Context = new DbInfoTechSales_NewEntities();
		}

		public override List<VwOrder> GetOrderByPersonId(int PersonId)
		{
			return (from data in Context.VwOrder
					where
					data.PersonId == PersonId
					orderby data.OrderId descending
					select data).ToList();
		}

		public override List<TblOrderDetails> GetOrderDetailsByOrderId(int OrderId)
		{
			return (from data in Context.TblOrderDetails
					where
					data.orderId == OrderId
					select data).ToList();
		}

		public override string ShowProductByProductId(int ProductId)
		{
			return (from data in Context.TblUrun
					where data.UrunId == ProductId
					select data.UrunAdi).SingleOrDefault();
		}

		public override void OrderAdd(int PersonId)
		{
			TblOrder tblOrder = new TblOrder();
			tblOrder.PersonId = PersonId;
			tblOrder.CreateDate = DateTime.Now;
			tblOrder.Situation = 1;
			Context.TblOrder.Add(tblOrder);
			Context.SaveChanges();
			int OrderId = tblOrder.OrderId;
			TblKisiAdres tblKisiAdres = (from data in Context.TblKisiAdres
										 where
										 data.KisiId == PersonId
										 select data).SingleOrDefault();
			string PersonAdress = tblKisiAdres.Adres;
			TblKisiTelefon tblKisiTelefon = (from data in Context.TblKisiTelefon
											 where
											 data.KisiId == PersonId
											 select data).SingleOrDefault();
			string PersonContact = tblKisiTelefon.Telefon;

			int TotalBasketCount = (from data in Context.TblSepetDetay
									where
									data.KisiId == PersonId
									select data).Count();

			for (int i = 0; i < TotalBasketCount; i++)
			{
				TblSepetDetay tblSepetDetay = (from data in Context.TblSepetDetay
											   where
											   data.KisiId == PersonId
											   select data).FirstOrDefault();
					TblOrderDetails tblOrderDetails = new TblOrderDetails()
					{
						orderId = OrderId,
						PersonId = PersonId,
						PersonAdress = PersonAdress,
						PersonContact = PersonContact,
						ProductId = tblSepetDetay.UrunId,
					};
					Context.TblOrderDetails.Add(tblOrderDetails);
					double X_OrderTex = Convert.ToDouble(tblSepetDetay.KdvToplami);
					double X_OrderlSub = Convert.ToDouble(tblSepetDetay.AraToplam);
					TblOrderPrice tblOrderPrice = new TblOrderPrice()
					{
						OrderId = OrderId,
						OrderPiece = Convert.ToInt32(tblSepetDetay.Adet),
						OrderTex = X_OrderTex,
						OrderlSub = X_OrderlSub,
						OrderTotalPrice = (int?)Convert.ToDouble(X_OrderTex + X_OrderlSub),
					};
					Context.TblOrderPrice.Add(tblOrderPrice);
					Context.TblSepetDetay.Remove(tblSepetDetay);
					Context.SaveChanges();
				
			}


		}

		public override int OrderCount(int PersonId)
		{
			return (from data in Context.VwOrder
					where
					data.PersonId == PersonId
					select data).Count();
		}
	}
}
