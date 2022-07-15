using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace build.Views.Home
{
    public class BalanceView : PageModel
    {
        private readonly ILogger<BalanceView> _logger;

        public BalanceView(ILogger<BalanceView> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}