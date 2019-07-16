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
    public partial class PageObject_BGT_B_DEPT_YEAR_EXE : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME");
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameFieldAlias = "BUDGET_YEAR";
            List<FieldItem> List = new List<FieldItem>();
            List.Add(new FieldItem() { Field = "BUDGET_YEAR", Title = "预算年度", Width = 80 });
            this.ddlInputBUDGET_YEAR.FieldItems = List;
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			CauseObject_COM_TYPE cause282 =  new CauseObject_COM_TYPE();
			cause282.PARENT_ID = "0012";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause282);
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_YEAR_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_EXE_D>();
				EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = new EntityObject_BGT_B_DEPT_YEAR_EXE();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							ComTextBox txtInputITEM_FACT_VALUE = (ComTextBox)row.FindControl("txtInputITEM_FACT_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_YEAR_EXE_D detailEntity = new EntityObject_BGT_B_DEPT_YEAR_EXE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_FACT_VALUE.Text))
					detailEntity.ITEM_FACT_VALUE = decimal.Parse(txtInputITEM_FACT_VALUE.Text);
					else
					detailEntity.ITEM_FACT_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
						try
						{
							BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
							ViewState["CUR_OBJ"] = baseEntity;
							ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
						}
						catch (Exception expt)
						{
							throw expt;
						}

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_YEAR_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_EXE_D>();
						List<EntityObject_BGT_B_DEPT_YEAR_EXE_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_EXE_D>();
						List<EntityObject_BGT_B_DEPT_YEAR_EXE_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_EXE_D>();
						EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							ComTextBox txtInputITEM_FACT_VALUE = (ComTextBox)row.FindControl("txtInputITEM_FACT_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_YEAR_EXE_D detailEntity = new EntityObject_BGT_B_DEPT_YEAR_EXE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_FACT_VALUE.Text))
					detailEntity.ITEM_FACT_VALUE = decimal.Parse(txtInputITEM_FACT_VALUE.Text);
					else
					detailEntity.ITEM_FACT_VALUE = 0;
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
							BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
							ShowEditState(baseEntity);
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
                EntityObject_BGT_B_DEPT_YEAR_EXE_D entity = (EntityObject_BGT_B_DEPT_YEAR_EXE_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
                //ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
                //txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //ComTextBox txtInputITEM_FACT_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_FACT_VALUE");
                //txtInputITEM_FACT_VALUE.Text = entity.ITEM_FACT_VALUE == null ? "0": entity.ITEM_FACT_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_YEAR_EXE cause = new CauseObject_BGT_B_DEPT_YEAR_EXE();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_YEAR_EXE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_YEAR_EXE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_YEAR_EXE cause = (CauseObject_BGT_B_DEPT_YEAR_EXE)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = new EntityObject_BGT_B_DEPT_YEAR_EXE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_YEAR.KeyField = "ID";
                //this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
				this.ddlInputBUDGET_YEAR.KeyValue = baseEntity.BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_YEAR)?string.Empty: BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(new EntityObject_BGT_D_BUDGET_YEAR(){ID = baseEntity.BUDGET_YEAR}).BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
                this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
                this.ddlInputBUDGET_YEAR.NameFieldAlias = "BUDGET_YEAR";
                List<FieldItem> List = new List<FieldItem>();
                List.Add(new FieldItem() { Field = "BUDGET_YEAR", Title = "预算年度", Width = 80 });
                this.ddlInputBUDGET_YEAR.FieldItems = List;
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";

				CauseObject_COM_TYPE cause768 =  new CauseObject_COM_TYPE();
				cause768.PARENT_ID = "0012";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.BUDGET_CONTENTS_ID,"ID","NAME",cause768);
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_D_BUDGET_ITEM cause675 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause675.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_B_DEPT_YEAR_EXE_D.ITEM_ID from BGT_B_DEPT_YEAR_EXE_D where BGT_B_DEPT_YEAR_EXE_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_DEPT_YEAR_EXE_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause675);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_YEAR_EXE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_EXE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_YEAR_EXE entity = new EntityObject_BGT_B_DEPT_YEAR_EXE();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_EXE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

