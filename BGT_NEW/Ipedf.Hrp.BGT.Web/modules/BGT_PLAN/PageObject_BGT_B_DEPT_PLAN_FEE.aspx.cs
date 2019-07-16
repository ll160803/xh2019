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
    public partial class PageObject_BGT_B_DEPT_PLAN_FEE : ComNestingResourceEditPage
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
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("预算科室不能为空");
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_PLAN_FEE_D cause = new CauseObject_BGT_B_DEPT_PLAN_FEE_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE).ID;
			dataSource = BizLogicObject_BGT_B_DEPT_PLAN_FEE_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PLAN_FEE_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PLAN_FEE_D>();
			list.AddRange((DisplayObject_BGT_B_DEPT_PLAN_FEE_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PLAN_FEE_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_DEPT_PLAN_FEE_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetBusinessBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID);
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_PLAN_FEE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PLAN_FEE_D>();
				EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = new EntityObject_BGT_B_DEPT_PLAN_FEE();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PLAN_FEE_D detailEntity = new EntityObject_BGT_B_DEPT_PLAN_FEE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}

                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_PLAN_FEE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PLAN_FEE_D>();
						List<EntityObject_BGT_B_DEPT_PLAN_FEE_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_PLAN_FEE_D>();
						List<EntityObject_BGT_B_DEPT_PLAN_FEE_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PLAN_FEE_D>();
						EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PLAN_FEE_D detailEntity = new EntityObject_BGT_B_DEPT_PLAN_FEE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_DEPT_PLAN_FEE_D entity = (EntityObject_BGT_B_DEPT_PLAN_FEE_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
				txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_PLAN_FEE cause = new CauseObject_BGT_B_DEPT_PLAN_FEE();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_PLAN_FEE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PLAN_FEE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_PLAN_FEE cause = (CauseObject_BGT_B_DEPT_PLAN_FEE)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = new EntityObject_BGT_B_DEPT_PLAN_FEE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_PLAN_FEE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PLAN_FEE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_PLAN_FEE entity = new EntityObject_BGT_B_DEPT_PLAN_FEE();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PLAN_FEE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_B_DEPT_PLAN_FEE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PLAN_FEE;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_PLAN_FEE_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_DEPT_PLAN_FEE_D> dl = new List<EntityObject_BGT_B_DEPT_PLAN_FEE_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_DEPT_PLAN_FEE_D detailEntity = new EntityObject_BGT_B_DEPT_PLAN_FEE_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_DEPT_PLAN_FEE_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

