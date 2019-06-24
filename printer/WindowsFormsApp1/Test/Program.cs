using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.NetworkCredential c = new System.Net.NetworkCredential("hr_qiuc", "qc654321");
            WebPrint.ZHRWS_ZCPS zHRWS_ZCPS = new WebPrint.ZHRWS_ZCPS();
            zHRWS_ZCPS.Credentials = c;
            WebPrint.Zhr00FmZcpsdy zhr = new WebPrint.Zhr00FmZcpsdy();
            zhr.Icnum = "421181198908223626";
            zhr.Zhrzjlx = "2";
            var res= zHRWS_ZCPS.Zhr00FmZcpsdy(zhr);
            Console.WriteLine(res.Gesctxt);
            Console.Read();
        }
    }
}
