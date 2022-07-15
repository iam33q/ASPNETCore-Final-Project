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
    public class DetailsModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public DetailsModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

      public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FirstOrDefaultAsync(m => m.transactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }
            else 
            {
                Transaction = transaction;
            }
            return Page();
        }
    }
}
