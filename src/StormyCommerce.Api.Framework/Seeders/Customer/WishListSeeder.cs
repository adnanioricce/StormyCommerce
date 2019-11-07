using System.Collections.Generic;
using Bogus;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Api.Framework.Seeders.Customer
{
    public static class WishListSeeder
    {
        public static Wishlist SingleWishListSeed(StormyCustomer customer,List<WishlistItem> items)
        {
            var fakeWishList = new Faker<Wishlist>("pt_BR")                
                .Rules((f, v) =>
                {
                    v.Id = 0;
                    v.Customer = customer;
                    items.ForEach(item => item.Wishlist = v);
                    v.WishlistItems = items;                     
                }).Generate();
            return fakeWishList;
        }
        public static List<WishlistItem> WishListItemsSeed(List<StormyProduct> products,int count = 1)
        {
            var fakeWishListitems = new Faker<WishlistItem>("pt_BR")
                .Rules((f, v) =>
                {
                    v.Id = 0;
                    v.Product = f.PickRandom(products);                      
                }).Generate(count);
            return fakeWishListitems;
        }
    }
}
