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
	public partial class PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
			
			//平台自动生成代码
			if (txtQueryDECLARE_CAUSE.Text != string.Empty)
			{
				cause.DECLARE_CAUSE = string.Format("{0}%",this.txtQueryDECLARE_CAUSE.Text);
			}
			if (txtQueryASSET_ID.Text != string.Empty)
			{
				cause.ASSET_ID = string.Format("{0}%",this.txtQueryASSET_ID.Text);
			}
			if (txtQueryMONEY.Text != string.Empty)
			{
				cause.MONEY = decimal.Parse(this.txtQueryMONEY.Text);
			}
			if (txtQueryFUND_NAME.Text != string.Empty)
			{
				cause.FUND_NAME = string.Format("{0}%",this.txtQueryFUND_NAME.Text);
			}
			if (txtQueryAMOUNT.Text != string.Empty)
			{
				cause.AMOUNT = decimal.Parse(this.txtQueryAMOUNT.Text);
			}
			if (txtQueryPRICE.Text != string.Empty)
			{
				cause.PRICE = decimal.Parse(this.txtQueryPRICE.Text);
			}
			if (txtQueryBEGINCOMPLETE_TIME.Text != string.Empty)
			{
				if (cause.COMPLETE_TIME == null) 
					cause.COMPLETE_TIME = new DateSpan();
					cause.COMPLETE_TIME.Begin = DateTime.Parse(txtQueryBEGINCOMPLETE_TIME.Text);
			}
			if (txtQueryENDCOMPLETE_TIME.Text != string.Empty)
			{
				if (cause.COMPLETE_TIME == null)
					cause.COMPLETE_TIME = new DateSpan();
				cause.COMPLETE_TIME.End = DateTime.Parse(txtQueryENDCOMPLETE_TIME.Text);
			}
			if (txtQueryASSET_NAME.Text != string.Empty)
			{
				cause.ASSET_NAME = string.Format("{0}%",this.txtQueryASSET_NAME.Text);
			}
			if (txtQueryBUILDING_NAME.Text != string.Empty)
			{
				cause.BUILDING_NAME = string.Format("{0}%",this.txtQueryBUILDING_NAME.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND  o = (CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

