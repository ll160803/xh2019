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

using Ipedf.Web.Entity;

using Ipedf.Hrp.BGT.Utility;
using System.Text;
using System.Linq;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;

namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1
    {
        protected decimal totalMoney;
        protected decimal controlMoney;
        protected DataTable dt = new DataTable("AllVehSite");
        protected void OnResultGridRowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[0].Text = "合计";
                for( int i=2;i< e.Row.Cells.Count;i++)
                {
                    //e.Row.Cells[i].Text = string.Format("{0:F2}", ColumnSum(dt,i));
                    //e.Row.Cells[i].Text = ColumnSum(dt, i).ToString(); 
                }
                e.Row.Cells[5].Text = ColumnSum(dt, 5).ToString();
                //e.Row.Cells[6].Text = string.Format("{0:F2}", totalMoney);      //金额 
                //e.Row.Cells[8].Text = string.Format("{0:F2}", controlMoney);    //控制数         
            }
            
        }

        protected double ColumnSum(DataTable dt, int Column)
        {
            double d = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (string.IsNullOrEmpty(row[Column].ToString()))
                {
                    d += 0;
                }
                else
                {
                    d += Convert.ToDouble(row[Column].ToString());
                }
            }
            return d;
        }

        protected void ddlQueryBUDGET_YEAR_Changed(object sender, EventArgs e)
        {
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, this.ddlQueryBUDGET_YEAR.SelectedValue);
            if (depts.Length != 0)
            {
                this.ddlBUDGET_DEPT_ID.DataSource = depts;
                this.ddlBUDGET_DEPT_ID.DataTextField = "NAME";
                this.ddlBUDGET_DEPT_ID.DataValueField = "ID";
                this.ddlBUDGET_DEPT_ID.DataBind();
            }
            else
            {
                this.ddlBUDGET_DEPT_ID.DataSource = depts;
                this.ddlBUDGET_DEPT_ID.DataTextField = "NAME";
                this.ddlBUDGET_DEPT_ID.DataValueField = "ID";
                this.ddlBUDGET_DEPT_ID.DataBind();
                Response.Write("<script>alert('当前年度不存在该科室数据')</script>");
                return;
            }
            ShowData();
            
        }

        protected void gvResultList_RowCreated(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void btnOutExcel_Click(object sender, EventArgs e)
        {
            if (this.gvList.Rows.Count > 0)
            {
                //调用导出方法  
                ExportGridViewForUTF8(this.gvList, DateTime.Now.ToString() + ".xls");
            }
            else
            {
                Response.Write("<script>alert('没有数据可导出，请先查询数据!')</script>");
                return;
            }
        }

        /// <summary>  
        /// 重载，否则出现“类型“GridView”的控件“GridView1”必须放在具有 runat=server 的窗体标... ”的错误  
        /// </summary>  
        /// <param name="control"></param>  
        public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
        {
            //base.VerifyRenderingInServerForm(control);  
        }

        /// <summary>  
        /// 导出方法  
        /// </summary>  
        /// <param name="GridView"></param>  
        /// <param name="filename">保存的文件名称</param>  
        private void ExportGridViewForUTF8(GridView GridView, string filename)
        {
            GridView.BorderWidth = 1;

            switch (GridView.HeaderRow.RowType)
            {
                case DataControlRowType.Header:
                    GridView.HeaderRow.CssClass = "GridViewScrollHeader";
                    //总表头
                    TableCellCollection tcHeader = GridView.HeaderRow.Cells;
                    tcHeader.Clear();

                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[0].Text = "经费类别";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[1].Text = "凭证中的过帐日期";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[2].Text = "经费代码";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[3].Text = "经费代码名称";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[4].Text = "说明";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[5].Text = "按本位币计的金额";


                    break;
                case DataControlRowType.Footer:
                    break;
            }

            string attachment = "attachment; filename=" + filename;

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", attachment);

            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            Response.ContentType = "application/ms-excel";
            System.IO.StringWriter sw = new System.IO.StringWriter();

            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView.RenderControl(htw);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();

        }
    }
}
