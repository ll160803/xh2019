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
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class selectdialog_budgetItem : BaseWebPage
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
            CauseObject_BGT_D_BUDGET_YEAR cause343 = new CauseObject_BGT_D_BUDGET_YEAR();
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", cause343);
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
            if (!string.IsNullOrEmpty(txtQueryName.Text))
            {
                cause.NAME = string.Format("%{0}%", txtQueryName.Text);
            }
            cause.BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue;
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
                ComGridView gvList = FindControl("gvList") as ComGridView;
                if (gvList != null)
                {
                    gvList.PageSize = pageSize;
                    gvList.PageIndex = pageIndex;
                    gvList.DataSource = WebControlHelper.PreparePagingDataSource(dataSource, pageSize, PrepareGridKeyNames().Length == 0 ? "ID" : PrepareGridKeyNames()[0]);
                    gvList.DataKeyNames = PrepareGridKeyNames();
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