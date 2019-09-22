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
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityInitializer(
            StormyDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_context.Database.EnsureCreated())
            {
                if (!_roleManager.RoleExistsAsync(Roles.Admin).Result)
                {
                    var resultado = _roleManager.CreateAsync(
                        new IdentityRole(Roles.Admin)).Result;
                    if (!resultado.Succeeded)
                    {
                        throw new Exception(
                            $"Erro durante a criação da role {Roles.Admin}.");
                    }
                }
                if (!_roleManager.RoleExistsAsync(Roles.Guest).Result)
                {
                    var resultado = _roleManager.CreateAsync(new IdentityRole(Roles.Guest)).Result;
                    if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Guest}");
                }
                if (!_roleManager.RoleExistsAsync(Roles.Customer).Result)
                {
                    var resultado = _roleManager.CreateAsync(new IdentityRole(Roles.Customer)).Result;
                    if (!resultado.Succeeded) throw new Exception($"Erro durante a criação da Role {Roles.Customer}");
                }

                CreateUser(
                    //TODO: actually, I think is not secure to initialize this here...
                    new ApplicationUser()
                    {
                        UserName = "stormyadmin",
                        Email = "stormycommerce@gmail.com",
                        EmailConfirmed = true,
                        Role = new IdentityRole(Roles.Admin)
                    }, "!D4vpassword",Roles.Admin);                
            }
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

                if (resultado.Succeeded &&
                    !String.IsNullOrWhiteSpace(initialRole))
                {
                    _userManager.AddToRoleAsync(user, initialRole).Wait();
                }
            }
        }
    }
}
