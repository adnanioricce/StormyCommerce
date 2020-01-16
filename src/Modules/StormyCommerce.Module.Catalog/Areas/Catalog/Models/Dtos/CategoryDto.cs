﻿using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class CategoryDto
    {
        public CategoryDto(){}

        public CategoryDto(Category category)
        {
            Id = category.Id;
            Name = category.Name;
            Slug = category.Slug;
            DisplayOrder = category.DisplayOrder;                        
            Description = category.Description;
            ThumbnailImage = category.ThumbnailImage is null ? ThumbnailImage : new MediaDto(category.ThumbnailImage);
        }

        public long? Id { get; private set; } = 0;
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public int DisplayOrder { get; private set; }                
        public string Description { get; private set; }
        public MediaDto ThumbnailImage { get; private set; } = new MediaDto();
    }
}
