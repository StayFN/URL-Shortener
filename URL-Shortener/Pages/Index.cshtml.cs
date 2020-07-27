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
using Microsoft.EntityFrameworkCore.Sqlite;
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

        public List<string> InvalidTokens { get; set; } = new List<string>() {"Index", "UrlDelivery", "Error"};

        public async Task OnGetAsync()
        {
            UrlModels = await db.UrlModels.ToListAsync();
            PathUrl = Request.Path.ToString().TrimStart('/');
            
            if (!string.IsNullOrEmpty(PathUrl))
            {
                if (db.UrlModels.Find(PathUrl) != null)
                {
                    Response.Redirect(db.UrlModels.Find(PathUrl).OriginalUrl);
                }
                
            }
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false || InvalidTokens.Contains(ShortenModel.TokenId) || string.IsNullOrEmpty(ShortenModel.OriginalUrl))
            {
                ShortenModel = null;
                return Page();               
            }
            
            if (db.UrlModels.Find(ShortenModel.TokenId) == null)
            {
                if (ShortenModel.TokenId == null)
                {
                    ShortenModel.TokenId = Tokengenerator();
                }
                db.UrlModels.Add(new UrlModel
                {
                    TokenId = ShortenModel.TokenId,
                    OriginalUrl = ShortenModel.OriginalUrl
                });
            }
            else
            {
                db.UrlModels.Find(ShortenModel.TokenId).OriginalUrl = ShortenModel.OriginalUrl;
            }
            db.SaveChanges();
            
            string DeliveryUrl = ShortenModel.TokenId;

            ShortenModel = null;
            return RedirectToPage("/UrlDelivery", new { DeliveryUrl });
        }
        
        public string Tokengenerator() 
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string urlcharpool = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789"; 
            var chars = Enumerable.Range(0, 7).Select(x => urlcharpool[random.Next(0, urlcharpool.Length)]); // Unique string mit GUID oder so zu stressig weil länge 7
            return new string(chars.ToArray());
        }




    }
}
