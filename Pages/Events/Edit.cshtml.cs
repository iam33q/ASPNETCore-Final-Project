// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using build.Data;
// using build.Models.EventLog;

// namespace build.Pages.Events
// {
//     public class EditModel : PageModel
//     {
//         private readonly build.Data.PropertiesContext _context;

//         public EditModel(build.Data.PropertiesContext context)
//         {
//             _context = context;
//         }

//         [BindProperty]
//         public Event Event { get; set; } = default!;

//         public async Task<IActionResult> OnGetAsync(int? id)
//         {
//             if (id == null || _context.Events == null)
//             {
//                 return NotFound();
//             }

//             var event =  await _context.Events.FirstOrDefaultAsync(m => m.eventID == id);
//             if (event == null)
//             {
//                 return NotFound();
//             }
//             Event = event;
//            ViewData["PropertyID"] = new SelectList(_context.Properties, "propertyID", "propertyID");
//             return Page();
//         }

//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see https://aka.ms/RazorPagesCRUD.
//         public async Task<IActionResult> OnPostAsync()
//         {
//             if (!ModelState.IsValid)
//             {
//                 return Page();
//             }

//             _context.Attach(Event).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!EventExists(Event.eventID))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return RedirectToPage("./Index");
//         }

//         private bool EventExists(int id)
//         {
//           return _context.Events.Any(e => e.eventID == id);
//         }
//     }
// }
