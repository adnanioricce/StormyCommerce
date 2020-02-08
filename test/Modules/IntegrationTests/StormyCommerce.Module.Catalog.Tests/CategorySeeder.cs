using System.Collections.Generic;
using Bogus;
using SimplCommerce.Module.Catalog.Models;

namespace StormyCommerce.Module.Catalog.Tests
{
    public static class CategorySeeder
    {
        private static Faker<Category> BaseCategorySeed()
        {
            return new Faker<Category>()
                .RuleFor(v => v.Name,f => f.Commerce.ProductAdjective())
                .RuleFor(v => v.Slug,f => f.Lorem.Sentences())
                .RuleFor(v => v.MetaTitle,f => f.Lorem.Sentences())
                .RuleFor(v => v.MetaKeywords,f => f.Lorem.Sentences());
        } 
        public static Category InsertCategorySeed()
        {
            return BaseCategorySeed().Generate();
        }
        public static List<Category> InsertCategorySeed(int count)
        {
            return BaseCategorySeed().Generate(count);
        }
    }
}