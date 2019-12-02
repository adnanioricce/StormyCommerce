using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private readonly StormyCommerce.Infraestructure.Data.StormyDbContext _context;

        public DeleteModel(StormyCommerce.Infraestructure.Data.StormyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StormyCommerce.Core.Entities.Catalog.Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
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

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
