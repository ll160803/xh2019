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
	public partial class PageObject_BGT_B_CPN_INC_PERSONFUND_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
			this.ddlQueryDEPT_ID.DataTable = "COM_DEPART";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_CPN_INC_PERSONFUND cause = new CauseObject_BGT_B_CPN_INC_PERSONFUND();
			
			//平台自动生成代码
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_ID.KeyValue))
			{
				cause.DEPT_ID = this.ddlQueryDEPT_ID.KeyValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_CPN_INC_PERSONFUND  o = (CauseObject_BGT_B_CPN_INC_PERSONFUND)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_CPN_INC_PERSONFUND.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

