using StormyCommerce.Core.Entities.Media;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Product
{
	
	public class Category : BaseEntity
	{	
		public string Name { get; set; }
        public string Description { get; set; }
        public int ParentCategoryId { get; set; }
        public int PictureId { get; set; }
        //builder.Entity<TEntity>().Ignore(c => c.NotMappedEntity); //this is the equivalent in FluentAPI
        [NotMapped]
        public Picture Picture { get; set; }
    }
}
