using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Pharmacy.Models.Pharmacist pharmacist)
        {
            using (MyDBContext db = new MyDBContext())
            {
                var pharmacistdetails = db.pharmacists.Where(c => c.Username == pharmacist.Username && c.Password == pharmacist.Password && c.Firstname == pharmacist.Firstname && c.Lastname == pharmacist.Lastname && c.Email == pharmacist.Email).FirstOrDefault();
                if (pharmacistdetails == null)
                {
                    return View("Index",pharmacist);
                }
                else
                {
                    Session["id"] = pharmacist.id;
                    return RedirectToAction("About", "Home");
                }
            }
        }
    }
}