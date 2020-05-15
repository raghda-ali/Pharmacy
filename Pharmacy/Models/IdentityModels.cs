using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pharmacy.Models
{
    public class IdentityModels
    {
        public DbSet<Pharmacist> pharmacists { get; set; }
    }
}