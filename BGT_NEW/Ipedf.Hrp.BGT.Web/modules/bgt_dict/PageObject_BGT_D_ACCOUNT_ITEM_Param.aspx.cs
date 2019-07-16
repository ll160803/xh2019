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
	public partial class PageObject_BGT_D_ACCOUNT_ITEM_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			CauseObject_COM_TYPE cause658 =  new CauseObject_COM_TYPE();
			cause658.PARENT_ID = "0018";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause658);
			CauseObject_COM_TYPE cause621 =  new CauseObject_COM_TYPE();
			cause621.PARENT_ID = "0006";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryDIRECTION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause621);
			CauseObject_COM_TYPE cause745 =  new CauseObject_COM_TYPE();
			cause745.PARENT_ID = "0016";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlQueryPROPERTY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause745);
			SetEnumReferenceBinding(this.ddlQueryIS_CASH, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlQueryIS_ASSSIST, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_ACCOUNT_ITEM cause = new CauseObject_BGT_D_ACCOUNT_ITEM();
			
			//平台自动生成代码
			if (txtQueryCODE.Text != string.Empty)
			{
				cause.CODE = string.Format("{0}%",this.txtQueryCODE.Text);
			}
			if (txtQueryNAME.Text != string.Empty)
			{
				cause.NAME = string.Format("{0}%",this.txtQueryNAME.Text);
			}
			if (txtQueryFULL_NAME.Text != string.Empty)
			{
				cause.FULL_NAME = string.Format("{0}%",this.txtQueryFULL_NAME.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryITEM_TYPE_ID.SelectedValue))
			{
				cause.ITEM_TYPE_ID = this.ddlQueryITEM_TYPE_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryDIRECTION_ID.SelectedValue))
			{
				cause.DIRECTION_ID = this.ddlQueryDIRECTION_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryPROPERTY_ID.SelectedValue))
			{
				cause.PROPERTY_ID = this.ddlQueryPROPERTY_ID.SelectedValue;
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_CASH.SelectedValue))
			{
				cause.IS_CASH = decimal.Parse(this.ddlQueryIS_CASH.SelectedValue);
			}
			if (!string.IsNullOrEmpty(ddlQueryIS_ASSSIST.SelectedValue))
			{
				cause.IS_ASSSIST = decimal.Parse(this.ddlQueryIS_ASSSIST.SelectedValue);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_ACCOUNT_ITEM  o = (CauseObject_BGT_D_ACCOUNT_ITEM)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_ACCOUNT_ITEM.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

