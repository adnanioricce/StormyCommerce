using Bogus;
using System;
using SimplCommerce.Module.Catalog.Models;
using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Tests
{
    public static class ProductSeeder
    {
        private static Faker<Product> BaseProductSeed(){
            return new Faker<Product>("pt_BR")
                .RuleFor(v => v.Name,f => f.Lorem.Sentences())
                .RuleFor(v => v.Slug,f => f.Lorem.Sentences())
                .RuleFor(v => v.MetaTitle,f => f.Lorem.Sentences())
                .RuleFor(v => v.MetaKeywords,f => f.Lorem.Sentences())         
                .RuleFor(v => v.Sku,f => f.Lorem.Sentences())                
                .RuleFor(v => v.Gtin,f => f.Lorem.Sentences())
                .RuleFor(v => v.NormalizedName,f => f.Lorem.Sentences())
                .RuleFor(v => v.ShortDescription,f => f.Lorem.Sentences())
                .RuleFor(v => v.StockQuantity,10)
                .RuleFor(v => v.UnitsOnOrder,2)
                .RuleFor(v => v.CreatedById,10L)
                .RuleFor(v => v.LatestUpdatedById,10L);                                
        }
        public static Product InsertProductSeed(){            
            return BaseProductSeed().Generate();
        }
        public static IEnumerable<Product> InsertProductSeed(int count){            
            return BaseProductSeed().Generate(count);
        }
    }
}
