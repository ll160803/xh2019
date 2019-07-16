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
    public partial class PageObject_BGT_B_BUDGET_DATA_2
    {
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_V_BGT_INC_BUDGET_DATA_EXT), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            //平台自动生成代码
            CauseObject_V_BGT_INC_BUDGET_DATA cause = new CauseObject_V_BGT_INC_BUDGET_DATA();
            if (ViewState["CUR_OBJ"] != null)
                cause.BUDGET_DATA_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA).ID;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = true;
            orderBy.OrderBy = "ITEM_ID_NAME";
            dataSource = BizLogicObject_V_BGT_INC_BUDGET_DATA.Proxy.QueryExt(cause, null, orderBy);
            System.Collections.Generic.List<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT> list = new System.Collections.Generic.List<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT>();
            list.AddRange((DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT>(5));
            dataSource = list.ToArray();
            return dataSource;
        } 
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
            this.gvDeptList.DataKeyNames = new string[] { "DEPT_ID"};
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
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Enabled = entity.STATUS == "已提交";//未提交的数据不能被勾选,供打回
                e.Row.Cells[1].Text = (e.Row.RowIndex + 1).ToString();
                e.Row.ForeColor = entity.STATUS == "已提交" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
        }
        protected void DeptBudgetDataUndoSubmit(object sender, EventArgs e)
        {
            List<DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS> undoDetailEntities = new List<DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS>();
            foreach (GridViewRow row in gvDeptList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS entity = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
                    string key = gvDeptList.DataKeys[row.RowIndex].Value.ToString();
                    string[] keyArray = key.Split(',');
                    entity.DEPT_ID = keyArray[0];
                    entity.BUDGET_YEAR = keyArray[1];
                    entity.TEMPLET_ID = keyArray[2];
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            undoDetailEntities.Add(entity);
                        }
                    }
                }
            }
            BizLogicMsg msg = BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.Proxy.UndoSubmitDeptIncomeBudgetData(undoDetailEntities.ToArray());
            if (msg.Succeed)
            {
                WebControlHelper.ShowAlert(this, "打回成功!");
                ShowDetailData();
            }
            else
            {
                WebControlHelper.ShowAlert(this, msg.Message);
            }
        }
    }
}
