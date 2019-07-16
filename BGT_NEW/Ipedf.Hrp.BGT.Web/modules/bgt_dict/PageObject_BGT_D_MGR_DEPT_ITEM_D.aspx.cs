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
	public partial class PageObject_BGT_D_MGR_DEPT_ITEM_D : ComSimplePage
	{
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
			CauseObject_BGT_D_MGR_DEPT_ITEM_D cause = (CauseObject_BGT_D_MGR_DEPT_ITEM_D)parameter;
			dataSource = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.ddlInputBIZ_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlInputBIZ_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=2";
        }
        protected override string PrepareOrderByColumn()
        {
            return "Id";
        }
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_MGR_DEPT_ITEM_D curObj = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
									//平台自动生成代码
				BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_MGR_DEPT_ITEM_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
									//平台自动生成代码
				BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_MGR_DEPT_ITEM_D curObj = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Get(curObj);
				this.ddlInputBIZ_DEPT_ID.KeyField = "ID";
				this.ddlInputBIZ_DEPT_ID.NameField = "NAME";
				this.ddlInputBIZ_DEPT_ID.KeyValue = curObj.BIZ_DEPT_ID;
				this.ddlInputBIZ_DEPT_ID.NameValue = string.IsNullOrEmpty(curObj.BIZ_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = curObj.BIZ_DEPT_ID}).NAME;
				this.ddlInputBIZ_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputBIZ_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=2";
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_MGR_DEPT_ITEM_D cause = new CauseObject_BGT_D_MGR_DEPT_ITEM_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_MGR_DEPT_ITEM_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_D_MGR_DEPT_ITEM_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_MGR_DEPT_ITEM_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> deleteDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_MGR_DEPT_ITEM_D entity = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

