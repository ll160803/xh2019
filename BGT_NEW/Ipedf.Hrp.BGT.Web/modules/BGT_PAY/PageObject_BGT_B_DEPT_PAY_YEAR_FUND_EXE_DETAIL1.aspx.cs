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
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1 : BaseWebPage
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
                 //Response.Write("<script>alert('当前年度不存在该科室数据')</script>");
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
                //SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME
                
                CauseObject_V_BGT_D_BUDGET_ITEM cause = new CauseObject_V_BGT_D_BUDGET_ITEM();
                string kk = System.Text.Encoding.Default.GetString(Convert.FromBase64String(Request.QueryString["Code"].ToString().Replace("%2B", "+")));
                kk = kk.Substring(0, kk.Length - 1);
                String[] b ;
                b  = kk.Split(',');
                StringBuilder sc = new StringBuilder();
                string endstr = "";
                for (int i = 0; i < b.Length; i++)  //根据数组的元素个数判断循环次数
                {
                    kk = "'" + b[i] + "'";  //在每个元素前后加上我们想要的格式，效果例如：
                    // " 'tt' "
                    if (i < b.Length - 1)  //根据数组元素的个数来判断应该加多少个逗号
                    {
                        kk += ",";
                    }
                    endstr += kk;
                }
                    //cause.BUDGET_YEAR = Request.QueryString["Year"].ToString();
                    //cause.DEPT_NAME = SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME;
                    //cause.SetCustomCondition(" order by budget_year_name desc,code ");
                    cause.SetCustomCondition(" and code is not null and BUDGET_YEAR_NAME = '" + Request.QueryString["Year"].ToString() + "' and CODE in (" + endstr + ")");
  
                DisplayObject_V_BGT_D_BUDGET_ITEM[] bdb = BizLogicObject_V_BGT_D_BUDGET_ITEM.Proxy.Query(cause);
                string BegDate = "";
                string EndDate = "";
                BegDate = !string.IsNullOrEmpty(Request.QueryString["BegDate"].ToString()) ? Request.QueryString["BegDate"] : Request.QueryString["Year"].ToString() + "0101";
                EndDate = !string.IsNullOrEmpty(Request.QueryString["EndDate"].ToString()) ? Request.QueryString["EndDate"].ToString() : Request.QueryString["Year"].ToString() + "1231";
                RfcNOC frc = new RfcNOC();
                dt = frc.GetZFI02_FM_IF_JFSZJY(BegDate, EndDate, bdb);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["BUDAT"].ToString() == "0000-00-00")
                    {
                        dr.BeginEdit();
                        dr["BUDAT"] = "";
                        dr.EndEdit();
                    }
                }
                //DataTable dt = new DataTable("cart");
                //DataColumn dc1 = new DataColumn("ZJFLB", Type.GetType("System.String"));
                //DataColumn dc2 = new DataColumn("BUDAT", Type.GetType("System.String"));
                //DataColumn dc3 = new DataColumn("AUFEX", Type.GetType("System.String"));
                //DataColumn dc4 = new DataColumn("ZLTEXT", Type.GetType("System.String"));
                //DataColumn dc5 = new DataColumn("BKTXT", Type.GetType("System.String"));
                //DataColumn dc6 = new DataColumn("DMBTR", Type.GetType("System.String"));
                //dt.Columns.Add(dc1);
                //dt.Columns.Add(dc2);
                //dt.Columns.Add(dc3);
                //dt.Columns.Add(dc4);
                //dt.Columns.Add(dc5);
                //dt.Columns.Add(dc6);
                //for (int i = 0; i < 100; i++)
                //{
                //    DataRow dr = dt.NewRow();
                //    dr["ZJFLB"] = "经费类别";
                //    if (i % 2 == 1)
                //    {
                //        dr["BUDAT"] = "2018-01-01";
                //    }
                //    else
                //    {
                //        dr["BUDAT"] = "2018-01-02";
                //    }
                //    dr["AUFEX"] = i.ToString();
                //    dr["ZLTEXT"] = "001";
                //    dr["BKTXT"] = "娃娃";
                //    dr["DMBTR"] = i.ToString();
                //    dt.Rows.Add(dr);
                //}

                
             
                if (gvList != null)
                {
                    
                    gvList.PageSize = int.MaxValue;
                    gvList.PageIndex = pageIndex;
                    gvList.DataSource = dt;
                    
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

        /// <summary>
        /// DataTable筛选，排序返回符合条件行组成的新DataTable或直接用DefaultView按条件返回
        /// eg:SortExprDataTable(dt,"Sex='男'","Time Desc",1)
        /// </summary>
        /// <param name="dt">传入的DataTable</param>
        /// <param name="strExpr">筛选条件</param>
        /// <param name="strSort">排序条件</param>
        /// <param name="mode">1,直接用DefaultView按条件返回,效率较高;2,DataTable筛选，排序返回符合条件行组成的新DataTable</param>
        public static DataTable SortDataTable(DataTable dt, string strExpr, string strSort, int mode)
        {
            switch (mode)
            {
                case 1:
                    //方法一　直接用DefaultView按条件返回
                    dt.DefaultView.RowFilter = strExpr;
                    dt.DefaultView.Sort = strSort;
                    return dt;
                case 2:
                    //方法二　DataTable筛选，排序返回符合条件行组成的新DataTable
                    DataTable dt1 = new DataTable();
                    DataRow[] GetRows = dt.Select(strExpr, strSort);
                    //复制DataTable dt结构不包含数据
                    dt1 = dt.Clone();
                    foreach (DataRow row in GetRows)
                    {
                        dt1.Rows.Add(row.ItemArray);
                    }
                    return dt1;
                default:
                    return dt;
            }

        }
    }
}

