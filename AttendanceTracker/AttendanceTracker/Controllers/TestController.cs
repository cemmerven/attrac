using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AttendanceTracker.Models;

namespace AttendanceTracker.Controllers
{
    public class TestController : Controller
    {

      public ActionResult Hello() { // FormCollection (Request.From) vs Request.QueryString

         // TODO : ViewData vs ViewBag vs TempData
          
         return View( "Hello" );
      }
 
      public ActionResult HelloTo() { // FormCollection (Request.Form) vs Request.QueryString
         return View( "HelloTo" );
      }

      // TODO : GET ile POST binding farkı yaratıyor mu? POST ile QueryString de dolu geçerse ne olur? [FromBody] attribute deneyi ve örneği.
      public ActionResult FormData( string firstname, int number = int.MinValue ) { 

         var valueA = Request.QueryString[ "name" ];
         var valueB = Request.Form[ "name" ];
         return View( "HelloWithParams" );
      }

      //-----------------------------------------------------------------------

      public ActionResult HtmlForm1() {  
         return View( "HtmlForm1" );
      }
      public ActionResult HtmlFormData1() { // Request.Form vs Request.QueryString  POST / GET 

         return new EmptyResult();
      }

      //-----------------------------------------------------------------------
      
       public ActionResult HtmlForm2() { 
         return View( "HtmlForm2" );
      }

      public ActionResult HtmlFormData2(/* TODO : parametre listesini HtmlForm2.cshtm deki forma göre oluştur */) { 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------

      public ActionResult HtmlFormViewSelection() { 
         return View( );
      }

      public ActionResult HtmlFormDataViewSelection( string metin ) { 
     
         if ( String.IsNullOrWhiteSpace( metin ) )
           return View( "OKNOT" );
         else
           return View( "OK" );
      
      }

      //-----------------------------------------------------------------------
 
      public ActionResult HtmlForm3() { 
         return View( "HtmlForm3" );
      }

      public ActionResult HtmlFormData3( Person person ) {   /*Complex binding, children */ 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------
      
      public ActionResult HtmlForm4() { 
         return View( "HtmlForm4" );
      }
      public ActionResult HtmlFormData4( List<Person> people ) {  /*Complex binding, collection */ 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------
 
      public ActionResult HtmlForm5() { 
         return View( "HtmlForm5" );
      }
      public ActionResult HtmlFormData5( Person person, HomeAddress address ) {  /*Complex binding, mutliple parameters*/ 

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------

      public ActionResult HtmlForm6() { 
         return View();
      }
      public ActionResult HtmlFormData6( [ Bind( Include="Name") ] Person person ) { // TODO : HtmlForm6 Complex binding, aggregate address

         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------       

      public ActionResult HtmlList1() { 

         ViewBag.Person = new Person { Name = "ali", Age = 12 };

         return View();
      }

      //-----------------------------------------------------------------------       

      public ActionResult HtmlList2() { 

         var psn = new Person { Name = "ali", Age = 12 };

         return View( psn );
      }

      //-----------------------------------------------------------------------       

      public ActionResult OK() { 
         return View();
      }
      public ActionResult HtmlLink1() { 
         return View();
      }
      public ActionResult HtmlLinkTarget1() {  // TODO : Basic dynamic link usage

         var path = Server.MapPath(".");
         path = Server.MapPath("..");
         path = Server.MapPath("~/");
         var str = HttpRuntime.AppDomainAppVirtualPath;
         
         
         // Html.Action
         // Html.ActionLink
         // Url.Action

         return new EmptyResult();
      
      }

      //----------------------------------------------------------------------- 
      
      public ActionResult HtmlLinkTarget2( string name, int age = 0 ) { // TODO : parametre geçir ( routevalues name age )  

         // Url.RouteUrl
         // Html.ActionLink 
         // Html.RenderActionLink
         // Html.RenderAction
         return new EmptyResult();
      
      }

      //-----------------------------------------------------------------------       

    }//class

}//namespace
