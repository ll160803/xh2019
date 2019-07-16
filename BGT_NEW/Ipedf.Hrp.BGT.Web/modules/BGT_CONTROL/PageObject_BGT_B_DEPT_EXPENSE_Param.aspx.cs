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
	public partial class PageObject_BGT_B_DEPT_EXPENSE_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryAPPLY_USER_ID.DataTable = "COM_USER";
			this.ddlQueryAPPLY_DEPT_ID.DataTable = "COM_DEPART";
			this.ddlQueryPAY_USER_ID.DataTable = "COM_USER";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_EXPENSE cause = new CauseObject_BGT_B_DEPT_EXPENSE();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryAPPLY_USER_ID.KeyValue))
			{
				cause.APPLY_USER_ID = this.ddlQueryAPPLY_USER_ID.KeyValue;
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
			if (txtQuerySUMARRY.Text != string.Empty)
			{
				cause.SUMARRY = string.Format("{0}%",this.txtQuerySUMARRY.Text);
			}
			if (txtQueryBEGINPAY_DATE.Text != string.Empty)
			{
				if (cause.PAY_DATE == null) 
					cause.PAY_DATE = new DateSpan();
					cause.PAY_DATE.Begin = DateTime.Parse(txtQueryBEGINPAY_DATE.Text);
			}
			if (txtQueryENDPAY_DATE.Text != string.Empty)
			{
				if (cause.PAY_DATE == null)
					cause.PAY_DATE = new DateSpan();
				cause.PAY_DATE.End = DateTime.Parse(txtQueryENDPAY_DATE.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryAPPLY_DEPT_ID.KeyValue))
			{
				cause.APPLY_DEPT_ID = this.ddlQueryAPPLY_DEPT_ID.KeyValue;
			}
			if (txtQueryPAY_MONEY.Text != string.Empty)
			{
				cause.PAY_MONEY = decimal.Parse(this.txtQueryPAY_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryPAY_USER_ID.KeyValue))
			{
				cause.PAY_USER_ID = this.ddlQueryPAY_USER_ID.KeyValue;
			}
			if (txtQueryAPPLY_MONEY.Text != string.Empty)
			{
				cause.APPLY_MONEY = decimal.Parse(this.txtQueryAPPLY_MONEY.Text);
			}
			if (txtQueryFINANCE_CYCLE.Text != string.Empty)
			{
				cause.FINANCE_CYCLE = string.Format("{0}%",this.txtQueryFINANCE_CYCLE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_DEPT_EXPENSE  o = (CauseObject_BGT_B_DEPT_EXPENSE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_EXPENSE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

