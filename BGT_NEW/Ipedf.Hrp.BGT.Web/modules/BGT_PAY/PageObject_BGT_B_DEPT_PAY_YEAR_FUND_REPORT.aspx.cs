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
using Ipedf.Hrp.Web.common;
using System.Text;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_REPORT : BaseWebPage
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
            CheckSession();
            //this.gvList.Attributes.Add("style", "word-break:keep-all;word-wrap:normal");
            this.gvList.Attributes.Add("style", "width: 100%; border-collapse: collapse;");
            if (!Page.IsPostBack)
            {
                SetPageState(PageState.List);
                ShowNotice(Ipedf.Web.Common.Message.PageWelcomeMsg);
                PrepareCause();
                ShowData();
            }
        }
        protected override void PrepareCause()
        {
            SetForeignKeyBinding(this.ddlQueryBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR");
            for (int i = this.ddlQueryBUDGET_YEAR.Items.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(this.ddlQueryBUDGET_YEAR.Items[i].Value))
                {
                    ddlQueryBUDGET_YEAR.Items.RemoveAt(i);
                }
            }
            if (!string.IsNullOrEmpty(Session["budget_year"].ToString()))
            {
                this.ddlQueryBUDGET_YEAR.SelectedValue = Session["budget_year"].ToString();
            }
            else
            {
                string Year1 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
                this.ddlQueryBUDGET_YEAR.SelectedValue = Year1;
            }
            
            //CauseObject_BGT_D_BUDGET_YEAR cause343 = new CauseObject_BGT_D_BUDGET_YEAR();
            //SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", cause343);
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME,this.ddlQueryBUDGET_YEAR.SelectedValue);
            if (depts.Length != 0)
            {
                this.ddlBUDGET_DEPT_ID.DataSource = depts;
                this.ddlBUDGET_DEPT_ID.DataTextField = "NAME";
                this.ddlBUDGET_DEPT_ID.DataValueField = "ID";
                this.ddlBUDGET_DEPT_ID.DataBind();
            }
            else
            {
                 Response.Write("<script>alert('当前年度不存在该科室数据')</script>");
                 return;
            }
            this.ddlBUDGET_DEPT_ID.SelectedIndex = 0;
            //this.ddlBUDGET_DEPT_ID.Enabled = false;
        }
        public void ddlInputBUDGET_YEAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        protected override void ShowData()
        {

            BindGridView();
        }
        protected override void OnClose(object sender, EventArgs e)
        {
            SetPageState(PageState.List);
            PrepareInput();
            ShowNotice(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override void OnQuery(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            dt.Dispose();
            dt = new DataTable();
            SetPageState(PageState.Query);
            ShowData();
            ShowNotice(Ipedf.Web.Common.Message.PageQuerySucceedMsg);
        }
        protected void gvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvList.PageIndex = e.NewPageIndex;
            ShowData();
        }
        protected void pager_PageIndex_Changed(object sender, EventArgs e)
        {
            BindGridView();
        }
        protected void BindGridView()
        {
            object parameter = PrepareQueryParameter();
            ComPager pager = (ComPager)FindControl("pager");
            BindDataGrid(parameter, pager == null ? 0 : pager.PageIndex, pager == null ? 10 : pager.PageSize);
        }
        protected virtual object PrepareQueryParameter()
        {
            //试用版本,平纹软件,版权所有
            CauseObject_BGT_D_BUDGET_ITEM cause = new CauseObject_BGT_D_BUDGET_ITEM();
            //if (!string.IsNullOrEmpty(txtQueryName.Text))
            //{
            //    cause.NAME = string.Format("%{0}%", txtQueryName.Text);
            //}
            //cause.BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue;
            return cause;
        }
        protected virtual string[] PrepareGridKeyNames()
        {
            return new string[] { "ID" };
        }
        protected virtual void BindDataGrid(object parameter, int pageIndex, int pageSize)
        {
            PagingParamter paging = new PagingParamter();
            paging.PageIndex = pageIndex;
            paging.PageSize = pageSize;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.OrderBy = "ID";
            orderBy.Asc = false;

            object dataSource = PrepareDataSource(parameter, paging, orderBy);
            if (dataSource != null)
            {
                ComPager pager = (ComPager)FindControl("pager");
                if (pager != null)
                {
                    pager.TotalRecords = paging.TotalRecords;
                }
                GridView gvList = FindControl("gvList") as GridView;
                if (gvList != null)
                {
                    CauseObject_BGT_D_BUDGET_DEPT cause1 = new CauseObject_BGT_D_BUDGET_DEPT();
                    StringBuilder sb = new StringBuilder();
                    sb.Append(" and BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = '" + ddlQueryBUDGET_YEAR.SelectedValue + "' ");
                    if (!string.IsNullOrEmpty(ddlBUDGET_DEPT_ID.SelectedValue))
                    {
                        sb.Append(" and BGT_D_BUDGET_DEPT.ID = '" + ddlBUDGET_DEPT_ID.SelectedValue + "' ");
                    }
                    cause1.SetCustomCondition(sb.ToString());
                    DisplayObject_BGT_D_BUDGET_DEPT[] ld = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(cause1);

                    CauseObject_BGT_D_BUDGET_DEPT cause2 = new CauseObject_BGT_D_BUDGET_DEPT();
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append(" and BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = '" + ddlQueryBUDGET_YEAR.SelectedValue + "' ");
                    if (!string.IsNullOrEmpty(ddlBUDGET_DEPT_ID.SelectedValue))
                    {
                        sb1.Append(" and BGT_D_BUDGET_DEPT.ID = '" + ddlBUDGET_DEPT_ID.SelectedValue + "' ");
                    }
                    else
                    {
                        return;
                    }
                    cause2.SetCustomCondition(sb1.ToString());
                    DisplayObject_BGT_D_BUDGET_DEPT[] ld1 = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(cause2);

                    gvList.PageSize = int.MaxValue;
                    gvList.PageIndex = pageIndex;
                   
                    DataColumnCollection columns = dt.Columns;
                    columns.Add("Code", typeof(System.String));
                    columns.Add("Name", typeof(System.String));
                    for (int i = 0; i < ld.Length; i++)
                    {
                        for (int k = 1; k <= 4; k++)
                        {
                            columns.Add(ld[i].ID+"Money"+k, typeof(System.String));
                        }
                    }
                    //BGT_D_BUDGET_ITEM
                    CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
                    cause.BUDGET_YEAR = this.ddlQueryBUDGET_YEAR.SelectedValue;
                    if(!string.IsNullOrEmpty(ddlBUDGET_DEPT_ID.SelectedValue))
                    {
                        cause.BUDGET_DEPT_ID = ddlBUDGET_DEPT_ID.SelectedValue;
                    }
                    cause.STATE = 2;
                    cause.SetCustomCondition(" order by code ");
                    DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] bdi = BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(cause);
                    for (int i = 0; i < bdi.Length; i++)
                    {
                        DataRow datarow = dt.NewRow();
                        datarow["Code"] = bdi[i].CODE;
                        datarow["Name"] = bdi[i].BGT_D_BUDGET_ITEM_ID_NAME;
                        datarow[bdi[i].BUDGET_DEPT_ID + "Money1"] = bdi[i].FUND_MONEY;
                        datarow[bdi[i].BUDGET_DEPT_ID + "Money2"] = bdi[i].CONTROL_MONEY;
                        datarow[bdi[i].BUDGET_DEPT_ID + "Money3"] = bdi[i].FUND_MONEY1;
                        datarow[bdi[i].BUDGET_DEPT_ID + "Money4"] = bdi[i].CONTROL_MONEY1;
                        dt.Rows.Add(datarow);
                    }
                    gvList.DataSource = dt;
                    //gvList.DataKeyNames = PrepareGridKeyNames();
                    this.gvList.Columns.Clear();
                    for (int i = 0; i < ld.Length * 4 + 2; i++)
                    {
                        System.Web.UI.WebControls.BoundField field;
                        //instantiation class
                        field = new BoundField();
                        if (i == 0)
                        {
                            field.DataField = "Code";
                            //field.ItemStyle.Width = 300;
                        }
                        else if (i == 1)
                        {
                            field.DataField = "Name";
                            //field.ItemStyle.Width = 300;
                        }
                        else
                        {
                            int j = (i-2) / 4;
                            int k = (i-1) % 4;
                            if (k == 0) 
                            {
                                k = 4;
                            }

                            field.DataField = ld[j].ID + "Money" + k;
                            //field.ItemStyle.Width = 200;
                            field.NullDisplayText = "-";
                        }
                        
                        this.gvList.Columns.Add(field);
                    }
                    gvList.DataBind();
                    
                }
            }

        }

        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            CauseObject_BGT_D_BUDGET_ITEM cause = (CauseObject_BGT_D_BUDGET_ITEM)parameter;
            object dataSource = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            dt.Dispose();
            dt = new DataTable();
            ShowData();
        }
        protected void gvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //如果传入的参数存在,则设置目标选中
                DisplayObject_BGT_D_BUDGET_ITEM entity = (DisplayObject_BGT_D_BUDGET_ITEM)e.Row.DataItem;
                ComGroupRadioButton select = (ComGroupRadioButton)e.Row.FindControl("cbSelect");
                select.Checked = Request["id"] == entity.ID.Trim();
                select.Attributes.Add("onclick", "window.parent.document.getElementById('objectvalue').value ='" + entity.ID + "," + entity.NAME + "';");
            }
        }
        
    }
}

