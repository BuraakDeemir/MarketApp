
using DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public abstract class BaseCategory
	{
		public abstract List<VWUrunVeKategoriler> CategoryShowById(int CategoryId);
	}
}
