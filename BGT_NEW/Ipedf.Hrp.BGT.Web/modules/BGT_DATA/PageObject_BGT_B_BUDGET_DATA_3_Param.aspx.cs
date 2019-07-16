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
    public partial class PageObject_BGT_B_BUDGET_DATA_3_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
			this.ddlQueryBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
            this.ddlQueryBUDGET_YEAR.NameField = "BUDGET_YEAR";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_DATA cause = new CauseObject_BGT_B_BUDGET_DATA();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryTEMPLET_ID.KeyValue))
			{
				cause.TEMPLET_ID = this.ddlQueryTEMPLET_ID.KeyValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_DATA  o = (CauseObject_BGT_B_BUDGET_DATA)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_DATA_3.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

