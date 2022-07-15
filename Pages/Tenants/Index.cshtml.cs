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
    public class IndexModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public IndexModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        public IList<Tenant> Tenant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tenants != null)
            {
                Tenant = await _context.Tenants
                .Include(t => t.Property).ToListAsync();
            }
        }
    }
}
