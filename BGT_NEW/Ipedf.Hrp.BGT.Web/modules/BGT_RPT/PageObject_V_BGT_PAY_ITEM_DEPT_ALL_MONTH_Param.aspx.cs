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
	public partial class PageObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
			this.ddlQueryITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH cause = new CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH();
			
			//平台自动生成代码
			if (txtQueryM9TH.Text != string.Empty)
			{
				cause.M9TH = decimal.Parse(this.txtQueryM9TH.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.KeyValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.KeyValue;
			}
			if (txtQueryM4TH.Text != string.Empty)
			{
				cause.M4TH = decimal.Parse(this.txtQueryM4TH.Text);
			}
			if (txtQueryM7TH.Text != string.Empty)
			{
				cause.M7TH = decimal.Parse(this.txtQueryM7TH.Text);
			}
			if (txtQueryM8TH.Text != string.Empty)
			{
				cause.M8TH = decimal.Parse(this.txtQueryM8TH.Text);
			}
			if (txtQueryM6TH.Text != string.Empty)
			{
				cause.M6TH = decimal.Parse(this.txtQueryM6TH.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (txtQueryM10TH.Text != string.Empty)
			{
				cause.M10TH = decimal.Parse(this.txtQueryM10TH.Text);
			}
			if (txtQueryM11TH.Text != string.Empty)
			{
				cause.M11TH = decimal.Parse(this.txtQueryM11TH.Text);
			}
			if (txtQueryM5TH.Text != string.Empty)
			{
				cause.M5TH = decimal.Parse(this.txtQueryM5TH.Text);
			}
			if (txtQueryM1TH.Text != string.Empty)
			{
				cause.M1TH = decimal.Parse(this.txtQueryM1TH.Text);
			}
			if (txtQueryM3TH.Text != string.Empty)
			{
				cause.M3TH = decimal.Parse(this.txtQueryM3TH.Text);
			}
			if (txtQueryMALL.Text != string.Empty)
			{
				cause.MALL = decimal.Parse(this.txtQueryMALL.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (txtQueryM12TH.Text != string.Empty)
			{
				cause.M12TH = decimal.Parse(this.txtQueryM12TH.Text);
			}
			if (txtQueryM2TH.Text != string.Empty)
			{
				cause.M2TH = decimal.Parse(this.txtQueryM2TH.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH  o = (CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

