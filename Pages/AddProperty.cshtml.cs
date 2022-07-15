using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace build.Pages
{
    public class AddProperty : PageModel
    {
        private readonly ILogger<AddProperty> _logger;

        public AddProperty(ILogger<AddProperty> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}