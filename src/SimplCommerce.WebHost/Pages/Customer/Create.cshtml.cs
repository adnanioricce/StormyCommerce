using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.WebHost.Pages.Customer
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
            return Page();
        }

        [BindProperty]
        public StormyCustomer StormyCustomer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(StormyCustomer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}