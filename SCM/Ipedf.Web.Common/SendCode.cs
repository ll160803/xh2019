using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Common
{
    public class SendCode
    {
        /// <summary>
        /// 给据SAP给出的科室名称得出科室编码 编码是自创的
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string GetDepartCode(string Name)
        {
            var deName = "06";
            if (Name.Contains("门诊")) deName = "01";
            if (Name.Contains("住院")) deName = "02";
            if (Name.Contains("代煎")) deName = "03";
            if (Name.Contains("静配")) deName = "04";
            if (Name.Contains("小包装")) deName = "05";
            //switch (Name)
            //{
            //    case "门诊药房":
            //        deName = "01"; break;
            //    case "住院药房":
            //        deName = "02";
            //        break;
            //    case "草药房(代煎)":
            //        deName = "03";
            //        break;
            //    case "静配药房":
            //        deName = "04";
            //        break;
            //    case "草药房(小包装)":
            //        deName = "05";
            //        break;
            //}
            return deName;
        }
    }
}
