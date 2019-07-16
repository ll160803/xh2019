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
	public partial class PageObject_BGT_B_ADJUST_EXE_D_Param : ComQueryParameterPage
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
			CauseObject_BGT_B_ADJUST_EXE_D cause = new CauseObject_BGT_B_ADJUST_EXE_D();
			
			//平台自动生成代码
			if (txtQueryFUND_CODE.Text != string.Empty)
			{
				cause.FUND_CODE = string.Format("{0}%",this.txtQueryFUND_CODE.Text);
			}
			if (txtQueryCHANGE_CAUSE.Text != string.Empty)
			{
				cause.CHANGE_CAUSE = string.Format("{0}%",this.txtQueryCHANGE_CAUSE.Text);
			}
			if (txtQueryEXE_MONEY.Text != string.Empty)
			{
				cause.EXE_MONEY = decimal.Parse(this.txtQueryEXE_MONEY.Text);
			}
			if (txtQueryREF_TAB_ID.Text != string.Empty)
			{
				cause.REF_TAB_ID = string.Format("{0}%",this.txtQueryREF_TAB_ID.Text);
			}
			if (txtQueryCHANGE_MONEY.Text != string.Empty)
			{
				cause.CHANGE_MONEY = decimal.Parse(this.txtQueryCHANGE_MONEY.Text);
			}
			if (txtQueryBASE_ID.Text != string.Empty)
			{
				cause.BASE_ID = string.Format("{0}%",this.txtQueryBASE_ID.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_ADJUST_EXE_D  o = (CauseObject_BGT_B_ADJUST_EXE_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

