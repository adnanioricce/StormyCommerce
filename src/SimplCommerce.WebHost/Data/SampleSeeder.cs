using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Infraestructure.Data;
using Bogus;
namespace SimplCommerce.WebHost.Data
{
    public static class SampleSeeder
    {
        public static void Seed(this StormyDbContext context)
        {
            var jsonFile = File.ReadAllText("Categories.json");            
            var categories = JsonConvert.DeserializeObject<List<Category>>(jsonFile);
            categories.Add(new Category
            {
                Id = 0,
                Name = "Boné",
                Description = "uma descrição emocionante",
                ThumbnailImageUrl = "",
            });
            categories.Add(new Category
            {
                Id = 0,
                Name = "Bermuda",
                Description = "uma descrição animadora",
                DisplayOrder = 2,
                ThumbnailImageUrl = ""
            });
            categories.Add(new Category
            {
                Id = 0,
                Name = "Sapato",
                Description = "uma descricão foda",
                ThumbnailImageUrl = ""
            });
            var products = JsonConvert.DeserializeObject<List<StormyProduct>>(File.ReadAllText("Products.json"));
            products.ForEach(p =>
            {
                var faker = new Faker<StormyProduct>();
                p.SKU = Guid.NewGuid().ToString();
                p.Slug = p.GenerateSlug();
                p.ShortDescription = "uma descrição curta";
                p.Categories.Add(new ProductCategory
                {
                    Product = p,
                    Category = categories.First(),
                });
                p.Brand.Description = "uma descrição";
                //p.
            });
        }
    }
}
