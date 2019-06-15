using System.Collections.Generic;
namespace StormyCommerce.Module.Catalog.Dtos
{
	//DTO or ViewModel
	public class ProductDto
	{
		public string Name { get; set;}
		public string Description { get; set;}
		public decimal Price { get; set; }
		public IList<ProductMediaDto> ProductMediaList { get; set; } 
		public bool IsAvailable { get; set;}
		public BrandDto Brand { get; set; }
		public CategoryDto Category { get; set;} 
	}
}
