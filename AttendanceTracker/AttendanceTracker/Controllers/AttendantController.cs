using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AttendanceTracker.Models;

namespace AttendanceTracker.Controllers
{
    public class AttendantController : Controller
    {
        

        public ActionResult Index()
        {
            return RedirectToAction( "AllAttendants" );
        }

        public ActionResult AllAttendants()
        { 
           
           return View( MvcApplication._attendantRepo.List );
        }

        public ActionResult Details( int id )
        {
           var attendant = MvcApplication._attendantRepo.FindById( id );
           return View( attendant );
        }

         public ActionResult Delete( int id )
         {
           var attendant = MvcApplication._attendantRepo.FindById( id );
           return View( attendant );
         }


    }
}
