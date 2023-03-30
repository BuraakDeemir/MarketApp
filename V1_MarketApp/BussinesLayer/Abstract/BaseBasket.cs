
using DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public abstract class BaseBasket
	{
		public abstract int CreateBasket(TblSepet Basket);
		public abstract bool AddProductToBasket (TblSepetDetay BasketDetail);
		public abstract List<TblUrun> ShowProductByProductId(int ProductId);
		public abstract List<VwBasket> GetBasketByUserId(int UserId);
		public abstract int BasketCount(int UserId);
		public abstract void DeleteBasketbyBasketId(int BasketId);
		public abstract void DeleteAllBasketByUserId(int UserId);


	}
}
