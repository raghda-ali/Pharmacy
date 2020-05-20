using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pharmacy.Models
{
    public class Order
    {
        [Key]
        [ForeignKey("Medicine")]
        public int medicine_id { get; set; }
        public double total_price { get;set;}
        public float amount { get; set; }
        public virtual Medicine Medicine{ get; set; }

    }
}