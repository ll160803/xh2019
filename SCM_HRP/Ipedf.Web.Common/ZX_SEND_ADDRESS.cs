using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Common
{
    public enum ZX_SEND_ADDRESS
    {
        //南院库房，南院门诊，南院仁济，南院泰康，南院静配，南院麻醉，南院大输液，后湖门诊，后湖住院，后湖静配，后湖麻醉，后湖大输液，谌家矶，花桥，商学院

        南院库房 = 1,
        南院门诊 = 2,
        南院仁济 = 3,
        南院泰康 = 4,
        南院静配 = 5,
        南院麻醉 = 6,
        南院大输液 = 7,
        后湖门诊 = 8,
        后湖住院 = 9,
        后湖静配 = 10,
        后湖麻醉 = 11,
        后湖大输液 = 12,
        谌家矶 = 13,
        花桥 = 14,
        商学院 = 15
    }
    public static class ZX_ADDRESS
    {
        public static string GET_Address(string address)
        {
            string add = "01";
            switch (address)
            {
                case "南院库房":
                    add = "01";
                    break;
                case "南院门诊":
                    add = "02";
                    break;
                case "南院仁济":
                    add = "03";
                    break;
                case "南院泰康":
                    add = "04";
                    break;
                case "南院静配":
                    add = "05";
                    break;
                case "南院麻醉":
                    add = "06";
                    break;
                case "南院大输液":
                    add = "07";
                    break;
                case "后湖门诊":
                    add = "08";
                    break;
                case "后湖住院":
                    add = "09";
                    break;
                case "后湖静配":
                    add = "10";
                    break;
                case "后湖麻醉":
                    add = "11";
                    break;
                case "后湖大输液":
                    add = "12";
                    break;
                case "谌家矶":
                    add = "13";
                    break;
                case "花桥":
                    add = "14";
                    break;
                case "商学院":
                    add = "15";
                    break;
                default:
                    add = "01";
                    break;
            }
            return add;
        }
    }
}
