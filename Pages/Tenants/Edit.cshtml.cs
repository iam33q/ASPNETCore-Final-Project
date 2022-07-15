using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Tenant;

namespace build.Pages.Tenants
{
    public class EditModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public EditModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tenant Tenant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tenants == null)
            {
                return NotFound();
            }

            var tenant =  await _context.Tenants.FirstOrDefaultAsync(m => m.tenantID == id);
            if (tenant == null)
            {
                return NotFound();
            }
            Tenant = tenant;
           ViewData["PropertyID"] = new SelectList(_context.Properties, "propertyID", "propertyID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tenant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TenantExists(Tenant.tenantID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TenantExists(int id)
        {
          return _context.Tenants.Any(e => e.tenantID == id);
        }
    }
}
