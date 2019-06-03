using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App.Codes
{
    public class DateTimeHelper
    {
       public static string toString(System.DateTime dateTime)
        {
            if (dateTime == null || dateTime.Year == 1)
            {
                return "";
            }

            return dateTime.ToShortDateString();
        }

        public static string toString(System.DateTime dateTime1, System.DateTime dateTime2)
        {
            if (dateTime1 == null || dateTime2 == null || dateTime1.Year == 1 || dateTime2.Year == 1)
            {
                return "";
            }

            return toString(dateTime1) + " 至 " + toString(dateTime2);
        }
    }
}