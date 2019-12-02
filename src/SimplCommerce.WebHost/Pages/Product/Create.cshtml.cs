using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public CreateModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandId"] = new SelectList(_context.Set<StormyCommerce.Core.Entities.Catalog.Product.Brand> (), "Id", "Slug");
        ViewData["VendorId"] = new SelectList(_context.Set<StormyVendor>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public StormyProduct StormyProduct { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(StormyProduct);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
