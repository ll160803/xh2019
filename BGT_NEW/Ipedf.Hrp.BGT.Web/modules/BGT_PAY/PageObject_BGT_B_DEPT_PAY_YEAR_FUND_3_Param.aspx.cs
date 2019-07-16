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
	public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
            //SystemLogic.Proxy.CurrentUser.DEPART_ID
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlQueryBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
			SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR");
			this.ddlQueryBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			this.ddlQueryDEPT_USER_ID.DataTable = "COM_USER";
			this.ddlQueryFUND_TYPE_ID.DataTable = "COM_TYPE";


            this.ddlQueryFUND_TYPE_ID.Condition = "COM_TYPE.ID='BGT_00010201'";
            this.ddlQueryFUND_TYPE_ID.KeyValue = "BGT_00010202";
            this.ddlQueryFUND_TYPE_ID.NameValue = "资产购置预算";
			SetEnumReferenceBinding(this.ddlQuerySTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlQueryBUDGET_DEPT_ID.KeyValue = depts[0].NAME;
                this.ddlQueryBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlQueryBUDGET_DEPT_ID.ReadOnly = true;
            this.ddlQueryFUND_TYPE_ID.ReadOnly = true;
		}        
        protected override  object PrepareQueryParameter()
        {
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
			
			//平台自动生成代码
            if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
            {
                cause.BUDGET_DEPT_ID_NAME = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
            }
            else
            {
                cause.BUDGET_DEPT_ID_NAME = "默认科室";
            }
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_YEAR.SelectedValue))
			{
				cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue))
			{
				cause.BGT_D_BUDGET_ITEM_ID = this.ddlQueryBGT_D_BUDGET_ITEM_ID.KeyValue;
			}
			if (txtQueryITEM_NAME.Text != string.Empty)
			{
				cause.ITEM_NAME = string.Format("{0}%",this.txtQueryITEM_NAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_USER_ID.KeyValue))
			{
				cause.DEPT_USER_ID = this.ddlQueryDEPT_USER_ID.KeyValue;
			}
			if (txtQueryDECALRE_CAUSE.Text != string.Empty)
			{
				cause.DECALRE_CAUSE = string.Format("{0}%",this.txtQueryDECALRE_CAUSE.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryFUND_TYPE_ID.KeyValue))
			{
				cause.FUND_TYPE_ID = this.ddlQueryFUND_TYPE_ID.KeyValue;
			}
			if (txtQueryFUND_MONEY.Text != string.Empty)
			{
				cause.FUND_MONEY = decimal.Parse(this.txtQueryFUND_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQuerySTATE.SelectedValue))
			{
				cause.STATE = decimal.Parse(this.ddlQuerySTATE.SelectedValue);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND o = (CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

