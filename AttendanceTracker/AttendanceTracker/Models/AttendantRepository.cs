using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AttendanceTracker.Models {
   public class AttendantRepository {

      List<Attendant> _attendants = new List<Attendant>{
         new Attendant{ Name = "can", Present = false },
         new Attendant{ Name = "cem", Present = false }
      };

      public ReadOnlyCollection<Attendant> List { 
      
         get{ 
            return new ReadOnlyCollection<Attendant>( _attendants );
         }//get
      
      }//List


      public Attendant FindById( int attendantId ) {

          var attendant = _attendants.Find( a => a.Id == attendantId );
         
          return attendant;

      }//FindById


      internal void Update( Attendant attendant ) {
        _attendants[ attendant.Id ] = attendant;
      }

      internal void Create( Attendant attendant ) {
         _attendants.Add( attendant );
      }
   }//class
}//namespace