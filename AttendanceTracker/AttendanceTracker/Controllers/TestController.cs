using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceTracker.Controllers
{
    public class TestController : Controller
    {
 
      public ActionResult HelloTo() { // FormCollection parameters vs Request.QueryString
         return View( "HelloTo" );
      }

      public ActionResult FormData( string firstname, int number = int.MinValue ) { 
         return View( "HelloWithParams" );
      }

    }
}
