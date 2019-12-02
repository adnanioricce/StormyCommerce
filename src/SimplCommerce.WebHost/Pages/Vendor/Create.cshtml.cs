using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Vendor
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
        ViewData["VendorAddressId"] = new SelectList(_context.Set<VendorAddress>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public StormyVendor StormyVendor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vendor.Add(StormyVendor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}