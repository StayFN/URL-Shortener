﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URL_Shortener.Data;

namespace URL_Shortener.Data.Migrations
{
    [DbContext(typeof(UrlModelContext))]
    partial class UrlModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("URL_Shortener.Models.UrlModel", b =>
                {
                    b.Property<string>("TokenId")
                        .HasColumnName("Token")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalUrl")
                        .HasColumnName("OriginalUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("TokenId");

                    b.ToTable("UrlModels");

                });
#pragma warning restore 612, 618
        }
    }
}
