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
        
        List<Attendant> _attendants = new List<Attendant>{
           new Attendant{ Name = "can", Present = false },
           new Attendant{ Name = "cem", Present = false }
        };

        public ActionResult Index()
        {
            return RedirectToAction( "AllAttendants" );
        }

        public ActionResult AllAttendants()
        { 
           return View( _attendants );
        }


    }
}
