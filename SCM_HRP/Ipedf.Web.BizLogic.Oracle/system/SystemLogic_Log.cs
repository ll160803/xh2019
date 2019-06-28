using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.Entity;
using System.Web.UI;
using Ipedf.Common;
using System.Reflection;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic : BizLogicBase<object>
    {
        public void LogEvent(DisplayObject_COM_USER user, Page page, string command, string message)
        {
            EntityObject_COM_LOG log = new EntityObject_COM_LOG();
            log.COMMAND = command == null ? string.Empty : command;
            log.LOG_TIME = System.DateTime.Now;
            log.IPADDRESS = page == null ? string.Empty : page.Request.UserHostAddress;
            log.MESSAGE = message;
            log.PAGEURL = page == null ? "系统平台" : PrepareUrl(page.Request.Url.AbsoluteUri);
            log.USER_ID = user == null ? string.Empty : user.ID;
            log.TYPE = (decimal)日志类型.正常;
            HelperObject_COM_LOG.Save(log, null);
        }
        public void LogError(DisplayObject_COM_USER user, Page page, string command, string message)
        {
            EntityObject_COM_LOG log = new EntityObject_COM_LOG();
            log.COMMAND = command == null ? string.Empty : command;
            log.LOG_TIME = System.DateTime.Now;
            log.IPADDRESS = page == null ? string.Empty : page.Request.UserHostAddress;
            log.MESSAGE = message;
            log.PAGEURL = page == null ? "系统平台" : PrepareUrl(page.Request.Url.AbsoluteUri);
            log.USER_ID = user == null ? string.Empty : user.ID;
            log.TYPE = (decimal)日志类型.错误;
            HelperObject_COM_LOG.Save(log, null);
        }
        public void LogEvent(DisplayObject_COM_USER user, HttpRequest request, string command, string message)
        {
            EntityObject_COM_LOG log = new EntityObject_COM_LOG();
            log.COMMAND = command == null ? string.Empty : command;
            log.LOG_TIME = System.DateTime.Now;
            log.IPADDRESS =request==null?"": request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            log.MESSAGE = message;
            log.PAGEURL =request==null?"": request.Url.ToString();
            log.USER_ID = user == null ? string.Empty : user.ID;
            log.TYPE = (decimal)日志类型.正常;
            HelperObject_COM_LOG.Save(log, null);
        }
        public void LogError(DisplayObject_COM_USER user, HttpRequest request, string command, string message)
        {
            EntityObject_COM_LOG log = new EntityObject_COM_LOG();
            log.COMMAND = command == null ? string.Empty : command;
            log.LOG_TIME = System.DateTime.Now;
            log.IPADDRESS = request == null ? "" : request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            log.MESSAGE = message;
            log.PAGEURL = request == null ? "" : request.Url.ToString();
            log.USER_ID = user == null ? string.Empty : user.ID;
            log.TYPE = (decimal)日志类型.错误;
            HelperObject_COM_LOG.Save(log, null);
        }
    }

}
