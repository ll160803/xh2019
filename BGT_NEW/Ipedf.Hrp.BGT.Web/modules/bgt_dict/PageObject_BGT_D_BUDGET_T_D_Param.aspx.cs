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
	public partial class PageObject_BGT_D_BUDGET_T_D_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryITEM_ID.DataTable = "BGT_D_PLAN_ITEM";
			CauseObject_COM_TYPE cause853 =  new CauseObject_COM_TYPE();
			cause853.PARENT_ID = "0011";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryCALCULATE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause853);
			CauseObject_COM_TYPE cause846 =  new CauseObject_COM_TYPE();
			cause846.PARENT_ID = "0010";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPREPARE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause846);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T_D cause = new CauseObject_BGT_D_BUDGET_T_D();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryITEM_ID.KeyValue))
			{
				cause.ITEM_ID = this.ddlQueryITEM_ID.KeyValue;
			}
			if (txtQueryCONSULT.Text != string.Empty)
			{
				cause.CONSULT = string.Format("{0}%",this.txtQueryCONSULT.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryCALCULATE_METHOD_ID.SelectedValue))
			{
				cause.CALCULATE_METHOD_ID = this.ddlQueryCALCULATE_METHOD_ID.SelectedValue;
			}
			if (txtQueryCALCULATE_FORMULA.Text != string.Empty)
			{
				cause.CALCULATE_FORMULA = string.Format("{0}%",this.txtQueryCALCULATE_FORMULA.Text);
			}
			if (txtQueryCALCULATE_INDEX.Text != string.Empty)
			{
				cause.CALCULATE_INDEX = decimal.Parse(this.txtQueryCALCULATE_INDEX.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryPREPARE_METHOD_ID.SelectedValue))
			{
				cause.PREPARE_METHOD_ID = this.ddlQueryPREPARE_METHOD_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_T_D  o = (CauseObject_BGT_D_BUDGET_T_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_T_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

