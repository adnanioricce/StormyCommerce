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
    public class IndexModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public IndexModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        public IList<StormyShipment> StormyShipment { get;set; }

        public async Task OnGetAsync()
        {
            StormyShipment = await _context.Shipment
                .Include(s => s.DestinationAddress)
                .Include(s => s.Order).ToListAsync();
        }
    }
}
