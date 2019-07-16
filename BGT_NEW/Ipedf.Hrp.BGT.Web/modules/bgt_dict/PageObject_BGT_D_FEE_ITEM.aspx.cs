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
    public partial class PageObject_BGT_D_FEE_ITEM : ComListEditPage
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
                throw new Exception("指标编码不能为空");
            if (string.IsNullOrEmpty(txtInputNAME.Text))
                throw new Exception("指标名称不能为空");
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_FEE_ITEM cause = (CauseObject_BGT_D_FEE_ITEM)parameter;
			dataSource = BizLogicObject_BGT_D_FEE_ITEM.Proxy.Query(cause, paging, orderBy);
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
			CauseObject_COM_TYPE cause852 =  new CauseObject_COM_TYPE();
			cause852.PARENT_ID = "0007";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause852);
			SetEnumReferenceBinding(this.ddlInputIS_DISABLE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause735 =  new CauseObject_COM_TYPE();
			cause735.PARENT_ID = "0001";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputUNIT_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause735);
			CauseObject_COM_TYPE cause576 =  new CauseObject_COM_TYPE();
			cause576.PARENT_ID = "0022";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputITEM_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause576);
			SetEnumReferenceBinding(this.ddlInputIS_CALCULATE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.txtInputNAME.Text = string.Empty;
			SetEnumReferenceBinding(this.ddlInputIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			CauseObject_COM_TYPE cause587 =  new CauseObject_COM_TYPE();
			cause587.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause587);
			this.txtInputCODE.Text = string.Empty;
			CauseObject_COM_TYPE cause226 =  new CauseObject_COM_TYPE();
			cause226.PARENT_ID = "0008";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause226);
			CauseObject_COM_TYPE cause844 =  new CauseObject_COM_TYPE();
			cause844.PARENT_ID = "0021";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause844);
			CauseObject_COM_TYPE cause264 =  new CauseObject_COM_TYPE();
			cause264.PARENT_ID = "0002";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputADVICE_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause264);
			CauseObject_COM_TYPE cause468 =  new CauseObject_COM_TYPE();
			cause468.PARENT_ID = "0017";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause468);

            //是否停用
            WebControlHelper.SetSelected(ddlInputIS_DISABLE, (decimal)是否状态.否);
            //是否计算
            WebControlHelper.SetSelected(ddlInputIS_CALCULATE, (decimal)是否状态.否);
            //是否结转
            WebControlHelper.SetSelected(ddlInputIS_CARRYOVER, (decimal)是否状态.否);
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
				EntityObject_BGT_D_FEE_ITEM curObj = new EntityObject_BGT_D_FEE_ITEM();
									//平台自动生成代码
				curObj.BUDGET_YEAR = this.tvTree.SelectedValue;
                                    //if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
                                    //    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_DISABLE.SelectedValue))
										curObj.IS_DISABLE = decimal.Parse(ddlInputIS_DISABLE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputUNIT_ID.SelectedValue))
										curObj.UNIT_ID = ddlInputUNIT_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_CLASSIFY_ID.SelectedValue))
										curObj.ITEM_CLASSIFY_ID = ddlInputITEM_CLASSIFY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CALCULATE.SelectedValue))
										curObj.IS_CALCULATE = decimal.Parse(ddlInputIS_CALCULATE.SelectedValue);
					curObj.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_CARRYOVER.SelectedValue))
										curObj.IS_CARRYOVER = decimal.Parse(ddlInputIS_CARRYOVER.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
					curObj.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										curObj.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDATA_TYPE_ID.SelectedValue))
										curObj.DATA_TYPE_ID = ddlInputDATA_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputADVICE_CLASSIFY_ID.SelectedValue))
										curObj.ADVICE_CLASSIFY_ID = ddlInputADVICE_CLASSIFY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_PATTERN_ID.SelectedValue))
										curObj.PREPARE_PATTERN_ID = ddlInputPREPARE_PATTERN_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_FEE_ITEM.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_FEE_ITEM curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_FEE_ITEM;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_DISABLE.SelectedValue))
										curObj.IS_DISABLE = decimal.Parse(ddlInputIS_DISABLE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputUNIT_ID.SelectedValue))
										curObj.UNIT_ID = ddlInputUNIT_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_CLASSIFY_ID.SelectedValue))
										curObj.ITEM_CLASSIFY_ID = ddlInputITEM_CLASSIFY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CALCULATE.SelectedValue))
										curObj.IS_CALCULATE = decimal.Parse(ddlInputIS_CALCULATE.SelectedValue);
					curObj.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_CARRYOVER.SelectedValue))
										curObj.IS_CARRYOVER = decimal.Parse(ddlInputIS_CARRYOVER.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
					curObj.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										curObj.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDATA_TYPE_ID.SelectedValue))
										curObj.DATA_TYPE_ID = ddlInputDATA_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputADVICE_CLASSIFY_ID.SelectedValue))
										curObj.ADVICE_CLASSIFY_ID = ddlInputADVICE_CLASSIFY_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_PATTERN_ID.SelectedValue))
										curObj.PREPARE_PATTERN_ID = ddlInputPREPARE_PATTERN_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_FEE_ITEM.Proxy.Update(curObj);
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
				EntityObject_BGT_D_FEE_ITEM curObj = new EntityObject_BGT_D_FEE_ITEM();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_FEE_ITEM.Proxy.Get(curObj);
				CauseObject_COM_TYPE cause435 =  new CauseObject_COM_TYPE();
				cause435.PARENT_ID = "0007";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.ITEM_TYPE_ID,"ID","NAME",cause435);
				SetEnumReferenceSelected(this.ddlInputIS_DISABLE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_DISABLE);
				CauseObject_COM_TYPE cause218 =  new CauseObject_COM_TYPE();
				cause218.PARENT_ID = "0001";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputUNIT_ID, typeof( BizLogicObject_COM_TYPE), curObj.UNIT_ID,"ID","NAME",cause218);
				CauseObject_COM_TYPE cause331 =  new CauseObject_COM_TYPE();
				cause331.PARENT_ID = "0022";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputITEM_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE), curObj.ITEM_CLASSIFY_ID,"ID","NAME",cause331);
				SetEnumReferenceSelected(this.ddlInputIS_CALCULATE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_CALCULATE);
				this.txtInputNAME.Text = curObj.NAME == null ? string.Empty:curObj.NAME.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_CARRYOVER);
				CauseObject_COM_TYPE cause383 =  new CauseObject_COM_TYPE();
				cause383.PARENT_ID = "0019";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.IMPORT_TYPE_ID,"ID","NAME",cause383);
				this.txtInputCODE.Text = curObj.CODE == null ? string.Empty:curObj.CODE.ToString();
				CauseObject_COM_TYPE cause845 =  new CauseObject_COM_TYPE();
				cause845.PARENT_ID = "0008";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.SOURCE_TYPE_ID,"ID","NAME",cause845);
				CauseObject_COM_TYPE cause422 =  new CauseObject_COM_TYPE();
				cause422.PARENT_ID = "0021";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.DATA_TYPE_ID,"ID","NAME",cause422);
				CauseObject_COM_TYPE cause872 =  new CauseObject_COM_TYPE();
				cause872.PARENT_ID = "0002";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputADVICE_CLASSIFY_ID, typeof( BizLogicObject_COM_TYPE), curObj.ADVICE_CLASSIFY_ID,"ID","NAME",cause872);
				CauseObject_COM_TYPE cause224 =  new CauseObject_COM_TYPE();
				cause224.PARENT_ID = "0017";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE), curObj.PREPARE_PATTERN_ID,"ID","NAME",cause224);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.GridViewEdit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }       
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_FEE_ITEM cause = new CauseObject_BGT_D_FEE_ITEM();
			
			return cause;
        }     
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_FEE_ITEM>(parameter);
        }   
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_FEE_ITEM_PARAM.aspx", 500, 500);
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
            List<EntityObject_BGT_D_FEE_ITEM> deleteDetailEntities = new List<EntityObject_BGT_D_FEE_ITEM>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_FEE_ITEM entity = new EntityObject_BGT_D_FEE_ITEM();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_FEE_ITEM.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

