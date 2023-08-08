using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QLTV.Models
{
    public class CompanyDBContext: DbContext
    {
        public CompanyDBContext(): base("datathuvien") { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}