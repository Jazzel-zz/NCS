using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NCS.Models;

namespace NCS.Controllers
{
    [Authorize]

    public class PlanDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PlanDetails
        public ActionResult Index()
        {
            var planDetails = db.PlanDetails.Include(p => p.ApplicationUser).Include(p => p.Connection);
            return View(planDetails.ToList());
        }

        // GET: PlanDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanDetail planDetail = db.PlanDetails.Find(id);
            if (planDetail == null)
            {
                return HttpNotFound();
            }
            return View(planDetail);
        }

        // GET: PlanDetails/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name");
            ViewBag.ConnectionId = new SelectList(db.Connections, "Id", "ConnectionName");
            return View();
        }

        // POST: PlanDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ConnectionId,Duration,Description,ApplicationUserId")] PlanDetail planDetail)
        {
            if (ModelState.IsValid)
            {
                db.PlanDetails.Add(planDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", planDetail.ApplicationUserId);
            ViewBag.ConnectionId = new SelectList(db.Connections, "Id", "ConnectionName", planDetail.ConnectionId);
            return View(planDetail);
        }

        // GET: PlanDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanDetail planDetail = db.PlanDetails.Find(id);
            if (planDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", planDetail.ApplicationUserId);
            ViewBag.ConnectionId = new SelectList(db.Connections, "Id", "ConnectionName", planDetail.ConnectionId);
            return View(planDetail);
        }

        // POST: PlanDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ConnectionId,Duration,Description,ApplicationUserId")] PlanDetail planDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", planDetail.ApplicationUserId);
            ViewBag.ConnectionId = new SelectList(db.Connections, "Id", "ConnectionName", planDetail.ConnectionId);
            return View(planDetail);
        }

        // GET: PlanDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanDetail planDetail = db.PlanDetails.Find(id);
            if (planDetail == null)
            {
                return HttpNotFound();
            }
            return View(planDetail);
        }

        // POST: PlanDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanDetail planDetail = db.PlanDetails.Find(id);
            db.PlanDetails.Remove(planDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
