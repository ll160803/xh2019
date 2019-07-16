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
using Ipedf.Hrp.BGT.Utility;
using System.Text;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR
    {
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_DEPT_PAY_YEAR_D cause = new CauseObject_BGT_B_DEPT_PAY_YEAR_D();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR).ID;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = true;
            orderBy.OrderBy = "ITEM_ID_NAME";
            dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAR_D.Proxy.QueryExt(cause, null, orderBy);
            System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT>();
            list.AddRange((DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT>(5));
            dataSource = list.ToArray();
            return dataSource;
        } 
        protected override void OnCustom(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Calculate(baseEntity);
                if (msg.Succeed)
                {
                    WebControlHelper.ShowAlert(this, "生成成功!");
                    ShowDetailData();
                }
                else
                {
                    WebControlHelper.ShowAlert(this, msg.Message);
                }
            }
            else
            {
                WebControlHelper.ShowAlert(this, "当前记录未保存,不能执行生成操作.");
            }
        }
        //public override void ShowSaveState()
        //{
        //    base.ShowSaveState();
        //    this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Visible;
        //}
        //public override void ShowSubmitState()
        //{
        //    base.ShowSubmitState();
        //    this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Visible;
        //}
        //public override void ShowAuditState()
        //{
        //    base.ShowAuditState();
        //    this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Visible;
        //}
        //public override void ShowUndoSubmitState()
        //{
        //    base.ShowUndoSubmitState();
        //    this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Visible;
        //}
        public override void ShowSubmitState()
        {
            base.ShowSubmitState();
            //科室年度预算类数据,提交后,统一流转到审查平衡环节进一步处理
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Audit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoAudit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Archive].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.Audit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoAudit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.Archive].Visible = false;
            this.btnCreateContent.Visible = false;
        }
        public override void ShowEditState(object entity)
        {
            base.ShowEditState(entity);
            //科室年度预算类数据,提交后,统一流转到审查平衡环节进一步处理
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Audit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoAudit].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Archive].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.Audit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoAudit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.Archive].Visible = false;


            //2016-07-28
            if ((entity as EntityObject_BGT_B_DEPT_PAY_YEAR).STATE == (decimal)Ipedf.Common.数据状态.编辑中)
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = true;
            }
            else
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = false;
            }
            //EntityObject_BGT_B_DEPT_PAY_YEAR sender = entity as EntityObject_BGT_B_DEPT_PAY_YEAR;
            //if (sender.STATE == (decimal)Ipedf.Common.数据状态.编辑中)
            //{
            //    CauseObject_BGT_D_BUDGET_PATTERN p = new CauseObject_BGT_D_BUDGET_PATTERN();
            //    p.BUDGET_YEAR = sender.BUDGET_YEAR;
            //    DisplayObject_BGT_D_BUDGET_PATTERN[] ps = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Query(p);
            //    if (ps.Length != 0)
            //    {
            //        if (ps[0].PAY_PATTERN_ID.Trim() == "00170002")//自下而上
            //        {
            //            this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
            //            this.command[Ipedf.Web.Control.ButtonType.Custom].Text = "自下而上-计算";
            //        }
            //        else if (ps[0].PAY_PATTERN_ID.Trim() == "00170001")//自上而下
            //        {
            //            this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
            //            this.command[Ipedf.Web.Control.ButtonType.Custom].Text = "自上而下-计算";
            //        }
            //    }
            //}
            //else
            //{
            //    this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = false;
            //    //this.command[Ipedf.Web.Control.ButtonType.Calculate].Visible = false;
            //}
        }
        //protected override void SetPageState(PageState pageState)
        //{
        //    base.SetPageState(pageState);
        //    if (pageState == PageState.Edit)
        //    {
        //        this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
        //        this.command[Ipedf.Web.Control.ButtonType.Custom].Text = "自下而上-计算";
        //    }
        //    else
        //    {
        //        this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = false;
        //    }
        //}

        //2016-07-28
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
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity.STATE == (decimal)Ipedf.Common.数据状态.编辑中)
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = true;
            }
            else
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = false;
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
                EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
                DataTable data = ImportUtil.ExcelToDataTable(filePath);
                List<string> colMsg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.CheckImportService(baseEntity, data);
                StringBuilder strResult = new StringBuilder();
                //ImportUtil.AppendCheckResultToExcel(filePath, colMsg);
                if (colMsg[0] == "Succeed")
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.ImportDataService(baseEntity, data);
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
    }
}
