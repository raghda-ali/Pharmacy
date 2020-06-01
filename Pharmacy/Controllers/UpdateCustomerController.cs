using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy.Controllers
{
    public class UpdateCustomerController : Controller
    {
        // GET: UpdateCustomer
        public ActionResult Index()
        {
            return View();
        }

        // GET: UpdateCustomer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UpdateCustomer/Create
       /* public ActionResult Create()
        {
            return View();
        }

        // POST: UpdateCustomer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/

        // GET: UpdateCustomer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UpdateCustomer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UpdateCustomer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UpdateCustomer/Delete/5
      /*  [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
