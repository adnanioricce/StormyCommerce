using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Shipment
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
        ViewData["DestinationAddressId"] = new SelectList(_context.Set<CustomerAddress>(), "Id", "Id");
        ViewData["StormyOrderId"] = new SelectList(_context.Order, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public StormyShipment StormyShipment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shipment.Add(StormyShipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
