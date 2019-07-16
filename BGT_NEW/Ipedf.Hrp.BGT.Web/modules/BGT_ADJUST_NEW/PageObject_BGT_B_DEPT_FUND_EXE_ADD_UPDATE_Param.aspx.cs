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
	public partial class PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlQueryBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			SetEnumReferenceBinding(this.ddlQueryIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlQueryFUND_TYPE_ID.DataTable = "COM_TYPE";
			SetEnumReferenceBinding(this.ddlQueryIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlQueryDEPT_USER_ID.DataTable = "COM_USER";
			SetEnumReferenceBinding(this.ddlQuerySTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause = new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue))
			{
				cause.BGT_D_BUDGET_ITEM_ID = this.ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue;
			}
			if (txtQueryFREE_FIELD3.Text != string.Empty)
			{
				cause.FREE_FIELD3 = string.Format("{0}%",this.txtQueryFREE_FIELD3.Text);
			}
			if (txtQueryFREE_FIELD.Text != string.Empty)
			{
				cause.FREE_FIELD = string.Format("{0}%",this.txtQueryFREE_FIELD.Text);
			}
			if (txtQueryDECALRE_CAUSE.Text != string.Empty)
			{
				cause.DECALRE_CAUSE = string.Format("{0}%",this.txtQueryDECALRE_CAUSE.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (txtQueryCONTROL_MONEY.Text != string.Empty)
			{
				cause.CONTROL_MONEY = decimal.Parse(this.txtQueryCONTROL_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_FIXED.SelectedValue))
			{
				cause.IS_FIXED = decimal.Parse(this.ddlQueryIS_FIXED.SelectedValue);
			}
			if (txtQueryFREE_FIELD2.Text != string.Empty)
			{
				cause.FREE_FIELD2 = string.Format("{0}%",this.txtQueryFREE_FIELD2.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryFUND_TYPE_ID.KeyValue))
			{
				cause.FUND_TYPE_ID = this.ddlQueryFUND_TYPE_ID.KeyValue;
			}
			if (txtQueryREF_TAB_ID.Text != string.Empty)
			{
				cause.REF_TAB_ID = string.Format("{0}%",this.txtQueryREF_TAB_ID.Text);
			}
			if (txtQueryFUND_MONEY.Text != string.Empty)
			{
				cause.FUND_MONEY = decimal.Parse(this.txtQueryFUND_MONEY.Text);
			}
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_PERFORMANCE.SelectedValue))
			{
				cause.IS_PERFORMANCE = decimal.Parse(this.ddlQueryIS_PERFORMANCE.SelectedValue);
			}
			if (txtQueryITEM_NAME.Text != string.Empty)
			{
				cause.ITEM_NAME = string.Format("{0}%",this.txtQueryITEM_NAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_USER_ID.KeyValue))
			{
				cause.DEPT_USER_ID = this.ddlQueryDEPT_USER_ID.KeyValue;
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQuerySTATE.SelectedValue))
			{
				cause.STATE = decimal.Parse(this.ddlQuerySTATE.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE  o = (CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

