using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Common
{
   public class EncryptNumber
    {
       public static string EncryCode(string code)
       {
           int hideCode = 7;//加密数字
           int i_code = int.Parse(code);
           return (i_code ^ hideCode).ToString();

       }
       public static string DeEncryCode(string code)
       {
           int hideCode = 7;//加密数字
           int i_code = int.Parse(code);
           return (hideCode ^ i_code).ToString();
       }
    }
}
