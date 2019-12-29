﻿using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Module.Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Module.Customer.Data
{
    public class IdentityInitializer
    {
        private readonly StormyDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public IdentityInitializer(
            StormyDbContext context,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {            
           if (!_roleManager.RoleExistsAsync(Roles.Admin).Result)
            {
                var resultado = _roleManager.CreateAsync(
                    new Role(Roles.Admin)).Result;
                if (!resultado.Succeeded)
                {
                    throw new Exception(
                        $"Erro durante a criação da role {Roles.Admin}.");
                }
            }
            if (!_roleManager.RoleExistsAsync(Roles.Guest).Result)
            {
                var resultado = _roleManager.CreateAsync(new Role(Roles.Guest)).Result;
                if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Guest}");
            }
            if (!_roleManager.RoleExistsAsync(Roles.Customer).Result)
            {
                var resultado = _roleManager.CreateAsync(new Role(Roles.Customer)).Result;
                if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Customer}");
            }
            var adminUser = new User()
                {
                    FullName = "admin user",
                    UserName = "stormyadmin",
                    Email = "stormycommerce@gmail.com",
                    EmailConfirmed = true                    
                   
                                
                    
                };                
            CreateUser(adminUser
                //TODO: actually, I think is not secure to initialize this here...
                , "!D4vpassword",Roles.Admin);                
            CreateUser(
                //TODO: actually, I think is not secure to initialize this here...
                new User()
                {
                    UserName = "stormydev",
                    Email = "adnangonzaga@gmail.com",
                    EmailConfirmed = true ,                    
                    Addresses = new List<CustomerAddress>
                    {
                        new CustomerAddress(new AddressDetail("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento","","")) 
                        { 
                            Type = AddressType.Billing,
                            IsDefault = true                        
                        },                        
                        new CustomerAddress(new AddressDetail("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento","",""))
                        {
                            Type = AddressType.Shipping,
                            IsDefault = true
                        }
                    },
                    CPF = "10172930820",
                    PhoneNumber = "+5511992887102",
                    FullName = "Severino Francisco Daniel da Rocha",
                    DateOfBirth = new DateTime(2001,11,1),                    
                    
                    
                }, "!D4velopment",Roles.Customer);
            CreateUser(new User()
            {
                UserName = "stormytest",
                Email = "aguinobaldis@gmail.com",
                EmailConfirmed = true,
                Addresses = new List<CustomerAddress>
                    {
                        new CustomerAddress(new AddressDetail("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento","",""))
                        {
                            Type = AddressType.Billing,
                            IsDefault = true
                        },
                        new CustomerAddress(new AddressDetail("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento","",""))
                        {
                            Type = AddressType.Shipping,
                            IsDefault = true
                        }
                    },
                CPF = "10172930820",
                PhoneNumber = "+5511992887102",
                FullName = "Severino Francisco Daniel da Rocha",
                DateOfBirth = new DateTime(2001, 11, 1),


            }, "!D4velopment", Roles.Customer);
            
        }

        private void CreateUser(
            User user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                user.Roles.Add(new UserRole(_roleManager.Roles.FirstOrDefault(c => string.Equals(c.Name, initialRole, StringComparison.OrdinalIgnoreCase))));
                //user.CustomerWishlist.User = user;
                var resultado = _userManager.CreateAsync(user, password).Result;
            }
        }
    }
}
