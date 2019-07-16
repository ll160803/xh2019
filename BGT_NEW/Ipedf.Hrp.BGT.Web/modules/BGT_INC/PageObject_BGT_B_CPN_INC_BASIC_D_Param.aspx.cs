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
	public partial class PageObject_BGT_B_CPN_INC_BASIC_D_Param : ComQueryParameterPage
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
			CauseObject_BGT_B_CPN_INC_BASIC_D cause = new CauseObject_BGT_B_CPN_INC_BASIC_D();
			
			//平台自动生成代码
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (txtQueryCONTROL_MONEY.Text != string.Empty)
			{
				cause.CONTROL_MONEY = decimal.Parse(this.txtQueryCONTROL_MONEY.Text);
			}
			if (txtQueryMONEY.Text != string.Empty)
			{
				cause.MONEY = decimal.Parse(this.txtQueryMONEY.Text);
			}
			if (txtQueryBASE_ID.Text != string.Empty)
			{
				cause.BASE_ID = string.Format("{0}%",this.txtQueryBASE_ID.Text);
			}
			if (txtQueryDECALRE_CAUSE.Text != string.Empty)
			{
				cause.DECALRE_CAUSE = string.Format("{0}%",this.txtQueryDECALRE_CAUSE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_CPN_INC_BASIC_D  o = (CauseObject_BGT_B_CPN_INC_BASIC_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_CPN_INC_BASIC_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

