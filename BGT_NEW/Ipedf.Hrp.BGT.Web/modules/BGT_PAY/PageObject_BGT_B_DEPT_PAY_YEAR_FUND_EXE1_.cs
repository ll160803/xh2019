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
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE1
    {
        protected decimal totalMoney;
        protected decimal controlMoney;
        protected DataTable dt = new DataTable("AllVehSite");
        protected void OnResultGridRowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[0].Text = "合计";
                for( int i=2;i< e.Row.Cells.Count-1;i++)
                {
                    //e.Row.Cells[i].Text = string.Format("{0:F2}", ColumnSum(dt,i));
                    //e.Row.Cells[i].Text = ColumnSum(dt, i).ToString(); 
                }
                //e.Row.Cells[1].Text = ColumnSum(dt, 3).ToString();
                //e.Row.Cells[2].Text = ColumnSum(dt, 4).ToString();
                //e.Row.Cells[3].Text = ColumnSum(dt, 5).ToString();
                //e.Row.Cells[4].Text = ColumnSum(dt, 6).ToString();
                //e.Row.Cells[5].Text = ColumnSum(dt, 7).ToString();
                //e.Row.Cells[6].Text = string.Format("{0:F2}", totalMoney);      //金额 
                //e.Row.Cells[8].Text = string.Format("{0:F2}", controlMoney);    //控制数         
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string url = "PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1.aspx?Year=" + ddlQueryBUDGET_YEAR.SelectedItem.Text + "&Dept=" + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(e.Row.Cells[1].Text)).Replace("+", "%2B") + "&Code=" + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(e.Row.Cells[2].Text)).Replace("+", "%2B")+"&BegDate="+txtQueryBEGINDELIVER_DATE.Text + "&EndDate="+txtQueryENDDELIVER_DATE.Text;
                //鼠标移动到每项时颜色交替效果
                e.Row.Attributes.Add("OnMouseOut", "this.style.backgroundColor='White';this.style.color='#003399'");
                e.Row.Attributes.Add("OnMouseOver", "this.style.backgroundColor='#6699FF';this.style.color='#8C4510'");

                //单击/双击 事件
                //e.Row.Attributes.Add("OnDblClick", "window.open('" + url + "','', 'alwaysRaised=1,dependent=1,resizable=0,scrollbars,width=500,height=300')");
                //e.Row.Attributes.Add("OnDblClick", "DbClickEvent('" + e.Row.Cells[1].Text + "')");


                //e.Row.Attributes.Add("OnClick", "ClickEvent('" + e.Row.Cells[1].Text + "')");
                //e.Row.Attributes.Add("OnClick", "window.open('" + url + "','', 'alwaysRaised=1,dependent=1,resizable=0,scrollbars=0,width=812,height=440')");
                CheckBox chk = (CheckBox)e.Row.FindControl("cbItem");
                e.Row.Attributes["onclick"] = chk.ClientID + ".checked=!" + chk.ClientID + ".checked;";
                //停止事件冒泡，防止选中状态混乱
                chk.Attributes["onclick"] = "window.event.cancelBubble = true;";
                //e.Row.Attributes.Add("OnKeyDown", "GridViewItemKeyDownEvent('" + e.Row.Cells[1].Text + "')");

                //设置悬浮鼠标指针形状为"小手"
                e.Row.Attributes["style"] = "Cursor:hand";
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
            ShowData();
            
        }

        protected void gvResultList_RowCreated(object sender, GridViewRowEventArgs e)
        {
            
        }
        protected void btnMX(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string Code = "";
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox CheckBox1 = (CheckBox)row.Cells[0].FindControl("cbItem");
                    if (CheckBox1.Checked)
                    {
                        Code += row.Cells[3].Text;
                        Code += ",";
                    }
                    
                }
            }
            if (Code != "")
            {
                string url = "PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1.aspx?Year=" + ddlQueryBUDGET_YEAR.SelectedItem.Text + "&Dept=&Code=" + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(Code)).Replace("+", "%2B") + "&BegDate=" + txtQueryBEGINDELIVER_DATE.Text + "&EndDate=" + txtQueryENDDELIVER_DATE.Text;
                ltScript.Text = "<script>window.open('" + url + "','', 'alwaysRaised=1,dependent=1,resizable=0,scrollbars=0,width=812,height=440');</script>";
            }
            else
            {
                Response.Write("<script>alert('请至少选中一条数据!')</script>");
                return;
            }
        }
        protected void btnOutExcel_Click(object sender, EventArgs e)
        {
            ltScript.Text = "";
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
                    tcHeader[0].Text = "部门代码";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[1].Text = "部门名称";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[2].Text = "经费代码";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[3].Text = "经费名称";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[4].Text = "年初预算";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[5].Text = "年中调整";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[6].Text = "调整后预算";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[7].Text = "已执行预算";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[8].Text = "剩余预算";
                    tcHeader.Add(new TableHeaderCell());
                    tcHeader[9].Text = "预算执行率";

                    
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
