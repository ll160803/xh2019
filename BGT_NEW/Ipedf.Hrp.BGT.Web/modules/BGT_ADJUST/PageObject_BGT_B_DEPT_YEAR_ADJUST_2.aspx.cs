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
    public partial class PageObject_BGT_B_DEPT_YEAR_ADJUST_2 : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlInputADJUST_ID.DataTable = "BGT_B_BUDGET_ADJUST";
            this.ddlInputADJUST_ID.NameField = "ADJUST_CODE";


            this.ddlInputADJUST_ID.Enabled = false;
            this.ddlInputBUDGET_DEPT_ID.Enabled = false;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D>();
				EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = new EntityObject_BGT_B_DEPT_YEAR_ADJUST();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputADJUST_ID.KeyValue))
										baseEntity.ADJUST_ID = ddlInputADJUST_ID.KeyValue;

                                    baseEntity.BUDGET_CONTENTS_ID = "00120002";//收入预算
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
                            //ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_YEAR_ADJUST_D detailEntity = new EntityObject_BGT_B_DEPT_YEAR_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);        
                ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D>();
						List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D>();
						List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_ADJUST_D>();
						EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputADJUST_ID.KeyValue))
										baseEntity.ADJUST_ID = ddlInputADJUST_ID.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
                            //ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_YEAR_ADJUST_D detailEntity = new EntityObject_BGT_B_DEPT_YEAR_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
                    detailEntity.SetNotUpdate("BUDGET_BASE", "ITEM_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_DEPT_YEAR_ADJUST_D entity = (EntityObject_BGT_B_DEPT_YEAR_ADJUST_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_PLAN_ITEM","ID","NAME");
				ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
				txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //ComTextBox txtInputBUDGET_BASE = (ComTextBox)e.Row.FindControl("txtInputBUDGET_BASE");
                //txtInputBUDGET_BASE.Text = entity.BUDGET_BASE == null ? "0": entity.BUDGET_BASE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_YEAR_ADJUST cause = new CauseObject_BGT_B_DEPT_YEAR_ADJUST();
            cause.BUDGET_CONTENTS_ID = "00120002";//收入预算
            cause.SetCustomCondition(" and BGT_B_BUDGET_ADJUST_ADJUST_ID.id in(select id from BGT_B_BUDGET_ADJUST t where BUDGET_YEAR in (select id from Bgt_d_Budget_Year where IS_AVAILABE =1))");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_YEAR_ADJUST>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_YEAR_ADJUST_2_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_YEAR_ADJUST cause = (CauseObject_BGT_B_DEPT_YEAR_ADJUST)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = new EntityObject_BGT_B_DEPT_YEAR_ADJUST();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputADJUST_ID.KeyField = "ID";
				this.ddlInputADJUST_ID.NameField = "ADJUST_CODE";
				this.ddlInputADJUST_ID.KeyValue = baseEntity.ADJUST_ID;
				this.ddlInputADJUST_ID.NameValue = string.IsNullOrEmpty(baseEntity.ADJUST_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Get(new EntityObject_BGT_B_BUDGET_ADJUST(){ID = baseEntity.ADJUST_ID}).ADJUST_CODE;
				this.ddlInputADJUST_ID.DataTable = "BGT_B_BUDGET_ADJUST";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_D_PLAN_ITEM cause154 =  new CauseObject_BGT_D_PLAN_ITEM();
			cause154.SetCustomCondition(" and BGT_D_PLAN_ITEM.ID in( select BGT_B_DEPT_YEAR_ADJUST_D.ITEM_ID from BGT_B_DEPT_YEAR_ADJUST_D where BGT_B_DEPT_YEAR_ADJUST_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_DEPT_YEAR_ADJUST_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_PLAN_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_PLAN_ITEM),"ID","NAME",cause154);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_YEAR_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_YEAR_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_YEAR_ADJUST> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_YEAR_ADJUST>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_YEAR_ADJUST entity = new EntityObject_BGT_B_DEPT_YEAR_ADJUST();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_YEAR_ADJUST.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

