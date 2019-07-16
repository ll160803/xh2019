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
	public partial class PageObject_BGT_B_BUDGET_CONTROL_D_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_COM_TYPE cause147 =  new CauseObject_COM_TYPE();
			cause147.PARENT_ID = "0201";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause147);
			this.ddlQueryITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			this.ddlQueryITEM_ID.Condition = "BGT_D_BUDGET_ITEM.IS_END=1";
			CauseObject_COM_TYPE cause753 =  new CauseObject_COM_TYPE();
			cause753.PARENT_ID = "0202";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryEDITION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause753);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_CONTROL_D cause = new CauseObject_BGT_B_BUDGET_CONTROL_D();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryTYPE_ID.SelectedValue))
			{
				cause.TYPE_ID = this.ddlQueryTYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryEDITION_ID.SelectedValue))
			{
				cause.EDITION_ID = this.ddlQueryEDITION_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_CONTROL_D  o = (CauseObject_BGT_B_BUDGET_CONTROL_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_CONTROL_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

