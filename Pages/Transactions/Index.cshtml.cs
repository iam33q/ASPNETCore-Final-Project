using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Balance;

namespace build.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public IndexModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Transactions != null)
            {
                Transaction = await _context.Transactions
                .Include(t => t.Property).ToListAsync();
            }
        }
    }
}
