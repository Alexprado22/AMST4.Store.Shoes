using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AMST4.Store.Shoes.Views.Color
{
    public class Color : PageModel
    {
        private readonly ILogger<Color> _logger;

        public Color(ILogger<Color> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}