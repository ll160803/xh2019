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
	public partial class PageObject_BGT_B_CPN_INC_PERSON_FEE_Param : ComQueryParameterPage
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
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_CPN_INC_PERSON_FEE cause = new CauseObject_BGT_B_CPN_INC_PERSON_FEE();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (txtQueryFREE_FIELD3.Text != string.Empty)
			{
				cause.FREE_FIELD3 = string.Format("{0}%",this.txtQueryFREE_FIELD3.Text);
			}
			if (txtQueryFREE_FIELD.Text != string.Empty)
			{
				cause.FREE_FIELD = string.Format("{0}%",this.txtQueryFREE_FIELD.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (txtQueryMONEY.Text != string.Empty)
			{
				cause.MONEY = decimal.Parse(this.txtQueryMONEY.Text);
			}
			if (txtQueryIS_FIXED.Text != string.Empty)
			{
				cause.IS_FIXED = decimal.Parse(this.txtQueryIS_FIXED.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryIS_PERFORMANCE.Text != string.Empty)
			{
				cause.IS_PERFORMANCE = decimal.Parse(this.txtQueryIS_PERFORMANCE.Text);
			}
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (txtQueryFREE_FIELD2.Text != string.Empty)
			{
				cause.FREE_FIELD2 = string.Format("{0}%",this.txtQueryFREE_FIELD2.Text);
			}
			if (txtQueryCONTROL_MONEY.Text != string.Empty)
			{
				cause.CONTROL_MONEY = decimal.Parse(this.txtQueryCONTROL_MONEY.Text);
			}
			if (txtQueryDECALRE_CAUSE.Text != string.Empty)
			{
				cause.DECALRE_CAUSE = string.Format("{0}%",this.txtQueryDECALRE_CAUSE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_CPN_INC_PERSON_FEE  o = (CauseObject_BGT_B_CPN_INC_PERSON_FEE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_CPN_INC_PERSON_FEE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

