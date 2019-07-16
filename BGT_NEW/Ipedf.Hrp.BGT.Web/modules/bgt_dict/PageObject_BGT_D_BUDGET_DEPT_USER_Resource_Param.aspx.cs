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
	public partial class PageObject_BGT_D_BUDGET_DEPT_USER_Resource_Param : ComQueryParameterPage
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
			CauseObject_COM_USER cause = new CauseObject_COM_USER();
			
			//平台自动生成代码
			if (txtQueryACCOUNT.Text != string.Empty)
			{
				cause.ACCOUNT = string.Format("{0}%",this.txtQueryACCOUNT.Text);
			}
			if (txtQueryENTRY_COUNT.Text != string.Empty)
			{
				cause.ENTRY_COUNT = decimal.Parse(this.txtQueryENTRY_COUNT.Text);
			}
			if (txtQueryBEGINLAST_ENTRY_TIME.Text != string.Empty)
			{
				if (cause.LAST_ENTRY_TIME == null) 
					cause.LAST_ENTRY_TIME = new DateSpan();
					cause.LAST_ENTRY_TIME.Begin = DateTime.Parse(txtQueryBEGINLAST_ENTRY_TIME.Text);
			}
			if (txtQueryENDLAST_ENTRY_TIME.Text != string.Empty)
			{
				if (cause.LAST_ENTRY_TIME == null)
					cause.LAST_ENTRY_TIME = new DateSpan();
				cause.LAST_ENTRY_TIME.End = DateTime.Parse(txtQueryENDLAST_ENTRY_TIME.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_COM_USER  o = (CauseObject_COM_USER)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_USER_Resource.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

