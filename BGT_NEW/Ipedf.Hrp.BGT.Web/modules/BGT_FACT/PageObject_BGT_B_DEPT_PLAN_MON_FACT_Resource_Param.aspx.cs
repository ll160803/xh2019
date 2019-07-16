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
	public partial class PageObject_BGT_B_DEPT_PLAN_MON_FACT_Resource_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause747 =  new CauseObject_BGT_D_BUDGET_YEAR();
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause747);
			CauseObject_COM_TYPE cause258 =  new CauseObject_COM_TYPE();
			cause258.PARENT_ID = "0007";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause258);
			CauseObject_COM_TYPE cause355 =  new CauseObject_COM_TYPE();
			cause355.PARENT_ID = "0001";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryUNIT_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause355);
			CauseObject_COM_TYPE cause752 =  new CauseObject_COM_TYPE();
			cause752.PARENT_ID = "0022";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryITEM_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause752);
			CauseObject_COM_TYPE cause382 =  new CauseObject_COM_TYPE();
			cause382.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause382);
			CauseObject_COM_TYPE cause3821 =  new CauseObject_COM_TYPE();
			cause3821.PARENT_ID = "0008";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQuerySOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause3821);
			CauseObject_COM_TYPE cause158 =  new CauseObject_COM_TYPE();
			cause158.PARENT_ID = "0021";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause158);
			CauseObject_COM_TYPE cause576 =  new CauseObject_COM_TYPE();
			cause576.PARENT_ID = "0002";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryADVICE_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause576);
			CauseObject_COM_TYPE cause115 =  new CauseObject_COM_TYPE();
			cause115.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause115);
			SetEnumReferenceBinding(this.ddlQueryIS_DISABLE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_CALCULATE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_PLAN_ITEM cause = new CauseObject_BGT_D_PLAN_ITEM();
			
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
			if (!string.IsNullOrEmpty(ddlQueryITEM_TYPE_ID.SelectedValue))
			{
				cause.ITEM_TYPE_ID = this.ddlQueryITEM_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryUNIT_ID.SelectedValue))
			{
				cause.UNIT_ID = this.ddlQueryUNIT_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_CLASSIFY_ID.SelectedValue))
			{
				cause.ITEM_CLASSIFY_ID = this.ddlQueryITEM_CLASSIFY_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIMPORT_TYPE_ID.SelectedValue))
			{
				cause.IMPORT_TYPE_ID = this.ddlQueryIMPORT_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQuerySOURCE_TYPE_ID.SelectedValue))
			{
				cause.SOURCE_TYPE_ID = this.ddlQuerySOURCE_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryDATA_TYPE_ID.SelectedValue))
			{
				cause.DATA_TYPE_ID = this.ddlQueryDATA_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryADVICE_CLASSIFY_ID.SelectedValue))
			{
				cause.ADVICE_CLASSIFY_ID = this.ddlQueryADVICE_CLASSIFY_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryPREPARE_PATTERN_ID.SelectedValue))
			{
				cause.PREPARE_PATTERN_ID = this.ddlQueryPREPARE_PATTERN_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_DISABLE.SelectedValue))
			{
				cause.IS_DISABLE = decimal.Parse(this.ddlQueryIS_DISABLE.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_CALCULATE.SelectedValue))
			{
				cause.IS_CALCULATE = decimal.Parse(this.ddlQueryIS_CALCULATE.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_CARRYOVER.SelectedValue))
			{
				cause.IS_CARRYOVER = decimal.Parse(this.ddlQueryIS_CARRYOVER.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_PLAN_ITEM  o = (CauseObject_BGT_D_PLAN_ITEM)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_PLAN_MON_FACT_Resource.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

