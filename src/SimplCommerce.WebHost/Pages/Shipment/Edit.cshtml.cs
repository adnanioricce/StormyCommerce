using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Shipment
{
    public class EditModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public EditModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
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
           ViewData["DestinationAddressId"] = new SelectList(_context.Set<CustomerAddress>(), "Id", "Id");
           ViewData["StormyOrderId"] = new SelectList(_context.Order, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StormyShipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StormyShipmentExists(StormyShipment.Id))
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

        private bool StormyShipmentExists(long id)
        {
            return _context.Shipment.Any(e => e.Id == id);
        }
    }
}
