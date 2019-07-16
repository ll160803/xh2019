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
	public partial class PageObject_BGT_B_BUDGET_PROJ_D : ComSimplePage
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
			CauseObject_BGT_B_BUDGET_PROJ_D cause = (CauseObject_BGT_B_BUDGET_PROJ_D)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputNAME.Text = string.Empty;
			this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			SetEnumReferenceBinding(this.ddlInputIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.txtInputCODE.Text = string.Empty;
			this.txtInputBUDEGT_MONEY.Text = "0.00";
			this.txtInputEXECUTED_MONEY.Text = "0.00";
			this.txtInputAPPLY_MONEY.Text = "0.00";
			this.txtInputAPPLIED_MONEY.Text = "0.00";
			CauseObject_COM_TYPE cause568 =  new CauseObject_COM_TYPE();
			cause568.PARENT_ID = "0030";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputSOURCE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause568);
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
				EntityObject_BGT_B_BUDGET_PROJ_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_D();
									//平台自动生成代码
					curObj.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC.SelectedValue))
										curObj.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC.SelectedValue);
					curObj.CODE = txtInputCODE.Text;
					if(!string.IsNullOrEmpty(txtInputBUDEGT_MONEY.Text))
					curObj.BUDEGT_MONEY = decimal.Parse(txtInputBUDEGT_MONEY.Text);
					else
					curObj.BUDEGT_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
					curObj.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
					else
					curObj.EXECUTED_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					curObj.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					curObj.APPLY_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLIED_MONEY.Text))
					curObj.APPLIED_MONEY = decimal.Parse(txtInputAPPLIED_MONEY.Text);
					else
					curObj.APPLIED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_ID.SelectedValue))
										curObj.SOURCE_ID = ddlInputSOURCE_ID.SelectedValue;
				BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
									//平台自动生成代码
					curObj.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC.SelectedValue))
										curObj.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC.SelectedValue);
					curObj.CODE = txtInputCODE.Text;
					if(!string.IsNullOrEmpty(txtInputBUDEGT_MONEY.Text))
					curObj.BUDEGT_MONEY = decimal.Parse(txtInputBUDEGT_MONEY.Text);
					else
					curObj.BUDEGT_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
					curObj.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
					else
					curObj.EXECUTED_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					curObj.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					curObj.APPLY_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLIED_MONEY.Text))
					curObj.APPLIED_MONEY = decimal.Parse(txtInputAPPLIED_MONEY.Text);
					else
					curObj.APPLIED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_ID.SelectedValue))
										curObj.SOURCE_ID = ddlInputSOURCE_ID.SelectedValue;
				BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Get(curObj);
				this.txtInputNAME.Text = curObj.NAME == null ? string.Empty:curObj.NAME.ToString();
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = curObj.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ITEM_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM(){ID = curObj.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
				SetEnumReferenceSelected(this.ddlInputIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_GOV_PROC);
				this.txtInputCODE.Text = curObj.CODE == null ? string.Empty:curObj.CODE.ToString();
				this.txtInputBUDEGT_MONEY.Text = curObj.BUDEGT_MONEY == null ? string.Empty:curObj.BUDEGT_MONEY.ToString();
				this.txtInputEXECUTED_MONEY.Text = curObj.EXECUTED_MONEY == null ? string.Empty:curObj.EXECUTED_MONEY.ToString();
				this.txtInputAPPLY_MONEY.Text = curObj.APPLY_MONEY == null ? string.Empty:curObj.APPLY_MONEY.ToString();
				this.txtInputAPPLIED_MONEY.Text = curObj.APPLIED_MONEY == null ? string.Empty:curObj.APPLIED_MONEY.ToString();
				CauseObject_COM_TYPE cause351 =  new CauseObject_COM_TYPE();
				cause351.PARENT_ID = "0030";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputSOURCE_ID, typeof( BizLogicObject_COM_TYPE), curObj.SOURCE_ID,"ID","NAME",cause351);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_D cause = new CauseObject_BGT_B_BUDGET_PROJ_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_BUDGET_PROJ_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_D entity = new EntityObject_BGT_B_BUDGET_PROJ_D();
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
                BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
	}
}

