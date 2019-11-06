using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=NORTHWND; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
