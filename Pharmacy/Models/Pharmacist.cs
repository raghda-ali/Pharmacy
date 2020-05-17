using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pharmacy.Models
{
    public class Pharmacist
    {
        public int id { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="This field is required.")]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Firstname { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Lastname { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }
    }
}