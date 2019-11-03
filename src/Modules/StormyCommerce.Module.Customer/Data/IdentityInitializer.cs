using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Module.Customer.Models;
using System;

namespace StormyCommerce.Module.Customer.Data
{
    public class IdentityInitializer
    {
        private readonly StormyDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public IdentityInitializer(
            StormyDbContext context,
            UserManager<ApplicationUser> userManager,
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
                new ApplicationUser()
                {
                    UserName = "stormyadmin",
                    Email = "stormycommerce@gmail.com",
                    EmailConfirmed = true,
                    Role = new ApplicationRole(Roles.Admin)
                }, "!D4vpassword",Roles.Admin);                
            CreateUser(
                //TODO: actually, I think is not secure to initialize this here...
                new ApplicationUser()
                {
                    UserName = "stormydev",
                    Email = "adnangonzaga@gmail.com",
                    EmailConfirmed = true,
                    Role = new ApplicationRole(Roles.Customer)
                }, "!D4velopment",Roles.Customer);                
            
        }

        private void CreateUser(
            ApplicationUser user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                var resultado = _userManager
                    .CreateAsync(user, password).Result;

                // if (resultado.Succeeded &&
                //     !String.IsNullOrWhiteSpace(initialRole))
                // {
                //     _userManager.AddToRoleAsync(user, initialRole).Wait();
                // }
            }
        }
    }
}
