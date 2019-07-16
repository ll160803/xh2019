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
    public partial class PageObject_BGT_D_BUDGET_T_CPN_I_plan : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME");
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_T_CPN_I_D cause = new CauseObject_BGT_D_BUDGET_T_CPN_I_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I).ID;
			dataSource = BizLogicObject_BGT_D_BUDGET_T_CPN_I_D.Proxy.Query2(cause);
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_T_CPN_I_D> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_T_CPN_I_D>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_T_CPN_I_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_T_CPN_I_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_D_BUDGET_T_CPN_I_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_D_BUDGET_T_CPN_I_D> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_CPN_I_D>();
				EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = new EntityObject_BGT_D_BUDGET_T_CPN_I();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComTextBox txtInputBUDGET_YEAR_VALUE = (ComTextBox)row.FindControl("txtInputBUDGET_YEAR_VALUE");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                            ComTextBox txtInputINCREASE_SCALE = (ComTextBox)row.FindControl("txtInputINCREASE_SCALE");
							//ComTextBox txtInputLAST_YEAR_VALUE = (ComTextBox)row.FindControl("txtInputLAST_YEAR_VALUE");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_CPN_I_D detailEntity = new EntityObject_BGT_D_BUDGET_T_CPN_I_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_YEAR_VALUE.Text))
                    //detailEntity.BUDGET_YEAR_VALUE = decimal.Parse(txtInputBUDGET_YEAR_VALUE.Text);
                    //else
                    //detailEntity.BUDGET_YEAR_VALUE = 0;
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputINCREASE_SCALE.Text))
					detailEntity.INCREASE_SCALE = decimal.Parse(txtInputINCREASE_SCALE.Text);
					else
					detailEntity.INCREASE_SCALE = 0;
                    //if(!string.IsNullOrEmpty(txtInputLAST_YEAR_VALUE.Text))
                    //detailEntity.LAST_YEAR_VALUE = decimal.Parse(txtInputLAST_YEAR_VALUE.Text);
                    //else
                    //detailEntity.LAST_YEAR_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        PrepareDetailDataSourceControl(baseEntity.ID);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_D_BUDGET_T_CPN_I_D> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_CPN_I_D>();
						List<EntityObject_BGT_D_BUDGET_T_CPN_I_D> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_CPN_I_D>();
						List<EntityObject_BGT_D_BUDGET_T_CPN_I_D> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_CPN_I_D>();
						EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
				
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComTextBox txtInputBUDGET_YEAR_VALUE = (ComTextBox)row.FindControl("txtInputBUDGET_YEAR_VALUE");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputINCREASE_SCALE = (ComTextBox)row.FindControl("txtInputINCREASE_SCALE");
                            //ComTextBox txtInputLAST_YEAR_VALUE = (ComTextBox)row.FindControl("txtInputLAST_YEAR_VALUE");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_CPN_I_D detailEntity = new EntityObject_BGT_D_BUDGET_T_CPN_I_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_YEAR_VALUE.Text))
                    //detailEntity.BUDGET_YEAR_VALUE = decimal.Parse(txtInputBUDGET_YEAR_VALUE.Text);
                    //else
                    //detailEntity.BUDGET_YEAR_VALUE = 0;
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputINCREASE_SCALE.Text))
					detailEntity.INCREASE_SCALE = decimal.Parse(txtInputINCREASE_SCALE.Text);
					else
					detailEntity.INCREASE_SCALE = 0;
                    //if(!string.IsNullOrEmpty(txtInputLAST_YEAR_VALUE.Text))
                    //detailEntity.LAST_YEAR_VALUE = decimal.Parse(txtInputLAST_YEAR_VALUE.Text);
                    //else
                    //detailEntity.LAST_YEAR_VALUE = 0;
                    detailEntity.SetUpdate("INCREASE_SCALE");
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
                                    //if (IsDeleteAble)
                                    //{
                                    //    deleteDetailEntities.Add(detailEntity);
                                    //}
								}								
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_D_BUDGET_T_CPN_I_D entity = (EntityObject_BGT_D_BUDGET_T_CPN_I_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComTextBox txtInputBUDGET_YEAR_VALUE = (ComTextBox)e.Row.FindControl("txtInputBUDGET_YEAR_VALUE");
                //txtInputBUDGET_YEAR_VALUE.Text = entity.BUDGET_YEAR_VALUE == null ? "0": entity.BUDGET_YEAR_VALUE.ToString();
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
				ComTextBox txtInputINCREASE_SCALE = (ComTextBox)e.Row.FindControl("txtInputINCREASE_SCALE");
				txtInputINCREASE_SCALE.Text = entity.INCREASE_SCALE == null ? "0": entity.INCREASE_SCALE.ToString();
                //ComTextBox txtInputLAST_YEAR_VALUE = (ComTextBox)e.Row.FindControl("txtInputLAST_YEAR_VALUE");
                //txtInputLAST_YEAR_VALUE.Text = entity.LAST_YEAR_VALUE == null ? "0": entity.LAST_YEAR_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T_CPN_I cause = new CauseObject_BGT_D_BUDGET_T_CPN_I();
            cause.BUDGET_CONTENTS_ID = "00120001";//计划指标
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_T_CPN_I>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_T_CPN_I_plan_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_T_CPN_I cause = (CauseObject_BGT_D_BUDGET_T_CPN_I)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = new EntityObject_BGT_D_BUDGET_T_CPN_I();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_YEAR.KeyField = "ID";
				this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
				this.ddlInputBUDGET_YEAR.KeyValue = baseEntity.BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_YEAR)?string.Empty: BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(new EntityObject_BGT_D_BUDGET_YEAR(){ID = baseEntity.BUDGET_YEAR}).BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Submit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.UndoSubmit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Cancel(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_CPN_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_CPN_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_T_CPN_I> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_CPN_I>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_T_CPN_I entity = new EntityObject_BGT_D_BUDGET_T_CPN_I();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_CPN_I.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                ShowData();
            }  
            
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {
           
			CauseObject_BGT_D_BUDGET_ITEM cause452 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause452.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_D_BUDGET_T_CPN_I_D.ITEM_ID from BGT_D_BUDGET_T_CPN_I_D where BGT_D_BUDGET_T_CPN_I_D.BASE_ID = '" + id + "' group by BGT_D_BUDGET_T_CPN_I_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause452);
        }
    }
}

