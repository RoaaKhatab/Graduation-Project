using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolGuide3.Models;

namespace SchoolGuide3.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()

        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.UserAccount.ToList());
            }

        }

        //RegistrationMethods

        //TheGetMethod(To get data from user)
        public ActionResult Register()
        {
            return View();
        }

        //ThePostMethod(To Add In db)
        [HttpPost]
        public ActionResult Register(Users account)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.UserAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + "Successfully Registerd .";

            }
            return View();
        }

        //LoginMethods

        //TheGetMethod(get data from user)
        public ActionResult login()
        {
            return View();

        }

        //ThePostMethod
        [HttpPost]
        public ActionResult login(Users user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                
                var usr = db.UserAccount.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                
               
                if(user.Usertype==1 && usr!=null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.UserName.ToString();
                    return RedirectToAction("Index", "Admin");
                }
               else if (usr!=null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.UserName.ToString();
                    return RedirectToAction("LoggedIn");

                }
                {
                    ModelState.AddModelError("", "username or password is wrong.");
                }

            }
            return View();
        }

        //LoggedInMethod 
        public ActionResult LoggedIn()
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

        public ActionResult LogouT()
        {
            return RedirectToAction("Login");
        }

    }
}