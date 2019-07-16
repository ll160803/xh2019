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
	public partial class PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause = new CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
			
			//平台自动生成代码
			if (txtQueryDEPT_NAME.Text != string.Empty)
			{
				cause.DEPT_NAME = string.Format("{0}%",this.txtQueryDEPT_NAME.Text);
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
			if (txtQueryDEPT_ID.Text != string.Empty)
			{
				cause.DEPT_ID = string.Format("{0}%",this.txtQueryDEPT_ID.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS  o = (CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

