using System;
using System.Collections.Generic;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.ShoppingCart.Models;

namespace SimplCommerce.Tests.Seeders
{
    public class OrderServiceSeeders
    {
        public static Country GetCountry()
        {
            return new Country("BR")
            {
                IsShippingEnabled = true,
                Name = "Brasil"
            };
        }
        public static StateOrProvince GetStateOrProvince()
        {
            return new StateOrProvince
            {
                Name = "Test province",
                CountryId = "Brazil"
            };
        }
        public static District GetDistrict()
        {
            return new District
            {
                Name = "Test district",
                StateOrProvinceId = 1
            };
        }
        public static Cart GetCart()
        {
            return new Cart(1)
            {

                Items = GetCartItems(),
                IsActive = true,
                CustomerId = 1,
                CreatedById = 1,
                ShippingMethod = "sedex"                
            };
        }
        public static List<CartItem> GetCartItems()
        {
            return new List<CartItem>
                {
                    new CartItem
                    {
                        ProductId = 1,
                        Product = GetProduct(),
                        Quantity = 2,                        
                    }
                };
        }
        public static Product GetProduct()
        {
            return new Product
            {
                Name = "test name",
                Slug = "test-name",
                Price = 120.0m,
                StockQuantity = 2,       
                StockTrackingIsEnabled = true
            };
        }
        public static Address GetShippingAddress()
        {
            return new Address
            {
                AddressLine1 = "address line 1",
                AddressLine2 = "address line 2",
                ContactName = "contact name",
                CountryId = "BR",
                StateOrProvinceId = 1,
                DistrictId = 1,
                City = "Some city",
                ZipCode = "11443-360",
                Phone = "+55(81)543-956124"
            };
        }        
        public static string GetJsonShippingData()
        {
            return @"
                {                    
                    'AddressLine1':'address line 1',
                    'AddressLine2':'address line 2',
                    'ContactName':'contact name',
                    'CountryId':'Brazil',
                    'StateOrProvinceId':1,
                    'DistrictId':1,
                    'City':'Some city',
                    'ZipCode':'11443-360',
                    'Phone':'+55(81)543-956124'                    
                }";
        }
        public User GetUser()
        {
            return new User
            {
                Id = 1,
                UserGuid = Guid.NewGuid(),
                FullName = "test user fullname",
                Email = "test@email.com",
                Culture = "BR",
                PhoneNumber = "+551123456789",
                Roles = new List<UserRole>{
                   new UserRole{
                       RoleId = 1
                   }
               },
                ExtensionData = @"{
                    'Documents' : [
                        {
                            'Type':'cpf',
                            'Value':'76942610054'
                        }   
                    ]}
                "
            };

        }
    }
}
