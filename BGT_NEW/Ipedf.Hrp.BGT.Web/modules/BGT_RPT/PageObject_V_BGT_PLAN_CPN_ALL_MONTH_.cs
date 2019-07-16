using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_V_BGT_PLAN_CPN_ALL_MONTH 
    {
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_V_BGT_PLAN_CPN_ALL_MONTH entity = (EntityObject_V_BGT_PLAN_CPN_ALL_MONTH)e.Row.DataItem;
                
                //打开子查询的代码
                CauseObject_V_BGT_PLAN_ITEM_DEPT_ALL_MONTH o = new CauseObject_V_BGT_PLAN_ITEM_DEPT_ALL_MONTH();
                o.ITEM_ID = entity.ITEM_ID;
                string parameter = JsonConvert.SerializeObject(o);
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
                parameters.Add("linkquery", parameter);
                string url = WebControlHelper.EncodeUrl("PageObject_V_BGT_PLAN_ITEM_DEPT_ALL_MONTH.aspx", parameters);
                e.Row.Cells[1].Text = string.Format("<a href=\"#\" onclick=\"window.open('{0}')\">{1}<a/>", url, e.Row.Cells[1].Text);
            }
        }
    }
}
