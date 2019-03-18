using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolGuide3.Models;
using System.IO;

namespace SchoolGuide3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private OurDbContext db = new OurDbContext();

        public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }

        public ActionResult ViewUsers()

        {

                return View(db.UserAccount.ToList());
            
        }

        public ActionResult Delete(int id)
        {
            var user=db.UserAccount.Where(u=>u.UserID.Equals(id)).SingleOrDefault();
            db.UserAccount.Remove(user);
            db.SaveChanges();
            return RedirectToAction("ViewUsers");
        }

       /* public ActionResult Details()
        {
            return View(db.UserAccount.ToList());
        }
        */
    }
}