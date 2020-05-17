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
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginPharmacist(Pharmacy.Models.Pharmacist pharmacist)
        {
            using (MyDBContext db = new MyDBContext())
            {
                var pharmacistdetails = db.pharmacists.Where(c => c.Username == pharmacist.Username && c.Password == pharmacist.Password && c.Firstname == pharmacist.Firstname && c.Lastname == pharmacist.Lastname && c.Email == pharmacist.Email).FirstOrDefault();
                if (pharmacistdetails == null)
                {
                    return View("LoginPharmacist", pharmacist);
                }
                else
                {
                    Session["id"] = pharmacist.id;
                    return RedirectToAction("LoginPharmacist");
                }
            }
        }
    }
}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(Pharmacist objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (MyDBContext db = new MyDBContext())
        //        {
        //            var obj = db.pharmacists.Where(a => a.Username.Equals(objUser.Username) && a.Password.Equals(objUser.Password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["id"] = obj.id.ToString();
        //                Session["Username"] = obj.Username.ToString();
        //                return RedirectToAction("UserDashBoard");
        //            }
        //        }
        //    }
        //    return View(objUser);
        //}

        //public ActionResult UserDashBoard()
        //{
        //    if (Session["idservese"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }
      