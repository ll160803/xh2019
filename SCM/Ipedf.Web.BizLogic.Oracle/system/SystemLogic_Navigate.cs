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
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.DataAccess;
using System.Web.UI;
using Ipedf.Web.Entity;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        static Hashtable pageNavigateCache = Hashtable.Synchronized(new Hashtable());
        /// <summary>
        /// 清空导航缓存,当菜单数据发生变更时请调用此方法以更新缓存
        /// </summary>
        public  void ResetPageNavigateCache()
        {
            pageNavigateCache.Clear();
        }
        private string PreparePageNavigateCacheKey(Page page)
        {
            return Ipedf.Core.UrlHelper.PrepareName(page);
        }
        private string PreparePageNavigateCacheKey(string page)
        {
            return Ipedf.Core.UrlHelper.PrepareName(page);
        }
        private void SetPageNavigateCache(Page page, string navigateString)
        {
            pageNavigateCache[PreparePageNavigateCacheKey(page)] = navigateString;
        }
        private void SetPageNavigateCache(string page, string navigateString)
        {
            pageNavigateCache[PreparePageNavigateCacheKey(page)] = navigateString;
        }
        public string GetPageNavigateCache(Page page)
        {
            if (pageNavigateCache.Count == 0)
                PreparePageNavigateCache(SystemLogic.Proxy.CurrentUser);
            return (string)pageNavigateCache[PreparePageNavigateCacheKey(page)];
        }
        private void PreparePageNavigateCache(DisplayObject_COM_USER user)
        {            
            CauseObject_V_COM_QUERY_MENUS p = new CauseObject_V_COM_QUERY_MENUS();
            p.USER_ID = user.ID;
            DisplayObject_V_COM_QUERY_MENUS[] results = HelperObject_V_COM_QUERY_MENUS.Query(p);
            foreach (DisplayObject_V_COM_QUERY_MENUS result in results)
            {
                SetPageNavigateCache(result.PAGE_URL, string.Concat(" 您当前的位置:", result.SYSTEM_NAME, ">", result.MODULE_NAME, ">", result.FUNCTION_NAME, ">", result.PAGE_NAME));
            }
        }
    }
}
