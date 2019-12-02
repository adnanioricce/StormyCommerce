using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public IndexModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        public IList<StormyOrder> StormyOrder { get;set; }

        public async Task OnGetAsync()
        {
            StormyOrder = await _context.Order
                .Include(s => s.Customer).ToListAsync();
        }
    }
}
