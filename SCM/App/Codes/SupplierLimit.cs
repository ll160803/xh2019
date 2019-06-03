using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ipedf.Web.Common;

namespace Ipedf.App.Codes
{
    public class SupplierLimit
    {
        /// <summary>
        /// 是否限制当前供应商上传验收报告文件
        /// </summary>
        /// <param name="gysAccount">供应商账号</param>
        public static bool IsSettingLimit(string gysAccount)
        {
            // 10000056,10000109,10000208
            if (string.IsNullOrEmpty(gysAccount)) return false;
            string accounts = IniFileHelper.IniReadValue("SUPPLIER", "ACCOUNT", System.Web.Hosting.HostingEnvironment.MapPath("~/Cache/SupplierConfig.ini"));
            if (string.IsNullOrEmpty(accounts))
            {
                return false;
            }
            if (accounts.Contains(gysAccount))
            {
                return true;//不做限制
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 设置供应商是否需要上传验收合格证书 不限制需要放入ini文件中
        /// </summary>
        /// <param name="gysAccount"></param>
        /// <param name="flag">0是限制 1是取消限制</param>
        public static bool SettingLimit(string gysAccount, string flag)
        {
            try
            {
                var listCodes = gysAccount.Split(',');
                string accounts = IniFileHelper.IniReadValue("SUPPLIER", "ACCOUNT", HttpContext.Current.Server.MapPath("~/Cache/SupplierConfig.ini"));
                if (string.IsNullOrEmpty(accounts))
                {
                    if (flag == "1")
                    {
                        IniFileHelper.IniWriteValue("SUPPLIER", "ACCOUNT", gysAccount, HttpContext.Current.Server.MapPath("~/Cache/SupplierConfig.ini"));
                    }
                }
                else
                {
                    if (flag == "1")
                    {
                        foreach (var item in listCodes)
                        {
                            if (!accounts.Contains(item))
                            {
                                accounts += "," + item;
                            }
                        }
                        IniFileHelper.IniWriteValue("SUPPLIER", "ACCOUNT", accounts, HttpContext.Current.Server.MapPath("~/Cache/SupplierConfig.ini"));
                    }
                    else
                    {
                        foreach (var item in listCodes)
                        {
                            if (accounts.Contains(item))
                            {
                                accounts = accounts.Replace(item + ",", "");
                                accounts = accounts.Replace(item, "");

                            }
                        }
                        IniFileHelper.IniWriteValue("SUPPLIER", "ACCOUNT", accounts, HttpContext.Current.Server.MapPath("~/Cache/SupplierConfig.ini"));
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }


    }
}