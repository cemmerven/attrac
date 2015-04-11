using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceTracker.Controllers
{
    public class TestController : Controller
    {
 
      public ActionResult HelloTo() { 
      
         return View( "HelloTo" );
      }

      [HttpPost]
      public ActionResult HelloTo( string firstname ) { 
      
         return View( "HelloTo" );
      }


    }
}
