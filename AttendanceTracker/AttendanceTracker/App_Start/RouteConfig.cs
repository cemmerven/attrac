using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AttendanceTracker {
   public class RouteConfig {
      public static void RegisterRoutes( RouteCollection routes ) {

         routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

         routes.RouteExistingFiles = true;

         routes.MapRoute(
            name: "Beden",
            url: "{controller}/{action}/{*anything}",
            defaults: new { controller = "Test", action = "Show", anyting = UrlParameter.Optional}
          
         );


         /*
         routes.MapRoute(
            name: "Beden",
            url: "{controller}/{action}/{date}",
            defaults: new { controller = "Test", action = "Show", date = "2012-12-12" },
            constraints: new { date = @"\d{4}-\d{2}-\d{2}" }
         );
          * 
         routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}"
            //defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
         );

         routes.MapRoute(
            name:        "Archive", 
            url:         "Archive/{entryDate}", 
            defaults:    new { controller = "Blog", action = "Details" }, 
            constraints: new { entryDate = @"d{2}-d{2}-d{4}" },
            namespaces:  new string[]{"","",""}
          );

        routes.MapRoute(
            "Default", // Route name
            "{controller}/{id}", // URL with parameters
            new { controller = "Home", action = "Index" , id = UrlParameter.Optional } // Parameter defaults
        );

        routes.MapRoute(
            "Wk", // Route name
            "{controller}/{action}/{slug}/{id}", // URL with parameters
            new { controller = "Wk", action = "c", slug = "", id = UrlParameter.Optional } // Parameter defaults
        );

         routes.MapRoute(
                    "Instance",
                    "Server/{id}/Instances/{instanceId}/Databases",
                    new { controller = "Server", action = "Databases", id = "id",instanceId="instanceId" }
                    );
         
        routes.MapRoute(
            "Book", // Route name
            "{controller}/{id}/{pageNo}", // URL with parameters
            new { controller = "Book", action = "Index",id = UrlParameter.Optional,pageNo = UrlParameter.Optional } // Parameter defaults
        );

        routes.MapRoute(
            "UserArea", // Route name
            "{controller}/{slug}/{id}", // URL with parameters
            new { controller = "UserArea", action = "Index", slug = UrlParameter.Optional, id = UrlParameter.Optional } // Parameter defaults
        );


        routes.MapRoute(
               "CatchIt", // Name
               "Product/{*values}",  // URL
               new { controller = "Product", action = "Index" } // Defaults
        );

      */

         routes.MapRoute(
             "CatchAll",
             "{*path}",
              new { controller = "Home", action = "Error" } 
         );
         /*
         routes.MapRoute(
             "CatchAll",
             "{*.}",
              new { controller = "Home", action = "Error" } 
         );
         */
         var route = (Route) routes[ "Default" ];


      }
   }
}