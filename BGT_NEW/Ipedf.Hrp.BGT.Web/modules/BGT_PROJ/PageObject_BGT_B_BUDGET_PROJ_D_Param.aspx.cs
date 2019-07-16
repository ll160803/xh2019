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
	public partial class PageObject_BGT_B_BUDGET_PROJ_D_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			SetEnumReferenceBinding(this.ddlQueryIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause873 =  new CauseObject_COM_TYPE();
			cause873.PARENT_ID = "0030";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQuerySOURCE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause873);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_D cause = new CauseObject_BGT_B_BUDGET_PROJ_D();
			
			//平台自动生成代码
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_GOV_PROC.SelectedValue))
			{
				cause.IS_GOV_PROC = decimal.Parse(this.ddlQueryIS_GOV_PROC.SelectedValue);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryBUDEGT_MONEY.Text != string.Empty)
			{
				cause.BUDEGT_MONEY = decimal.Parse(this.txtQueryBUDEGT_MONEY.Text);
			}
			if (txtQueryEXECUTED_MONEY.Text != string.Empty)
			{
				cause.EXECUTED_MONEY = decimal.Parse(this.txtQueryEXECUTED_MONEY.Text);
			}
			if (txtQueryAPPLY_MONEY.Text != string.Empty)
			{
				cause.APPLY_MONEY = decimal.Parse(this.txtQueryAPPLY_MONEY.Text);
			}
			if (txtQueryAPPLIED_MONEY.Text != string.Empty)
			{
				cause.APPLIED_MONEY = decimal.Parse(this.txtQueryAPPLIED_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQuerySOURCE_ID.SelectedValue))
			{
				cause.SOURCE_ID = this.ddlQuerySOURCE_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_PROJ_D  o = (CauseObject_BGT_B_BUDGET_PROJ_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

