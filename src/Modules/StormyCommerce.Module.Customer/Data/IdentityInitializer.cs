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
                    Roles = new List<IdentityRole>()
                    {
                        new IdentityRole(Roles.Admin)
                    }
                }, "!D4vpassword",Roles.Admin);                
            CreateUser(
                //TODO: actually, I think is not secure to initialize this here...
                new StormyCustomer()
                {
                    UserName = "stormydev",
                    Email = "adnangonzaga@gmail.com",
                    EmailConfirmed = true,
                    Roles = new List<IdentityRole>{
                        new IdentityRole(Roles.Customer) 
                    }
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
