using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace URL_Shortener.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Models.ShortenModel Shorten { get; set; } 
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            InvalidShortUrls = new List<string> { "", "/", "/Index", "/index" };
        }

        [BindProperty]
        public string PathUrl { get; set; }
        public List<string> InvalidShortUrls { get; set; }
        public void OnGet()
        {
            PathUrl = Request.Path.ToString();
            if (!InvalidShortUrls.Contains(PathUrl))             // Proof of Concept Redirect

            {
                Response.Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
           
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            // Calculate ShortUrl or Assign Custom Path

            //  Save Model to Database

            return RedirectToPage("/UrlDelivery", new { Shorten.OriginalUrl });
        }
       
    }
}
