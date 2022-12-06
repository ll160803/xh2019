using System;
using System.Collections.Generic;
using System.Text;

namespace XH_Print
{
    public class DataXH
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string preMonthMin { get; set; }
        public string preMonthMax {
            get
            {
                if (String.IsNullOrEmpty(preMonthMin)) return "";
                return GraphicsTable.MoneyToUpper(preMonthMin);
            }
            set
            {
            }
        }
        public string afterMonthMin { get; set; }
        public string afterMonthMax
        {
            get
            {
                if (String.IsNullOrEmpty(afterMonthMin)) return "";
               return  GraphicsTable.MoneyToUpper(afterMonthMin);
            }
            set {
            }
        }
        public string preYearMin { get; set; }
        public string preYearMax
        {
            get
            {
                if (String.IsNullOrEmpty(preYearMin)) return "";
                return GraphicsTable.MoneyToUpper(preYearMin);
            }
            set
            {
            }
        }
        public string afterYearMin { get; set; }
        public string afterYearMax {
            get
            {
                if (String.IsNullOrEmpty(afterYearMin)) return "";
                return GraphicsTable.MoneyToUpper(afterYearMin);
            }
            set
            {
            }
        }
    }
}
