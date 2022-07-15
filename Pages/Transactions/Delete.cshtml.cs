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
    public class DeleteModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public DeleteModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction != null)
            {
                Transaction = transaction;
                _context.Transactions.Remove(Transaction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
