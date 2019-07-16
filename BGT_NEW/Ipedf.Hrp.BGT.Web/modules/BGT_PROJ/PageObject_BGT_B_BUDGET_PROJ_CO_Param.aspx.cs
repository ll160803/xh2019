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
	public partial class PageObject_BGT_B_BUDGET_PROJ_CO_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			this.ddlQueryPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
			SetEnumReferenceBinding(this.ddlQueryIS_RECENTLY, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_CO cause = new CauseObject_BGT_B_BUDGET_PROJ_CO();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (txtQueryEXECUTED_MONEY.Text != string.Empty)
			{
				cause.EXECUTED_MONEY = decimal.Parse(this.txtQueryEXECUTED_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryPROJECT_ID.KeyValue))
			{
				cause.PROJECT_ID = this.ddlQueryPROJECT_ID.KeyValue;
			}
			if (txtQueryBUDGET_MONEY.Text != string.Empty)
			{
				cause.BUDGET_MONEY = decimal.Parse(this.txtQueryBUDGET_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_RECENTLY.SelectedValue))
			{
				cause.IS_RECENTLY = decimal.Parse(this.ddlQueryIS_RECENTLY.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_PROJ_CO  o = (CauseObject_BGT_B_BUDGET_PROJ_CO)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_CO.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

