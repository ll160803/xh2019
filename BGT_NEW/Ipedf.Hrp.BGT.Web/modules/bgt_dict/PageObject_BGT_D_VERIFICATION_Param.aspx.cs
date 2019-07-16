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
	public partial class PageObject_BGT_D_VERIFICATION_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			CauseObject_COM_TYPE cause528 =  new CauseObject_COM_TYPE();
			cause528.PARENT_ID = "0013";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause528);
			CauseObject_COM_TYPE cause124 =  new CauseObject_COM_TYPE();
			cause124.PARENT_ID = "0014";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause124);
			CauseObject_COM_TYPE cause164 =  new CauseObject_COM_TYPE();
			cause164.PARENT_ID = "0015";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQuerySOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause164);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_VERIFICATION cause = new CauseObject_BGT_D_VERIFICATION();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_TYPE_ID.SelectedValue))
			{
				cause.ITEM_TYPE_ID = this.ddlQueryITEM_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIMPORT_TYPE_ID.SelectedValue))
			{
				cause.IMPORT_TYPE_ID = this.ddlQueryIMPORT_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQuerySOURCE_TYPE_ID.SelectedValue))
			{
				cause.SOURCE_TYPE_ID = this.ddlQuerySOURCE_TYPE_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_VERIFICATION  o = (CauseObject_BGT_D_VERIFICATION)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_VERIFICATION.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

