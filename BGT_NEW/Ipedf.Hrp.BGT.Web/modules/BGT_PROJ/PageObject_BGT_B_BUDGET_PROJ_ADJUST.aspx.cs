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
    public partial class PageObject_BGT_B_BUDGET_PROJ_ADJUST : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
            //CauseObject_COM_TYPE cause713 =  new CauseObject_COM_TYPE();
            //cause713.PARENT_ID = "0031";
            //SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceADJUST_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause713);
			SetForeignKeyBinding(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_B_BUDGET_PROJ_D),"ID","NAME");
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D cause = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST).ID;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
			this.txtInputCREATE_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputADJUST_CODE.Text = string.Empty;
			this.txtInputCOMMENTS.Text = string.Empty;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
										baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					baseEntity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					baseEntity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.ADJUST_CODE = txtInputADJUST_CODE.Text;
					baseEntity.COMMENTS = txtInputCOMMENTS.Text;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputADJUST_TYPE_ID = (ComDropDownList)row.FindControl("ddlInputADJUST_TYPE_ID");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                            //ComTextBox txtInputADJUST_VALUE = (ComTextBox)row.FindControl("txtInputADJUST_VALUE");
                            //ComTextBox txtInputITEM_BASE_VALUE = (ComTextBox)row.FindControl("txtInputITEM_BASE_VALUE");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                                
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputADJUST_TYPE_ID.SelectedValue))
                                    //    detailEntity.ADJUST_TYPE_ID = ddlInputADJUST_TYPE_ID.SelectedValue;
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                    //if(!string.IsNullOrEmpty(txtInputADJUST_VALUE.Text))
                    //detailEntity.ADJUST_VALUE = decimal.Parse(txtInputADJUST_VALUE.Text);
                    //else
                    //detailEntity.ADJUST_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputITEM_BASE_VALUE.Text))
                    //detailEntity.ITEM_BASE_VALUE = decimal.Parse(txtInputITEM_BASE_VALUE.Text);
                    //else
                    //detailEntity.ITEM_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
									//AuditAdd(detailEntity);
                    detailEntity.SetNotUpdate("ADJUST_VALUE", "ITEM_BASE_VALUE");
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
						List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
						EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputPROJECT_ID.KeyValue))
										baseEntity.PROJECT_ID = ddlInputPROJECT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					baseEntity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					baseEntity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.ADJUST_CODE = txtInputADJUST_CODE.Text;
					baseEntity.COMMENTS = txtInputCOMMENTS.Text;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputADJUST_TYPE_ID = (ComDropDownList)row.FindControl("ddlInputADJUST_TYPE_ID");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                            //ComTextBox txtInputADJUST_VALUE = (ComTextBox)row.FindControl("txtInputADJUST_VALUE");
                            //ComTextBox txtInputITEM_BASE_VALUE = (ComTextBox)row.FindControl("txtInputITEM_BASE_VALUE");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                                
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputADJUST_TYPE_ID.SelectedValue))
                                    //    detailEntity.ADJUST_TYPE_ID = ddlInputADJUST_TYPE_ID.SelectedValue;
                    //                if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                    //                    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                    ////if(!string.IsNullOrEmpty(txtInputADJUST_VALUE.Text))
                    //detailEntity.ADJUST_VALUE = decimal.Parse(txtInputADJUST_VALUE.Text);
                    //else
                    //detailEntity.ADJUST_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputITEM_BASE_VALUE.Text))
                    //detailEntity.ITEM_BASE_VALUE = decimal.Parse(txtInputITEM_BASE_VALUE.Text);
                    //else
                    //detailEntity.ITEM_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    detailEntity.SetNotUpdate("ADJUST_VALUE", "ITEM_BASE_VALUE");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D entity = (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComDropDownList ddlInputADJUST_TYPE_ID= (ComDropDownList)e.Row.FindControl("ddlInputADJUST_TYPE_ID");
                //CopyComDropDownListItem(ddlDataSourceADJUST_TYPE_ID,ddlInputADJUST_TYPE_ID, entity.ADJUST_TYPE_ID);
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_B_BUDGET_PROJ_D","ID","NAME");
                //ComTextBox txtInputADJUST_VALUE = (ComTextBox)e.Row.FindControl("txtInputADJUST_VALUE");
                //txtInputADJUST_VALUE.Text = entity.ADJUST_VALUE == null ? "0": entity.ADJUST_VALUE.ToString();
                //ComTextBox txtInputITEM_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_BASE_VALUE");
                //txtInputITEM_BASE_VALUE.Text = entity.ITEM_BASE_VALUE == null ? "0": entity.ITEM_BASE_VALUE.ToString();
				ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
				txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_ADJUST>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_ADJUST_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause = (CauseObject_BGT_B_BUDGET_PROJ_ADJUST)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Get(baseEntity);
				this.ddlInputPROJECT_ID.KeyField = "ID";
				this.ddlInputPROJECT_ID.NameField = "NAME";
				this.ddlInputPROJECT_ID.KeyValue = baseEntity.PROJECT_ID;
				this.ddlInputPROJECT_ID.NameValue = string.IsNullOrEmpty(baseEntity.PROJECT_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_PROJ.Proxy.Get(new EntityObject_BGT_B_BUDGET_PROJ(){ID = baseEntity.PROJECT_ID}).NAME;
				this.ddlInputPROJECT_ID.DataTable = "BGT_B_BUDGET_PROJ";
				this.txtInputCREATE_DATE.Text = baseEntity.CREATE_DATE == null ? string.Empty:baseEntity.CREATE_DATE.ToString();
				this.txtInputADJUST_CODE.Text = baseEntity.ADJUST_CODE == null ? string.Empty:baseEntity.ADJUST_CODE.ToString();
				this.txtInputCOMMENTS.Text = baseEntity.COMMENTS == null ? string.Empty:baseEntity.COMMENTS.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_COM_TYPE cause256 =  new CauseObject_COM_TYPE();
			cause256.PARENT_ID = "0031";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceADJUST_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause256);
			CauseObject_BGT_B_BUDGET_PROJ_D cause413 =  new CauseObject_BGT_B_BUDGET_PROJ_D();
			cause413.SetCustomCondition(" and BGT_B_BUDGET_PROJ_D.ID in( select BGT_B_BUDGET_PROJ_ADJUST_D.ITEM_ID from BGT_B_BUDGET_PROJ_ADJUST_D where BGT_B_BUDGET_PROJ_ADJUST_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_BUDGET_PROJ_ADJUST_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_B_BUDGET_PROJ_D>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_B_BUDGET_PROJ_D),"ID","NAME",cause413);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_ADJUST entity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
                WebControlHelper.ShowAlert(this, "请选择预算项目");
                return;
            }
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("linkid", baseEntity.ID);
            parameters.Add("projectid", baseEntity.PROJECT_ID);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_PROJ_ADJUST_Resource.aspx", parameters);
            base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> dl = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D detailEntity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

