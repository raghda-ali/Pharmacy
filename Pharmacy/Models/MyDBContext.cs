using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Pharmacy.Models
{
    public class MyDBContext : DbContext { public MyDBContext() { }
        public DbSet<Pharmacist> pharmacists { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<Order> orders { get; set; }

    }


}