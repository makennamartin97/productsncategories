﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using productsncategories.Models;

namespace productsncategories.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200618223246_migrations3")]
    partial class migrations3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("productsncategories.Models.Association", b =>
                {
                    b.Property<int>("associationID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("categoryID");

                    b.Property<int>("productID");

                    b.HasKey("associationID");

                    b.HasIndex("categoryID");

                    b.HasIndex("productID");

                    b.ToTable("associations");
                });

            modelBuilder.Entity("productsncategories.Models.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("categoryname");

                    b.HasKey("categoryID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("productsncategories.Models.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<decimal>("price");

                    b.Property<string>("productname");

                    b.HasKey("productID");

                    b.ToTable("products");
                });

            modelBuilder.Entity("productsncategories.Models.Association", b =>
                {
                    b.HasOne("productsncategories.Models.Category", "navcategory")
                        .WithMany("products")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("productsncategories.Models.Product", "navproduct")
                        .WithMany("categories")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}