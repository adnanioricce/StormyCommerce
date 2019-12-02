using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public DetailsModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
