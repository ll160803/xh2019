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
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using System.Linq;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_B_CPN_INC_MEDICAL2_f2 : ComSimplePage
	{
        protected decimal totalMoney;
        protected decimal totalCount;
        protected decimal perMoney;

        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
		}
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_V_BGT_B_CPN_INC_MEDICAL cause = (CauseObject_V_BGT_B_CPN_INC_MEDICAL)parameter;
			dataSource = BizLogicObject_V_BGT_B_CPN_INC_MEDICAL.Proxy.Query(cause, paging, orderBy);
            decimal[] values = BizLogicObject_V_BGT_B_CPN_INC_MEDICAL.Proxy.QuerySUM(cause);
            if (values.Length > 0)
            {
                totalMoney = values[0];
                totalCount = values[1];
                perMoney = values[2];
            }
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
            //this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            //this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            //DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            //if (depts.Length != 0)
            //{
            //    this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
            //    this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            //}
            //this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            //this.ddlInputDEPT_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            //this.ddlInputDEPT_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
			this.txtInputMONEY.Text = "0.00";
			
			
			this.txtInputITEM_NAME.Text = string.Empty;
			
			this.txtInputPER_MONEY.Text = "0.00";
			
			this.txtInputPERSON_COUNT.Text = "0.00";
			
			this.txtInputDECALRE_CAUSE.Text = string.Empty;
            //hsc 附件上传
            upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
            upFiles.TableId = "";
            upFiles.ReadOnly = true;
			
        }
        protected override string PrepareOrderByColumn()
        {
            return "Create_Time";
        }
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_MEDICAL curObj = new EntityObject_BGT_B_CPN_INC_MEDICAL();
									//平台自动生成代码
                //if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                //    curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;

                curObj.COM_TYPE_ID = "BGT_00030002";//住院收入		
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
					
					if(!string.IsNullOrEmpty(txtInputPERSON_COUNT.Text))
					curObj.PERSON_COUNT = decimal.Parse(txtInputPERSON_COUNT.Text);
					else
					curObj.PERSON_COUNT = 0;
				
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                    if (curObj.PERSON_COUNT > 0)
                    {
                        curObj.PER_MONEY = curObj.MONEY / curObj.PERSON_COUNT;
                    }
				BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Save(curObj);
				ShowEditState(curObj);
                upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
                upFiles.TableId = curObj.ID;
                upFiles.ReadOnly = false;
                this.txtInputPER_MONEY.Text = curObj.PER_MONEY.ToString();
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_MEDICAL curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
									//平台自动生成代码
                //if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                //    curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;

                curObj.COM_TYPE_ID = "BGT_00030002";//住院收入
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
					
					
					
								
					if(!string.IsNullOrEmpty(txtInputPERSON_COUNT.Text))
					curObj.PERSON_COUNT = decimal.Parse(txtInputPERSON_COUNT.Text);
					else
					curObj.PERSON_COUNT = 0;
				
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                    if (curObj.PERSON_COUNT > 0)
                    {
                        curObj.PER_MONEY = curObj.MONEY / curObj.PERSON_COUNT;
                    }
				BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Update(curObj);
				ShowEditState(curObj);
                upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
                upFiles.TableId = curObj.ID;
                upFiles.ReadOnly = false;
                this.txtInputPER_MONEY.Text = curObj.PER_MONEY.ToString();
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_MEDICAL curObj = new EntityObject_BGT_B_CPN_INC_MEDICAL();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Get(curObj);
           
                SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), curObj.BUDGET_YEAR, "ID", "BUDGET_YEAR");


                //this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
                //this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
                //this.ddlInputBUDGET_DEPT_ID.KeyValue = curObj.BUDGET_DEPT_ID;
                //this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(curObj.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = curObj.BUDGET_DEPT_ID}).NAME;
                //this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				
				this.txtInputMONEY.Text = curObj.MONEY == null ? string.Empty:curObj.MONEY.ToString();
                //this.ddlInputDEPT_USER_ID.KeyField = "ID";
                //this.ddlInputDEPT_USER_ID.NameField = "NAME";
                //this.ddlInputDEPT_USER_ID.KeyValue = curObj.DEPT_USER_ID;
                //this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(curObj.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = curObj.DEPT_USER_ID }).NAME;
                //this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
				
				this.txtInputITEM_NAME.Text = curObj.ITEM_NAME == null ? string.Empty:curObj.ITEM_NAME.ToString();
				
				this.txtInputPER_MONEY.Text = curObj.PER_MONEY == null ? string.Empty:curObj.PER_MONEY.ToString();
				
				this.txtInputPERSON_COUNT.Text = curObj.PERSON_COUNT == null ? string.Empty:curObj.PERSON_COUNT.ToString();
				
				this.txtInputDECALRE_CAUSE.Text = curObj.DECALRE_CAUSE == null ? string.Empty:curObj.DECALRE_CAUSE.ToString();
                upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
                upFiles.TableId = curObj.ID;
                upFiles.ReadOnly = false;
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_V_BGT_B_CPN_INC_MEDICAL cause = new CauseObject_V_BGT_B_CPN_INC_MEDICAL();
            cause.COM_TYPE_ID = "BGT_00030002";
            cause.STATE = 2;
            //cause.CREATE_DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_B_CPN_INC_MEDICAL>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_INC_MEDICAL_PARAM2.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_INC_MEDICAL> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_MEDICAL>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_INC_MEDICAL entity = new EntityObject_BGT_B_CPN_INC_MEDICAL();
                    entity.ID = gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities.Add(entity);
                        }
                    }
                }
            }
            try
            {
                BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }

        protected override void OnExport(object sender, EventArgs e)
        {
            HSSFWorkbook hssfworkbookDown;
            string modelExlPath = System.Web.HttpContext.Current.Server.MapPath("~/Template/bgt/住院收入预算.xls");
            if (File.Exists(modelExlPath) == false)//模板不存在
            {
                return;
            }

            using (FileStream file = new FileStream(modelExlPath, FileMode.Open, FileAccess.Read))
            {
                hssfworkbookDown = new HSSFWorkbook(file);
                file.Close();
            }

            CauseObject_BGT_B_CPN_INC_MEDICAL cause = new CauseObject_BGT_B_CPN_INC_MEDICAL();
            cause.COM_TYPE_ID = "BGT_00030002";
            cause.STATE = 2;
            cause.SetCustomCondition(" order by Create_Time asc ");
            DisplayObject_BGT_B_CPN_INC_MEDICAL[] dataSource = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Query(cause);
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

        public static void WriterExcel(HSSFWorkbook hssfworkbookDown, int sheetIndex, DisplayObject_BGT_B_CPN_INC_MEDICAL[] DT)
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
                    dataRow.Cells[0].SetCellValue(DT[j].BUDGET_YEAR_NAME != null ? DT[j].BUDGET_YEAR_NAME.ToString() : " ");
                    dataRow.CreateCell(1);
                    dataRow.Cells[1].SetCellValue(DT[j].COM_TYPE_ID_NAME != null ? DT[j].COM_TYPE_ID_NAME.ToString() : " ");
                    dataRow.CreateCell(2);
                    dataRow.Cells[2].SetCellValue(DT[j].BUDGET_DEPT_ID_NAME != null ? DT[j].BUDGET_DEPT_ID_NAME.ToString() : " ");
                    dataRow.CreateCell(3);
                    dataRow.Cells[3].SetCellValue(DT[j].ITEM_NAME != null ? DT[j].ITEM_NAME.ToString() : " ");
                    dataRow.CreateCell(4);
                    dataRow.Cells[4].SetCellValue(DT[j].MONEY != null ? DT[j].MONEY.ToString() : " ");
                    dataRow.CreateCell(5);
                    dataRow.Cells[5].SetCellValue(DT[j].PER_MONEY != null ? DT[j].PER_MONEY.ToString() : " ");
                    dataRow.CreateCell(6);
                    dataRow.Cells[6].SetCellValue(DT[j].PERSON_COUNT != null ? DT[j].PERSON_COUNT.ToString() : " ");
                    dataRow.CreateCell(7);
                    dataRow.Cells[7].SetCellValue(DT[j].STATE_NAME != null ? DT[j].STATE_NAME.ToString() : " ");

                    for (int i = 0; i <= 7; i++)//循环列，添加样式
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

        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[0].Text = "合计";
                e.Row.Cells[5].Text = string.Format("{0:F2}", totalMoney);      //金额 
                e.Row.Cells[6].Text = string.Format("{0:F2}", perMoney);    //控制数       
                e.Row.Cells[7].Text = string.Format("{0:F2}", totalCount);    //控制数 
            }
        }
    }
}

