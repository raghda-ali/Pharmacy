using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pharmacy.Models;


namespace Pharmacy.Controllers
{
    public class registerController : Controller
    {
        // GET: register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Pharmacist obj)

        {
            if (ModelState.IsValid)
            {
                MyDBContext db = new MyDBContext();
                db.pharmacists.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}