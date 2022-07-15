using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace build.Pages
{
    public class Features : PageModel
    {
        private readonly ILogger<Features> _logger;

        public Features(ILogger<Features> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}