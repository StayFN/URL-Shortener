using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.Models;
using Microsoft.EntityFrameworkCore;

namespace URL_Shortener.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder) // Testdaten
        {
            modelBuilder.Entity<UrlModel>().HasData(
                new UrlModel
                {
                    TokenId = "yt",

                    OriginalUrl = "https://www.youtube.com"
                }
                );
            return modelBuilder;
        }
    }
}
