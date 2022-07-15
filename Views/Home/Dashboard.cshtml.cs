using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using build.Models;
using build.Models.Balance;
using build.Models.EventLog;
using build.Models.Inventory;

namespace build.Views.Home
{
    public class Dashboard : PageModel
    {
        private readonly ILogger<Dashboard> _logger;

        public Dashboard(ILogger<Dashboard> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            
        }
    }
}