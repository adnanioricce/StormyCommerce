using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Catalog
{
    //TODO:Change DataAnotation mapping to FluentAPI mapping
    public class Category : EntityBase
    {
        public Category(){}

        public Category(long id)
        {
            Id = id;
        }

        public Category(Category category)
        {
            Id = category.Id;
            Name = category.Name;
            Slug = category.Slug;            
            Description = category.Description;
            DisplayOrder = category.DisplayOrder;
            IsPublished = category.IsPublished;
            IncludeInMenu = category.IncludeInMenu;
            ParentId = category.ParentId;               
            ThumbnailImageUrl = category.ThumbnailImageUrl;
        }

        public Category(Category category, long id)
        {
            Id = id;
            Name = category.Name;
            Slug = category.Slug;            
            Description = category.Description;
            DisplayOrder = category.DisplayOrder;
            IsPublished = category.IsPublished;
            IncludeInMenu = category.IncludeInMenu;
            ParentId = category.ParentId;            
            ThumbnailImageUrl = category.ThumbnailImageUrl;
        }        

        public string Name { get; set; }
        public string Slug { get; set; }        
        public string Description { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public Category Parent { get; set; }

        public int DisplayOrder { get; set; }
        public bool IsPublished { get; set; }
        public bool IncludeInMenu { get; set; }
        
        public long? ParentId { get; set; }
        public long? ChildrenId { get; set; }
        public long? ThumbnailImageId { get; set; }
        public Media.Media ThumbnailImage { get; set; }
    }
}
