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
    public partial class PageObject_BGT_D_ACCOUNT_ITEM : ComTreeEditPage
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
            if (string.IsNullOrEmpty(txtInputCODE.Text))
                throw new Exception("科目编码不能为空");
            if (string.IsNullOrEmpty(txtInputNAME.Text))
                throw new Exception("科目名称不能为空");
            if(string.IsNullOrEmpty(txtInputFULL_NAME.Text))
                throw new Exception("科目全称不能为空");
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            orderBy.Asc = false;
			//平台自动生成代码
			CauseObject_BGT_D_ACCOUNT_ITEM cause = (CauseObject_BGT_D_ACCOUNT_ITEM)parameter;
			dataSource = BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputCODE.Text = string.Empty;
			this.txtInputNAME.Text = string.Empty;
			this.txtInputFULL_NAME.Text = string.Empty;
			CauseObject_COM_TYPE cause854 =  new CauseObject_COM_TYPE();
			cause854.PARENT_ID = "0018";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause854);
			CauseObject_COM_TYPE cause187 =  new CauseObject_COM_TYPE();
			cause187.PARENT_ID = "0006";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputDIRECTION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause187);
			CauseObject_COM_TYPE cause838 =  new CauseObject_COM_TYPE();
			cause838.PARENT_ID = "0016";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPROPERTY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause838);
			SetEnumReferenceBinding(this.ddlInputIS_CASH, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			SetEnumReferenceBinding(this.ddlInputIS_ASSSIST, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            SetEnumReferenceBinding(this.ddlInputIS_END, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            
            //现金流量
            WebControlHelper.SetSelected(ddlInputIS_CASH, (decimal)是否状态.否);
            //辅助核算
            WebControlHelper.SetSelected(ddlInputIS_ASSSIST, (decimal)是否状态.否);
            //是否末级
            WebControlHelper.SetSelected(ddlInputIS_END, (decimal)是否状态.否);

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
				EntityObject_BGT_D_ACCOUNT_ITEM curObj = new EntityObject_BGT_D_ACCOUNT_ITEM();
									//平台自动生成代码
					curObj.CODE = txtInputCODE.Text;
					curObj.NAME = txtInputNAME.Text;
					curObj.FULL_NAME = txtInputFULL_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
				curObj.PARENT_ID = this.tvTree.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDIRECTION_ID.SelectedValue))
										curObj.DIRECTION_ID = ddlInputDIRECTION_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPROPERTY_ID.SelectedValue))
										curObj.PROPERTY_ID = ddlInputPROPERTY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CASH.SelectedValue))
										curObj.IS_CASH = decimal.Parse(ddlInputIS_CASH.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_ASSSIST.SelectedValue))
										curObj.IS_ASSSIST = decimal.Parse(ddlInputIS_ASSSIST.SelectedValue);
                                    if (!string.IsNullOrEmpty(ddlInputIS_END.SelectedValue))
                                        curObj.IS_END = ddlInputIS_END.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_ACCOUNT_ITEM curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_ACCOUNT_ITEM;
									//平台自动生成代码
					curObj.CODE = txtInputCODE.Text;
					curObj.NAME = txtInputNAME.Text;
					curObj.FULL_NAME = txtInputFULL_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDIRECTION_ID.SelectedValue))
										curObj.DIRECTION_ID = ddlInputDIRECTION_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPROPERTY_ID.SelectedValue))
										curObj.PROPERTY_ID = ddlInputPROPERTY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CASH.SelectedValue))
										curObj.IS_CASH = decimal.Parse(ddlInputIS_CASH.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_ASSSIST.SelectedValue))
										curObj.IS_ASSSIST = decimal.Parse(ddlInputIS_ASSSIST.SelectedValue);
                                    if (!string.IsNullOrEmpty(ddlInputIS_END.SelectedValue))
                                        curObj.IS_END = ddlInputIS_END.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Update(curObj);
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
				EntityObject_BGT_D_ACCOUNT_ITEM curObj = new EntityObject_BGT_D_ACCOUNT_ITEM();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Get(curObj);
				this.txtInputCODE.Text = curObj.CODE == null ? string.Empty:curObj.CODE.ToString();
				this.txtInputNAME.Text = curObj.NAME == null ? string.Empty:curObj.NAME.ToString();
				this.txtInputFULL_NAME.Text = curObj.FULL_NAME == null ? string.Empty:curObj.FULL_NAME.ToString();
				CauseObject_COM_TYPE cause411 =  new CauseObject_COM_TYPE();
				cause411.PARENT_ID = "0018";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.ITEM_TYPE_ID,"ID","NAME",cause411);
				CauseObject_COM_TYPE cause417 =  new CauseObject_COM_TYPE();
				cause417.PARENT_ID = "0006";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputDIRECTION_ID, typeof( BizLogicObject_COM_TYPE), curObj.DIRECTION_ID,"ID","NAME",cause417);
				CauseObject_COM_TYPE cause312 =  new CauseObject_COM_TYPE();
				cause312.PARENT_ID = "0016";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPROPERTY_ID, typeof( BizLogicObject_COM_TYPE), curObj.PROPERTY_ID,"ID","NAME",cause312);
				SetEnumReferenceSelected(this.ddlInputIS_CASH, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_CASH);
				SetEnumReferenceSelected(this.ddlInputIS_ASSSIST, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_ASSSIST);
                SetEnumReferenceSelected(this.ddlInputIS_END, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_END);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.GridViewEdit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }        
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_ACCOUNT_ITEM cause = new CauseObject_BGT_D_ACCOUNT_ITEM();
			
			return cause;
        }        
        protected override object PrepareTreeViewDataSource()
        {
            
			ComLevelDataEntity entity = new ComLevelDataEntity();
			entity.DataObjectName = "BGT_D_ACCOUNT_ITEM";
			entity.DataObjectAlias = "t";
			entity.StartWithRoot = true;
			entity.KeyFieldName = "ID";
			entity.LevelFieldName = "PARENT_ID";
			entity.DisplayFieldName = "NAME";
			ComLevelDataEntity[] results = SystemLogic.Proxy.PrepareHierarchyData(entity);
			return results;
        }      
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_ACCOUNT_ITEM>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_ACCOUNT_ITEM_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_ACCOUNT_ITEM> deleteDetailEntities = new List<EntityObject_BGT_D_ACCOUNT_ITEM>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_ACCOUNT_ITEM entity = new EntityObject_BGT_D_ACCOUNT_ITEM();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                int index = this.tvTree.SelectedIndex;
                ShowData();
                this.tvTree.SelectedIndex = index;
            }       
            
            
        }
        protected override void ShowQueryResult(object parameter)
        {
            if (this.tvTree.SelectedValue != null)
            {
                parameter.GetType().GetProperty("PARENT_ID").SetValue(parameter,this.tvTree.SelectedValue,null);
            }
            base.ShowQueryResult(parameter);
        }
    }
}

