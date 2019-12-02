using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Order
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
        ViewData["StormyCustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public StormyOrder StormyOrder { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(StormyOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}