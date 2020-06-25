using Microsoft.EntityFrameworkCore;
using System;

namespace productsncategories.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> products {get;set;}
        public DbSet<Category> categories {get;set;}
        public DbSet<Association> associations {get;set;}
        
        // this is the variable we will use to connect to the MySQL table, Lizards
        //public DbSet<Product> products { get; set; }
        //public DbSet<Category> categories { get; set; }
    }
}