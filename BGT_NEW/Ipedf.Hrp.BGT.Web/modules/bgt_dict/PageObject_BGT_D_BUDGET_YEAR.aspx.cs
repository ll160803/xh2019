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
namespace Ipedf.Web
{
	public partial class PageObject_BGT_D_BUDGET_YEAR : ComSimplePage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
		}
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(txtInputBUDGET_YEAR.Text))
                throw new Exception("预算年度不能为空");
          
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause = (CauseObject_BGT_D_BUDGET_YEAR)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputBUDGET_YEAR.Text = string.Empty;
            SetEnumReferenceBinding(this.ddlInputIS_AVAILABE, typeof(Ipedf.Hrp.BGT.Common.预算阶段));
            //默认不启用
            WebControlHelper.SetSelected(this.ddlInputIS_AVAILABE, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
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
				EntityObject_BGT_D_BUDGET_YEAR curObj = new EntityObject_BGT_D_BUDGET_YEAR();
									//平台自动生成代码
					curObj.BUDGET_YEAR = txtInputBUDGET_YEAR.Text;
                    if (!string.IsNullOrEmpty(ddlInputIS_AVAILABE.SelectedValue))
                        curObj.IS_AVAILABE = decimal.Parse(ddlInputIS_AVAILABE.SelectedValue);
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
									//平台自动生成代码
					curObj.BUDGET_YEAR = txtInputBUDGET_YEAR.Text;
                    if (!string.IsNullOrEmpty(ddlInputIS_AVAILABE.SelectedValue))
                        curObj.IS_AVAILABE = decimal.Parse(ddlInputIS_AVAILABE.SelectedValue);

                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Update(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_YEAR curObj = new EntityObject_BGT_D_BUDGET_YEAR();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(curObj);
				this.txtInputBUDGET_YEAR.Text = curObj.BUDGET_YEAR == null ? string.Empty:curObj.BUDGET_YEAR.ToString();
                this.txtInputBUDGET_YEAR.Enabled = false;
                SetEnumReferenceSelected(this.ddlInputIS_AVAILABE, typeof(Ipedf.Hrp.BGT.Common.预算阶段), curObj.IS_AVAILABE);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                #region 预算控制设置
                divControl.Visible = true;
                BindBtn(id);
                #endregion
                SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_YEAR cause = new CauseObject_BGT_D_BUDGET_YEAR();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_YEAR>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_YEAR obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_D_BUDGET_YEAR obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_YEAR obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_YEAR obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_YEAR obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_YEAR_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_YEAR> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_YEAR>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_YEAR entity = new EntityObject_BGT_D_BUDGET_YEAR();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                ShowData();
            }  
            
        }

	}
}

