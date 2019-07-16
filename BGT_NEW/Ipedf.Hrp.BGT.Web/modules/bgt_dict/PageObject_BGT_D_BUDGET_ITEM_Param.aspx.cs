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
	public partial class PageObject_BGT_D_BUDGET_ITEM_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause343 =  new CauseObject_BGT_D_BUDGET_YEAR();
            //cause343.IS_VALID = 1;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause343);
            this.ddlQueryBUDGET_YEAR.SelectedValue = Session["budget_year"].ToString();
            this.ddlBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = '" + this.ddlQueryBUDGET_YEAR.SelectedValue + "'";
			CauseObject_COM_TYPE cause147 =  new CauseObject_COM_TYPE();
			cause147.PARENT_ID = "0018";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause147);
			CauseObject_COM_TYPE cause563 =  new CauseObject_COM_TYPE();
			cause563.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause563);
			CauseObject_COM_TYPE cause584 =  new CauseObject_COM_TYPE();
			cause584.PARENT_ID = "0021";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause584);
			CauseObject_COM_TYPE cause536 =  new CauseObject_COM_TYPE();
			cause536.PARENT_ID = "0020";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryUSAGE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause536);
			CauseObject_COM_TYPE cause871 =  new CauseObject_COM_TYPE();
			cause871.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause871);
            this.ddlComments.DataTable = "COM_TYPE";
            this.ddlComments.Condition = " COM_TYPE.PARENT_ID='BGTTYPE_001' ";
			SetEnumReferenceBinding(this.ddlQueryIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_FINAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_ITEM cause = new CauseObject_BGT_D_BUDGET_ITEM();
			
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
			if (!string.IsNullOrEmpty(ddlQueryIMPORT_TYPE_ID.SelectedValue))
			{
				cause.IMPORT_TYPE_ID = this.ddlQueryIMPORT_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryDATA_TYPE_ID.SelectedValue))
			{
				cause.DATA_TYPE_ID = this.ddlQueryDATA_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryUSAGE_ID.SelectedValue))
			{
				cause.USAGE_ID = this.ddlQueryUSAGE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryPREPARE_PATTERN_ID.SelectedValue))
			{
				cause.PREPARE_PATTERN_ID = this.ddlQueryPREPARE_PATTERN_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_CARRYOVER.SelectedValue))
			{
				cause.IS_CARRYOVER = decimal.Parse(this.ddlQueryIS_CARRYOVER.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_MERGE.SelectedValue))
			{
				cause.IS_MERGE = decimal.Parse(this.ddlQueryIS_MERGE.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_FINAL.SelectedValue))
			{
				cause.IS_END = decimal.Parse(this.ddlQueryIS_FINAL.SelectedValue);
			}
            if (!string.IsNullOrEmpty(ddlBUDGET_DEPT_ID.KeyValue))
            {
                cause.SetCustomCondition(" and BGT_D_BUDGET_DEPT.ID = '" + this.ddlBUDGET_DEPT_ID.KeyValue + "' ");
            }
            if (!string.IsNullOrEmpty(this.ddlComments.KeyValue))
            {
                cause.COMMENTS = this.ddlComments.KeyValue;
            }
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_ITEM  o = (CauseObject_BGT_D_BUDGET_ITEM)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_ITEM.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

