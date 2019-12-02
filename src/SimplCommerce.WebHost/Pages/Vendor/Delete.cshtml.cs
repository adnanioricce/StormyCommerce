using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Vendor
{
    public class DeleteModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public DeleteModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StormyVendor StormyVendor { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StormyVendor = await _context.Vendor
                .Include(s => s.Address).FirstOrDefaultAsync(m => m.Id == id);

            if (StormyVendor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StormyVendor = await _context.Vendor.FindAsync(id);

            if (StormyVendor != null)
            {
                _context.Vendor.Remove(StormyVendor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
