using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Inventory;

namespace build.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public IndexModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Items != null)
            {
                Item = await _context.Items
                .Include(i => i.Property).ToListAsync();
            }
        }
    }
}
