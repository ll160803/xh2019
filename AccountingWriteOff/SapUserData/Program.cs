using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapUserData
{
    class Program
    {
        static void Main(string[] args)
        {
            SAPHandle sa = new SAPHandle();
            sa.GetMysqlUserData(SAPHandle.SynUserDataFromSap());
            Console.ReadLine();
        }
    }
}
