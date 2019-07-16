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
using Ipedf.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Linq;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_B_ADJUST_EXE_Resource : ComSimpleListPage
	{
        public override bool OpLimitRequest
        {
            get
            {
                return false;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
            this.command[Ipedf.Web.Control.ButtonType.Custom].Text = Ipedf.Web.Common.ButtonText.Confirm;
            this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
            this.command[Ipedf.Web.Control.ButtonType.Query].Visible = true;
		}
		protected override void OnCustom(object sender, EventArgs e)
        {
            List<string> el = new List<string>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_FUND_EXE entity = new EntityObject_BGT_B_DEPT_FUND_EXE();
                    //var cause = new CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT
                    //{
                    //    BUDGET_YEAR = entity.BUDGET_YEAR,
                    //    BUDGET_DEPT_ID = entity.BUDGET_DEPT_ID,
                    //    BGT_D_BUDGET_ITEM_ID = entity.BGT_D_BUDGET_ITEM_ID

                    //};

                    //cause.SetCustomCondition(string.Format(" and V_BGT_ADJUST_FUND_MONEY_ECT.State =3 ORDER BY MODIFY_TIME DESC"));
                    //if (BizLogicObject_V_BGT_ADJUST_FUND_MONEY_ECT.Proxy.Query(cause).Count() > 0)
                    //{
                    //    DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] bb = BizLogicObject_V_BGT_ADJUST_FUND_MONEY_ECT.Proxy.Query(cause);
                    //    entity.CONTROL_MONEY1 = bb[0].CHANGE_MONEY;
                    //}
                    entity.ID = gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Checked)
                    {
                        el.Add(entity.ID);
                    }
                }
            }
            string parameter = JsonConvert.SerializeObject(el.ToArray());
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            parameters.Add("linksource", parameter);
            parameters.Remove("linkquery");
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url, "';self.close();"));           
        }
		protected override void PrepareCause()
		{
			
		}
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_FUND_EXE cause = (CauseObject_BGT_B_DEPT_FUND_EXE)parameter;
			//平台自动生成代码
			dataSource = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override string PrepareOrderByColumn()
        {
            return "Create_Time";
        }
      
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_FUND_EXE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE_Resource_PARAM.aspx", parameters);
            string scripts = WebControlHelper.GetOpenWindowScript(url, 500, 500);
            return scripts;
        }
        
	}
}

