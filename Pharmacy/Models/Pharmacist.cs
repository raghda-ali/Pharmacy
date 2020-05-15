using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharmacy.Models
{
    public class Pharmacist
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}