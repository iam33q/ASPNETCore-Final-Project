using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace build.Views.Home
{
    public class TenantView : PageModel
    {
        private readonly ILogger<TenantView> _logger;

        public TenantView(ILogger<TenantView> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}