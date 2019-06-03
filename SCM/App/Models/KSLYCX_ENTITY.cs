using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App.Models
{
    public class KSLYCX_ENTITY
    {
        public string NORMT { get; set; }
        private string _EBELN;
        public string EBELN
        {
            get
            {
                if (_EBELN != null)
                {
                    return _EBELN.TrimStart('0');

                }
                return _EBELN;
            }
            set
            {
                _EBELN = value;
            }
        }
        public string KOSTL { get; set; }
        public string LTEXT { get; set; }
        public string CPUDT { get; set; }
        public string CPUTM { get; set; }
        private string _matnr;
        public string MATNR
        {
            get
            {
                if (_matnr != null)
                {
                    return _matnr.TrimStart('0');

                }
                return _matnr;
            }
            set
            {
                _matnr = value;
            }
        }
        public string MAKTX { get; set; }
        public string MEINS { get; set; }
        public string MSEHL { get; set; }
        public decimal MENGE { get; set; }
        public decimal BRTWR { get; set; }
        public decimal DMBTR { get; set; }
        public string BWART { get; set; }
        public string ID { get; set; }
    }
}