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
    public partial class PageObject_BGT_B_BUDGET_PROJ_CO : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_B_BUDGET_PROJ_D),"ID","NAME");
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_CO_D cause = new CauseObject_BGT_B_BUDGET_PROJ_CO_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO).ID;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_CO_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_CO_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_CO_D>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_PROJ_CO_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_PROJ_CO_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_BUDGET_PROJ_CO_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.txtInputEXECUTED_MONEY.Text = "0.00";
			this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
			this.txtInputBUDGET_MONEY.Text = "0.00";
            this.txtInputADJUST_MONEY.Text = "0.00";
			SetEnumReferenceBinding(this.ddlInputIS_RECENTLY, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_PROJ_CO_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_CO_D>();
				EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_CO();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
					baseEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
					else
					baseEntity.EXECUTED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
										baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputBUDGET_MONEY.Text))
					baseEntity.BUDGET_MONEY = decimal.Parse(txtInputBUDGET_MONEY.Text);
					else
					baseEntity.BUDGET_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_RECENTLY.SelectedValue))
										baseEntity.IS_RECENTLY = decimal.Parse(ddlInputIS_RECENTLY.SelectedValue);
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                            //ComTextBox txtInputEXECUTED_MONEY1 = (ComTextBox)row.FindControl("txtInputEXECUTED_MONEY");
                            //ComTextBox txtInputBUDGET_MONEY1 = (ComTextBox)row.FindControl("txtInputBUDGET_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_CO_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_CO_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                    //if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY1.Text))
                    //detailEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY1.Text);
                    //else
                    //detailEntity.EXECUTED_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_MONEY1.Text))
                    //detailEntity.BUDGET_MONEY = decimal.Parse(txtInputBUDGET_MONEY1.Text);
                    //else
                    //detailEntity.BUDGET_MONEY = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_PROJ_CO_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_CO_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_CO_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_CO_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_CO_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_CO_D>();
						EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY.Text))
					baseEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY.Text);
					else
					baseEntity.EXECUTED_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
										baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputBUDGET_MONEY.Text))
					baseEntity.BUDGET_MONEY = decimal.Parse(txtInputBUDGET_MONEY.Text);
					else
					baseEntity.BUDGET_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_RECENTLY.SelectedValue))
										baseEntity.IS_RECENTLY = decimal.Parse(ddlInputIS_RECENTLY.SelectedValue);
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                            //ComTextBox txtInputEXECUTED_MONEY1 = (ComTextBox)row.FindControl("txtInputEXECUTED_MONEY");
                            //ComTextBox txtInputBUDGET_MONEY1 = (ComTextBox)row.FindControl("txtInputBUDGET_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_CO_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_CO_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                    //if(!string.IsNullOrEmpty(txtInputEXECUTED_MONEY1.Text))
                    //detailEntity.EXECUTED_MONEY = decimal.Parse(txtInputEXECUTED_MONEY1.Text);
                    //else
                    //detailEntity.EXECUTED_MONEY = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_MONEY1.Text))
                    //detailEntity.BUDGET_MONEY = decimal.Parse(txtInputBUDGET_MONEY1.Text);
                    //else
                    //detailEntity.BUDGET_MONEY = 0;
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_BUDGET_PROJ_CO_D entity = (EntityObject_BGT_B_BUDGET_PROJ_CO_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_B_BUDGET_PROJ_D","ID","NAME");
                //ComTextBox txtInputEXECUTED_MONEY = (ComTextBox)e.Row.FindControl("txtInputEXECUTED_MONEY");
                //txtInputEXECUTED_MONEY.Text = entity.EXECUTED_MONEY == null ? "0": entity.EXECUTED_MONEY.ToString();
                //ComTextBox txtInputBUDGET_MONEY = (ComTextBox)e.Row.FindControl("txtInputBUDGET_MONEY");
                //txtInputBUDGET_MONEY.Text = entity.BUDGET_MONEY == null ? "0": entity.BUDGET_MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_CO cause = new CauseObject_BGT_B_BUDGET_PROJ_CO();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_CO>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_CO_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_CO cause = (CauseObject_BGT_B_BUDGET_PROJ_CO)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_CO();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
				this.txtInputEXECUTED_MONEY.Text = baseEntity.EXECUTED_MONEY == null ? string.Empty:baseEntity.EXECUTED_MONEY.ToString();
				this.ddlInputPROJECT_ID.KeyField = "ID";
				this.ddlInputPROJECT_ID.NameField = "NAME";
				this.ddlInputPROJECT_ID.KeyValue = baseEntity.PROJECT_ID;
				this.ddlInputPROJECT_ID.NameValue = string.IsNullOrEmpty(baseEntity.PROJECT_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Get(new EntityObject_BGT_B_BUDGET_PROJ(){ID = baseEntity.PROJECT_ID}).NAME;
				this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
				this.txtInputBUDGET_MONEY.Text = baseEntity.BUDGET_MONEY == null ? string.Empty:baseEntity.BUDGET_MONEY.ToString();
            this.txtInputADJUST_MONEY.Text = baseEntity.ADJUST_MONEY.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_RECENTLY, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_RECENTLY);
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_B_BUDGET_PROJ_D cause114 =  new CauseObject_BGT_B_BUDGET_PROJ_D();
			cause114.SetCustomCondition(" and BGT_B_BUDGET_PROJ_D.ID in( select BGT_B_BUDGET_PROJ_CO_D.ITEM_ID from BGT_B_BUDGET_PROJ_CO_D where BGT_B_BUDGET_PROJ_CO_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_BUDGET_PROJ_CO_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_B_BUDGET_PROJ_D>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_B_BUDGET_PROJ_D),"ID","NAME",cause114);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_CO baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_CO;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_CO> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_CO>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_CO entity = new EntityObject_BGT_B_BUDGET_PROJ_CO();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_CO.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

