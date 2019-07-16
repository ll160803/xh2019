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
using System.IO;
using Ipedf.Common;

namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_CPN_HIS_DATA_1
    {
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_CPN_HIS_DATA_D cause = new CauseObject_BGT_B_CPN_HIS_DATA_D();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_HIS_DATA).ID;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = true;
            orderBy.OrderBy = "ITEM_ID_NAME";
            dataSource = BizLogicObject_BGT_B_CPN_HIS_DATA_D.Proxy.QueryFinanceExt(cause, null, orderBy);
            System.Collections.Generic.List<DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT> list = new System.Collections.Generic.List<DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT>();
            list.AddRange((DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT>(5));
            dataSource = list.ToArray();
            return dataSource;
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
            EntityObject_BGT_B_CPN_HIS_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_HIS_DATA;
            if (baseEntity.STATE == (decimal)数据状态.编辑中)
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = true;
            }
            else
            {
                btnScan.Visible = btnUpload.Visible = this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = false;
            }
        }
        public override void ShowEditState(object entity)
        {
            base.ShowEditState(entity);
            //2016-07-28
            if ((entity as EntityObject_BGT_B_CPN_HIS_DATA).STATE == (decimal)数据状态.编辑中)
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
                EntityObject_BGT_B_CPN_HIS_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_HIS_DATA;
                DataTable data = ImportUtil.ExcelToDataTable(filePath);
                List<string> colMsg = BizLogicObject_BGT_B_CPN_HIS_DATA.Proxy.CheckIncomeService(baseEntity, data);
                StringBuilder strResult = new StringBuilder();
                //ImportUtil.AppendCheckResultToExcel(filePath, colMsg);
                if (colMsg[0] == "Succeed")
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_HIS_DATA.Proxy.ImportIncomeService(baseEntity, data);
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
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}
