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
	public partial class PageObject_BGT_B_BUDGET_CONTROL_D : ComSimplePage
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
			CauseObject_BGT_B_BUDGET_CONTROL_D cause = (CauseObject_BGT_B_BUDGET_CONTROL_D)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			CauseObject_COM_TYPE cause831 =  new CauseObject_COM_TYPE();
			cause831.PARENT_ID = "0201";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause831);
			this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			this.ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.IS_END=1";
			CauseObject_COM_TYPE cause353 =  new CauseObject_COM_TYPE();
			cause353.PARENT_ID = "0202";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputEDITION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause353);
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
				EntityObject_BGT_B_BUDGET_CONTROL_D curObj = new EntityObject_BGT_B_BUDGET_CONTROL_D();
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										curObj.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputEDITION_ID.SelectedValue))
										curObj.EDITION_ID = ddlInputEDITION_ID.SelectedValue;
				BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_CONTROL_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										curObj.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputEDITION_ID.SelectedValue))
										curObj.EDITION_ID = ddlInputEDITION_ID.SelectedValue;
				BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_CONTROL_D curObj = new EntityObject_BGT_B_BUDGET_CONTROL_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Get(curObj);
				CauseObject_COM_TYPE cause774 =  new CauseObject_COM_TYPE();
				cause774.PARENT_ID = "0201";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputTYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.TYPE_ID,"ID","NAME",cause774);
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = curObj.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ITEM_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM(){ID = curObj.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
				this.ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.IS_END=1";
				CauseObject_COM_TYPE cause164 =  new CauseObject_COM_TYPE();
				cause164.PARENT_ID = "0202";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputEDITION_ID, typeof( BizLogicObject_COM_TYPE), curObj.EDITION_ID,"ID","NAME",cause164);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_CONTROL_D cause = new CauseObject_BGT_B_BUDGET_CONTROL_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_CONTROL_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_BUDGET_CONTROL_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_CONTROL_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_CONTROL_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_CONTROL_D entity = new EntityObject_BGT_B_BUDGET_CONTROL_D();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

