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
	public partial class PageObject_BGT_D_BUDGET_YEAR_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetEnumReferenceBinding(this.ddlQuerySTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_YEAR cause = new CauseObject_BGT_D_BUDGET_YEAR();
			
			//平台自动生成代码
			if (txtQueryBUDGET_YEAR.Text != string.Empty)
			{
				cause.BUDGET_YEAR = string.Format("{0}%",this.txtQueryBUDGET_YEAR.Text);
			}
			if (!string.IsNullOrEmpty(ddlQuerySTATE.SelectedValue))
			{
				cause.STATE = decimal.Parse(this.ddlQuerySTATE.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_YEAR  o = (CauseObject_BGT_D_BUDGET_YEAR)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_YEAR.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

