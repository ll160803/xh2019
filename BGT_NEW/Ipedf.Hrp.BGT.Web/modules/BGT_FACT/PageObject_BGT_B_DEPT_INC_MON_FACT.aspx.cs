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
    public partial class PageObject_BGT_B_DEPT_INC_MON_FACT : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            command[Ipedf.Web.Control.ButtonType.Custom].Text = "生成";
            command[Ipedf.Web.Control.ButtonType.Custom].Enabled = command[Ipedf.Web.Control.ButtonType.Save].Enabled;
            command[Ipedf.Web.Control.ButtonType.Custom].Visible = command[Ipedf.Web.Control.ButtonType.Save].Visible;
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("核销科室不能为空");
        }  
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME");
			CauseObject_COM_TYPE cause521 =  new CauseObject_COM_TYPE();
			cause521.PARENT_ID = "0015";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause521);
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetBusinessBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID);
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
			this.txtInputFINANCE_CYCLE.Text = string.Empty;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D>();
				EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = new EntityObject_BGT_B_DEPT_INC_MON_FACT();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					baseEntity.FINANCE_CYCLE = txtInputFINANCE_CYCLE.Text;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputSOURCE_TYPE_ID = (ComDropDownList)row.FindControl("ddlInputSOURCE_TYPE_ID");
							ComTextBox txtInputFACT_VALUE = (ComTextBox)row.FindControl("txtInputFACT_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_INC_MON_FACT_D detailEntity = new EntityObject_BGT_B_DEPT_INC_MON_FACT_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										detailEntity.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputFACT_VALUE.Text))
					detailEntity.FACT_VALUE = decimal.Parse(txtInputFACT_VALUE.Text);
					else
					detailEntity.FACT_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D>();
						List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D>();
						List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D>();
						EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					baseEntity.FINANCE_CYCLE = txtInputFINANCE_CYCLE.Text;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputSOURCE_TYPE_ID = (ComDropDownList)row.FindControl("ddlInputSOURCE_TYPE_ID");
							ComTextBox txtInputFACT_VALUE = (ComTextBox)row.FindControl("txtInputFACT_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_INC_MON_FACT_D detailEntity = new EntityObject_BGT_B_DEPT_INC_MON_FACT_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputSOURCE_TYPE_ID.SelectedValue))
										detailEntity.SOURCE_TYPE_ID = ddlInputSOURCE_TYPE_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputFACT_VALUE.Text))
					detailEntity.FACT_VALUE = decimal.Parse(txtInputFACT_VALUE.Text);
					else
					detailEntity.FACT_VALUE = 0;
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_DEPT_INC_MON_FACT_D entity = (EntityObject_BGT_B_DEPT_INC_MON_FACT_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComDropDownList ddlInputSOURCE_TYPE_ID= (ComDropDownList)e.Row.FindControl("ddlInputSOURCE_TYPE_ID");
				CopyComDropDownListItem(ddlDataSourceSOURCE_TYPE_ID,ddlInputSOURCE_TYPE_ID, entity.SOURCE_TYPE_ID);
				ComTextBox txtInputFACT_VALUE = (ComTextBox)e.Row.FindControl("txtInputFACT_VALUE");
				txtInputFACT_VALUE.Text = entity.FACT_VALUE == null ? "0": entity.FACT_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_INC_MON_FACT cause = new CauseObject_BGT_B_DEPT_INC_MON_FACT();
            cause.SetCustomCondition(" and  substr(BGT_B_DEPT_INC_MON_FACT.FINANCE_CYCLE,1,4) in (select budget_year from BGT_D_BUDGET_YEAR where IS_AVAILABE = 1)");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_INC_MON_FACT>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_INC_MON_FACT_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_INC_MON_FACT cause = (CauseObject_BGT_B_DEPT_INC_MON_FACT)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = new EntityObject_BGT_B_DEPT_INC_MON_FACT();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.txtInputFINANCE_CYCLE.Text = baseEntity.FINANCE_CYCLE == null ? string.Empty:baseEntity.FINANCE_CYCLE.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_COM_TYPE cause517 =  new CauseObject_COM_TYPE();
			cause517.PARENT_ID = "0015";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceSOURCE_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause517);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_INC_MON_FACT> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_INC_MON_FACT entity = new EntityObject_BGT_B_DEPT_INC_MON_FACT();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_INC_MON_FACT.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_B_DEPT_INC_MON_FACT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_INC_MON_FACT;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_INC_MON_FACT_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D> dl = new List<EntityObject_BGT_B_DEPT_INC_MON_FACT_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_DEPT_INC_MON_FACT_D detailEntity = new EntityObject_BGT_B_DEPT_INC_MON_FACT_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_DEPT_INC_MON_FACT_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

