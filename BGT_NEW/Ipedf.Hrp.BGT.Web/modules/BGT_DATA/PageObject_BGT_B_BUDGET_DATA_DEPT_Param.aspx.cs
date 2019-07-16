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
	public partial class PageObject_BGT_B_BUDGET_DATA_DEPT_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_DATA_DEPT cause = new CauseObject_BGT_B_BUDGET_DATA_DEPT();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (txtQueryBEGINCREATE_DATE.Text != string.Empty)
			{
				if (cause.CREATE_DATE == null) 
					cause.CREATE_DATE = new DateSpan();
					cause.CREATE_DATE.Begin = DateTime.Parse(txtQueryBEGINCREATE_DATE.Text);
			}
			if (txtQueryENDCREATE_DATE.Text != string.Empty)
			{
				if (cause.CREATE_DATE == null)
					cause.CREATE_DATE = new DateSpan();
				cause.CREATE_DATE.End = DateTime.Parse(txtQueryENDCREATE_DATE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_DATA_DEPT  o = (CauseObject_BGT_B_BUDGET_DATA_DEPT)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_DATA_DEPT.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

