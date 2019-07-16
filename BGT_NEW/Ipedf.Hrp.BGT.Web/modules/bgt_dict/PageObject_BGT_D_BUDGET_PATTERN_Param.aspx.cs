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
	public partial class PageObject_BGT_D_BUDGET_PATTERN_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			SetEnumReferenceBinding(this.ddlQueryIS_INTERNAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause377 =  new CauseObject_COM_TYPE();
			cause377.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPAY_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause377);
			CauseObject_COM_TYPE cause532 =  new CauseObject_COM_TYPE();
			cause532.PARENT_ID = "0025";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPAY_LEVEL_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause532);
			SetEnumReferenceBinding(this.ddlQueryIS_PAY_ITEM_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause462 =  new CauseObject_COM_TYPE();
			cause462.PARENT_ID = "0024";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryINCOME_LEVEL_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause462);
			CauseObject_COM_TYPE cause547 =  new CauseObject_COM_TYPE();
			cause547.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryINCOME_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause547);
			CauseObject_COM_TYPE cause858 =  new CauseObject_COM_TYPE();
			cause858.PARENT_ID = "0026";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPAY_PATTERN_ENTRY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause858);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_PATTERN cause = new CauseObject_BGT_D_BUDGET_PATTERN();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_INTERNAL.SelectedValue))
			{
				cause.IS_INTERNAL = decimal.Parse(this.ddlQueryIS_INTERNAL.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryPAY_PATTERN_ID.SelectedValue))
			{
				cause.PAY_PATTERN_ID = this.ddlQueryPAY_PATTERN_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryPAY_LEVEL_ID.SelectedValue))
			{
				cause.PAY_LEVEL_ID = this.ddlQueryPAY_LEVEL_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_PAY_ITEM_MERGE.SelectedValue))
			{
				cause.IS_PAY_ITEM_MERGE = decimal.Parse(this.ddlQueryIS_PAY_ITEM_MERGE.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryINCOME_LEVEL_ID.SelectedValue))
			{
				cause.INCOME_LEVEL_ID = this.ddlQueryINCOME_LEVEL_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryINCOME_PATTERN_ID.SelectedValue))
			{
				cause.INCOME_PATTERN_ID = this.ddlQueryINCOME_PATTERN_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryPAY_PATTERN_ENTRY_ID.SelectedValue))
			{
				cause.PAY_PATTERN_ENTRY_ID = this.ddlQueryPAY_PATTERN_ENTRY_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_PATTERN  o = (CauseObject_BGT_D_BUDGET_PATTERN)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_PATTERN.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

