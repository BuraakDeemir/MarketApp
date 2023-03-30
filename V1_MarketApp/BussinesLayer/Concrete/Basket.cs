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
	public class Basket : BaseBasket
	{
		private static DbInfoTechSales_NewEntities Context;

		public Basket()
		{
			Context = new DbInfoTechSales_NewEntities();
		}
		public override int CreateBasket(TblSepet Basket)
		{
			Context.TblSepet.Add(Basket);
			Context.SaveChanges();
			return Basket.SepetId;
		}

		public override bool AddProductToBasket(TblSepetDetay BasketDetail)
		{
			bool result = false;
			var UrunSepetteVarmi = (from data in Context.TblSepetDetay
									where data.UrunId == BasketDetail.UrunId &&
									data.SepetId == BasketDetail.SepetId
									select data).Any();
			if (UrunSepetteVarmi)
			{
				var sepettekiUrun = (from data in Context.TblSepetDetay
									 where data.UrunId == BasketDetail.UrunId &&
									 data.SepetId == BasketDetail.SepetId
									 select data).FirstOrDefault();
				sepettekiUrun.Adet += BasketDetail.Adet;
				Context.SaveChanges();
				result = true;
			}
			else
			{
				Context.TblSepetDetay.Add(BasketDetail);
				Context.SaveChanges();
				result = true;
			}
			return result;
		}

		public override List<TblUrun> ShowProductByProductId(int ProductId)
		{
			return (from data in Context.TblUrun
					where data.UrunId == ProductId
					select data).ToList();
		}

		public override List<VwBasket> GetBasketByUserId(int UserId)
		{
			return (from data in Context.VwBasket
					where data.KisiId == UserId
					select data).ToList();
		}

		public override int BasketCount(int UserId)
		{
			return (from data in Context.VwBasket
					where data.KisiId == UserId
					select data).ToList().Count;
		}

		public override void DeleteBasketbyBasketId(int BasketId)
		{
			TblSepetDetay tblSepetDetay = (from data in Context.TblSepetDetay
										   where data.SepetId == BasketId
										   select data).SingleOrDefault();
			Context.TblSepetDetay.Remove(tblSepetDetay);
			Context.SaveChanges();
		}

		public override void DeleteAllBasketByUserId(int UserId)
		{
			List<TblSepetDetay> tblSepetDetayCount = (from data in Context.TblSepetDetay
													  where data.KisiId == UserId
													  select data).ToList();
			int count = tblSepetDetayCount.Count;

			for (int i = 0; i < count; i++)
			{
				TblSepetDetay tblSepetDetay = (from data in Context.TblSepetDetay
											   where data.KisiId == UserId
											   select data).FirstOrDefault();
				Context.TblSepetDetay.Remove(tblSepetDetay);
				Context.SaveChanges();
			}
		}
	}
}
