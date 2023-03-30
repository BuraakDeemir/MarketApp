using DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public abstract class BaseOrder
	{
		public abstract void OrderAdd(int PersonId);

		public abstract int OrderCount(int PersonId);

		public abstract List<VwOrder> GetOrderByPersonId(int PersonId);

		public abstract List<TblOrderDetails> GetOrderDetailsByOrderId(int OrderId);
		public abstract string ShowProductByProductId(int ProductId);
	}
}
