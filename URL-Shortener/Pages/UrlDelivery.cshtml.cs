using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace URL_Shortener
{
    public class UrlDeliveryModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string OriginalUrl { get; set; }
        public void OnGet()
        {

        }
    }
}