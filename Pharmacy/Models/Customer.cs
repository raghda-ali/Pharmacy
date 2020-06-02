using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharmacy.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Customer_name { get; set; }
        public int NumberOfOrders { get; set; }
    }
}