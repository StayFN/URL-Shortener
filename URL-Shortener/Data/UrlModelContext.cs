using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.Data.Configurations;
using URL_Shortener.Models;

namespace URL_Shortener.Data
{
    public class UrlModelContext : DbContext
    {
        public DbSet<UrlModel> UrlModels { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=URLShortener.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UrlModel>().HasKey(b => b.TokenId);
            modelBuilder.ApplyConfiguration(new UrlModelConfiguration()).Seed();
        }


    }
}
