using CRUDWithORM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDWithORM.Data
{
   public class ProductContext:DbContext
    {
        public ProductContext():base()
        {

        }

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database = ProductDB; Integrated Security = true;");
        }
    }
}
