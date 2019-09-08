using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public class EntityDataSeeder
    {
        public static List<EntityType> GetEntityTypeSeedList()
        {
            return new List<EntityType>
            {
                new EntityType("Category") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Category", RoutingAction = "CategoryDetail", IsMenuable = true },
                new EntityType("Brand") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Brand", RoutingAction = "BrandDetail", IsMenuable = true },
                new EntityType("Product") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Product", RoutingAction = "ProductDetail", IsMenuable = false }
            };
        }

        public static List<Entity> GetEntitySeedList()
        {
            return new List<Entity>
            {
                new Entity(1)
                {
                    EntityId = 1,
                    IsDeleted = false,
                    LastModified = DateTimeOffset.UtcNow,
                    EntityTypeId = "Category",
                    Name = "Woman",
                    Slug = "woman",
                },
                new Entity(2)
                {
                    EntityId = 2,
                    EntityTypeId = "Brand",
                    Name = "Shirts",
                    Slug = "shirts",
                    IsDeleted = false,
                    LastModified = DateTimeOffset.UtcNow
                },
                new Entity(3)
                {
                    EntityId = 3,
                    EntityTypeId = "Product",
                    Name = "Some awesome Product",
                    Slug = "some-awesome-product",
                    IsDeleted = false,
                    LastModified = DateTimeOffset.UtcNow
                }
            };
        }
    }
}
