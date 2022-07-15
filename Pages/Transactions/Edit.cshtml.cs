using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Balance;

namespace build.Pages.Transactions
{
    public class EditModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public EditModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Transaction Transaction { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction =  await _context.Transactions.FirstOrDefaultAsync(m => m.transactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }
            Transaction = transaction;
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

            _context.Attach(Transaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionExists(Transaction.transactionID))
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

        private bool TransactionExists(int id)
        {
          return _context.Transactions.Any(e => e.transactionID == id);
        }
    }
}
