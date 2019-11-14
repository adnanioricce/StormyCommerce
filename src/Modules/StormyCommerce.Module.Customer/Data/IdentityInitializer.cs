using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Module.Customer.Models;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Module.Customer.Data
{
    public class IdentityInitializer
    {
        private readonly StormyDbContext _context;
        private readonly UserManager<StormyCustomer> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public IdentityInitializer(
            StormyDbContext context,
            UserManager<StormyCustomer> userManager,
            RoleManager<ApplicationRole> roleManager)
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
                    new ApplicationRole(Roles.Admin)).Result;
                if (!resultado.Succeeded)
                {
                    throw new Exception(
                        $"Erro durante a criação da role {Roles.Admin}.");
                }
            }
            if (!_roleManager.RoleExistsAsync(Roles.Guest).Result)
            {
                var resultado = _roleManager.CreateAsync(new ApplicationRole(Roles.Guest)).Result;
                if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Guest}");
            }
            if (!_roleManager.RoleExistsAsync(Roles.Customer).Result)
            {
                var resultado = _roleManager.CreateAsync(new ApplicationRole(Roles.Customer)).Result;
                if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Customer}");
            }

            CreateUser(
                //TODO: actually, I think is not secure to initialize this here...
                new StormyCustomer()
                {
                    UserName = "stormyadmin",
                    Email = "stormycommerce@gmail.com",
                    EmailConfirmed = true,
                    Roles = new List<ApplicationRole>()
                    {
                        new ApplicationRole(Roles.Admin)
                    },
                    
                }, "!D4vpassword",Roles.Admin);                
            CreateUser(
                //TODO: actually, I think is not secure to initialize this here...
                new StormyCustomer()
                {
                    UserName = "stormydev",
                    Email = "adnangonzaga@gmail.com",
                    EmailConfirmed = true,
                    Roles = new List<ApplicationRole>{
                        new ApplicationRole(Roles.Customer) 
                    },
                    DefaultBillingAddress = new CustomerAddress
                    {
                        Address = new Core.Entities.Common.Address("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento")
                    },
                    DefaultShippingAddress = new CustomerAddress
                    {
                        Address = new Core.Entities.Common.Address("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento"),
                    },
                    CPF = "10172930820",
                    PhoneNumber = "+5511992887102",
                    FullName = "Severino Francisco Daniel da Rocha",
                    DateOfBirth = new DateTime(2001,11,1),                    
                    
                    
                }, "!D4velopment",Roles.Customer);                
            
        }

        private void CreateUser(
            StormyCustomer user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                var resultado = _userManager
                    .CreateAsync(user, password).Result;                
            }
        }
    }
}
