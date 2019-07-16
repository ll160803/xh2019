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
    public partial class PageObject_BGT_D_MGR_DEPT_ITEM : ComNestingResourceEditPage
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
            if (string.IsNullOrEmpty(ddlInputMGR_DEPT_ID.KeyValue))
                throw new Exception("职能科室不能为空");
            if (string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                throw new Exception("预算科目不能为空");
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_MGR_DEPT_ITEM_D cause = new CauseObject_BGT_D_MGR_DEPT_ITEM_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM).ID;
			dataSource = BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_D_MGR_DEPT_ITEM_D> list = new System.Collections.Generic.List<DisplayObject_BGT_D_MGR_DEPT_ITEM_D>();
			list.AddRange((DisplayObject_BGT_D_MGR_DEPT_ITEM_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_MGR_DEPT_ITEM_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_D_MGR_DEPT_ITEM_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005' and BGT_D_BUDGET_ITEM.IS_END = 1 and BGT_D_BUDGET_ITEM.Budget_Year = (select id from BGT_D_BUDGET_YEAR where IS_AVAILABE=1 and rownum = 1)";
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.ddlInputMGR_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            //取系统默认预算年下的职能科室
            this.ddlInputMGR_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.Is_Function = 1 and BGT_D_BUDGET_DEPT.Budget_Year = (select id from BGT_D_BUDGET_YEAR where IS_AVAILABE=1 and rownum = 1) ";
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> saveDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
				EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = new EntityObject_BGT_D_MGR_DEPT_ITEM();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										baseEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputMGR_DEPT_ID.KeyValue))
										baseEntity.MGR_DEPT_ID = ddlInputMGR_DEPT_ID.KeyValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							//平台自动生成代码
								EntityObject_BGT_D_MGR_DEPT_ITEM_D detailEntity = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> saveDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
						List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> updateDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
						List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> deleteDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
						EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										baseEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputMGR_DEPT_ID.KeyValue))
										baseEntity.MGR_DEPT_ID = ddlInputMGR_DEPT_ID.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							//平台自动生成代码
								EntityObject_BGT_D_MGR_DEPT_ITEM_D detailEntity = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if (detailEntity.ID == string.Empty)
									{
										//AuditAdd(detailEntity);
										saveDetailEntities.Add(detailEntity);
									}
									else
									{
										detailEntity.SetNotUpdate("BIZ_DEPT_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_D_MGR_DEPT_ITEM_D entity = (EntityObject_BGT_D_MGR_DEPT_ITEM_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_MGR_DEPT_ITEM cause = new CauseObject_BGT_D_MGR_DEPT_ITEM();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_MGR_DEPT_ITEM>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_MGR_DEPT_ITEM_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_MGR_DEPT_ITEM cause = (CauseObject_BGT_D_MGR_DEPT_ITEM)parameter;
			dataSource = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = new EntityObject_BGT_D_MGR_DEPT_ITEM();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Get(baseEntity);
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = baseEntity.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.ITEM_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM(){ID = baseEntity.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
				this.ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005'";
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
				this.ddlInputMGR_DEPT_ID.KeyField = "ID";
				this.ddlInputMGR_DEPT_ID.NameField = "NAME";
				this.ddlInputMGR_DEPT_ID.KeyValue = baseEntity.MGR_DEPT_ID;
				this.ddlInputMGR_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.MGR_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.MGR_DEPT_ID}).NAME;
				this.ddlInputMGR_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputMGR_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_MGR_DEPT_ITEM> deleteDetailEntities = new List<EntityObject_BGT_D_MGR_DEPT_ITEM>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_MGR_DEPT_ITEM entity = new EntityObject_BGT_D_MGR_DEPT_ITEM();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_MGR_DEPT_ITEM.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_D_MGR_DEPT_ITEM baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_MGR_DEPT_ITEM;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_MGR_DEPT_ITEM_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_MGR_DEPT_ITEM_D> dl = new List<EntityObject_BGT_D_MGR_DEPT_ITEM_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_D_MGR_DEPT_ITEM_D detailEntity = new EntityObject_BGT_D_MGR_DEPT_ITEM_D();
                detailEntity.BASE_ID = key;
                detailEntity.BIZ_DEPT_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_MGR_DEPT_ITEM_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

