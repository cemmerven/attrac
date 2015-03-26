using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceTracker.Models {
   public class Attendant {

      static int _counter = 0;

      public Attendant()
      {
         Id = _counter++;
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public bool Present { get; set; }
   }
}