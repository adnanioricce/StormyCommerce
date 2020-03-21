using System.Collections.Generic;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.ShoppingCart.Models;

namespace SimplCommerce.Module.Payments.Tests
{
    public class PaymentSeeder
    {
        public static Address GetAddress(){
            return new Address{               
                Phone = "+551199765432",
                ZipCode = "000000000",                
                City = "city",
                Number = "1245",
                AddressLine1 = "R. Something",
                StateOrProvince = new StateOrProvince{
                    Name = "Name of State",
                    Code = "NS"                    
                },                
            };
        }
        public static User GetUser()
        {
            return new User {
                Id = 1,
                FullName = "Aguinobaldo de Peroba"
            };
        }
        public static Cart GetCart(){
            return new Cart{                
                Items = new List<CartItem>{
                    new CartItem{
                        Product = new Product{
                            Name = "T-Shirt White",
                            Price = 4.00m
                        },
                        Quantity = 4,

                    },
                    new CartItem{
                        Product = new Product{
                            Name = "T-Shirt black",
                            Price = 4.00m
                        },
                        Quantity = 2
                    }
                }                
            };
        }   
    }   
}
