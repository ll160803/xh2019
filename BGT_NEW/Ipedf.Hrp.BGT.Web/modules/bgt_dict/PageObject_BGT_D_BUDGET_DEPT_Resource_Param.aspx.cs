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
	public partial class PageObject_BGT_D_BUDGET_DEPT_Resource_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			SetEnumReferenceBinding(this.ddlQueryTYPE, Type.GetType( "Ipedf.Common.组织类型, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_COM_DEPART cause = new CauseObject_COM_DEPART();
			
			//平台自动生成代码
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryTYPE.SelectedValue))
			{
				cause.TYPE = decimal.Parse(this.ddlQueryTYPE.SelectedValue);
			}
			if (txtQueryFAX.Text != string.Empty)
			{
				cause.FAX = string.Format("{0}%",this.txtQueryFAX.Text);
			}
			if (txtQueryPHONE.Text != string.Empty)
			{
				cause.PHONE = string.Format("{0}%",this.txtQueryPHONE.Text);
			}
			if (txtQueryBEGINDROP_DATE.Text != string.Empty)
			{
				if (cause.DROP_DATE == null) 
					cause.DROP_DATE = new DateSpan();
					cause.DROP_DATE.Begin = DateTime.Parse(txtQueryBEGINDROP_DATE.Text);
			}
			if (txtQueryENDDROP_DATE.Text != string.Empty)
			{
				if (cause.DROP_DATE == null)
					cause.DROP_DATE = new DateSpan();
				cause.DROP_DATE.End = DateTime.Parse(txtQueryENDDROP_DATE.Text);
			}
			if (txtQueryBEGINCREATE_DATE.Text != string.Empty)
			{
				if (cause.CREATE_DATE == null) 
					cause.CREATE_DATE = new DateSpan();
					cause.CREATE_DATE.Begin = DateTime.Parse(txtQueryBEGINCREATE_DATE.Text);
			}
			if (txtQueryENDCREATE_DATE.Text != string.Empty)
			{
				if (cause.CREATE_DATE == null)
					cause.CREATE_DATE = new DateSpan();
				cause.CREATE_DATE.End = DateTime.Parse(txtQueryENDCREATE_DATE.Text);
			}
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryADDRESS.Text != string.Empty)
			{
				cause.ADDRESS = string.Format("{0}%",this.txtQueryADDRESS.Text);
			}
			if (txtQueryPOST_CODE.Text != string.Empty)
			{
				cause.POST_CODE = string.Format("{0}%",this.txtQueryPOST_CODE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_COM_DEPART  o = (CauseObject_COM_DEPART)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_Resource.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

