using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolGuide3.Models;
using System.IO;

namespace SchoolGuide3.Controllers
{
    public class ParentController : Controller
    {

        // GET: Parent

        private OurDbContext db = new OurDbContext();



        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Filteration(string SchoolCategory , string SchoolFees, string SchoolLocation)
        {

            var result = from s in db.Schools
                         select s;
            // var result = _context.car.Include(b => b.Type);
            if (!string.IsNullOrEmpty(SchoolCategory))
            {
                result = db.Schools.Where(x => x.Sc_Category.Contains(SchoolCategory));

            }
            if (!string.IsNullOrEmpty(SchoolFees))
            {
                result = db.Schools.Where(x => x.Sc_Fees == SchoolFees);

            }
            if (!string.IsNullOrEmpty(SchoolLocation))
            {
                result = db.Schools.Where(x => x.Sc_Location == SchoolLocation);

            }
                                 
            
            return View(result);

        }

    }
}