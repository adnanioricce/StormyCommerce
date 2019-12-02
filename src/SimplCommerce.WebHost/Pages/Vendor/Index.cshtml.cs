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
    public class IndexModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public IndexModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        public IList<StormyVendor> StormyVendor { get;set; }

        public async Task OnGetAsync()
        {
            StormyVendor = await _context.Vendor
                .Include(s => s.Address).ToListAsync();
        }
    }
}
