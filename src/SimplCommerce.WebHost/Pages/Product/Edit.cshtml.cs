using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Product
{
    public class EditModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public EditModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StormyProduct StormyProduct { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StormyProduct = await _context.Product
                .Include(s => s.Brand)
                .Include(s => s.Vendor).FirstOrDefaultAsync(m => m.Id == id);

            if (StormyProduct == null)
            {
                return NotFound();
            }
           ViewData["BrandId"] = new SelectList(_context.Set<StormyCommerce.Core.Entities.Catalog.Product.Brand>(), "Id", "Slug");
           ViewData["VendorId"] = new SelectList(_context.Set<StormyVendor>(), "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StormyProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StormyProductExists(StormyProduct.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StormyProductExists(long id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
