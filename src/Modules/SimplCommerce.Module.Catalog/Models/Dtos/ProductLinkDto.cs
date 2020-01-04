﻿namespace SimplCommerce.Module.Catalog.Models.Dtos
{
    public class ProductLinkDto
    {
        public ProductLinkDto(ProductLink productLink)
        {
            Product = new ProductDto(productLink.Product);
            LinkedProduct = new ProductDto(productLink.LinkedProduct);
            LinkType = productLink.LinkType;
        }
        public ProductDto Product { get; private set; }
        public ProductDto LinkedProduct { get; private set; }
        public ProductLinkType LinkType { get; private set; }
    }
}
