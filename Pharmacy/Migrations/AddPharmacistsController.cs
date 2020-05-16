using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Migrations
{
    public class AddPharmacistsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: AddPharmacists
        public ActionResult Index()
        {
            return View(db.pharmacists.ToList());
        }

        // GET: AddPharmacists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pharmacist pharmacist = db.pharmacists.Find(id);
            if (pharmacist == null)
            {
                return HttpNotFound();
            }
            return View(pharmacist);
        }

        // GET: AddPharmacists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddPharmacists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Username,Password,Firstname,Lastname,Email")] Pharmacist pharmacist)
        {
            if (ModelState.IsValid)
            {
                db.pharmacists.Add(pharmacist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pharmacist);
        }

        // GET: AddPharmacists/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Pharmacist pharmacist = db.pharmacists.Find(id);
        //    if (pharmacist == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(pharmacist);
        //}

        //// POST: AddPharmacists/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "id,Username,Password,Firstname,Lastname,Email")] Pharmacist pharmacist)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(pharmacist).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(pharmacist);
        //}

        //// GET: AddPharmacists/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Pharmacist pharmacist = db.pharmacists.Find(id);
        //    if (pharmacist == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(pharmacist);
        //}

        //// POST: AddPharmacists/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Pharmacist pharmacist = db.pharmacists.Find(id);
        //    db.pharmacists.Remove(pharmacist);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
