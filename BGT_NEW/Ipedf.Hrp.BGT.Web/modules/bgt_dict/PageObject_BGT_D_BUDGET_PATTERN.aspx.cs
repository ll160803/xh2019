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
	public partial class PageObject_BGT_D_BUDGET_PATTERN : ComSimplePage
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
			CauseObject_BGT_D_BUDGET_PATTERN cause = (CauseObject_BGT_D_BUDGET_PATTERN)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			SetEnumReferenceBinding(this.ddlInputIS_INTERNAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause375 =  new CauseObject_COM_TYPE();
			cause375.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPAY_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause375);
			CauseObject_COM_TYPE cause318 =  new CauseObject_COM_TYPE();
			cause318.PARENT_ID = "0025";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPAY_LEVEL_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause318);
			SetEnumReferenceBinding(this.ddlInputIS_PAY_ITEM_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause516 =  new CauseObject_COM_TYPE();
			cause516.PARENT_ID = "0024";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputINCOME_LEVEL_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause516);
			CauseObject_COM_TYPE cause426 =  new CauseObject_COM_TYPE();
			cause426.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputINCOME_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause426);
			CauseObject_COM_TYPE cause186 =  new CauseObject_COM_TYPE();
			cause186.PARENT_ID = "0026";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPAY_PATTERN_ENTRY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause186);
            CauseObject_COM_TYPE cause171 = new CauseObject_COM_TYPE();
            cause171.PARENT_ID = "0017";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPLAN_PATTERN_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause171);

            //业务预算-自上而下
            WebControlHelper.SetSelected(this.ddlInputPLAN_PATTERN_ID, "00170001");
            //收入预算-自上而下
            WebControlHelper.SetSelected(this.ddlInputINCOME_PATTERN_ID, "00170001");
            //支出预算-自下而上
            WebControlHelper.SetSelected(this.ddlInputPAY_PATTERN_ID, "00170002");
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
				EntityObject_BGT_D_BUDGET_PATTERN curObj = new EntityObject_BGT_D_BUDGET_PATTERN();
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_INTERNAL.SelectedValue))
										curObj.IS_INTERNAL = decimal.Parse(ddlInputIS_INTERNAL.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputPAY_PATTERN_ID.SelectedValue))
										curObj.PAY_PATTERN_ID = ddlInputPAY_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPAY_LEVEL_ID.SelectedValue))
										curObj.PAY_LEVEL_ID = ddlInputPAY_LEVEL_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_PAY_ITEM_MERGE.SelectedValue))
										curObj.IS_PAY_ITEM_MERGE = decimal.Parse(ddlInputIS_PAY_ITEM_MERGE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputINCOME_LEVEL_ID.SelectedValue))
										curObj.INCOME_LEVEL_ID = ddlInputINCOME_LEVEL_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputINCOME_PATTERN_ID.SelectedValue))
										curObj.INCOME_PATTERN_ID = ddlInputINCOME_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPAY_PATTERN_ENTRY_ID.SelectedValue))
										curObj.PAY_PATTERN_ENTRY_ID = ddlInputPAY_PATTERN_ENTRY_ID.SelectedValue;
                                    if (!string.IsNullOrEmpty(ddlInputPLAN_PATTERN_ID.SelectedValue))
                                        curObj.PLAN_PATTERN_ID = ddlInputPLAN_PATTERN_ID.SelectedValue;
				//BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Save(curObj);
                BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_PATTERN curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_INTERNAL.SelectedValue))
										curObj.IS_INTERNAL = decimal.Parse(ddlInputIS_INTERNAL.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputPAY_PATTERN_ID.SelectedValue))
										curObj.PAY_PATTERN_ID = ddlInputPAY_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPAY_LEVEL_ID.SelectedValue))
										curObj.PAY_LEVEL_ID = ddlInputPAY_LEVEL_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_PAY_ITEM_MERGE.SelectedValue))
										curObj.IS_PAY_ITEM_MERGE = decimal.Parse(ddlInputIS_PAY_ITEM_MERGE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputINCOME_LEVEL_ID.SelectedValue))
										curObj.INCOME_LEVEL_ID = ddlInputINCOME_LEVEL_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputINCOME_PATTERN_ID.SelectedValue))
										curObj.INCOME_PATTERN_ID = ddlInputINCOME_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPAY_PATTERN_ENTRY_ID.SelectedValue))
										curObj.PAY_PATTERN_ENTRY_ID = ddlInputPAY_PATTERN_ENTRY_ID.SelectedValue;
                                    if (!string.IsNullOrEmpty(ddlInputPLAN_PATTERN_ID.SelectedValue))
                                        curObj.PLAN_PATTERN_ID = ddlInputPLAN_PATTERN_ID.SelectedValue;
				//BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Update(curObj);
                BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Update(curObj);
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
				EntityObject_BGT_D_BUDGET_PATTERN curObj = new EntityObject_BGT_D_BUDGET_PATTERN();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Get(curObj);
                CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR(); p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
                SetForeignKeySelected<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), curObj.BUDGET_YEAR, "ID", "BUDGET_YEAR",p);
				SetEnumReferenceSelected(this.ddlInputIS_INTERNAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_INTERNAL);
				CauseObject_COM_TYPE cause553 =  new CauseObject_COM_TYPE();
				cause553.PARENT_ID = "0017";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPAY_PATTERN_ID, typeof( BizLogicObject_COM_TYPE), curObj.PAY_PATTERN_ID,"ID","NAME",cause553);
				CauseObject_COM_TYPE cause836 =  new CauseObject_COM_TYPE();
				cause836.PARENT_ID = "0025";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPAY_LEVEL_ID, typeof( BizLogicObject_COM_TYPE), curObj.PAY_LEVEL_ID,"ID","NAME",cause836);
				SetEnumReferenceSelected(this.ddlInputIS_PAY_ITEM_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_PAY_ITEM_MERGE);
				CauseObject_COM_TYPE cause785 =  new CauseObject_COM_TYPE();
				cause785.PARENT_ID = "0024";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputINCOME_LEVEL_ID, typeof( BizLogicObject_COM_TYPE), curObj.INCOME_LEVEL_ID,"ID","NAME",cause785);
				CauseObject_COM_TYPE cause757 =  new CauseObject_COM_TYPE();
				cause757.PARENT_ID = "0017";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputINCOME_PATTERN_ID, typeof( BizLogicObject_COM_TYPE), curObj.INCOME_PATTERN_ID,"ID","NAME",cause757);
				CauseObject_COM_TYPE cause487 =  new CauseObject_COM_TYPE();
				cause487.PARENT_ID = "0026";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPAY_PATTERN_ENTRY_ID, typeof( BizLogicObject_COM_TYPE), curObj.PAY_PATTERN_ENTRY_ID,"ID","NAME",cause487);
                CauseObject_COM_TYPE cause127 = new CauseObject_COM_TYPE();
                cause127.PARENT_ID = "0017";
                SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPLAN_PATTERN_ID, typeof(BizLogicObject_COM_TYPE), curObj.PLAN_PATTERN_ID, "ID", "NAME", cause127);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_PATTERN cause = new CauseObject_BGT_D_BUDGET_PATTERN();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_PATTERN>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_PATTERN obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_D_BUDGET_PATTERN obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_PATTERN obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_PATTERN obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_PATTERN obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_PATTERN;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_PATTERN_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_PATTERN> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_PATTERN>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_PATTERN entity = new EntityObject_BGT_D_BUDGET_PATTERN();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_PATTERN.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

