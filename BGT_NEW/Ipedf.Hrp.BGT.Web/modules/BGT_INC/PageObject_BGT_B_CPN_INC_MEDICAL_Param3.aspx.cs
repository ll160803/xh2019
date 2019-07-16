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
	public partial class PageObject_BGT_B_CPN_INC_MEDICAL_Param3 : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
			this.ddlQueryCOM_TYPE_ID.DataTable = "COM_TYPE";
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			SetEnumReferenceBinding(this.ddlQueryIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQuerySTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_CPN_INC_MEDICAL cause = new CauseObject_BGT_B_CPN_INC_MEDICAL();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryCOM_TYPE_ID.KeyValue))
			{
				cause.COM_TYPE_ID = this.ddlQueryCOM_TYPE_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_FIXED.SelectedValue))
			{
				cause.IS_FIXED = decimal.Parse(this.ddlQueryIS_FIXED.SelectedValue);
			}
			if (txtQueryCONTROL_MONEY.Text != string.Empty)
			{
				cause.CONTROL_MONEY = decimal.Parse(this.txtQueryCONTROL_MONEY.Text);
			}
			if (txtQueryMONEY.Text != string.Empty)
			{
				cause.MONEY = decimal.Parse(this.txtQueryMONEY.Text);
			}
			if (txtQueryFREE_FIELD2.Text != string.Empty)
			{
				cause.FREE_FIELD2 = string.Format("{0}%",this.txtQueryFREE_FIELD2.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_PERFORMANCE.SelectedValue))
			{
				cause.IS_PERFORMANCE = decimal.Parse(this.ddlQueryIS_PERFORMANCE.SelectedValue);
			}
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (txtQueryITEM_NAME.Text != string.Empty)
			{
				cause.ITEM_NAME = string.Format("{0}%",this.txtQueryITEM_NAME.Text);
			}
			if (txtQueryDEPT_USER_ID.Text != string.Empty)
			{
				cause.DEPT_USER_ID = string.Format("{0}%",this.txtQueryDEPT_USER_ID.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryPER_MONEY.Text != string.Empty)
			{
				cause.PER_MONEY = decimal.Parse(this.txtQueryPER_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQuerySTATE.SelectedValue))
			{
				cause.STATE = decimal.Parse(this.ddlQuerySTATE.SelectedValue);
			}
			if (txtQueryPERSON_COUNT.Text != string.Empty)
			{
				cause.PERSON_COUNT = decimal.Parse(this.txtQueryPERSON_COUNT.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (txtQueryDECALRE_CAUSE.Text != string.Empty)
			{
				cause.DECALRE_CAUSE = string.Format("{0}%",this.txtQueryDECALRE_CAUSE.Text);
			}
			if (txtQueryFREE_FIELD.Text != string.Empty)
			{
				cause.FREE_FIELD = string.Format("{0}%",this.txtQueryFREE_FIELD.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_CPN_INC_MEDICAL  o = (CauseObject_BGT_B_CPN_INC_MEDICAL)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_CPN_INC_MEDICAL3.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

