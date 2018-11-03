using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public class Product
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            //public string Add { get; set; }
            //public string Save { get; set; }
            public long CategoryId { get; set; }
            public Category Category { get; set; }
        }

        public class Category
        {

            [DatabaseGenerated(DatabaseGeneratedOption.None)]
  
                public long id { get; set; }
                public string name { get; set; }

            public List<Product> ListProduct { get; set; }

        }

    }
}
