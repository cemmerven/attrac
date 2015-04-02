using System;
using System.Collections.Generic;
using System.IO;
using SIO = System.IO;

using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AttendanceTracker.Models;

namespace AttendanceTracker.Controllers
{
   //[HandleError(ExceptionType = typeof(RepositoryException), View = "RepositoryError" )]
   public class AttendantController : Controller
   {

      public ActionResult Index()
      {
         //throw new ApplicationException( "TEST EXCEPTION" );
         return RedirectToAction( "AllAttendants" );
      }
     
      public ActionResult AllAttendants()
      { 
         return View( MvcApplication._attendantRepo.List );
      }

      [HandleError(ExceptionType= typeof(Exception), View= "AttendantError" )]
      public ActionResult Details( int id = int.MinValue )
      {
         if ( id == int.MinValue ) {
            return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
         }

         var attendant = MvcApplication._attendantRepo.FindById( id );

         if ( attendant == null ) {
            return HttpNotFound();
         }

         return View( attendant );
      }
  

      [HttpGet]
      public ActionResult Create()
      {
         return View( new Attendant() );
      }	  

      [HttpPost]
      public ActionResult Create( Attendant attendant )
      {
         MvcApplication._attendantRepo.Create( attendant );
         return RedirectToAction( "AllAttendants" );
      }	  

      [HttpGet]
      public ActionResult Edit( int id )
      {
         var attendant = MvcApplication._attendantRepo.FindById( id );
         return View( attendant );
      }

      [HttpPost]
      public ActionResult Edit( Attendant attendant )
      {
         MvcApplication._attendantRepo.Update( attendant );
         return View( attendant );
      }

      [HttpGet]
      public ActionResult Delete( int id )
      {
         var attendant = MvcApplication._attendantRepo.FindById( id );
         return View( attendant );
      }

      [HttpPost,ActionName("Delete")]
      public ActionResult DeleteConfirmed( int id )
      {
         // TODO :  delete
         return RedirectToAction( "AllAttendants" );
      }

      protected override void OnException( ExceptionContext filterContext ) {

         Log( filterContext );


         if ( !filterContext.ExceptionHandled || !filterContext.HttpContext.IsCustomErrorEnabled ) {
            return;
         }

         filterContext.Result = new ViewResult {
            ViewName = "~/Views/Shared/GenericError.cshtml"
         };

         filterContext.ExceptionHandled = true;

         base.OnException( filterContext );
      }

      private void Log( ExceptionContext filterContext ) {

         try {
            var text = new StringBuilder();
            const string LOG_FILE_NAME = "ErrorLog.txt";
            string logPath = filterContext.HttpContext.Server.MapPath( "~/App_Data/" );
            string logFile = Path.Combine( logPath, LOG_FILE_NAME );

            text
               .AppendFormat( "source: {0}\r\n", filterContext.Exception.Source )
               .AppendFormat( "target: {0}\r\n", filterContext.Exception.TargetSite )
               .AppendFormat( "type: {0}\r\n", filterContext.Exception.GetType().Name )
               .AppendFormat( "message: {0}\r\n", filterContext.Exception.Message )
               .AppendFormat( "stack: {0}\r\n", filterContext.Exception.StackTrace )
               ;

            SIO.File.AppendAllText( logFile, text.ToString() );

         } finally {
            // SILENT FAIL
         }

      }

   }//class

}//namespace
