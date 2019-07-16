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
using System.Text;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using Ipedf.Hrp.BGT.Utility;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_MACHINE1 : ComSimpleListPage
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
                    EntityObject_BGT_D_MACHINE entity = new EntityObject_BGT_D_MACHINE();
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
            CauseObject_BGT_D_MACHINE cause = (CauseObject_BGT_D_MACHINE)parameter;
			//平台自动生成代码
            orderBy.Asc = true;
            dataSource = BizLogicObject_BGT_D_MACHINE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override string PrepareOrderByColumn()
        {
            return "NO";
        }
      
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_MACHINE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE_Resource_PARAM.aspx", parameters);
            string scripts = WebControlHelper.GetOpenWindowScript(url, 500, 500);
            return scripts;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (!this.btnScan.HasFile)
            {
                Response.Write("<script>alert('请选择需要导入的文件!')</script>");
                return;
            }
            string fileName = Guid.NewGuid().ToString() + btnScan.FileName;
            string filePath = Server.MapPath("~/UploadFile/bgt/") + fileName;
            btnScan.SaveAs(filePath);

            ImportClick(filePath);

        }
        public void ImportClick(string filePath)
        {
            try
            {
                EntityObject_BGT_D_MACHINE baseEntity = new EntityObject_BGT_D_MACHINE();
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                string linkid = parameters["linkid"].ToString();
                baseEntity.BASEID = linkid;
                DataTable data = ImportUtil.ExcelToDataTable(filePath);
                StringBuilder strResult = new StringBuilder();
                 BizLogicMsg msg = BizLogicObject_BGT_D_MACHINE.Proxy.ImportService3(baseEntity, data);
                 if (msg.Succeed)
                 {
                     strResult.Append("导入成功");
                 }
                 else
                 {
                     strResult.Append("导入失败");
                     throw new Exception(msg.Message);
                 }
                 ShowData();
                //ImportUtil.AppendCheckResultToExcel(filePath, colMsg);
                
                //  ClientScript.RegisterClientScriptBlock(Page.ClientScript.GetType(), "ImportResult", "<script>alert(" + strResult.ToString() + ") </script>");
                //ShowEditState(baseEntity);
                //ShowDetailData();
                //SetPageState(PageState.Edit);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script language='javascript' type='text/javascript'>alert('" + strResult.ToString() + "');</script>");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }
        }
        protected override void OnExport(object sender, EventArgs e)
        {

            HSSFWorkbook hssfworkbookDown;
            string modelExlPath = System.Web.HttpContext.Current.Server.MapPath("~/Template/bgt/2018年新增资产（100万以上专用设备）-模板.xls");
            if (File.Exists(modelExlPath) == false)//模板不存在
            {
                return;
            }
            using (FileStream file = new FileStream(modelExlPath, FileMode.Open, FileAccess.Read))
            {
                hssfworkbookDown = new HSSFWorkbook(file);
                file.Close();
            }
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            string linkid = parameters["linkid"].ToString();
            CauseObject_BGT_D_MACHINE cause = new CauseObject_BGT_D_MACHINE();
            cause.BASEID = linkid;
            cause.SetCustomCondition(" order by no asc ");
            DisplayObject_BGT_D_MACHINE[] dataSource = BizLogicObject_BGT_D_MACHINE.Proxy.Query(cause);
            if (dataSource.Count() > 0)
            {
                WriterExcel(hssfworkbookDown, 0, dataSource);
                string guid = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string filename = guid + ".xls";
                string strFilePath = System.Web.HttpContext.Current.Server.MapPath("~/UploadFile/bgt/" + DateTime.Now.Day + "/");
                if (Directory.Exists(strFilePath) == false)
                {
                    Directory.CreateDirectory(strFilePath);
                }
                strFilePath = strFilePath + filename;
                FileStream files = new FileStream(strFilePath, FileMode.Create);
                hssfworkbookDown.Write(files);
                files.Close();
                if (File.Exists(strFilePath) == false)//附件生成失败
                {
                    return;
                }
                var loadPath = "UploadFile/bgt/" + DateTime.Now.Day + "/";
                Response.Write(string.Format("<script type='text/javascript'>window.open('{0}','_blank');</script>", string.Format("../../{1}{0}.xls", guid, loadPath)));
            }
            else
            {
                Response.Write("<script>alert('没有数据可导出，请先查询数据!')</script>");
                return;
            }
            
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
        /// WriterExcel
        /// </summary>
        /// <param name="hssfworkbookDown"></param>
        /// <param name="sheetIndex"></param>
        /// <param name="DT"></param>
        public static void WriterExcel(HSSFWorkbook hssfworkbookDown, int sheetIndex, DisplayObject_BGT_D_MACHINE[] DT)
        {
            try
            {
                #region 设置单元格样式
                //字体
                HSSFFont fontS9 = (HSSFFont)hssfworkbookDown.CreateFont();
                fontS9.FontName = "Arial";
                fontS9.FontHeightInPoints = 10;
                fontS9.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
                //表格
                ICellStyle TableS9 = (ICellStyle)hssfworkbookDown.CreateCellStyle();
                TableS9.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                TableS9.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                TableS9.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                TableS9.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                TableS9.WrapText = true;
                TableS9.SetFont(fontS9);
                #endregion

                HSSFSheet sheet = (HSSFSheet)hssfworkbookDown.GetSheetAt(sheetIndex);
                hssfworkbookDown.SetSheetHidden(sheetIndex, false);
                hssfworkbookDown.SetActiveSheet(sheetIndex);

                int n = 1;//因为模板有表头，所以从第2行开始写
                for (int j = 0; j < DT.Count(); j++)
                {
                    HSSFRow dataRow = (HSSFRow)sheet.CreateRow(j + n);
                    dataRow.CreateCell(0);
                    dataRow.Cells[0].SetCellValue(DT[j].NO != null ? DT[j].NO.ToString() : " ");
                    dataRow.CreateCell(1);
                    dataRow.Cells[1].SetCellValue(DT[j].BUY != null ? DT[j].BUY.ToString() : " ");
                    dataRow.CreateCell(2);
                    dataRow.Cells[2].SetCellValue(DT[j].PRICE != null ? DT[j].PRICE.ToString() : " ");
                    dataRow.CreateCell(3);
                    dataRow.Cells[3].SetCellValue(DT[j].NUM != null ? DT[j].NUM.ToString() : " ");
                    dataRow.CreateCell(4);
                    dataRow.Cells[4].SetCellValue(DT[j].PROJECT != null ? DT[j].PROJECT.ToString() : " ");
                    dataRow.CreateCell(5);
                    dataRow.Cells[5].SetCellValue(DT[j].INSTALL != null ? DT[j].INSTALL.ToString() : " ");
                    dataRow.CreateCell(6);
                    dataRow.Cells[6].SetCellValue(DT[j].MAN != null ? DT[j].MAN.ToString() : " ");
                    dataRow.CreateCell(7);
                    dataRow.Cells[7].SetCellValue(DT[j].CONDITION != null ? DT[j].CONDITION.ToString() : " ");
                    dataRow.CreateCell(8);
                    dataRow.Cells[8].SetCellValue(DT[j].FREQUENCY != null ? DT[j].FREQUENCY.ToString() : " ");
                    dataRow.CreateCell(9);
                    dataRow.Cells[9].SetCellValue(DT[j].SPEC != null ? DT[j].SPEC.ToString() : " ");
                    dataRow.CreateCell(10);
                    dataRow.Cells[10].SetCellValue(DT[j].NEED != null ? DT[j].NEED.ToString() : " ");

                    for (int i = 0; i <= 10; i++)//循环列，添加样式
                    {
                        dataRow.Cells[i].CellStyle = TableS9;
                    }
                }
                //设定第一行，第一列的单元格选中
                sheet.SetActiveCell(0, 0);
            }
            catch (Exception ex)
            {
                //WriteLog(ex.ToString());
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

