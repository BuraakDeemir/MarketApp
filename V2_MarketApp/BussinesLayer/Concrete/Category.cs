using BussinesLayer.Abstract;
using DataLayers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class Category : BaseCategory
	{
		private static DbInfoTechSales_NewEntities Context;
		public Category()
		{
			Context = new DbInfoTechSales_NewEntities();
		}
		public override List<VWUrunVeKategoriler> CategoryShowById(int CategoryId)
		{
			return (from data in Context.VWUrunVeKategoriler
					where data.KategoriId == CategoryId
					select data).ToList();		
		}
	}
}
