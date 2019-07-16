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
	public partial class PageObject_BGT_B_PAY_PERSON_D_Param : ComQueryParameterPage
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
			CauseObject_BGT_B_PAY_PERSON_D cause = new CauseObject_BGT_B_PAY_PERSON_D();
			
			//平台自动生成代码
			if (txtQueryFINANCE_IDEA.Text != string.Empty)
			{
				cause.FINANCE_IDEA = string.Format("{0}%",this.txtQueryFINANCE_IDEA.Text);
			}
			if (txtQueryDECLARE_CAUSE.Text != string.Empty)
			{
				cause.DECLARE_CAUSE = string.Format("{0}%",this.txtQueryDECLARE_CAUSE.Text);
			}
			if (txtQueryCONTROL_COUNT.Text != string.Empty)
			{
				cause.CONTROL_COUNT = decimal.Parse(this.txtQueryCONTROL_COUNT.Text);
			}
			if (txtQueryOTHERS.Text != string.Empty)
			{
				cause.OTHERS = string.Format("{0}%",this.txtQueryOTHERS.Text);
			}
			if (txtQueryNOWYEAR_COUNT.Text != string.Empty)
			{
				cause.NOWYEAR_COUNT = decimal.Parse(this.txtQueryNOWYEAR_COUNT.Text);
			}
			if (txtQueryPERSON_TYPE_ID.Text != string.Empty)
			{
				cause.PERSON_TYPE_ID = string.Format("{0}%",this.txtQueryPERSON_TYPE_ID.Text);
			}
			if (txtQueryBASE_ID.Text != string.Empty)
			{
				cause.BASE_ID = string.Format("{0}%",this.txtQueryBASE_ID.Text);
			}
			if (txtQueryLASTYEAR_COUNT.Text != string.Empty)
			{
				cause.LASTYEAR_COUNT = decimal.Parse(this.txtQueryLASTYEAR_COUNT.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_PAY_PERSON_D  o = (CauseObject_BGT_B_PAY_PERSON_D)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_PAY_PERSON_D.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

