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
                .RuleFor(v => v.Name,f => f.Lorem.Sentances())
                .RuleFor(v => v.Slug,f => f.Lorem.Sentances())
                .RuleFor(v => v.MetaTitle,f => f.Lorem.Sentances())
                .RuleFor(v => v.MetaKeywords,f => f.Lorem.Sentances())         
                .RuleFor(v => v.Sku,f => f.Lorem.Sentances())                
                .RuleFor(v => v.Gtin,f => f.Lorem.Sentances())
                .RuleFor(v => v.NormalizedName,f => f.Lorem.Sentances())
                .RuleFor(v => v.ShortDescription,f => f.Lorem.Sentances())
                .RuleFor(v => v.CreatedOn,f => DateTime.UtcNow);            
        }
        public static Product InsertProductSeed(){            
            return BaseProductSeed().Generate();
        }
        public static IEnumerable<Product> InsertProductSeed(int count){            
            return BaseProductSeed().Generate(count);
        }
    }
}