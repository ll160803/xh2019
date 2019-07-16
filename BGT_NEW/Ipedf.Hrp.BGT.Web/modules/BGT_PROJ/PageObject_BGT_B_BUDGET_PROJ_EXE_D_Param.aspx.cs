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
	public partial class PageObject_BGT_B_BUDGET_PROJ_EXE_D_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
			this.ddlQueryAPPLY_USER_ID.DataTable = "COM_USER";
			SetForeignKeyBinding(this.ddlQueryEXECUTE_MONTH_ID, typeof( BizLogicObject_BGT_D_BUDGET_MONTH),"ID","BUDGET_MONTH");
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause = new CauseObject_BGT_B_BUDGET_PROJ_EXE_D();
			
			//平台自动生成代码
			if (txtQueryINVOICE_CODE.Text != string.Empty)
			{
				cause.INVOICE_CODE = string.Format("{0}%",this.txtQueryINVOICE_CODE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryAPPLY_USER_ID.KeyValue))
			{
				cause.APPLY_USER_ID = this.ddlQueryAPPLY_USER_ID.KeyValue;
			}
			if (txtQueryBEGINEXECUTE_DATE.Text != string.Empty)
			{
				if (cause.EXECUTE_DATE == null) 
					cause.EXECUTE_DATE = new DateSpan();
					cause.EXECUTE_DATE.Begin = DateTime.Parse(txtQueryBEGINEXECUTE_DATE.Text);
			}
			if (txtQueryENDEXECUTE_DATE.Text != string.Empty)
			{
				if (cause.EXECUTE_DATE == null)
					cause.EXECUTE_DATE = new DateSpan();
				cause.EXECUTE_DATE.End = DateTime.Parse(txtQueryENDEXECUTE_DATE.Text);
			}
			if (txtQueryEXECUTE_MONEY.Text != string.Empty)
			{
				cause.EXECUTE_MONEY = decimal.Parse(this.txtQueryEXECUTE_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryEXECUTE_MONTH_ID.SelectedValue))
			{
				cause.EXECUTE_MONTH_ID = this.ddlQueryEXECUTE_MONTH_ID.SelectedValue;
			}
			if (txtQueryBEGINAPPLY_DATE.Text != string.Empty)
			{
				if (cause.APPLY_DATE == null) 
					cause.APPLY_DATE = new DateSpan();
					cause.APPLY_DATE.Begin = DateTime.Parse(txtQueryBEGINAPPLY_DATE.Text);
			}
			if (txtQueryENDAPPLY_DATE.Text != string.Empty)
			{
				if (cause.APPLY_DATE == null)
					cause.APPLY_DATE = new DateSpan();
				cause.APPLY_DATE.End = DateTime.Parse(txtQueryENDAPPLY_DATE.Text);
			}
			if (txtQueryAPPLY_MONEY.Text != string.Empty)
			{
				cause.APPLY_MONEY = decimal.Parse(this.txtQueryAPPLY_MONEY.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_PROJ_EXE_D  o = (CauseObject_BGT_B_BUDGET_PROJ_EXE_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_EXE_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

