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
	public partial class PageObject_BGT_B_ADJUST_EXE_Resource_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            this.ddlQueryBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlQueryBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlQueryBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = '" + this.ddlInputBUDGET_YEAR.SelectedValue + "' and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID);
            this.ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlQueryBGT_D_BUDGET_ITEM_ID.NameValue = "";
			SetEnumReferenceBinding(this.ddlQueryIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlQueryFUND_TYPE_ID.DataTable = "COM_TYPE";
			SetEnumReferenceBinding(this.ddlQueryIS_UPDATE_ITEM, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlQueryDEPT_USER_ID.DataTable = "COM_USER";
            string dept_name = SystemLogic.Proxy.CurrentUser.ACCOUNT;
    
            if (dept_name != "预算办公室")
            {
                this.ddlQueryBUDGET_DEPT_ID.Enabled = false;
                //ddlQueryBUDGET_DEPT_ID.KeyValue = SystemLogic.Proxy.CurrentUser.DEPART_ID;
                //ddlQueryBUDGET_DEPT_ID.NameValue = SystemLogic.Proxy.CurrentUser.ACCOUNT;
                DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
                if (depts.Length != 0)
                {
                    this.ddlQueryBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                    this.ddlQueryBUDGET_DEPT_ID.NameValue = depts[0].NAME;
                }
            }
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_FUND_EXE cause = new CauseObject_BGT_B_DEPT_FUND_EXE();
			
			//平台自动生成代码
            if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
			{
                cause.BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue))
			{
				cause.BGT_D_BUDGET_ITEM_ID = this.ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue;
			}
			if (txtQueryFREE_FIELD3.Text != string.Empty)
			{
				cause.FREE_FIELD3 = string.Format("{0}%",this.txtQueryFREE_FIELD3.Text);
			}
			if (txtQueryFREE_FIELD.Text != string.Empty)
			{
				cause.FREE_FIELD = string.Format("{0}%",this.txtQueryFREE_FIELD.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_FIXED.SelectedValue))
			{
				cause.IS_FIXED = decimal.Parse(this.ddlQueryIS_FIXED.SelectedValue);
			}
			if (txtQueryFREE_FIELD2.Text != string.Empty)
			{
				cause.FREE_FIELD2 = string.Format("{0}%",this.txtQueryFREE_FIELD2.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryFUND_TYPE_ID.KeyValue))
			{
				cause.FUND_TYPE_ID = this.ddlQueryFUND_TYPE_ID.KeyValue;
			}
			if (txtQueryREF_TAB_ID.Text != string.Empty)
			{
				cause.REF_TAB_ID = string.Format("{0}%",this.txtQueryREF_TAB_ID.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_UPDATE_ITEM.SelectedValue))
			{
				cause.IS_UPDATE_ITEM = decimal.Parse(this.ddlQueryIS_UPDATE_ITEM.SelectedValue);
			}
			if (txtQueryFUND_MONEY.Text != string.Empty)
			{
				cause.FUND_MONEY = decimal.Parse(this.txtQueryFUND_MONEY.Text);
			}
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_PERFORMANCE.SelectedValue))
			{
				cause.IS_PERFORMANCE = decimal.Parse(this.ddlQueryIS_PERFORMANCE.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_USER_ID.KeyValue))
			{
				cause.DEPT_USER_ID = this.ddlQueryDEPT_USER_ID.KeyValue;
			}
            string dept_name = SystemLogic.Proxy.CurrentUser.ACCOUNT;
            if (dept_name != "预算办公室")
            {
                DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(ddlInputBUDGET_YEAR.SelectedValue, SystemLogic.Proxy.CurrentUser.ACCOUNT);
                //DisplayObject_BGT_D_BUDGET_DEPT[] db = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.ACCOUNT, this.ddlInputBUDGET_YEAR.SelectedValue);
                if (depts.Length > 0)
                    cause.BUDGET_DEPT_ID = depts[0].ID;
            }
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_DEPT_FUND_EXE  o = (CauseObject_BGT_B_DEPT_FUND_EXE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE_Resource.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

