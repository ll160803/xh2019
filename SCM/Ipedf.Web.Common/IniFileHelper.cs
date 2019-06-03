using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ipedf.Web.Common
{
    public class IniFileHelper
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key,
                    string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def,
                    StringBuilder retVal, int size, string filePath);



        //类的构造函数，传递INI文件名  
        public static void IniWriteValue(string Section, string Key, string Value, string path)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        //写INI文件  
        public static string IniReadValue(string Section, string Key, string path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, path);
            return temp.ToString();
        }
        /// <summary>
        /// 变更ini文件 以清除缓存
        /// </summary>
        /// <param name="path"></param>
        public static void UpdateCache(string path)
        {
            IniWriteValue("FileUpdate", "UpdateTime", string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now), path);
        }
       
    }
}
