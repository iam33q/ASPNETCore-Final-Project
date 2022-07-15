// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Microsoft.EntityFrameworkCore;
// using build.Data;
// using build.Models.EventLog;

// namespace build.Pages.Events
// {
//     public class IndexModel : PageModel
//     {
//         private readonly build.Data.PropertiesContext _context;

//         public IndexModel(build.Data.PropertiesContext context)
//         {
//             _context = context;
//         }

//         public IList<Event> Event { get;set; } = default!;

//         public async Task OnGetAsync()
//         {
//             if (_context.Events != null)
//             {
//                 Event = await _context.Events
//                 .Include(@ => @.Property).ToListAsync();
//             }
//         }
//     }
// }
