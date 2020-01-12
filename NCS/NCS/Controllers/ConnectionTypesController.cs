using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NCS.Models;

namespace NCS.Controllers
{
    [Authorize]
    public class ConnectionTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ConnectionTypes
        public ActionResult Index()
        {
            var connectionTypes = db.ConnectionTypes.Include(c => c.ApplicationUser);
            return View(connectionTypes.ToList());
        }

        // GET: ConnectionTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectionType connectionType = db.ConnectionTypes.Find(id);
            if (connectionType == null)
            {
                return HttpNotFound();
            }
            return View(connectionType);
        }

        // GET: ConnectionTypes/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: ConnectionTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,ApplicationUserId")] ConnectionType connectionType)
        {
            if (ModelState.IsValid)
            {
                connectionType.ApplicationUserId = User.Identity.GetUserId();
                db.ConnectionTypes.Add(connectionType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", connectionType.ApplicationUserId);
            return View(connectionType);
        }

        // GET: ConnectionTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectionType connectionType = db.ConnectionTypes.Find(id);
            if (connectionType == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", connectionType.ApplicationUserId);
            return View(connectionType);
        }

        // POST: ConnectionTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,ApplicationUserId")] ConnectionType connectionType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(connectionType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "Name", connectionType.ApplicationUserId);
            return View(connectionType);
        }

        // GET: ConnectionTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectionType connectionType = db.ConnectionTypes.Find(id);
            if (connectionType == null)
            {
                return HttpNotFound();
            }
            return View(connectionType);
        }

        // POST: ConnectionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConnectionType connectionType = db.ConnectionTypes.Find(id);
            db.ConnectionTypes.Remove(connectionType);
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
