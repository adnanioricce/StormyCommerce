using System;
using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Module.Catalog.Areas.Catalog.ViewModels
{
    public class ProductSearchResponse
    {
        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string ThumbnailImage { get; private set; }
        public string Slug { get; private set; }
        public string ShortDescription { get; private set; }
        public string UnitPrice { get; set; }
    }
}
