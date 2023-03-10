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
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_BUDGET_DATA_CPN
    {
        protected override string PrepareResultOrderByColumn()
        {
            return "id";
        }
        protected override string[] PrepareDetailGridKeyNames()
        {
            return new string[] { "item_id" };
        }
        protected override void ShowDetailData()
        {
            base.ShowDetailData();
            BindDeptProcessData();
        }
        protected void BindDeptProcessData()
        {
            CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS p = new CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
            p.TEMPLET_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA).TEMPLET_ID;
            p.BUDGET_YEAR = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA).BUDGET_YEAR;
            OrderByParameter orderby = new OrderByParameter();
            orderby.OrderBy = "STATUS";
            orderby.Asc = true;
            DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] depts = BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.Proxy.Query(p, null, orderby);
            this.gvDeptList.DataSource = depts;
            this.gvDeptList.DataKeyNames = new string[] { "DEPT_ID" };
            this.gvDeptList.DataBind();
        }
        protected override void RegisterGridEvent()
        {
            base.RegisterGridEvent();
            this.gvDeptList.RowDataBound += new GridViewRowEventHandler(DeptRowDataBound);
        }
        void DeptRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS entity = (DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS)e.Row.DataItem;
                e.Row.Cells[1].Text = (e.Row.RowIndex + 1).ToString();
                e.Row.ForeColor = entity.STATUS == "已提交" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
        }
    }
}
