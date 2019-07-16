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
	public partial class PageObject_BGT_B_ADJUST_EXE_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.ddlQueryDEPT_USER_ID.DataTable = "COM_USER";
            string dept_name = SystemLogic.Proxy.CurrentUser.ACCOUNT;
            if (dept_name != "预算办公室")
            {
                this.ddlQueryBUDGET_DEPT_ID.Enabled = false;
                ddlQueryBUDGET_DEPT_ID.KeyValue = SystemLogic.Proxy.CurrentUser.DEPART_ID;
                ddlQueryBUDGET_DEPT_ID.NameValue = SystemLogic.Proxy.CurrentUser.ACCOUNT;
            }
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_ADJUST_EXE cause = new CauseObject_BGT_B_ADJUST_EXE();
			
			//平台自动生成代码
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
            if (!string.IsNullOrEmpty(this.ddlInputBUDGET_YEAR.SelectedValue))
			{
                cause.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
			}
			if (txtQueryEXE_TOTAL_MONEY.Text != string.Empty)
			{
				cause.EXE_TOTAL_MONEY = decimal.Parse(this.txtQueryEXE_TOTAL_MONEY.Text);
			}
			if (txtQueryTOTAL_MONEY.Text != string.Empty)
			{
				cause.TOTAL_MONEY = decimal.Parse(this.txtQueryTOTAL_MONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryDEPT_USER_ID.KeyValue))
			{
				cause.DEPT_USER_ID = this.ddlQueryDEPT_USER_ID.KeyValue;
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryCHANGE_CAUSE.Text != string.Empty)
			{
				cause.CHANGE_CAUSE = string.Format("{0}%",this.txtQueryCHANGE_CAUSE.Text);
			}
            string dept_name = SystemLogic.Proxy.CurrentUser.ACCOUNT;
            if (dept_name != "预算办公室")
            {
                cause.CREATE_DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            }
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_ADJUST_EXE  o = (CauseObject_BGT_B_ADJUST_EXE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

