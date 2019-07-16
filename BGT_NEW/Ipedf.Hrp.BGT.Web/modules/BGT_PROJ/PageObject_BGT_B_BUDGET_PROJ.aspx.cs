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
using Ipedf.Common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_BUDGET_PROJ : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetEnumReferenceBinding(ddlDataSourceIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            CauseObject_COM_TYPE cause423 = new CauseObject_COM_TYPE();
            cause423.PARENT_ID = "0030";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceSOURCE_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause423);
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_D cause = new CauseObject_BGT_B_BUDGET_PROJ_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ).ID;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_D>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_PROJ_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_PROJ_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_BUDGET_PROJ_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
			this.txtInputREPLY_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			CauseObject_COM_TYPE cause245 =  new CauseObject_COM_TYPE();
			cause245.PARENT_ID = "0029";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputBIZ_STATE, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause245);
			CauseObject_COM_TYPE cause411 =  new CauseObject_COM_TYPE();
			cause411.PARENT_ID = "0027";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause411);
			this.txtInputNAME.Text = string.Empty;
			this.txtInputPURPOSE.Text = string.Empty;
			this.ddlInputPROJ_USER_ID.DataTable = "COM_USER";
			this.txtInputPLAN_BEGIN_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			SetEnumReferenceBinding(this.ddlInputIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.txtInputAPPLY_MONEY.Text = "0.00";
			this.txtInputBACKDROP.Text = string.Empty;
			this.ddlInputREPLY_USER_ID.DataTable = "COM_USER";
			this.txtInputAPPLY_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputPLAN_END_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputCODE.Text = string.Empty;

            CauseObject_COM_TYPE cause412 = new CauseObject_COM_TYPE();
            cause412.PARENT_ID = "0028";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputNATURE_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause412);

			this.ddlInputFINANCE_USER_ID.DataTable = "COM_USER";
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_PROJ_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_D>();
				EntityObject_BGT_B_BUDGET_PROJ baseEntity = new EntityObject_BGT_B_BUDGET_PROJ();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										baseEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputREPLY_DATE.Text))
					baseEntity.REPLY_DATE = DateTime.Parse(txtInputREPLY_DATE.Text);
					else
					baseEntity.REPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputBIZ_STATE.SelectedValue))
										baseEntity.BIZ_STATE = ddlInputBIZ_STATE.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										baseEntity.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
					baseEntity.NAME = txtInputNAME.Text;
					baseEntity.PURPOSE = txtInputPURPOSE.Text;
									if(!string.IsNullOrEmpty(ddlInputPROJ_USER_ID.KeyValue))
										baseEntity.PROJ_USER_ID = ddlInputPROJ_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputPLAN_BEGIN_DATE.Text))
					baseEntity.PLAN_BEGIN_DATE = DateTime.Parse(txtInputPLAN_BEGIN_DATE.Text);
					else
					baseEntity.PLAN_BEGIN_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC.SelectedValue))
										baseEntity.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					baseEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					baseEntity.APPLY_MONEY = 0;
					baseEntity.BACKDROP = txtInputBACKDROP.Text;
									if(!string.IsNullOrEmpty(ddlInputREPLY_USER_ID.KeyValue))
										baseEntity.REPLY_USER_ID = ddlInputREPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					baseEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					baseEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputPLAN_END_DATE.Text))
					baseEntity.PLAN_END_DATE = DateTime.Parse(txtInputPLAN_END_DATE.Text);
					else
					baseEntity.PLAN_END_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputNATURE_ID.SelectedValue))
										baseEntity.NATURE_ID = ddlInputNATURE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputFINANCE_USER_ID.KeyValue))
										baseEntity.FINANCE_USER_ID = ddlInputFINANCE_USER_ID.KeyValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputNAME1 = (ComTextBox)row.FindControl("txtInputNAME");
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComDropDownList ddlInputIS_GOV_PROC1 = (ComDropDownList)row.FindControl("ddlInputIS_GOV_PROC");
							ComTextBox txtInputCODE1 = (ComTextBox)row.FindControl("txtInputCODE");
							ComTextBox txtInputBUDEGT_MONEY = (ComTextBox)row.FindControl("txtInputBUDEGT_MONEY");
                            //ComTextBox txtInputEXECUTED_MONEY = (ComTextBox)row.FindControl("txtInputEXECUTED_MONEY");
							ComTextBox txtInputAPPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
                            ComTextBox txtInputREPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputREPLY_MONEY");
                            //ComTextBox txtInputAPPLIED_MONEY = (ComTextBox)row.FindControl("txtInputAPPLIED_MONEY");
							ComDropDownList ddlInputSOURCE_ID = (ComDropDownList)row.FindControl("ddlInputSOURCE_ID");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.NAME = txtInputNAME1.Text;
                    detailEntity.ADJUST_TYPE_ID = "00310001";//默认为编制
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC1.SelectedValue))
										detailEntity.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC1.SelectedValue);
					detailEntity.CODE = txtInputCODE1.Text;
					if(!string.IsNullOrEmpty(txtInputBUDEGT_MONEY.Text))
					detailEntity.BUDEGT_MONEY = decimal.Parse(txtInputBUDEGT_MONEY.Text);
					else
					detailEntity.BUDEGT_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
                    //detailEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
                    //else
                    //detailEntity.EXECUTED_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY1.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY1.Text);
					else
					detailEntity.APPLY_MONEY = 0;

                    if (!string.IsNullOrEmpty(txtInputREPLY_MONEY1.Text))
                        detailEntity.REPLY_MONEY = decimal.Parse(txtInputREPLY_MONEY1.Text);
                    else
                        detailEntity.REPLY_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputAPPLIED_MONEY.Text))
                    //detailEntity.APPLIED_MONEY = decimal.Parse(txtInputAPPLIED_MONEY.Text);
                    //else
                    //detailEntity.APPLIED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_ID.SelectedValue))
										detailEntity.SOURCE_ID = ddlInputSOURCE_ID.SelectedValue;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        PrepareDetailDataSourceControl(baseEntity.ID);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_PROJ_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_D>();
						EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										baseEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputREPLY_DATE.Text))
					baseEntity.REPLY_DATE = DateTime.Parse(txtInputREPLY_DATE.Text);
					else
					baseEntity.REPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputBIZ_STATE.SelectedValue))
										baseEntity.BIZ_STATE = ddlInputBIZ_STATE.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										baseEntity.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
					baseEntity.NAME = txtInputNAME.Text;
					baseEntity.PURPOSE = txtInputPURPOSE.Text;
									if(!string.IsNullOrEmpty(ddlInputPROJ_USER_ID.KeyValue))
										baseEntity.PROJ_USER_ID = ddlInputPROJ_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputPLAN_BEGIN_DATE.Text))
					baseEntity.PLAN_BEGIN_DATE = DateTime.Parse(txtInputPLAN_BEGIN_DATE.Text);
					else
					baseEntity.PLAN_BEGIN_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC.SelectedValue))
										baseEntity.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC.SelectedValue);
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					baseEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					baseEntity.APPLY_MONEY = 0;
					baseEntity.BACKDROP = txtInputBACKDROP.Text;
									if(!string.IsNullOrEmpty(ddlInputREPLY_USER_ID.KeyValue))
										baseEntity.REPLY_USER_ID = ddlInputREPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					baseEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					baseEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputPLAN_END_DATE.Text))
					baseEntity.PLAN_END_DATE = DateTime.Parse(txtInputPLAN_END_DATE.Text);
					else
					baseEntity.PLAN_END_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputNATURE_ID.SelectedValue))
										baseEntity.NATURE_ID = ddlInputNATURE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputFINANCE_USER_ID.KeyValue))
										baseEntity.FINANCE_USER_ID = ddlInputFINANCE_USER_ID.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputNAME1 = (ComTextBox)row.FindControl("txtInputNAME");
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComDropDownList ddlInputIS_GOV_PROC1 = (ComDropDownList)row.FindControl("ddlInputIS_GOV_PROC");
							ComTextBox txtInputCODE1 = (ComTextBox)row.FindControl("txtInputCODE");
							ComTextBox txtInputBUDEGT_MONEY = (ComTextBox)row.FindControl("txtInputBUDEGT_MONEY");
                            //ComTextBox txtInputEXECUTED_MONEY = (ComTextBox)row.FindControl("txtInputEXECUTED_MONEY");
							ComTextBox txtInputAPPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
                            ComTextBox txtInputREPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputREPLY_MONEY");
                            //ComTextBox txtInputAPPLIED_MONEY = (ComTextBox)row.FindControl("txtInputAPPLIED_MONEY");
							ComDropDownList ddlInputSOURCE_ID = (ComDropDownList)row.FindControl("ddlInputSOURCE_ID");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.NAME = txtInputNAME1.Text;
                    detailEntity.ADJUST_TYPE_ID = "00310001";//默认为编制
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputIS_GOV_PROC1.SelectedValue))
										detailEntity.IS_GOV_PROC = decimal.Parse(ddlInputIS_GOV_PROC1.SelectedValue);
					detailEntity.CODE = txtInputCODE1.Text;
					if(!string.IsNullOrEmpty(txtInputBUDEGT_MONEY.Text))
					detailEntity.BUDEGT_MONEY = decimal.Parse(txtInputBUDEGT_MONEY.Text);
					else
					detailEntity.BUDEGT_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
                    //detailEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
                    //else
                    //detailEntity.EXECUTED_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY1.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY1.Text);
					else
					detailEntity.APPLY_MONEY = 0;

                    if (!string.IsNullOrEmpty(txtInputREPLY_MONEY1.Text))
                        detailEntity.REPLY_MONEY = decimal.Parse(txtInputREPLY_MONEY1.Text);
                    else
                        detailEntity.REPLY_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputAPPLIED_MONEY.Text))
                    //detailEntity.APPLIED_MONEY = decimal.Parse(txtInputAPPLIED_MONEY.Text);
                    //else
                    //detailEntity.APPLIED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputSOURCE_ID.SelectedValue))
										detailEntity.SOURCE_ID = ddlInputSOURCE_ID.SelectedValue;
                                    detailEntity.SetNotUpdate("EXECUTED_MONEY", "APPLIED_MONEY");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ShowEditState(baseEntity);
                        PrepareDetailDataSourceControl(baseEntity.ID);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_BUDGET_PROJ_D entity = (EntityObject_BGT_B_BUDGET_PROJ_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputNAME = (ComTextBox)e.Row.FindControl("txtInputNAME");
				txtInputNAME.Text = entity.NAME == null ? String.Empty: entity.NAME.ToString();
				ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
				CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
                ddlInputITEM_ID.Condition =" BGT_D_BUDGET_ITEM.is_end = 1 and BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005'";
				ComDropDownList ddlInputIS_GOV_PROC= (ComDropDownList)e.Row.FindControl("ddlInputIS_GOV_PROC");
				CopyComDropDownListItem(ddlDataSourceIS_GOV_PROC,ddlInputIS_GOV_PROC, entity.IS_GOV_PROC);
				ComTextBox txtInputCODE = (ComTextBox)e.Row.FindControl("txtInputCODE");
				txtInputCODE.Text = entity.CODE == null ? String.Empty: entity.CODE.ToString();
				ComTextBox txtInputBUDEGT_MONEY = (ComTextBox)e.Row.FindControl("txtInputBUDEGT_MONEY");
				txtInputBUDEGT_MONEY.Text = entity.BUDEGT_MONEY == null ? "0": entity.BUDEGT_MONEY.ToString();
                //ComTextBox txtInputEXECUTED_MONEY = (ComTextBox)e.Row.FindControl("txtInputEXECUTED_MONEY");
                //txtInputEXECUTED_MONEY.Text = entity.EXECUTED_MONEY == null ? "0": entity.EXECUTED_MONEY.ToString();
				ComTextBox txtInputAPPLY_MONEY = (ComTextBox)e.Row.FindControl("txtInputAPPLY_MONEY");
				txtInputAPPLY_MONEY.Text = entity.APPLY_MONEY == null ? "0": entity.APPLY_MONEY.ToString();
                ComTextBox txtInputREPLY_MONEY = (ComTextBox)e.Row.FindControl("txtInputREPLY_MONEY");
                txtInputREPLY_MONEY.Text = entity.REPLY_MONEY == null ? "0" : entity.REPLY_MONEY.ToString();
                
                //ComTextBox txtInputAPPLIED_MONEY = (ComTextBox)e.Row.FindControl("txtInputAPPLIED_MONEY");
                //txtInputAPPLIED_MONEY.Text = entity.APPLIED_MONEY == null ? "0": entity.APPLIED_MONEY.ToString();
				ComDropDownList ddlInputSOURCE_ID= (ComDropDownList)e.Row.FindControl("ddlInputSOURCE_ID");
				CopyComDropDownListItem(ddlDataSourceSOURCE_ID,ddlInputSOURCE_ID, entity.SOURCE_ID);
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
                RegisterSelectedScript(txtInputNAME, select);
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ cause = new CauseObject_BGT_B_BUDGET_PROJ();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ cause = (CauseObject_BGT_B_BUDGET_PROJ)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ baseEntity = new EntityObject_BGT_B_BUDGET_PROJ();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
				this.ddlInputAPPLY_USER_ID.KeyField = "ID";
				this.ddlInputAPPLY_USER_ID.NameField = "NAME";
				this.ddlInputAPPLY_USER_ID.KeyValue = baseEntity.APPLY_USER_ID;
				this.ddlInputAPPLY_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.APPLY_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.APPLY_USER_ID}).NAME;
				this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
				this.txtInputREPLY_DATE.Text = baseEntity.REPLY_DATE == null ? string.Empty:baseEntity.REPLY_DATE.ToString();
				CauseObject_COM_TYPE cause648 =  new CauseObject_COM_TYPE();
				cause648.PARENT_ID = "0029";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputBIZ_STATE, typeof( BizLogicObject_COM_TYPE), baseEntity.BIZ_STATE,"ID","NAME",cause648);
				CauseObject_COM_TYPE cause114 =  new CauseObject_COM_TYPE();
				cause114.PARENT_ID = "0027";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputTYPE_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.TYPE_ID,"ID","NAME",cause114);
                CauseObject_COM_TYPE cause115 = new CauseObject_COM_TYPE();
                cause115.PARENT_ID = "0028";
                SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputNATURE_ID, typeof(BizLogicObject_COM_TYPE), baseEntity.NATURE_ID, "ID", "NAME", cause115);
				this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
				this.txtInputPURPOSE.Text = baseEntity.PURPOSE == null ? string.Empty:baseEntity.PURPOSE.ToString();
				this.ddlInputPROJ_USER_ID.KeyField = "ID";
				this.ddlInputPROJ_USER_ID.NameField = "NAME";
				this.ddlInputPROJ_USER_ID.KeyValue = baseEntity.PROJ_USER_ID;
				this.ddlInputPROJ_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.PROJ_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.PROJ_USER_ID}).NAME;
				this.ddlInputPROJ_USER_ID.DataTable = "COM_USER";
				this.txtInputPLAN_BEGIN_DATE.Text = baseEntity.PLAN_BEGIN_DATE == null ? string.Empty:baseEntity.PLAN_BEGIN_DATE.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_GOV_PROC, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_GOV_PROC);
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.txtInputAPPLY_MONEY.Text = baseEntity.APPLY_MONEY == null ? string.Empty:baseEntity.APPLY_MONEY.ToString();
                this.txtInputREPLY_MONEY.Text = baseEntity.REPLY_MONEY == null ? string.Empty : baseEntity.REPLY_MONEY.ToString();
				this.txtInputBACKDROP.Text = baseEntity.BACKDROP == null ? string.Empty:baseEntity.BACKDROP.ToString();
				this.ddlInputREPLY_USER_ID.KeyField = "ID";
				this.ddlInputREPLY_USER_ID.NameField = "NAME";
				this.ddlInputREPLY_USER_ID.KeyValue = baseEntity.REPLY_USER_ID;
				this.ddlInputREPLY_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.REPLY_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.REPLY_USER_ID}).NAME;
				this.ddlInputREPLY_USER_ID.DataTable = "COM_USER";
				this.txtInputAPPLY_DATE.Text = baseEntity.APPLY_DATE == null ? string.Empty:baseEntity.APPLY_DATE.ToString();
				this.txtInputPLAN_END_DATE.Text = baseEntity.PLAN_END_DATE == null ? string.Empty:baseEntity.PLAN_END_DATE.ToString();
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
				
				this.ddlInputFINANCE_USER_ID.KeyField = "ID";
				this.ddlInputFINANCE_USER_ID.NameField = "NAME";
				this.ddlInputFINANCE_USER_ID.KeyValue = baseEntity.FINANCE_USER_ID;
				this.ddlInputFINANCE_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.FINANCE_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.FINANCE_USER_ID}).NAME;
				this.ddlInputFINANCE_USER_ID.DataTable = "COM_USER";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity;
                PrepareDetailDataSourceControl(baseEntity.ID);
           
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {
            CauseObject_BGT_D_BUDGET_ITEM cause415 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause415.SetCustomCondition(" and BGT_D_BUDGET_ITEM.is_end = 1 and BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005' and   BGT_D_BUDGET_ITEM.ID in( select BGT_B_BUDGET_PROJ_D.ITEM_ID from BGT_B_BUDGET_PROJ_D where BGT_B_BUDGET_PROJ_D.BASE_ID = '" + id + "' group by BGT_B_BUDGET_PROJ_D.ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause415);

            CauseObject_COM_TYPE cause321 = new CauseObject_COM_TYPE();
            cause321.PARENT_ID = "0030";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceSOURCE_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause321);
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ entity = new EntityObject_BGT_B_BUDGET_PROJ();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

