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
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_ITEM : ComTreeEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            this.lbAppend.Visible = false;
            this.lbAppend.Enabled = this.tvTree.SelectedItem != null;
            ((ComControlBar)FindControl("command"))[Ipedf.Web.Control.ButtonType.Add].Enabled = true;
            btnUpload.Enabled = ((ComControlBar)FindControl("command"))[Ipedf.Web.Control.ButtonType.Add].Enabled;
            btnScan.Enabled = ((ComControlBar)FindControl("command"))[Ipedf.Web.Control.ButtonType.Add].Enabled;
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(txtInputCODE.Text))
                throw new Exception("科目编码不能为空");
            if (string.IsNullOrEmpty(txtInputNAME.Text))
                throw new Exception("科目名称不能为空");

            EntityObject_BGT_D_BUDGET_YEAR curObj = new EntityObject_BGT_D_BUDGET_YEAR();
            curObj.ID = this.ddlBudgetYear.SelectedValue;
            curObj = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(curObj);
            if (curObj == null)
              throw new Exception("选择的预算年度不存在");
            if (curObj.IS_AVAILABE == 3)
                throw new Exception("选择的预算年度已归档");
            if (string.IsNullOrEmpty(ddlBUDGET_DEPT_ID.KeyValue))
                throw new Exception("预算科室不能为空");
            if (ViewState["CUR_OBJ"] == null)
            {
                CauseObject_BGT_D_BUDGET_ITEM cb = new CauseObject_BGT_D_BUDGET_ITEM();
                cb.CODE = txtInputCODE.Text;
                cb.BUDGET_YEAR = this.ddlBudgetYear.SelectedValue;
                EntityObject_BGT_D_BUDGET_ITEM[] eb = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Query(cb);
                if (eb.Length > 0)
                {
                    throw new Exception("科目编码已存在");
                }
            }
        }
        public void ddlInputBUDGET_YEAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        protected override void PrepareCause()
        {
            CauseObject_BGT_D_BUDGET_YEAR cause343 = new CauseObject_BGT_D_BUDGET_YEAR();
            cause343.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", cause343);
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_ITEM cause = (CauseObject_BGT_D_BUDGET_ITEM)parameter;
            cause.BUDGET_YEAR = Session["budget_year"].ToString();
            //cause.SetCustomCondition(" order by budget_year_name desc,code ");
			dataSource = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
            //CauseObject_BGT_D_BUDGET_YEAR cause451 =  new CauseObject_BGT_D_BUDGET_YEAR();
            //cause451.IS_VALID = 1;
            //SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause451);
            SetForeignKeyBinding(this.ddlBudgetYear, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR");
            this.ddlBudgetYear.SelectedValue = Session["budget_year"].ToString();
			this.txtInputCODE.Text = string.Empty;
			this.txtInputNAME.Text = string.Empty;
            this.ddlBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = '" + this.ddlBudgetYear.SelectedValue + "'";
			CauseObject_COM_TYPE cause725 =  new CauseObject_COM_TYPE();
			cause725.PARENT_ID = "0018";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause725);
			CauseObject_COM_TYPE cause687 =  new CauseObject_COM_TYPE();
			cause687.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause687);
			CauseObject_COM_TYPE cause454 =  new CauseObject_COM_TYPE();
			cause454.PARENT_ID = "0021";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause454);
			CauseObject_COM_TYPE cause554 =  new CauseObject_COM_TYPE();
			cause554.PARENT_ID = "0020";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputUSAGE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause554);
			CauseObject_COM_TYPE cause714 =  new CauseObject_COM_TYPE();
			cause714.PARENT_ID = "0019";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause714);
			SetEnumReferenceBinding(this.ddlInputIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));            
			SetEnumReferenceBinding(this.ddlInputIS_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));           
			SetEnumReferenceBinding(this.ddlInputIS_FINAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            WebControlHelper.SetSelected(this.ddlInputIS_CARRYOVER, typeof(Ipedf.Common.是否状态), (int)Ipedf.Common.是否状态.否);
            WebControlHelper.SetSelected(this.ddlInputIS_MERGE, typeof(Ipedf.Common.是否状态), (int)Ipedf.Common.是否状态.否);
            WebControlHelper.SetSelected(this.ddlInputIS_FINAL, typeof(Ipedf.Common.是否状态), (int)Ipedf.Common.是否状态.否);
            this.ddlComments.DataTable = "COM_TYPE";
            this.ddlComments.Condition = " COM_TYPE.PARENT_ID='BGTTYPE_001' ";
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
				EntityObject_BGT_D_BUDGET_ITEM curObj = new EntityObject_BGT_D_BUDGET_ITEM();
									//平台自动生成代码
									if(!string.IsNullOrEmpty(this.ddlBudgetYear.SelectedValue))
                                        curObj.BUDGET_YEAR = this.ddlBudgetYear.SelectedValue;
					curObj.CODE = txtInputCODE.Text;
					curObj.NAME = txtInputNAME.Text;
				curObj.PARENT_ID = this.tvTree.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDATA_TYPE_ID.SelectedValue))
										curObj.DATA_TYPE_ID = ddlInputDATA_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputUSAGE_ID.SelectedValue))
										curObj.USAGE_ID = ddlInputUSAGE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_PATTERN_ID.SelectedValue))
										curObj.PREPARE_PATTERN_ID = ddlInputPREPARE_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CARRYOVER.SelectedValue))
										curObj.IS_CARRYOVER = decimal.Parse(ddlInputIS_CARRYOVER.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_MERGE.SelectedValue))
										curObj.IS_MERGE = decimal.Parse(ddlInputIS_MERGE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_FINAL.SelectedValue))
										curObj.IS_END = decimal.Parse(ddlInputIS_FINAL.SelectedValue);
                                    if (!string.IsNullOrEmpty(this.ddlComments.KeyValue))
                                        curObj.COMMENTS = this.ddlComments.KeyValue;
                                    else
                                        curObj.COMMENTS = "";
                                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ViewState["CUR_OBJ"] = curObj;
                EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM BBDB = new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
                BBDB.BASE_ID = this.ddlBUDGET_DEPT_ID.KeyValue;
                BBDB.BUDGET_ITEM_ID = curObj.ID;
                BizLogicMsg msg1 = BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Proxy.Save(BBDB);
                if (!msg1.Succeed)
                    throw new Exception(msg1.Message);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_ITEM curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_ITEM;
									//平台自动生成代码
                if (!string.IsNullOrEmpty(this.ddlBudgetYear.SelectedValue))
                    curObj.BUDGET_YEAR = this.ddlBudgetYear.SelectedValue;
					curObj.CODE = txtInputCODE.Text;
					curObj.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_TYPE_ID.SelectedValue))
										curObj.ITEM_TYPE_ID = ddlInputITEM_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIMPORT_TYPE_ID.SelectedValue))
										curObj.IMPORT_TYPE_ID = ddlInputIMPORT_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputDATA_TYPE_ID.SelectedValue))
										curObj.DATA_TYPE_ID = ddlInputDATA_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputUSAGE_ID.SelectedValue))
										curObj.USAGE_ID = ddlInputUSAGE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_PATTERN_ID.SelectedValue))
										curObj.PREPARE_PATTERN_ID = ddlInputPREPARE_PATTERN_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputIS_CARRYOVER.SelectedValue))
										curObj.IS_CARRYOVER = decimal.Parse(ddlInputIS_CARRYOVER.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_MERGE.SelectedValue))
										curObj.IS_MERGE = decimal.Parse(ddlInputIS_MERGE.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputIS_FINAL.SelectedValue))
										curObj.IS_END = decimal.Parse(ddlInputIS_FINAL.SelectedValue);
                                    if (!string.IsNullOrEmpty(this.ddlComments.KeyValue))
                                        curObj.COMMENTS = this.ddlComments.KeyValue;
                                    else
                                        curObj.COMMENTS = "";
                                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Update(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);

                //同时更新预算数据编码
                CauseObject_BGT_B_DEPT_PAY_YEAR_FUND cb = new CauseObject_BGT_B_DEPT_PAY_YEAR_FUND();
                cb.BGT_D_BUDGET_ITEM_ID = curObj.ID;
                cb.BUDGET_YEAR = this.ddlBudgetYear.SelectedValue;
                DisplayObject_BGT_B_DEPT_PAY_YEAR_FUND[] db = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(cb);

                foreach (DisplayObject_BGT_B_DEPT_PAY_YEAR_FUND lb in db)
                {
                    lb.CODE = curObj.CODE;
                    msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Update(lb);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                }
                //同时更新预算调整数据编码
                CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cba = new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
                cba.BGT_D_BUDGET_ITEM_ID = curObj.ID;
                cba.BUDGET_YEAR = this.ddlBudgetYear.SelectedValue;
                DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] dba = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Query(cba);

                foreach (DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE lb in dba)
                {
                    lb.CODE = curObj.CODE;
                    msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Update(lb);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                }
                //更新与科室关联表数据
                EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM BBDB = new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
                BBDB.ID = curObj.TAB_ID;
                BBDB.BASE_ID = this.ddlBUDGET_DEPT_ID.KeyValue;
                BBDB.BUDGET_ITEM_ID = curObj.ID;
                BizLogicMsg msg1 = BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Proxy.Update(BBDB);
                if (!msg1.Succeed)
                    throw new Exception(msg1.Message);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            SetPageState(PageState.GridViewEdit);
            int index = this.tvTree.SelectedIndex;
            BindTreeView();
            this.tvTree.SelectedIndex = index;
        }
        protected override void PrepareEdit(string id)
        {
            
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_ITEM curObj = new EntityObject_BGT_D_BUDGET_ITEM();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(curObj);
                CauseObject_BGT_D_BUDGET_YEAR cause158 = new CauseObject_BGT_D_BUDGET_YEAR();
                //cause158.IS_VALID = 1;
                SetForeignKeySelected<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), curObj.BUDGET_YEAR, "ID", "BUDGET_YEAR", cause158);
				this.txtInputCODE.Text = curObj.CODE == null ? string.Empty:curObj.CODE.ToString();
				this.txtInputNAME.Text = curObj.NAME == null ? string.Empty:curObj.NAME.ToString();
                SetForeignKeyBinding(this.ddlBudgetYear, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR");
                this.ddlBudgetYear.SelectedValue = curObj.BUDGET_YEAR;
                this.ddlBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
                this.ddlBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = '" + curObj.BUDGET_YEAR + "'";
                this.ddlBUDGET_DEPT_ID.KeyValue = curObj.DEPT_ID;
                this.ddlBUDGET_DEPT_ID.NameValue = curObj.DEPT_NAME;
				CauseObject_COM_TYPE cause322 =  new CauseObject_COM_TYPE();
				cause322.PARENT_ID = "0018";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputITEM_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.ITEM_TYPE_ID,"ID","NAME",cause322);
				CauseObject_COM_TYPE cause321 =  new CauseObject_COM_TYPE();
				cause321.PARENT_ID = "0019";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputIMPORT_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.IMPORT_TYPE_ID,"ID","NAME",cause321);
				CauseObject_COM_TYPE cause218 =  new CauseObject_COM_TYPE();
				cause218.PARENT_ID = "0021";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputDATA_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.DATA_TYPE_ID,"ID","NAME",cause218);
				CauseObject_COM_TYPE cause184 =  new CauseObject_COM_TYPE();
				cause184.PARENT_ID = "0020";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputUSAGE_ID, typeof( BizLogicObject_COM_TYPE), curObj.USAGE_ID,"ID","NAME",cause184);
				CauseObject_COM_TYPE cause311 =  new CauseObject_COM_TYPE();
				cause311.PARENT_ID = "0019";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPREPARE_PATTERN_ID, typeof( BizLogicObject_COM_TYPE), curObj.PREPARE_PATTERN_ID,"ID","NAME",cause311);
                this.ddlComments.DataTable = "COM_TYPE";
                this.ddlComments.Condition = " COM_TYPE.PARENT_ID='BGTTYPE_001' ";
                this.ddlComments.KeyValue = curObj.COMMENTS;
                this.ddlComments.NameValue = curObj.COMMENTS_NAME;
				SetEnumReferenceSelected(this.ddlInputIS_CARRYOVER, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_CARRYOVER);
				SetEnumReferenceSelected(this.ddlInputIS_MERGE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_MERGE);
				SetEnumReferenceSelected(this.ddlInputIS_FINAL, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_END);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.GridViewEdit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }        
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_BUDGET_ITEM cause = new CauseObject_BGT_D_BUDGET_ITEM();
            cause.BUDGET_YEAR = Session["budget_year"].ToString();
			return cause;
        }        
        protected override object PrepareTreeViewDataSource()
        {
            
			ComLevelDataEntity entity = new ComLevelDataEntity();
			entity.DataObjectName = "BGT_D_BUDGET_ITEM";
			entity.DataObjectAlias = "t";
			entity.StartWithRoot = true;
			entity.KeyFieldName = "ID";
			entity.LevelFieldName = "PARENT_ID";
			entity.DisplayFieldName = "NAME";
            entity.Protasis = string.Format(" t.BUDGET_YEAR = '{0}'", this.ddlInputBUDGET_YEAR.SelectedValue);
			ComLevelDataEntity[] results = SystemLogic.Proxy.PrepareHierarchyData(entity);
			return results;
        }      
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_ITEM>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_ITEM_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_ITEM> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_ITEM>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_ITEM entity = new EntityObject_BGT_D_BUDGET_ITEM();
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
            bool isdelete = true;
            foreach (EntityObject_BGT_D_BUDGET_ITEM lb in deleteDetailEntities)
            { 
                CauseObject_BGT_B_DEPT_PAY_YEAR_FUND cb = new CauseObject_BGT_B_DEPT_PAY_YEAR_FUND();
                cb.BGT_D_BUDGET_ITEM_ID = lb.ID;
                DisplayObject_BGT_B_DEPT_PAY_YEAR_FUND[] db = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(cb);
                if (db.Length > 0)
                {
                    isdelete = false;
                }
            }

            if(!isdelete)
                throw new Exception("选择的预算科目已存在预算数据，不允许删除");

            List<EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM> deleteDetailEntities1 = new List<EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM entity = new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
                    string id = gvList.DataKeys[row.RowIndex].Value.ToString();
                    entity.ID = id;
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities1.Add(entity);
                        }
                    }
                }
            }

            BizLogicMsg msg1 = BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Proxy.BatchDeleteEct(deleteDetailEntities1.ToArray());
            if (!msg1.Succeed)
                throw new Exception(msg1.Message);

            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

