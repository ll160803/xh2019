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
	public partial class PageObject_BGT_D_BUDGET_DEPT_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			CauseObject_COM_TYPE cause681 =  new CauseObject_COM_TYPE();
			cause681.PARENT_ID = "0004";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryDEPT_PROPERTY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause681);
			CauseObject_COM_TYPE cause245 =  new CauseObject_COM_TYPE();
			cause245.PARENT_ID = "0003";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryDEPT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause245);
			SetEnumReferenceBinding(this.ddlQueryIS_FUNCTION, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_DEPT cause = new CauseObject_BGT_D_BUDGET_DEPT();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_PROPERTY_ID.SelectedValue))
			{
				cause.DEPT_PROPERTY_ID = this.ddlQueryDEPT_PROPERTY_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_TYPE_ID.SelectedValue))
			{
				cause.DEPT_TYPE_ID = this.ddlQueryDEPT_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_FUNCTION.SelectedValue))
			{
				cause.IS_FUNCTION = decimal.Parse(this.ddlQueryIS_FUNCTION.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_DEPT  o = (CauseObject_BGT_D_BUDGET_DEPT)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

