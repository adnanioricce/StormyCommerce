using System;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Module.Customer.Models;

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

                CreateUser(
                    //TODO: actually, I think is not secure to initialize this here...
                    new ApplicationUser()
                    {
                        UserName = "admin_stormycommerce",
                        Email = "admin-stormycommerce@teste.com.br",
                        EmailConfirmed = true
                    }, "AdminStormyCommerce01!", Roles.Admin);

                CreateUser(
                    new ApplicationUser()
                    {
                        UserName = "usrinvalido_api",
                        Email = "usrinvalido-api@teste.com.br",
                        EmailConfirmed = true
                    }, "UsrInvStormyCommerceAPI01!");
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