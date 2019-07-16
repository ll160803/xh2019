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
using Ipedf.Hrp.BGT.Utility;
using System.Text;
using System.IO;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_ITEM
    {

        
        protected void lbAppend_Click(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_ITEM;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_ITEM;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("linkid", baseEntity.ID);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_ITEM_Resource.aspx", parameters);
            base.OpenWindow(url, 800, 360);
        }       
        protected override void DeserializeSourceObject(string key, string parameter)
        {
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.AppendByAccountItem(key, el);
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

                DataTable data = ImportUtil.ExcelToDataTable(filePath);
                List<string> colMsg = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.CheckImportService(data);
                StringBuilder strResult = new StringBuilder();
                //ImportUtil.AppendCheckResultToExcel(filePath, colMsg);
                if (colMsg[0] == "Succeed")
                {
                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.ImportDataService(ddlInputBUDGET_YEAR.SelectedValue, this.tvTree.SelectedValue, data);
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
                int index = this.tvTree.SelectedIndex;
                BindTreeView();
                this.tvTree.SelectedIndex = index;
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
