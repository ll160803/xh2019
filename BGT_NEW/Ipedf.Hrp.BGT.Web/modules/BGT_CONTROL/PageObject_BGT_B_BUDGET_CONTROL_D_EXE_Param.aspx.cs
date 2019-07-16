﻿using System;
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
	public partial class PageObject_BGT_B_BUDGET_CONTROL_D_EXE_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//平台自动生成代码
			this.ddlQueryBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause = new CauseObject_BGT_B_BUDGET_CONTROL_D_EXE();
			
			//平台自动生成代码
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
			if (txtQueryMONEY.Text != string.Empty)
			{
				cause.MONEY = decimal.Parse(this.txtQueryMONEY.Text);
			}
			if (!string.IsNullOrEmpty(ddlQueryBUDGET_DEPT_ID.KeyValue))
			{
				cause.BUDGET_DEPT_ID = this.ddlQueryBUDGET_DEPT_ID.KeyValue;
			}
			if (txtQueryFINANCE_CYCLE.Text != string.Empty)
			{
				cause.FINANCE_CYCLE = string.Format("{0}%",this.txtQueryFINANCE_CYCLE.Text);
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_B_BUDGET_CONTROL_D_EXE  o = (CauseObject_BGT_B_BUDGET_CONTROL_D_EXE)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_CONTROL_D_EXE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

