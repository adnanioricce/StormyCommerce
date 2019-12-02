using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Shipment
{
    public class DeleteModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public DeleteModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StormyShipment StormyShipment { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StormyShipment = await _context.Shipment
                .Include(s => s.DestinationAddress)
                .Include(s => s.Order).FirstOrDefaultAsync(m => m.Id == id);

            if (StormyShipment == null)
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

            StormyShipment = await _context.Shipment.FindAsync(id);

            if (StormyShipment != null)
            {
                _context.Shipment.Remove(StormyShipment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
