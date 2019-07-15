using StormyCommerce.Core.Entities.Media;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StormyCommerce.Core.Entities.Catalog
{
	//TODO:Change DataAnotation mapping to FluentAPI mapping
	public class Category : BaseEntity
	{
        public Category()
        {

        }
        public Category(long id)
        {
            Id = id;
        }
        public Category(Category category)
        {
            
            Id = category.Id;
            Name = category.Name;
            Slug = category.Slug;
            MetaTitle = category.MetaTitle;
            MetaKeywords = category.MetaKeywords;
            MetaDescription = category.MetaDescription;
            Description = category.Description;
            DisplayOrder = category.DisplayOrder;
            IsPublished = category.IsPublished;
            IncludeInMenu = category.IncludeInMenu;
            ParentId = category.ParentId;
            Parent = category.Parent;
            Childrens = category.Childrens;
            ThumbnailImage = category.ThumbnailImage;
        }
	    [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
	    public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
	    [StringLength(450)]
        public string Slug { get; set; }

	    [StringLength(450)]
        public string MetaTitle { get; set; }

	    [StringLength(450)]
        public string MetaKeywords { get; set; }

	    public string MetaDescription { get; set; }

        public string Description { get; set; }

	    public int DisplayOrder { get; set; }

        public bool IsPublished { get; set; }

	    public bool IncludeInMenu { get; set; }     

	    public long? ParentId { get; set; }

        public Category Parent { get; set; }

	    public IList<Category> Childrens { get; protected set; } = new List<Category>();

        public Media.Media ThumbnailImage { get; set; }                     

    }
}
