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
    public partial class PageObject_BGT_B_BUDGET_PROJ_EXE : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_B_BUDGET_PROJ_D),"ID","NAME");
			SetForeignKeyBinding(ddlDataSourceAPPLY_USER_ID, typeof( BizLogicObject_COM_USER),"ID","NAME");
			SetForeignKeyBinding(ddlDataSourceEXECUTE_MONTH_ID, typeof( BizLogicObject_BGT_D_BUDGET_MONTH),"ID","BUDGET_MONTH");
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause = new CauseObject_BGT_B_BUDGET_PROJ_EXE_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE).ID;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_EXE_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_EXE_D>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_PROJ_EXE_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_BUDGET_PROJ_EXE_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
            this.ddlInputPROJECT_ID.Condition = "  BGT_B_BUDGET_PROJ.BIZ_STATE = '00290001' and BGT_B_BUDGET_PROJ.STATE = '3'";
            this.ddlInputBUDGET_YEAR.Text = "...";
            //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //this.txtInputCREATE_DEPT_ID.Text = string.Empty;
            //this.txtInputMODIFY_DEPT_ID.Text = string.Empty;
            //this.txtInputCOMMENTS.Text = string.Empty;
            this.ddlInputAPPLY_MONEY.Text = "0";
            this.ddlInputEXECUTE_MONEY.Text = "0";
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
				EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_EXE();
						
									//平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
                {
                    baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
                    EntityObject_BGT_D_BUDGET_YEAR year = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.GetRecentlyBudgetYear(baseEntity.PROJECT_ID);
                    baseEntity.BUDGET_YEAR = year.ID;
                }
                                    
                                    //if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                                    //    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                    //baseEntity.CREATE_DEPT_ID = txtInputCREATE_DEPT_ID.Text;
                    //baseEntity.MODIFY_DEPT_ID = txtInputMODIFY_DEPT_ID.Text;
                    //baseEntity.COMMENTS = txtInputCOMMENTS.Text;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputINVOICE_CODE = (ComTextBox)row.FindControl("txtInputINVOICE_CODE");
							ComBaseBox ddlInputAPPLY_USER_ID = (ComBaseBox)row.FindControl("ddlInputAPPLY_USER_ID");
							ComTextBox txtInputEXECUTE_DATE = (ComTextBox)row.FindControl("txtInputEXECUTE_DATE");
							ComTextBox txtInputEXECUTE_MONEY = (ComTextBox)row.FindControl("txtInputEXECUTE_MONEY");
							ComDropDownList ddlInputEXECUTE_MONTH_ID = (ComDropDownList)row.FindControl("ddlInputEXECUTE_MONTH_ID");
							ComTextBox txtInputAPPLY_DATE = (ComTextBox)row.FindControl("txtInputAPPLY_DATE");
							ComTextBox txtInputAPPLY_MONEY = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_EXE_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.INVOICE_CODE = txtInputINVOICE_CODE.Text;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										detailEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_DATE.Text))
					detailEntity.EXECUTE_DATE = DateTime.Parse(txtInputEXECUTE_DATE.Text);
					else
					detailEntity.EXECUTE_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_MONEY.Text))
					detailEntity.EXECUTE_MONEY = decimal.Parse(txtInputEXECUTE_MONEY.Text);
					else
					detailEntity.EXECUTE_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputEXECUTE_MONTH_ID.SelectedValue))
										detailEntity.EXECUTE_MONTH_ID = ddlInputEXECUTE_MONTH_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					detailEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					detailEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					detailEntity.APPLY_MONEY = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
						EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
						
									//平台自动生成代码
                        if (!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
                        {
                            baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
                            EntityObject_BGT_D_BUDGET_YEAR year = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.GetRecentlyBudgetYear(baseEntity.PROJECT_ID);
                            baseEntity.BUDGET_YEAR = year.ID;
                        }
                                    //if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                                    //    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                    //baseEntity.CREATE_DEPT_ID = txtInputCREATE_DEPT_ID.Text;
                    //baseEntity.MODIFY_DEPT_ID = txtInputMODIFY_DEPT_ID.Text;
                    //baseEntity.COMMENTS = txtInputCOMMENTS.Text;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputINVOICE_CODE = (ComTextBox)row.FindControl("txtInputINVOICE_CODE");
							ComBaseBox ddlInputAPPLY_USER_ID = (ComBaseBox)row.FindControl("ddlInputAPPLY_USER_ID");
							ComTextBox txtInputEXECUTE_DATE = (ComTextBox)row.FindControl("txtInputEXECUTE_DATE");
							ComTextBox txtInputEXECUTE_MONEY = (ComTextBox)row.FindControl("txtInputEXECUTE_MONEY");
							ComDropDownList ddlInputEXECUTE_MONTH_ID = (ComDropDownList)row.FindControl("ddlInputEXECUTE_MONTH_ID");
							ComTextBox txtInputAPPLY_DATE = (ComTextBox)row.FindControl("txtInputAPPLY_DATE");
							ComTextBox txtInputAPPLY_MONEY = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_EXE_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.INVOICE_CODE = txtInputINVOICE_CODE.Text;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										detailEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_DATE.Text))
					detailEntity.EXECUTE_DATE = DateTime.Parse(txtInputEXECUTE_DATE.Text);
					else
					detailEntity.EXECUTE_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_MONEY.Text))
					detailEntity.EXECUTE_MONEY = decimal.Parse(txtInputEXECUTE_MONEY.Text);
					else
					detailEntity.EXECUTE_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputEXECUTE_MONTH_ID.SelectedValue))
										detailEntity.EXECUTE_MONTH_ID = ddlInputEXECUTE_MONTH_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					detailEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					detailEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					detailEntity.APPLY_MONEY = 0;
									if (detailEntity.ID == string.Empty)
									{
										//AuditAdd(detailEntity);
										saveDetailEntities.Add(detailEntity);
									}
									else
									{
										detailEntity.SetNotUpdate("ITEM_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ShowEditState(baseEntity);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_BUDGET_PROJ_EXE_D entity = (EntityObject_BGT_B_BUDGET_PROJ_EXE_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputINVOICE_CODE = (ComTextBox)e.Row.FindControl("txtInputINVOICE_CODE");
				txtInputINVOICE_CODE.Text = entity.INVOICE_CODE == null ? String.Empty: entity.INVOICE_CODE.ToString();
				ComBaseBox ddlInputAPPLY_USER_ID= (ComBaseBox)e.Row.FindControl("ddlInputAPPLY_USER_ID");
				CopyComDropDownListItem(ddlDataSourceAPPLY_USER_ID,ref ddlInputAPPLY_USER_ID, entity.APPLY_USER_ID,"COM_USER","ID","NAME");
				ComTextBox txtInputEXECUTE_DATE = (ComTextBox)e.Row.FindControl("txtInputEXECUTE_DATE");
				txtInputEXECUTE_DATE.Text = entity.EXECUTE_DATE == null ? String.Empty: entity.EXECUTE_DATE.ToString();
				ComTextBox txtInputEXECUTE_MONEY = (ComTextBox)e.Row.FindControl("txtInputEXECUTE_MONEY");
				txtInputEXECUTE_MONEY.Text = entity.EXECUTE_MONEY == null ? "0": entity.EXECUTE_MONEY.ToString();
				ComDropDownList ddlInputEXECUTE_MONTH_ID= (ComDropDownList)e.Row.FindControl("ddlInputEXECUTE_MONTH_ID");
				CopyComDropDownListItem(ddlDataSourceEXECUTE_MONTH_ID,ddlInputEXECUTE_MONTH_ID, entity.EXECUTE_MONTH_ID);
				ComTextBox txtInputAPPLY_DATE = (ComTextBox)e.Row.FindControl("txtInputAPPLY_DATE");
				txtInputAPPLY_DATE.Text = entity.APPLY_DATE == null ? String.Empty: entity.APPLY_DATE.ToString();
				ComTextBox txtInputAPPLY_MONEY = (ComTextBox)e.Row.FindControl("txtInputAPPLY_MONEY");
				txtInputAPPLY_MONEY.Text = entity.APPLY_MONEY == null ? "0": entity.APPLY_MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_EXE cause = new CauseObject_BGT_B_BUDGET_PROJ_EXE();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_EXE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_EXE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_EXE cause = (CauseObject_BGT_B_BUDGET_PROJ_EXE)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_EXE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Get(baseEntity);
				this.ddlInputPROJECT_ID.KeyField = "ID";
				this.ddlInputPROJECT_ID.NameField = "NAME";
				this.ddlInputPROJECT_ID.KeyValue = baseEntity.PROJECT_ID;
				this.ddlInputPROJECT_ID.NameValue = string.IsNullOrEmpty(baseEntity.PROJECT_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Get(new EntityObject_BGT_B_BUDGET_PROJ(){ID = baseEntity.PROJECT_ID}).NAME;
				this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
                this.ddlInputPROJECT_ID.Condition = "  BGT_B_BUDGET_PROJ.BIZ_STATE = '00290001' and BGT_B_BUDGET_PROJ.STATE = '3'";
                //SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
                EntityObject_BGT_D_BUDGET_YEAR year = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.GetRecentlyBudgetYear(baseEntity.PROJECT_ID);
                this.ddlInputBUDGET_YEAR.Text  = year.BUDGET_YEAR;
                this.ddlInputAPPLY_MONEY.Text = baseEntity.APPLY_MONEY.ToString();
                this.ddlInputEXECUTE_MONEY.Text = baseEntity.EXECUTE_MONEY.ToString();
                //this.txtInputCREATE_DEPT_ID.Text = baseEntity.CREATE_DEPT_ID == null ? string.Empty:baseEntity.CREATE_DEPT_ID.ToString();
                //this.txtInputMODIFY_DEPT_ID.Text = baseEntity.MODIFY_DEPT_ID == null ? string.Empty:baseEntity.MODIFY_DEPT_ID.ToString();
                //this.txtInputCOMMENTS.Text = baseEntity.COMMENTS == null ? string.Empty:baseEntity.COMMENTS.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_COM_USER cause327 =  new CauseObject_COM_USER();
			cause327.SetCustomCondition(" and COM_USER.ID in( select BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID from BGT_B_BUDGET_PROJ_EXE_D where BGT_B_BUDGET_PROJ_EXE_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID )");
			SetForeignKeyBinding<CauseObject_COM_USER>(ddlDataSourceAPPLY_USER_ID, typeof( BizLogicObject_COM_USER),"ID","NAME",cause327);
			SetForeignKeyBinding(ddlDataSourceEXECUTE_MONTH_ID, typeof( BizLogicObject_BGT_D_BUDGET_MONTH),"ID","BUDGET_MONTH");
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_EXE> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_EXE entity = new EntityObject_BGT_B_BUDGET_PROJ_EXE();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                ShowData();
            }  
            
        }
        protected override void OnResourceAppend(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ddlInputPROJECT_ID.KeyValue))
            {
                WebControlHelper.ShowAlert(this,"请选择预算项目");
                return;
            }
            EntityObject_BGT_B_BUDGET_PROJ_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
            parameters.Add("projectid", baseEntity.PROJECT_ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_EXE_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> dl = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_BUDGET_PROJ_EXE_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

