using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using build.Data;
using build.Models.Tenant;

namespace build.Pages.Tenants
{
    public class CreateModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public CreateModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PropertyID"] = new SelectList(_context.Properties, "propertyID", "propertyID");
            return Page();
        }

        [BindProperty]
        public Tenant Tenant { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tenants.Add(Tenant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
