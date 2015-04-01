using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendanceTracker.Models {
   public class Attendant {

      static int _counter = 1;

      public Attendant()
      {
         Id = _counter++;
      }

      public int Id { get; set; }

      [Required( ErrorMessage="bir ad gerekli" ) ]
      public string Name { get; set; }
      public bool Present { get; set; }
   }
}