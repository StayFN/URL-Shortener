using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using URL_Shortener.Data;
using URL_Shortener.Models;
using Microsoft.EntityFrameworkCore;
namespace URL_Shortener.Pages
{
    public class IndexModel : PageModel
    {
        public string PathUrl { get; set; }

        public UrlModelContext db;
        public IndexModel(UrlModelContext db) => this.db = db;
        public List<UrlModel> UrlModels { get; set; } = new List<UrlModel>();


        [BindProperty]
        public Models.UrlModel ShortenModel { get; set; }

        public List<string> InvalidTokens { get; set; } = new List<string>() { "", "/", "/Index", "Index", "Error" };

        public async Task OnGetAsync()
        {
            UrlModels = await db.UrlModels.ToListAsync();
            PathUrl = Request.Path.ToString();
            if (!InvalidTokens.Contains(PathUrl))
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

            db.UrlModels.Add(ShortenModel);
            db.SaveChanges();
            // Calculate ShortUrl or Assign Custom Path

            //  Save Model to Database
            
            return RedirectToPage("/UrlDelivery", new { ShortenModel.OriginalUrl });
        }

        public string Tokengenerator(string baseURL)
        {
            
            string urlchars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";


            return "";
        }
        
       
    }
}
