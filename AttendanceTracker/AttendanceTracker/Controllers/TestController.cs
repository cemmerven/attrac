using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendanceTracker.Models;

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

      //-----------------------------------------------------------------------

      public ActionResult HtmlForm1() { 
         return View( "HtmlForm1" );
      }
      public ActionResult HtmlFormData1() { 

         //Request.Form
         if ( String.IsNullOrWhiteSpace( Request.Form[ "metin" ] ) )
           return View( "OKNOT" );
         else
           return View( "OK" );
      }

      //-----------------------------------------------------------------------
      
       public ActionResult HtmlForm2() { 
         return View( "HtmlForm2" );
      }

      public ActionResult HtmlFormData2(/* TODO : parametre listesini HtmlForm2.cshtm deki forma göre oluştur */) { 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------

      public ActionResult HtmlForm3() { 
         return View( "HtmlForm3" );
      }
      public ActionResult HtmlFormData3( /* TODO : Complex binding person */ ) { 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------

    }//class

}//namespace
