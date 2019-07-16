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
    public partial class PageObject_BGT_D_BUDGET_T_3_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause263 =  new CauseObject_BGT_D_BUDGET_YEAR();
            //cause263.IS_VALID = 1;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlQueryBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause263);
			CauseObject_COM_TYPE cause454 =  new CauseObject_COM_TYPE();
			cause454.PARENT_ID = "0012";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause454);
			CauseObject_COM_TYPE cause782 =  new CauseObject_COM_TYPE();
			cause782.PARENT_ID = "0009";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryTEMPLET_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause782);
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T cause = new CauseObject_BGT_D_BUDGET_T();
			
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
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_CONTENTS_ID.SelectedValue))
			{
				cause.BUDGET_CONTENTS_ID = this.ddlQueryBUDGET_CONTENTS_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryTEMPLET_TYPE_ID.SelectedValue))
			{
				cause.TEMPLET_TYPE_ID = this.ddlQueryTEMPLET_TYPE_ID.SelectedValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_T  o = (CauseObject_BGT_D_BUDGET_T)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_T_3.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

