using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceTracker.Controllers
{
    public class TestController : Controller
    {

      public ActionResult Hello() { // FormCollection (Request.From) vs Request.QueryString
         return View( "Hello" );
      }
 
      public ActionResult HelloTo() { // FormCollection (Request.From) vs Request.QueryString
         return View( "HelloTo" );
      }

      public ActionResult FormData( string firstname, int number = int.MinValue ) { 
         return View( "HelloWithParams" );
      }

      public ActionResult HtmlForm() { 
         return View( "HtmlForm" );
      }
      public ActionResult HtmlFormData() { 

         //Request.Form
         if ( String.IsNullOrWhiteSpace( Request.Form["metin"] ) )
           return View( "OKNOT" );
         else
           return View( "OK" );
      
      }

    }
}
