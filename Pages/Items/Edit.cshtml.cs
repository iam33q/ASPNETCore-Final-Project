using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using build.Data;
using build.Models.Inventory;

namespace build.Pages.Items
{
    public class EditModel : PageModel
    {
        private readonly build.Data.PropertiesContext _context;

        public EditModel(build.Data.PropertiesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item =  await _context.Items.FirstOrDefaultAsync(m => m.itemID == id);
            if (item == null)
            {
                return NotFound();
            }
            Item = item;
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

            _context.Attach(Item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(Item.itemID))
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

        private bool ItemExists(int id)
        {
          return _context.Items.Any(e => e.itemID == id);
        }
    }
}
