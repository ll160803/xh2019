using ConsoleApp1.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference2.SCM_XHClient client = new ServiceReference2.SCM_XHClient();


            WcfMess_XH msg = client.ExportPurchasePlan("10000059", "admin", new DateTime(2016, 1, 1), new DateTime(2019, 1, 1));
            PlanDetail[] pandetails = new PlanDetail[1];
            pandetails[0] = new PlanDetail();
            pandetails[0].ID = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            pandetails[0].EBELN = msg.PurchasePlans[0].EBELN;
            pandetails[0].GYJH = "11111";
            pandetails[0].ORDER_MENGE = 1;
            pandetails[0].FLAG = "C";
            pandetails[0].MENGE = msg.PurchasePlans[0].MENGE    ;
            pandetails[0].PKG_AMOUNT = 1;
            pandetails[0].PKG_NUMBER = 1;
            pandetails[0].FPJR = 1;
            DateTime now = DateTime.Now;
            pandetails[0].VFDAT = now;
            
            WcfPlan_XH[] msg1 = client.ImportSupplyPlan("10000059", "admin", "武汉双鹤医药有限责任公司", pandetails);

            //Console.WriteLine("success: " + msg.IsSuccess);
            //Console.WriteLine("msg: " + msg.Mess);

            //foreach(Purchase item in msg.PurchasePlans)
            //{
            //    Console.WriteLine("id: " +  item.ID + ", name: " + item.NAME1);
            //}

            Console.ReadKey();

        }
    }
}
