using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace URL_Shortener.Data.Configurations
{
    public class UrlModelConfiguration : IEntityTypeConfiguration<UrlModel>
    {
        public void Configure(EntityTypeBuilder<UrlModel> builder)
        {
            builder.Property(p => p.TokenId).HasColumnName("Token");

            builder.Property(p => p.OriginalUrl).HasColumnName("OriginalUrl");
        }
    }
}
