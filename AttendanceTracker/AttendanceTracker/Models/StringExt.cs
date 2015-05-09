using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceTracker.Models
{
    public static class Ext
    {

        public static string Put( this string str, params object[] args ) {
            return String.Format( str, args );
        }

        public static string Put(this int num, params object[] args)
        {
            return String.Format(num.ToString(), args);
        }

    }

}