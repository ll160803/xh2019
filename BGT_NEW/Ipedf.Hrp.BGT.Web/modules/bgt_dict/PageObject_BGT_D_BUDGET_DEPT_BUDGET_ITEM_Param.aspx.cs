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
using Newtonsoft.Json;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlQueryBUDGET_ITEM_ID.Condition = "BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";

		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause = new CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_ITEM_ID.KeyValue))
			{
				cause.BUDGET_ITEM_ID = this.ddlQueryBUDGET_ITEM_ID.KeyValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM  o = (CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

