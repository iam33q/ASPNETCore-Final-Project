using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Tenant;

namespace build.Pages.Tenants
{
    public class DeleteModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public DeleteModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Tenant Tenant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tenants == null)
            {
                return NotFound();
            }

            var tenant = await _context.Tenants.FirstOrDefaultAsync(m => m.tenantID == id);

            if (tenant == null)
            {
                return NotFound();
            }
            else 
            {
                Tenant = tenant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Tenants == null)
            {
                return NotFound();
            }
            var tenant = await _context.Tenants.FindAsync(id);

            if (tenant != null)
            {
                Tenant = tenant;
                _context.Tenants.Remove(Tenant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
