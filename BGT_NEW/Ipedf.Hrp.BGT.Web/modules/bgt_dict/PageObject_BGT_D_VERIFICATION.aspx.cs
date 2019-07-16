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
using Ipedf.Common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_VERIFICATION : ComListEditPage
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
			CauseObject_BGT_D_VERIFICATION cause = (CauseObject_BGT_D_VERIFICATION)parameter;
			dataSource = BizLogicObject_BGT_D_VERIFICATION.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			//平台自动生成代码
			CauseObject_COM_TYPE cause453 =  new CauseObject_COM_TYPE();
			cause453.PARENT_ID = "0013";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause453);
			CauseObject_COM_TYPE cause172 =  new CauseObject_COM_TYPE();
			cause172.PARENT_ID = "0014";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause172);
			CauseObject_COM_TYPE cause147 =  new CauseObject_COM_TYPE();
			cause147.PARENT_ID = "0015";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause147);
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
				EntityObject_BGT_D_VERIFICATION curObj = new EntityObject_BGT_D_VERIFICATION();
									//平台自动生成代码
				curObj.BUDGET_YEAR = this.tvTree.SelectedValue;
                                    //if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                                    //    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										curObj.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_VERIFICATION.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_VERIFICATION curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_VERIFICATION;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										curObj.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_VERIFICATION.Proxy.Update(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            SetPageState(PageState.GridViewEdit);
            int index = this.tvTree.SelectedIndex;
            BindTreeView();
            this.tvTree.SelectedIndex = index;
        }
        protected override void PrepareEdit(string id)
        {
            
				//平台自动生成代码
				EntityObject_BGT_D_VERIFICATION curObj = new EntityObject_BGT_D_VERIFICATION();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_VERIFICATION.Proxy.Get(curObj);
				CauseObject_COM_TYPE cause237 =  new CauseObject_COM_TYPE();
				cause237.PARENT_ID = "0013";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.ITEM_TYPE_ID,"ID","NAME",cause237);
				CauseObject_COM_TYPE cause862 =  new CauseObject_COM_TYPE();
				cause862.PARENT_ID = "0014";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.IMPORT_TYPE_ID,"ID","NAME",cause862);
				CauseObject_COM_TYPE cause655 =  new CauseObject_COM_TYPE();
				cause655.PARENT_ID = "0015";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.SOURCE_TYPE_ID,"ID","NAME",cause655);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.GridViewEdit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }       
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_VERIFICATION cause = new CauseObject_BGT_D_VERIFICATION();
			
			return cause;
        }     
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_VERIFICATION>(parameter);
        }   
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_VERIFICATION_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareTreeViewDataSource()
        {
            
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)是否状态.是;
			DisplayObject_BGT_D_BUDGET_YEAR[] results = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p);
			return results;
        }    
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_VERIFICATION> deleteDetailEntities = new List<EntityObject_BGT_D_VERIFICATION>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_VERIFICATION entity = new EntityObject_BGT_D_VERIFICATION();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_VERIFICATION.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                int index = this.tvTree.SelectedIndex;
                BindTreeView();
                this.tvTree.SelectedIndex = index;
                BindGridView();
            }  
            
           
            
        }
        protected override void ShowQueryResult(object parameter)
        {
            if (this.tvTree.SelectedValue != null)
            {
                parameter.GetType().GetProperty("BUDGET_YEAR").SetValue(parameter,this.tvTree.SelectedValue,null);
            }
            base.ShowQueryResult(parameter);
        }
        protected override string PrepareDataTextField()
        {
            return "BUDGET_YEAR";
        }
    }
}

