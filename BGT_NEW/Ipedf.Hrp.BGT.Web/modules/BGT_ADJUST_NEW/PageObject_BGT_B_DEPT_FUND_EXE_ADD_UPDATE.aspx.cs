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
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceACCOUNT_ITEM_ID, typeof( BizLogicObject_BGT_D_ACCOUNT_ITEM),"ID","NAME");
			SetForeignKeyBinding(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID, typeof( BizLogicObject_BGT_D_ACCOUNT_ITEM),"ID","NAME");
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("预算科室不能为空");
        }
        protected override void RegisterGridEvent()
        {
            base.RegisterGridEvent();
            this.gvDetailList.RowDeleting += new GridViewDeleteEventHandler(gvDetailList_RowDeleting);
        }
        protected void gvDetailList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = gvDetailList.DataKeys[e.RowIndex].Value.ToString();
            if (string.IsNullOrEmpty(id))
            {
                gvDetailList.DeleteRow(e.RowIndex);
            }
            else
            {
                BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Delete(new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND { ID = id });
            }
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE).ID;
			dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
			list.AddRange((DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc
            this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            this.ddlInputDEPT_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            this.ddlInputDEPT_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            this.txtInputCODE.Text = "";
            this.txtInputFUND_MONEY.Text = "0.00";
            //hsc 附件上传
            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = "";
            upFiles.ReadOnly = true;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
				EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
										baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
					
					baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
					
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					baseEntity.CONTROL_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_FIXED.SelectedValue))
										baseEntity.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
					
								
                                        baseEntity.FUND_TYPE_ID = "BGT_000101";
					
					if(!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
					baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
					else
					baseEntity.FUND_MONEY = 0;
					baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_PERFORMANCE.SelectedValue))
										baseEntity.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);
					
									if(!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
										baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;//变更人
					baseEntity.CODE = txtInputCODE.Text;
									
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");
							//ComTextBox txtInputASSET_ID = (ComTextBox)row.FindControl("txtInputASSET_ID");
							ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
							ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");
							//ComTextBox txtInputAMOUNT = (ComTextBox)row.FindControl("txtInputAMOUNT");
							//ComTextBox txtInputPRICE = (ComTextBox)row.FindControl("txtInputPRICE");
							//ComTextBox txtInputCOMPLETE_TIME = (ComTextBox)row.FindControl("txtInputCOMPLETE_TIME");
							//ComTextBox txtInputASSET_NAME = (ComTextBox)row.FindControl("txtInputASSET_NAME");
							//ComTextBox txtInputBUILDING_NAME = (ComTextBox)row.FindControl("txtInputBUILDING_NAME");
							//ComBaseBox ddlInputACCOUNT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputACCOUNT_ITEM_ID");
							//ComBaseBox ddlInputBGT_D_ACCOUNT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputBGT_D_ACCOUNT_ITEM_ID");
							ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
							//ComTextBox txtInputFREE_FIELD3 = (ComTextBox)row.FindControl("txtInputFREE_FIELD3");
							//ComTextBox txtInputFREE_FIELD = (ComTextBox)row.FindControl("txtInputFREE_FIELD");
							//ComTextBox txtInputFREE_FIELD2 = (ComTextBox)row.FindControl("txtInputFREE_FIELD2");
							ComTextBox txtInputCONTROL_MONEY2 = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
					//detailEntity.ASSET_ID = txtInputASSET_ID.Text;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					detailEntity.MONEY = 0;
					detailEntity.FUND_NAME = txtInputFUND_NAME.Text;
                    //if(!string.IsNullOrEmpty(txtInputAMOUNT.Text))
                    //detailEntity.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
                    //else
                    //detailEntity.AMOUNT = 0;
                    //if(!string.IsNullOrEmpty(txtInputPRICE.Text))
                    //detailEntity.PRICE = decimal.Parse(txtInputPRICE.Text);
                    //else
                    //detailEntity.PRICE = 0;
                    //if(!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
                    //detailEntity.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
                    //else
                    //detailEntity.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;
                    //detailEntity.ASSET_NAME = txtInputASSET_NAME.Text;
                    //detailEntity.BUILDING_NAME = txtInputBUILDING_NAME.Text;
                    //                if(!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
                    //                    detailEntity.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
                    //                if(!string.IsNullOrEmpty(ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue))
                    //                    detailEntity.BGT_D_ACCOUNT_ITEM_ID = ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue;
					detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
                    //detailEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
                    //detailEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
                    //detailEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY2.Text))
					detailEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY2.Text);
					else
					detailEntity.CONTROL_MONEY = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
						try
						{
							BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
							if (!msg.Succeed)
					throw new Exception(msg.Message);
							ViewState["CUR_OBJ"] = baseEntity;
							PrepareDetailDataSourceControl(baseEntity.ID);
							ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
						}
						catch (Exception expt)
						{
							throw expt;
						}

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
						List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
						List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
						EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
										baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
					//baseEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
					//baseEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
					baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
					//baseEntity.NAME = txtInputNAME.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					baseEntity.CONTROL_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_FIXED.SelectedValue))
										baseEntity.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
                    //baseEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
                    //                if(!string.IsNullOrEmpty(ddlInputFUND_TYPE_ID.KeyValue))
                                    baseEntity.FUND_TYPE_ID = "BGT_000101";
					//baseEntity.REF_TAB_ID = txtInputREF_TAB_ID.Text;
					if(!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
					baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
					else
					baseEntity.FUND_MONEY = 0;
					baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_PERFORMANCE.SelectedValue))
										baseEntity.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);
                    //baseEntity.ITEM_NAME = txtInputITEM_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
										baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;
					baseEntity.CODE = txtInputCODE.Text;
									
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");
							//ComTextBox txtInputASSET_ID = (ComTextBox)row.FindControl("txtInputASSET_ID");
							ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
							ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");
							//ComTextBox txtInputAMOUNT = (ComTextBox)row.FindControl("txtInputAMOUNT");
							//ComTextBox txtInputPRICE = (ComTextBox)row.FindControl("txtInputPRICE");
							//ComTextBox txtInputCOMPLETE_TIME = (ComTextBox)row.FindControl("txtInputCOMPLETE_TIME");
							//ComTextBox txtInputASSET_NAME = (ComTextBox)row.FindControl("txtInputASSET_NAME");
							//ComTextBox txtInputBUILDING_NAME = (ComTextBox)row.FindControl("txtInputBUILDING_NAME");
							//ComBaseBox ddlInputACCOUNT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputACCOUNT_ITEM_ID");
							//ComBaseBox ddlInputBGT_D_ACCOUNT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputBGT_D_ACCOUNT_ITEM_ID");
							ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
							//ComTextBox txtInputFREE_FIELD3 = (ComTextBox)row.FindControl("txtInputFREE_FIELD3");
							//ComTextBox txtInputFREE_FIELD = (ComTextBox)row.FindControl("txtInputFREE_FIELD");
							//ComTextBox txtInputFREE_FIELD2 = (ComTextBox)row.FindControl("txtInputFREE_FIELD2");
							ComTextBox txtInputCONTROL_MONEY2 = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
					//detailEntity.ASSET_ID = txtInputASSET_ID.Text;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					detailEntity.MONEY = 0;
					detailEntity.FUND_NAME = txtInputFUND_NAME.Text;
                    //if(!string.IsNullOrEmpty(txtInputAMOUNT.Text))
                    //detailEntity.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
                    //else
                    //detailEntity.AMOUNT = 0;
                    //if(!string.IsNullOrEmpty(txtInputPRICE.Text))
                    //detailEntity.PRICE = decimal.Parse(txtInputPRICE.Text);
                    //else
                    //detailEntity.PRICE = 0;
                    //if(!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
                    //detailEntity.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
                    //else
                    //detailEntity.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;
                    //detailEntity.ASSET_NAME = txtInputASSET_NAME.Text;
                    //detailEntity.BUILDING_NAME = txtInputBUILDING_NAME.Text;
                    //                if(!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
                    //                    detailEntity.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
                    //                if(!string.IsNullOrEmpty(ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue))
                    //                    detailEntity.BGT_D_ACCOUNT_ITEM_ID = ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue;
					detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
                    //detailEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
                    //detailEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
                    //detailEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY2.Text))
					detailEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY2.Text);
					else
					detailEntity.CONTROL_MONEY = 0;
									if (detailEntity.ID == string.Empty)
									{
										//AuditAdd(detailEntity);
										saveDetailEntities.Add(detailEntity);
									}
									else
									{
										//AuditEdit(detailEntity);
										updateDetailEntities.Add(detailEntity);
									}
								}
								else
								{
									if (IsDeleteAble)
									{
										deleteDetailEntities.Add(detailEntity);
									}
								}								
							}
						}
						try
						{
							BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
							if (!msg.Succeed)
					throw new Exception(msg.Message);
							ShowEditState(baseEntity);
							PrepareDetailDataSourceControl(baseEntity.ID);
							ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
						}
						catch (Exception expt)
						{
							throw expt;
						}

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND entity = (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECLARE_CAUSE");
				txtInputDECLARE_CAUSE.Text = entity.DECLARE_CAUSE == null ? String.Empty: entity.DECLARE_CAUSE.ToString();
                //ComTextBox txtInputASSET_ID = (ComTextBox)e.Row.FindControl("txtInputASSET_ID");
                //txtInputASSET_ID.Text = entity.ASSET_ID == null ? String.Empty: entity.ASSET_ID.ToString();
				ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
				txtInputMONEY.Text = entity.MONEY == null ? "0": entity.MONEY.ToString();
				ComTextBox txtInputFUND_NAME = (ComTextBox)e.Row.FindControl("txtInputFUND_NAME");
				txtInputFUND_NAME.Text = entity.FUND_NAME == null ? String.Empty: entity.FUND_NAME.ToString();
                //ComTextBox txtInputAMOUNT = (ComTextBox)e.Row.FindControl("txtInputAMOUNT");
                //txtInputAMOUNT.Text = entity.AMOUNT == null ? "0": entity.AMOUNT.ToString();
                //ComTextBox txtInputPRICE = (ComTextBox)e.Row.FindControl("txtInputPRICE");
                //txtInputPRICE.Text = entity.PRICE == null ? "0": entity.PRICE.ToString();
                //ComTextBox txtInputCOMPLETE_TIME = (ComTextBox)e.Row.FindControl("txtInputCOMPLETE_TIME");
                //txtInputCOMPLETE_TIME.Text = entity.COMPLETE_TIME == null ? String.Empty: entity.COMPLETE_TIME.ToString();
                //ComTextBox txtInputASSET_NAME = (ComTextBox)e.Row.FindControl("txtInputASSET_NAME");
                //txtInputASSET_NAME.Text = entity.ASSET_NAME == null ? String.Empty: entity.ASSET_NAME.ToString();
                //ComTextBox txtInputBUILDING_NAME = (ComTextBox)e.Row.FindControl("txtInputBUILDING_NAME");
                //txtInputBUILDING_NAME.Text = entity.BUILDING_NAME == null ? String.Empty: entity.BUILDING_NAME.ToString();
                //ComBaseBox ddlInputACCOUNT_ITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputACCOUNT_ITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceACCOUNT_ITEM_ID,ref ddlInputACCOUNT_ITEM_ID, entity.ACCOUNT_ITEM_ID,"BGT_D_ACCOUNT_ITEM","ID","NAME");
                //ComBaseBox ddlInputBGT_D_ACCOUNT_ITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputBGT_D_ACCOUNT_ITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID,ref ddlInputBGT_D_ACCOUNT_ITEM_ID, entity.BGT_D_ACCOUNT_ITEM_ID,"BGT_D_ACCOUNT_ITEM","ID","NAME");
				ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
				txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA == null ? String.Empty: entity.FINANCE_IDEA.ToString();
                //ComTextBox txtInputFREE_FIELD3 = (ComTextBox)e.Row.FindControl("txtInputFREE_FIELD3");
                //txtInputFREE_FIELD3.Text = entity.FREE_FIELD3 == null ? String.Empty: entity.FREE_FIELD3.ToString();
                //ComTextBox txtInputFREE_FIELD = (ComTextBox)e.Row.FindControl("txtInputFREE_FIELD");
                //txtInputFREE_FIELD.Text = entity.FREE_FIELD == null ? String.Empty: entity.FREE_FIELD.ToString();
                //ComTextBox txtInputFREE_FIELD2 = (ComTextBox)e.Row.FindControl("txtInputFREE_FIELD2");
				//txtInputFREE_FIELD2.Text = entity.FREE_FIELD2 == null ? String.Empty: entity.FREE_FIELD2.ToString();
				ComTextBox txtInputCONTROL_MONEY = (ComTextBox)e.Row.FindControl("txtInputCONTROL_MONEY");
				txtInputCONTROL_MONEY.Text = entity.CONTROL_MONEY == null ? "0": entity.CONTROL_MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause = new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
            cause.FUND_TYPE_ID = "BGT_000101";
            if (!string.IsNullOrEmpty(this.ddlBUDGET_DEPT_ID.KeyValue))
            {
                cause.BUDGET_DEPT_ID = this.ddlBUDGET_DEPT_ID.KeyValue;
                gvResultList.Field_Value = "BUDGET_DEPT_ID";
                gvResultList.KeyValue = this.ddlBUDGET_DEPT_ID.KeyValue;
            }
            //  cause.SetCustomCondition(" and BGT_B_DEPT_PAY_YEAR_FUND.STATE !=1");
            //模拟标准查询
            return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause = JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE>(parameter);
            cause.FUND_TYPE_ID = "BGT_000101";
            if (!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
            {
                this.ddlBUDGET_DEPT_ID.KeyValue = cause.BUDGET_DEPT_ID;
                this.ddlBUDGET_DEPT_ID.NameValue = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT
                {
                    ID = cause.BUDGET_DEPT_ID
                }).NAME;
                gvResultList.Field_Value = "BUDGET_DEPT_ID";
                gvResultList.KeyValue = cause.BUDGET_DEPT_ID;
            }
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause = (CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Get(baseEntity);
                SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
				this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM(){ID = baseEntity.BGT_D_BUDGET_ITEM_ID}).NAME;
				this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
				
				this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty:baseEntity.DECALRE_CAUSE.ToString();
				
				this.txtInputCONTROL_MONEY.Text = baseEntity.CONTROL_MONEY == null ? string.Empty:baseEntity.CONTROL_MONEY.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_FIXED);
				//this.txtInputFREE_FIELD2.Text = baseEntity.FREE_FIELD2 == null ? string.Empty:baseEntity.FREE_FIELD2.ToString();
                this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc
				//this.txtInputREF_TAB_ID.Text = baseEntity.REF_TAB_ID == null ? string.Empty:baseEntity.REF_TAB_ID.ToString();
				this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY == null ? string.Empty:baseEntity.FUND_MONEY.ToString();
				this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? string.Empty:baseEntity.FINANCE_IDEA.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_PERFORMANCE);
				//this.txtInputITEM_NAME.Text = baseEntity.ITEM_NAME == null ? string.Empty:baseEntity.ITEM_NAME.ToString();
				this.ddlInputDEPT_USER_ID.KeyField = "ID";
				this.ddlInputDEPT_USER_ID.NameField = "NAME";
				this.ddlInputDEPT_USER_ID.KeyValue = baseEntity.DEPT_USER_ID;
				this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.DEPT_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.DEPT_USER_ID}).NAME;
				this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
			//	SetEnumReferenceSelected(this.ddlInputSTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.STATE);
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Submit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.UndoSubmit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Cancel(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE entity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
                    entity.ID = gvResultList.DataKeys[row.RowIndex].Value.ToString();
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
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                if (!msg.Succeed)
					throw new Exception(msg.Message);
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {
           
			CauseObject_BGT_D_ACCOUNT_ITEM cause721 =  new CauseObject_BGT_D_ACCOUNT_ITEM();
			cause721.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID from BGT_B_DEPT_PAY_YEAY_D_FUND where BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID = '" + id + "' group by BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceACCOUNT_ITEM_ID, typeof( BizLogicObject_BGT_D_ACCOUNT_ITEM),"ID","NAME",cause721);
			CauseObject_BGT_D_ACCOUNT_ITEM cause331 =  new CauseObject_BGT_D_ACCOUNT_ITEM();
			cause331.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID from BGT_B_DEPT_PAY_YEAY_D_FUND where BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID = '" + id + "' group by BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID, typeof( BizLogicObject_BGT_D_ACCOUNT_ITEM),"ID","NAME",cause331);
        }
    }
}

