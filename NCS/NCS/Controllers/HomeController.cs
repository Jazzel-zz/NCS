using NCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NCS.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Order = db.OrderDetails.Count();
            ViewBag.Users = db.Users.Count();
            ViewBag.Plans = db.PlanDetails.Count();
            ViewBag.Conn = db.ConnectionTypes.Count();
            ViewBag.w_Conn = 0;
            ViewBag.m_Conn = 0;
            return View(db.Connections.ToList());
        }

    }
}