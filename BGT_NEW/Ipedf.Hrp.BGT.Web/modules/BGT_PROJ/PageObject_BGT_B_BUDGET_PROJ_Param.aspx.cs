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
	public partial class PageObject_BGT_B_BUDGET_PROJ_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			this.ddlQueryAPPLY_USER_ID.DataTable = "COM_USER";
			CauseObject_COM_TYPE cause858 =  new CauseObject_COM_TYPE();
			cause858.PARENT_ID = "0029";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryBIZ_STATE, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause858);
			CauseObject_COM_TYPE cause125 =  new CauseObject_COM_TYPE();
			cause125.PARENT_ID = "0027";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause125);
			this.ddlQueryPROJ_USER_ID.DataTable = "COM_USER";
			SetEnumReferenceBinding(this.ddlQueryIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlQueryREPLY_USER_ID.DataTable = "COM_USER";
			SetForeignKeyBinding(this.ddlQueryNATURE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME");
			this.ddlQueryFINANCE_USER_ID.DataTable = "COM_USER";
			SetEnumReferenceBinding(this.ddlQuerySTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ cause = new CauseObject_BGT_B_BUDGET_PROJ();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryAPPLY_USER_ID.KeyValue))
			{
				cause.APPLY_USER_ID = this.ddlQueryAPPLY_USER_ID.KeyValue;
			}
			if (txtQueryBEGINREPLY_DATE.Text != string.Empty)
			{
				if (cause.REPLY_DATE == null) 
					cause.REPLY_DATE = new DateSpan();
					cause.REPLY_DATE.Begin = DateTime.Parse(txtQueryBEGINREPLY_DATE.Text);
			}
			if (txtQueryENDREPLY_DATE.Text != string.Empty)
			{
				if (cause.REPLY_DATE == null)
					cause.REPLY_DATE = new DateSpan();
				cause.REPLY_DATE.End = DateTime.Parse(txtQueryENDREPLY_DATE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryBIZ_STATE.SelectedValue))
			{
				cause.BIZ_STATE = this.ddlQueryBIZ_STATE.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryTYPE_ID.SelectedValue))
			{
				cause.TYPE_ID = this.ddlQueryTYPE_ID.SelectedValue;
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryPROJ_USER_ID.KeyValue))
			{
				cause.PROJ_USER_ID = this.ddlQueryPROJ_USER_ID.KeyValue;
			}
			if (txtQueryBEGINPLAN_BEGIN_DATE.Text != string.Empty)
			{
				if (cause.PLAN_BEGIN_DATE == null) 
					cause.PLAN_BEGIN_DATE = new DateSpan();
					cause.PLAN_BEGIN_DATE.Begin = DateTime.Parse(txtQueryBEGINPLAN_BEGIN_DATE.Text);
			}
			if (txtQueryENDPLAN_BEGIN_DATE.Text != string.Empty)
			{
				if (cause.PLAN_BEGIN_DATE == null)
					cause.PLAN_BEGIN_DATE = new DateSpan();
				cause.PLAN_BEGIN_DATE.End = DateTime.Parse(txtQueryENDPLAN_BEGIN_DATE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_GOV_PROC.SelectedValue))
			{
				cause.IS_GOV_PROC = decimal.Parse(this.ddlQueryIS_GOV_PROC.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryREPLY_USER_ID.KeyValue))
			{
				cause.REPLY_USER_ID = this.ddlQueryREPLY_USER_ID.KeyValue;
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
			if (txtQueryBEGINPLAN_END_DATE.Text != string.Empty)
			{
				if (cause.PLAN_END_DATE == null) 
					cause.PLAN_END_DATE = new DateSpan();
					cause.PLAN_END_DATE.Begin = DateTime.Parse(txtQueryBEGINPLAN_END_DATE.Text);
			}
			if (txtQueryENDPLAN_END_DATE.Text != string.Empty)
			{
				if (cause.PLAN_END_DATE == null)
					cause.PLAN_END_DATE = new DateSpan();
				cause.PLAN_END_DATE.End = DateTime.Parse(txtQueryENDPLAN_END_DATE.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryNATURE_ID.SelectedValue))
			{
				cause.NATURE_ID = this.ddlQueryNATURE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryFINANCE_USER_ID.KeyValue))
			{
				cause.FINANCE_USER_ID = this.ddlQueryFINANCE_USER_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQuerySTATE.SelectedValue))
			{
				cause.STATE = decimal.Parse(this.ddlQuerySTATE.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_PROJ  o = (CauseObject_BGT_B_BUDGET_PROJ)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

