//!This Code probably Will be deleted
using StormyCommerce.Core.Entities.Product;
using System.Collections.Generic; 
namespace StormyCommerce.Core.Entities 
{
	public class Stock : BaseEntity
	{
		public IEnumerable<StormyProduct> Products {get;set;}
		//?Why not put this on Product Instead?
		public IEnumerable<StormyOrder> Orders {get;set;}
	}
}
