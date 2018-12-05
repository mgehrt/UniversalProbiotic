using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UniversalProbiotic.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}