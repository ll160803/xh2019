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
	public partial class PageObject_BGT_B_DEPT_PLAN_YEAR_D_HIS_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryITEM_ID.DataTable = "BGT_D_PLAN_ITEM";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS cause = new CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (txtQueryITEM_VALUE.Text != string.Empty)
			{
				cause.ITEM_VALUE = decimal.Parse(this.txtQueryITEM_VALUE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS  o = (CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_PLAN_YEAR_D_HIS.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

