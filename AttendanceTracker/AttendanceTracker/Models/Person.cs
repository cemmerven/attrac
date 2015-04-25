using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AttendanceTracker.Models {
   public class Person {
      public string Name{ get; set; }
      public int Age{ get; set; }
      public string Mail{ get; set; }

      [DisplayFormat(DataFormatString="{0:d}")]
      public DateTime Registration { get; set; }

      public HomeAddress Address { get; set; }
      public List<Person> Children { get; set; }
   
   }
}
