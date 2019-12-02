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
    public class DetailsModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public DetailsModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

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
    }
}
