﻿using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Product;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOptionCombination : BaseEntity
    {
        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public long OptionId { get; set; }

        public ProductOption Option { get; set; }

        [StringLength(450)]
        public string Value { get; set; }

        public int SortIndex { get; set; }
    }
}