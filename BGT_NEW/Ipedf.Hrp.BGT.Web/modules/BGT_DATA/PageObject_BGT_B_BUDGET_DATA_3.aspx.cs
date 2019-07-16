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
    public partial class PageObject_BGT_B_BUDGET_DATA_3 : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            btnUndoSubmit.Enabled = command[Ipedf.Web.Control.ButtonType.Audit].Visible;
            btnUndoSubmit.Attributes.Add("onclick", "return confirm('确定要打回吗?');");
            //此界面的打回提交始终禁用
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Visible = false;
            this.command[Ipedf.Web.Control.ButtonType.UndoSubmit].Enabled = false;
        }
        protected override void PrepareCause()
        {
			
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
			this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameFieldAlias = "BUDGET_YEAR";
            List<FieldItem> List = new List<FieldItem>();
            List.Add(new FieldItem() { Field = "BUDGET_YEAR", Title = "预算年度", Width = 80 });
            this.ddlInputBUDGET_YEAR.FieldItems = List;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_DATA_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_D>();
				EntityObject_BGT_B_BUDGET_DATA baseEntity = new EntityObject_BGT_B_BUDGET_DATA();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_ID.KeyValue))
										baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
                            //ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_DATA_D detailEntity = new EntityObject_BGT_B_BUDGET_DATA_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
                    //detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
                    //else
                    //detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_DATA_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_D>();
						List<EntityObject_BGT_B_BUDGET_DATA_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_D>();
						List<EntityObject_BGT_B_BUDGET_DATA_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_D>();
						EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_ID.KeyValue))
										baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
                            //ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_DATA_D detailEntity = new EntityObject_BGT_B_BUDGET_DATA_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
                    //detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
                    //else
                    //detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                //EntityObject_BGT_B_BUDGET_DATA_D entity = (EntityObject_BGT_B_BUDGET_DATA_D)e.Row.DataItem;
                //CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                //select.Checked = entity.ID != string.Empty;
                
                //ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
                //txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //ComTextBox txtInputBUDGET_BASE = (ComTextBox)e.Row.FindControl("txtInputBUDGET_BASE");
                //txtInputBUDGET_BASE.Text = entity.BUDGET_BASE == null ? "0": entity.BUDGET_BASE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_DATA cause = new CauseObject_BGT_B_BUDGET_DATA();
            cause.BUDGET_CONTENTS_ID = "00120003";//支出预算
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_DATA>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_DATA_3_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_DATA cause = (CauseObject_BGT_B_BUDGET_DATA)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_DATA baseEntity = new EntityObject_BGT_B_BUDGET_DATA();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Get(baseEntity);
				this.ddlInputTEMPLET_ID.KeyField = "ID";
				this.ddlInputTEMPLET_ID.NameField = "NAME";
				this.ddlInputTEMPLET_ID.KeyValue = baseEntity.TEMPLET_ID;
				this.ddlInputTEMPLET_ID.NameValue = string.IsNullOrEmpty(baseEntity.TEMPLET_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_T.Proxy.Get(new EntityObject_BGT_D_BUDGET_T(){ID = baseEntity.TEMPLET_ID}).NAME;
				this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
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
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_DATA.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_DATA baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_DATA> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_DATA entity = new EntityObject_BGT_B_BUDGET_DATA();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_DATA.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

