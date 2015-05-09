using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace AttendanceTracker.Utilities {
   public static class Aid {

      public static void Log( ExceptionContext filterContext ) {

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

           File.AppendAllText( logFile, text.ToString() );

         } finally {
            // SILENT FAIL
         }

      }
   }
}