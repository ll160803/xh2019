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
	public partial class PageObject_BGT_B_BUDGET_PROJ_ADJUST_D_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_COM_TYPE cause162 =  new CauseObject_COM_TYPE();
			cause162.PARENT_ID = "0031";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryADJUST_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause162);
			this.ddlQueryITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D cause = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryADJUST_TYPE_ID.SelectedValue))
			{
				cause.ADJUST_TYPE_ID = this.ddlQueryADJUST_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (txtQueryADJUST_VALUE.Text != string.Empty)
			{
				cause.ADJUST_VALUE = decimal.Parse(this.txtQueryADJUST_VALUE.Text);
			}
			if (txtQueryITEM_BASE_VALUE.Text != string.Empty)
			{
				cause.ITEM_BASE_VALUE = decimal.Parse(this.txtQueryITEM_BASE_VALUE.Text);
			}
			if (txtQueryITEM_VALUE.Text != string.Empty)
			{
				cause.ITEM_VALUE = decimal.Parse(this.txtQueryITEM_VALUE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D  o = (CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_ADJUST_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

