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
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_1
    {
        protected decimal totalMoney;
        protected decimal controlMoney;
        protected override void OnResultGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[0].Text = "合计";
                e.Row.Cells[6].Text = string.Format("{0:F2}", totalMoney);      //金额 
                //e.Row.Cells[8].Text = string.Format("{0:F2}", controlMoney);    //控制数         
            }
        }
        protected  void OnSeSubmit(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_PAY_YEAR_FUND> submitDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_FUND>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_PAY_YEAR_FUND entity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();
                    entity.SetUpdate("STATE");
                    entity.ID = gvResultList.DataKeys[row.RowIndex].Value.ToString();
                    entity.STATE = 2;
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            submitDetailEntities.Add(entity);
                        }
                    }
                }
            }
            try
            {
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.BatchUpdate(submitDetailEntities.ToArray());
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {

            orderBy.OrderBy = "CREATE_TIME";
            //平台自动生成代码
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = (CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND)parameter;
            var dataSource = BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(cause, paging, orderBy);
            decimal[] values = BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.QuerySUM(cause);
            totalMoney = values[0];
            //controlMoney = values[1];
            return dataSource;
        }
        //2016-07-28
        public override void ShowEditState(object entity)
        {
            base.ShowEditState(entity);
            //2016-07-28
            if ((entity as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND).STATE == (decimal)Ipedf.Common.数据状态.编辑中)
            {
                btnScan.Visible = btnUpload.Visible = true;
            }
            else
            {
                btnScan.Visible = btnUpload.Visible = false;
            }
        }
        public override void ShowAddState()
        {
            base.ShowAddState();
            btnUpload.Visible = false;//新增模式时
            btnScan.Visible = false;
        }
        public override void ShowSaveState()
        {
            base.ShowSaveState();
            //2016-07-28           
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity.STATE == (decimal)Ipedf.Common.数据状态.编辑中)
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = true;
            }
            else
            {
                btnScan.Visible = btnUpload.Visible = false;
            }
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (!this.btnScan.HasFile)
            {
                ShowError("请选择需要上传的文件");
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
                EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
                DataTable data = ImportUtil.ExcelToDataTable(filePath);
                List<string> colMsg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.CheckService1(baseEntity, data);
                StringBuilder strResult = new StringBuilder();
                //ImportUtil.AppendCheckResultToExcel(filePath, colMsg);
                if (colMsg[0] == "Succeed")
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.ImportService1(baseEntity, data);
                    if (msg.Succeed)
                    {
                        strResult.Append("导入成功");
                    }
                    else
                    {
                        strResult.Append("导入失败");
                        throw new Exception(msg.Message);
                    }
                }
                else
                {
                    strResult.Append("导入失败，检测结果如下:");
                    for (int i = 1; i < colMsg.Count; i++)
                    {
                        strResult.Append("\\r\\n");
                        strResult.Append(colMsg[i]);
                    }
                }
                //  ClientScript.RegisterClientScriptBlock(Page.ClientScript.GetType(), "ImportResult", "<script>alert(" + strResult.ToString() + ") </script>");
                ShowEditState(baseEntity);
                ShowDetailData();
                SetPageState(PageState.Edit);
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

            FileStream file = new FileStream(System.Web.HttpContext.Current.Server.MapPath("~/Template/bgt/科室一般经费.xls"), FileMode.Open, FileAccess.Read);
            IWorkbook hssfworkbook = new HSSFWorkbook(file);
            ICellStyle style = hssfworkbook.CreateCellStyle();
            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");
            ISheet sheet2 = hssfworkbook.GetSheet("科室汇总");//填写经费主表合计
            string guid = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "科室一般经费预算";
            var SavePath = System.Web.HttpContext.Current.Server.MapPath("~/UploadFile/bgt/" + DateTime.Now.Day + "/");
            var loadPath = "UploadFile/bgt/" + DateTime.Now.Day + "/";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            string saveFileName = SavePath + guid + ".xls";
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.OrderBy = "CODE";
            orderBy.Asc = true;
            cause.FUND_TYPE_ID = "BGT_000101";
            cause.BUDGET_YEAR = Session["budget_year"].ToString();
            //没有对应的预算部门  会报错
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            cause.BUDGET_DEPT_ID = depts[0].ID;
            //cause.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
            var dataQuery = BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(cause, new PagingParamter() { PageIndex = 1, PageSize = int.MaxValue }, orderBy);



            int stratIndex_sheet2 = 0;//sheet2需要
            int RowIndex_sheet2 = stratIndex_sheet2 + 1;//excel输出到的当前行数


            ArrayList arrStyle_sheet2 = new ArrayList();//sheet2 样式
            int z = 1;
            foreach (var item in dataQuery)
            {

                #region 填写主表 sheet2 模板
                ExcelExport.GetCurrentCellStyle(sheet2, hssfworkbook, ref RowIndex_sheet2, stratIndex_sheet2 + 1, 14, arrStyle_sheet2, 0);
                HSSFRow dataRowColumn_2 = sheet2.GetRow(RowIndex_sheet2) as HSSFRow;
                int k_2 = 1;
                dataRowColumn_2.GetCell(k_2 - 1).SetCellValue(item.BUDGET_YEAR_NAME);//申请年度
                dataRowColumn_2.GetCell(k_2).SetCellValue(item.BUDGET_DEPT_ID_NAME);//预算科室
                dataRowColumn_2.GetCell(k_2 + 1).SetCellValue(item.DEPT_USER_ID_NAME);//科室负责人
                dataRowColumn_2.GetCell(k_2 + 2).SetCellValue(item.BGT_D_BUDGET_ITEM_ID_NAME);//经费名称
                dataRowColumn_2.GetCell(k_2 + 3).SetCellValue(item.CODE);//经费代码
                dataRowColumn_2.GetCell(k_2 + 4).SetCellValue(item.IS_PERFORMANCE_NAME);//是否为绩效考核项
                dataRowColumn_2.GetCell(k_2 + 5).SetCellValue(item.IS_FIXED_NAME);//是否为刚性预算
                dataRowColumn_2.GetCell(k_2 + 6).SetCellValue(item.FUND_MONEY.ToString());//一上申报金额
                dataRowColumn_2.GetCell(k_2 + 7).SetCellValue(item.CONTROL_MONEY.ToString());//一下调整金额
                dataRowColumn_2.GetCell(k_2 + 8).SetCellValue(item.ISAGREE == null ? "" : item.ISAGREE.ToString());//是否同意调整
                dataRowColumn_2.GetCell(k_2 + 9).SetCellValue(item.FUND_MONEY1.ToString());//二上申报金额
                dataRowColumn_2.GetCell(k_2 + 10).SetCellValue(item.CONTROL_MONEY1.ToString());//核定数
                dataRowColumn_2.GetCell(k_2 + 11).SetCellValue(item.STATE_NAME.ToString());//状态
                dataRowColumn_2.GetCell(k_2 + 12).SetCellValue(item.FUND_TYPE_ID_NAME);//经费类别
                //dataRowColumn_2.GetCell(k_2 + 7).SetCellValue(item.DECALRE_CAUSE);//一上申请说明
                RowIndex_sheet2 += 1;



                #endregion
                #region 填写 sheet1 模板
                ISheet sheet = hssfworkbook.CreateSheet(z.ToString() + "." + item.BGT_D_BUDGET_ITEM_ID_NAME);
                z++;
                ArrayList arrStyle = new ArrayList();

                SheetClone.CopySheet(hssfworkbook, sheet1, sheet, true,style);
                sheet.GetRow(0).GetCell(1).SetCellValue(item.BUDGET_DEPT_ID_NAME);//预算科室
                sheet.GetRow(0).GetCell(3).SetCellValue(item.DEPT_USER_ID_NAME);//科室负责人
                sheet.GetRow(0).GetCell(5).SetCellValue(item.BUDGET_YEAR_NAME);//科室负责人
                sheet.GetRow(1).GetCell(1).SetCellValue(item.BGT_D_BUDGET_ITEM_ID_NAME);//经费
                sheet.GetRow(1).GetCell(5).SetCellValue(item.FUND_TYPE_ID_NAME);//经费名称
                sheet.GetRow(2).GetCell(1).SetCellValue(item.FUND_MONEY.ToString());//一上经费金额
                sheet.GetRow(2).GetCell(3).SetCellValue(item.CONTROL_MONEY.ToString());//一下调整数
                sheet.GetRow(2).GetCell(5).SetCellValue(item.ISAGREE == null ? string.Empty : item.ISAGREE.ToString());//是否同意调整
                sheet.GetRow(3).GetCell(1).SetCellValue(item.FUND_MONEY.ToString());//二上经费金额
                sheet.GetRow(3).GetCell(3).SetCellValue(item.CONTROL_MONEY.ToString());//核定数
                sheet.GetRow(3).GetCell(5).SetCellValue(item.CODE == null ? " " : item.CODE.ToString());//经费编码
                sheet.GetRow(4).GetCell(1).SetCellValue(item.DECALRE_CAUSE == null ? " " : item.DECALRE_CAUSE.ToString());//一上说明
                sheet.GetRow(5).GetCell(1).SetCellValue(item.FINANCE_IDEA == null ? " " : item.FINANCE_IDEA.ToString());//一下说明
                sheet.GetRow(6).GetCell(1).SetCellValue(item.DECALRE_CAUSE1 == null ? " " : item.DECALRE_CAUSE1.ToString());//二上说明
                sheet.GetRow(7).GetCell(1).SetCellValue(item.FINANCE_IDEA1 == null ? " " : item.FINANCE_IDEA1.ToString());//二下说明

                int stratIndex = 9;//子列表开始行 
                int RowIndex = stratIndex + 1;//excel输出到的当前行数

                var dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND
                {
                    BASE_ID = item.ID
                }).ToList();

                
                for (int i = 0; i < dataSource.Count; i++)
                {
                    ExcelExport.GetCurrentCellStyle(sheet, hssfworkbook, ref RowIndex, stratIndex + 1, 8, arrStyle, 0);
                    HSSFRow dataRowColumn = sheet.GetRow(RowIndex) as HSSFRow;

                    int k = 1;
                    dataRowColumn.GetCell(k - 1).SetCellValue(dataSource[i].FUND_NAME);//支出明细
                    dataRowColumn.GetCell(k).SetCellValue(dataSource[i].MONEY.ToString());//一上申请金额
                    dataRowColumn.GetCell(k + 1).SetCellValue(dataSource[i].DECLARE_CAUSE);//依据说明
                    dataRowColumn.GetCell(k + 2).SetCellValue(dataSource[i].CONTROL_MONEY.ToString());//一下调整金额;
                    dataRowColumn.GetCell(k + 3).SetCellValue(dataSource[i].FINANCE_IDEA);//一下意见
                    dataRowColumn.GetCell(k + 4).SetCellValue(Convert.ToString(dataSource[i].MONEY1));//二上金额
                    dataRowColumn.GetCell(k + 5).SetCellValue(Convert.ToString(dataSource[i].CONTROL_MONEY1));//二下金额
                    dataRowColumn.GetCell(k + 6).SetCellValue(dataSource[i].FINANCE_IDEA1);//二下意见
                    RowIndex += 1;
                }
                sheet.ForceFormulaRecalculation = true;
                #endregion
            }

            #region  填写主表  合计  sheet2 模板

            if (dataQuery.Length > 0)
            {
                ExcelExport.GetCurrentCellStyle(sheet2, hssfworkbook, ref RowIndex_sheet2, stratIndex_sheet2 + 1, 14, arrStyle_sheet2, 0);
                HSSFRow dataRowColumn2 = sheet2.GetRow(RowIndex_sheet2) as HSSFRow;

                IFont f = hssfworkbook.CreateFont();
                f.Boldweight = (short)FontBoldWeight.Bold;
                style.CloneStyleFrom((ICellStyle)arrStyle_sheet2[0]);
                style.SetFont(f);
                dataRowColumn2.GetCell(0).CellStyle = style;
                IFont f2 = hssfworkbook.CreateFont();
                f2.Boldweight = (short)FontBoldWeight.Bold;
                style2.CloneStyleFrom((ICellStyle)arrStyle_sheet2[5]);
                style2.SetFont(f2);
                dataRowColumn2.GetCell(7).CellStyle = style2;
                dataRowColumn2.GetCell(8).CellStyle = style2;
                dataRowColumn2.GetCell(10).CellStyle = style2;
                dataRowColumn2.GetCell(11).CellStyle = style2;
                dataRowColumn2.GetCell(0).SetCellValue("科室合计:");

                dataRowColumn2.GetCell(7).SetCellValue(dataQuery.Sum(p => p.FUND_MONEY).ToString());
                dataRowColumn2.GetCell(8).SetCellValue(dataQuery.Sum(p => p.CONTROL_MONEY).ToString());
                dataRowColumn2.GetCell(10).SetCellValue(dataQuery.Sum(p => p.FUND_MONEY1).ToString());
                dataRowColumn2.GetCell(11).SetCellValue(dataQuery.Sum(p => p.CONTROL_MONEY1).ToString());
                RowIndex_sheet2 += 1;
            }
            #endregion

            hssfworkbook.RemoveSheetAt(0);
            using (FileStream fileWrite = new FileStream(saveFileName, FileMode.Create))
            {
                hssfworkbook.Write(fileWrite);
            }
            file.Dispose();
            Response.Write(string.Format("<script type='text/javascript'>window.open('{0}','_blank');</script>", string.Format("../../{1}{0}.xls", guid, loadPath)));
            // return string.Format("../../{1}{0}.xls", guid, SavePath);
        }
    }
}
