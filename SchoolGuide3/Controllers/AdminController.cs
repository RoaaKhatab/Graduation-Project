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
        public ActionResult ViewSchools()

        {

            return View(db.Schools.ToList());

        }

        public ActionResult DeleteSchool(int id)
        {
            var School = db.Schools.Where(u => u.Sc_id.Equals(id)).SingleOrDefault();
            db.Schools.Remove(School);
            db.SaveChanges();
            return RedirectToAction("ViewSchools");
        }


        public ActionResult AddSchool()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSchool(Schools School, HttpPostedFileBase upload)
        {
            //String path = Path.Combine(Server.MapPath("~/SchoolsPic"), upload.FileName);
            //upload.SaveAs(path);
            //School.Sc_Image = upload.FileName;
            db.Schools.Add(School);
            db.SaveChanges();
                                    
            return RedirectToAction("ViewSchools");
        }


        public ActionResult EditSchool(int id)
        {
            return View(db.Schools.Where(c => c.Sc_id.Equals(id)).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult EditSchool(Schools school)
        {
            db.Entry<Schools>(school).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ViewSchools");
        }



    }
}