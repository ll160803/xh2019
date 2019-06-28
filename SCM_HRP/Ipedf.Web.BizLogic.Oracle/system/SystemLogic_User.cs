using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.Entity;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        static byte[] key = new byte[] { 204, 226, 145, 83, 210, 212, 188, 19, 125, 194, 40, 144, 161, 14, 78, 28 };
        static byte[] IV = new byte[] { 210, 93, 166, 98, 125, 16, 146, 147 };
        static DisplayObject_COM_USER _INNER;
        const string _SESSION_KEY = "CURRENT_USER";
        public string Encrypt(string original)
        {
            RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();
            byte[] b = rc2CSP.Key;
            byte[] c = rc2CSP.IV;
            ICryptoTransform encryptor = rc2CSP.CreateEncryptor(key, IV);
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            byte[] toEncrypt = Encoding.ASCII.GetBytes(original);
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();
            byte[] encrypted = msEncrypt.ToArray();
            return Convert.ToBase64String(encrypted);
        }
        public string Decrypt(string content)
        {
            RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();
            byte[] encrypted = Convert.FromBase64String(content);
            ICryptoTransform decryptor = rc2CSP.CreateDecryptor(key, IV);
            MemoryStream msDecrypt = new MemoryStream(encrypted);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            StringBuilder roundtrip = new StringBuilder();
            int b = 0;
            do
            {
                b = csDecrypt.ReadByte();
                if (b != -1)
                {
                    roundtrip.Append((char)b);
                }

            } while (b != -1);
            return roundtrip.ToString();
        }
        public BizLogicMsg Login(string account, string password)
        {
            CauseObject_COM_USER userCauseObject = new CauseObject_COM_USER();
            userCauseObject.ACCOUNT = account;
            userCauseObject.PASSWORD = Encrypt(password);
            DisplayObject_COM_USER[] result = HelperObject_COM_USER.Query(userCauseObject);
            if (result.Length != 0)
            {
                result[0].ENTRY_COUNT = result[0].ENTRY_COUNT + 1;
                result[0].LAST_ENTRY_TIME = System.DateTime.Now;
                if (string.IsNullOrEmpty(result[0].DEPART_ID))
                {
                    return new BizLogicMsg("当前用户没有设置部门属性");
                }
                if (string.IsNullOrEmpty(result[0].DATA_ORGANISE_ID))
                {
                    result[0].DATA_ORGANISE_ID = SearchOrganiseByDepart(result[0].DEPART_ID);
                    if (string.IsNullOrEmpty(result[0].DATA_ORGANISE_ID))
                    {
                        return new BizLogicMsg("当前用户的单位信息通过部门属性获取不到,请检查部门的所属单位属性");
                    }
                }
                CurrentUser = result[0];
                AuditEdit(result[0]);
                HelperObject_COM_USER.Update(result[0], null);
                HttpRequest re = null;
                LogEvent(result[0], re, "登录系统", "登录成功");
                return new BizLogicMsg(true, result[0].CODE);
            }
            else
            {
                return new BizLogicMsg("账号或口令错误");
            }
        }
        public BizLogicMsg Login(Page page, string account, string password)
        {
            CauseObject_COM_USER userCauseObject = new CauseObject_COM_USER();
            userCauseObject.ACCOUNT = account;
            userCauseObject.PASSWORD = Encrypt(password);
            DisplayObject_COM_USER[] result = HelperObject_COM_USER.Query(userCauseObject);
            if (result.Length != 0)
            {
                result[0].ENTRY_COUNT = result[0].ENTRY_COUNT + 1;
                result[0].LAST_ENTRY_TIME = System.DateTime.Now;
               
                if (string.IsNullOrEmpty(result[0].DEPART_ID))
                {
                    return new BizLogicMsg("当前用户没有设置部门属性");
                }
                if (string.IsNullOrEmpty(result[0].DATA_ORGANISE_ID))
                {
                    result[0].DATA_ORGANISE_ID = SearchOrganiseByDepart(result[0].DEPART_ID);
                    if (string.IsNullOrEmpty(result[0].DATA_ORGANISE_ID))
                    {
                        return new BizLogicMsg("当前用户的单位信息通过部门属性获取不到,请检查部门的所属单位属性");
                    }
                }
                CurrentUser = result[0];
                AuditEdit(result[0]);
                HelperObject_COM_USER.Update(result[0], null);
               
                CauseObject_COM_ROLE_M_USER causeROLE = new CauseObject_COM_ROLE_M_USER
                {
                    USER_ID = result[0].ID
                };
                var arr_Entity_Role = BizLogicObject_COM_ROLE_M_USER.Proxy.Query(causeROLE);
                if (arr_Entity_Role.Length <= 0)
                {
                    return new BizLogicMsg("当前用户没有设置角色");
                }
                else
                {
                    if (arr_Entity_Role[0].ROLE_ID == "2f52f1f1-650c-4612-9b96-41746c29cc36")
                    {
                        LogEvent(result[0], page, "登录系统", "登录成功");
                        return new BizLogicMsg();
                    }
                    else
                    {
                       
                        return new BizLogicMsg("当前用户不具备PDA权限");
                    }
                }
               
            }
            else
            {
                return new BizLogicMsg("账号或口令错误");
            }
        }
        public BizLogicMsg ModifyPassword(Page page, string account, string oldPassword, string newPassword)
        {
            CauseObject_COM_USER userCauseObject = new CauseObject_COM_USER();
            userCauseObject.ACCOUNT = account;
            userCauseObject.PASSWORD = Encrypt(oldPassword);
            DisplayObject_COM_USER[] result = HelperObject_COM_USER.Query(userCauseObject);
            if (result.Length != 0)
            {
                result[0].PASSWORD = Encrypt(newPassword);
                AuditEdit(result[0]);
                HelperObject_COM_USER.Update(result[0], null);
                LogEvent(result[0], page, "修改口令", "修改成功");
                return new BizLogicMsg();
            }
            else
            {
                return new BizLogicMsg("原始口令错误");
            }
        }
        public BizLogicMsg ModifyPassword(HttpRequest request, string account, string oldPassword, string newPassword)
        {
            CauseObject_COM_USER userCauseObject = new CauseObject_COM_USER();
            userCauseObject.ACCOUNT = account;
            userCauseObject.PASSWORD = Encrypt(oldPassword);
            DisplayObject_COM_USER[] result = HelperObject_COM_USER.Query(userCauseObject);
            if (result.Length != 0)
            {
                result[0].PASSWORD = Encrypt(newPassword);
                AuditEdit(result[0]);
                HelperObject_COM_USER.Update(result[0], null);
                LogEvent(result[0], request, "修改口令", "修改成功");
                return new BizLogicMsg();
            }
            else
            {
                return new BizLogicMsg("原始口令错误");
            }
        }
        public DisplayObject_COM_USER CurrentUser
        {
            get
            {
                if (System.Web.HttpContext.Current != null)
                    if (System.Web.HttpContext.Current.Session != null)
                    {
                        DisplayObject_COM_USER user = (DisplayObject_COM_USER)System.Web.HttpContext.Current.Session[_SESSION_KEY];
                        return user;
                    }
                return null;
            }
            set
            {
                if (System.Web.HttpContext.Current != null)
                    if (System.Web.HttpContext.Current.Session != null)
                        System.Web.HttpContext.Current.Session["CURRENT_USER"] = value;
            }
        }
        public string GetSystemMenuByUser(string systemId, DisplayObject_COM_USER user, string xsl)
        {
            StringBuilder output = new StringBuilder(4096);
            output.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n");
            output.Append("<?xml-stylesheet href=\"").Append(xsl).Append("\" type=\"text/xsl\" ?>\n");
            CauseObject_V_COM_QUERY_MENUS p = new CauseObject_V_COM_QUERY_MENUS();
            p.USER_ID = user == null ? _INNER.ID : user.ID;
            p.SYSTEM_ID = systemId == null ? string.Empty : systemId.Trim();
            DisplayObject_V_COM_QUERY_MENUS[] results = HelperObject_V_COM_QUERY_MENUS.Query(p);
            if (results.Length == 0)
            {
                output.Append("<Modules Loginuser=\"").Append(user.ACCOUNT).Append("\"/>\n");
                return output.ToString();
            }
            output.Append("<Modules Loginuser=\"").Append(user.ACCOUNT).Append("\">\n");
            string preModule = string.Empty;
            string preFunction = string.Empty;
            //标志计数器
            int moduleCount = 0;
            int functionCount = 0;
            int pageCount = 0;
            foreach (DisplayObject_V_COM_QUERY_MENUS result in results)
            {
                if (!preModule.Contains(result.MODULE_NAME))
                {
                    if (moduleCount > 0)
                    {
                        //追加上一个Module的结束标签
                        output.Append("\t\t\t\t</Pages>\n");
                        output.Append("\t\t\t</Function>\n");
                        output.Append("\t\t</Functions>\n");
                        output.Append("\n\t</Module>\n");
                    }
                    //追加Module标签
                    output.Append("\t<Module Name=\"").Append(result.MODULE_NAME).Append("\" Code =\"").Append(result.MODULE_CODE).Append("\" Index=\"").Append(string.Concat(result.SYSTEM_DISPLAY_INDEX, result.MODULE_DISPALY_INDEX)).Append("\"").Append(" Url=\"").Append(result.MODULE_PAGE_URL).Append("\">\n");
                    output.Append("\t\t<Functions>\n");
                    output.Append("\t\t\t<Function Name=\"").Append(result.FUNCTION_NAME).Append("\" Code =\"").Append(result.FUNCTION_CODE).Append("\" Index=\"").Append(result.FUNCTION_DISPLAY_INDEX).Append("\"").Append(" Url=\"").Append(result.FUNCTION_PAGE_URL).Append("\">\n");
                    output.Append("\t\t\t\t<Pages>\n");
                    output.Append("\t\t\t\t\t<Page Href=\"").Append(result.PAGE_URL).Append("\" Name=\"").Append(result.PAGE_NAME).Append("\" Code =\"").Append(result.PAGE_CODE).Append("\" Index=\"").Append(result.PAGE_DISPLAY_INDEX).Append("\"/>\n");
                    moduleCount += 1;
                    functionCount += 1;
                    preFunction = result.FUNCTION_NAME;
                }
                else
                {
                    if (!preFunction.Contains(result.FUNCTION_NAME))
                    {
                        if (functionCount > 0)
                        {
                            //追加上一个Function的结束标签
                            output.Append("\t\t\t\t</Pages>\n");
                            output.Append("\t\t\t</Function>\n");
                        }
                        //追加Function标签
                        output.Append("\t\t\t<Function Name=\"").Append(result.FUNCTION_NAME).Append("\" Code =\"").Append(result.FUNCTION_CODE).Append("\" Index=\"").Append(string.Concat(result.SYSTEM_DISPLAY_INDEX, result.MODULE_DISPALY_INDEX, result.FUNCTION_DISPLAY_INDEX)).Append("\"").Append(" Url=\"").Append(result.FUNCTION_PAGE_URL).Append("\">\n");
                        output.Append("\t\t\t\t<Pages>\n");
                        output.Append("\t\t\t\t\t<Page Href=\"").Append(result.PAGE_URL).Append("\" Name=\"").Append(result.PAGE_NAME).Append("\" Code =\"").Append(result.PAGE_CODE).Append("\" Index=\"").Append(result.PAGE_DISPLAY_INDEX).Append("\"/>\n");
                        functionCount += 1;
                        pageCount += 1;
                        preFunction = result.FUNCTION_NAME;
                    }
                    else
                    {
                        //追加Page标签
                        output.Append("\t\t\t\t\t<Page Href=\"").Append(result.PAGE_URL).Append("\" Name=\"").Append(result.PAGE_NAME).Append("\" Code =\"").Append(result.PAGE_CODE).Append("\" Index=\"").Append(string.Concat(result.SYSTEM_DISPLAY_INDEX, result.MODULE_DISPALY_INDEX, result.FUNCTION_DISPLAY_INDEX, result.PAGE_DISPLAY_INDEX)).Append("\"/>\n");
                        pageCount += 1;

                    }
                }
                preModule = result.MODULE_NAME;

            }
            output.Append("\t\t\t\t</Pages>\n");
            output.Append("\t\t\t</Function>\n");
            output.Append("\t\t</Functions>\n");
            output.Append("\n\t</Module>\n");
            output.Append("</Modules>\n");
            return output.ToString();
        }
        public string GetSystemMenuByUser(string systemId, DisplayObject_COM_USER user)
        {

            CauseObject_V_COM_QUERY_MENUS p = new CauseObject_V_COM_QUERY_MENUS();
            p.USER_ID = user == null ? _INNER.ID : user.ID;
            p.SYSTEM_ID = systemId == null ? string.Empty : systemId.Trim();
            DisplayObject_V_COM_QUERY_MENUS[] results = HelperObject_V_COM_QUERY_MENUS.Query(p);
            List<EntityObject_Menu> menulist = new List<EntityObject_Menu>();
            if (results.Length == 0)
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(menulist.ToArray());
            }
            DataTable dt = DataSourceHelper.ConvertToDatatable<DisplayObject_V_COM_QUERY_MENUS>(results);
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format(" SYSTEM_ID = '{0}'", systemId);
            dv.Sort = "MODULE_DISPALY_INDEX";
            DataTable moduleDt = dv.ToTable();//获取模块
            foreach (DataRow mrow in moduleDt.Rows)
            {
                EntityObject_Menu moduleObj = new EntityObject_Menu();
                moduleObj.Name = mrow["MODULE_NAME"].ToString();
                moduleObj.Value = mrow["MODULE_DISPALY_INDEX"].ToString();

                List<EntityObject_Menu> functionlist = new List<EntityObject_Menu>();
                dv.RowFilter = string.Format(" MODULE_NAME = '{0}'", mrow["MODULE_NAME"]);
                dv.Sort = "FUNCTION_DISPLAY_INDEX";
                DataTable functionDt = dv.ToTable();//获取功能
                foreach (DataRow frow in functionDt.Rows)
                {
                    EntityObject_Menu functionObj = new EntityObject_Menu();
                    functionObj.Name = mrow["FUNCTION_NAME"].ToString();
                    functionObj.Value = mrow["FUNCTION_DISPLAY_INDEX"].ToString();

                    List<EntityObject_Menu> pagelist = new List<EntityObject_Menu>();
                    dv.RowFilter = string.Format(" FUNCTION_NAME = '{0}'", frow["FUNCTION_NAME"]);
                    dv.Sort = "PAGE_DISPLAY_INDEX";
                    DataTable pageDt = dv.ToTable();//获取表单

                    foreach (DataRow prow in pageDt.Rows)
                    {
                        EntityObject_Menu pageObj = new EntityObject_Menu();
                        pageObj.Name = mrow["PAGE_NAME"].ToString();
                        //pageObj.Value = mrow["PAGE_DISPLAY_INDEX"].ToString();
                        pageObj.Value = mrow["PAGE_URL"].ToString();
                        pagelist.Add(pageObj);//追加到页面集合
                    }
                    functionObj.Items = pagelist.ToArray();
                    functionlist.Add(functionObj);//追加到功能集合
                }
                moduleObj.Items = functionlist.ToArray();
                menulist.Add(moduleObj);//追加到模块集合
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(menulist.ToArray());
        }
        /// <summary>
        /// 直接生成页面需要的html
        /// </summary>
        /// <param name="systemId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetSystemMenuByUser_S(string systemId, DisplayObject_COM_USER user)
        {

            CauseObject_V_COM_QUERY_MENUS p = new CauseObject_V_COM_QUERY_MENUS();
            p.USER_ID = user == null ? _INNER.ID : user.ID;
            p.SYSTEM_ID = systemId == null ? string.Empty : systemId.Trim();
            DisplayObject_V_COM_QUERY_MENUS[] results = HelperObject_V_COM_QUERY_MENUS.Query(p);
            List<EntityObject_Menu> menulist = new List<EntityObject_Menu>();
            if (results.Length == 0)
            {
                return "";
            }

            StringBuilder strmenu2 = new StringBuilder();
            string preModule = string.Empty;
            string preFunction = string.Empty;
            //标志计数器
            int moduleCount = 0;
            int functionCount = 0;
            int pageCount = 0;
            foreach (DisplayObject_V_COM_QUERY_MENUS result in results)
            {
                if (!preModule.Contains(result.MODULE_NAME))
                {
                    if (moduleCount > 0)
                    {
                        //追加上一个Module的结束标签
                        strmenu2.Append("</ul></li>");
                        strmenu2.Append("</ul></div></div>");
                    }
                    //追加Module标签
                    strmenu2.Append(string.Format(" <div data-options=@iconCls:'{0}'@ title=@{1}@> <div class=@easyui-panel@  fit=@true@ border=@false@><ul class=@easyui-tree@ >", "icon-sys", result.MODULE_NAME));
                    strmenu2.Append(string.Format("<li data-options=@{0}@><span>{1}</span><ul>", string.Join(",", "state:'closed'"), result.FUNCTION_NAME));
                    strmenu2.Append(string.Format("<li><a href=@#@ icon=@{0}@ onclick=@ShowCenterHtml($(this))@ rel=@{1}@ id=@{2}@>{3}</a></li>", "icon-sys", result.PAGE_URL, result.PAGE_ID, result.PAGE_NAME));
                    moduleCount += 1;
                    functionCount += 1;
                    preFunction = result.FUNCTION_NAME;
                }
                else
                {
                    if (!preFunction.Contains(result.FUNCTION_NAME))
                    {
                        if (functionCount > 0)
                        {
                            //追加上一个Function的结束标签
                            strmenu2.Append("</ul></li>");

                        }
                        //追加Function标签
                        strmenu2.Append(string.Format("<li data-options=@{0}@><span>{1}</span><ul>", string.Join(",", "state:'closed'"), result.FUNCTION_NAME));
                        strmenu2.Append(string.Format("<li><a href=@#@ icon=@{0}@ onclick=@ShowCenterHtml($(this))@ rel=@{1}@ id=@{2}@>{3}</a></li>", "icon-sys", result.PAGE_URL, result.PAGE_ID, result.PAGE_NAME));
                        functionCount += 1;
                        pageCount += 1;
                        preFunction = result.FUNCTION_NAME;
                    }
                    else
                    {
                        //追加Page标签
                        strmenu2.Append(string.Format("<li><a href=@#@ icon=@{0}@ onclick=@ShowCenterHtml($(this))@ rel=@{1}@ id=@{2}@>{3}</a></li>", "icon-sys", result.PAGE_URL, result.PAGE_ID, result.PAGE_NAME));
                        pageCount += 1;

                    }
                }
                preModule = result.MODULE_NAME;

            }
            strmenu2.Append("</ul></li>");
            strmenu2.Append("</ul></div></div>");



            return strmenu2.ToString().Replace('@', '"');
        }
        public System.Collections.Specialized.StringDictionary GetSystemDictionaryByUser(string userId)
        {
            CauseObject_V_COM_QUERY_MENUS p = new CauseObject_V_COM_QUERY_MENUS();
            p.USER_ID = userId;
            DisplayObject_V_COM_QUERY_MENUS[] results = HelperObject_V_COM_QUERY_MENUS.Query(p);
            System.Collections.Specialized.StringDictionary ret = new System.Collections.Specialized.StringDictionary();
            foreach (DisplayObject_V_COM_QUERY_MENUS result in results)
            {
                ret[result.SYSTEM_ID] = result.SYSTEM_NAME;
            }
            return ret;
        }
        public DisplayObject_COM_SYSTEM[] GetSystemByUser(string userId)
        {
            return HelperObject_COM_USER.GetSystemByUser(userId);
        }
    }

}
