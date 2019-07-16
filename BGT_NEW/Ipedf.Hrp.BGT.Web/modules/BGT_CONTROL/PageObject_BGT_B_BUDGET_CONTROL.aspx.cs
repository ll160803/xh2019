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
    public partial class PageObject_BGT_B_BUDGET_CONTROL : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			CauseObject_COM_TYPE cause174 =  new CauseObject_COM_TYPE();
			cause174.PARENT_ID = "0201";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause174);
			CauseObject_BGT_D_BUDGET_ITEM cause875 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause875.IS_END = 1;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause875);
			CauseObject_COM_TYPE cause813 =  new CauseObject_COM_TYPE();
			cause813.PARENT_ID = "0202";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceEDITION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause813);
        } 
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			this.txtInputCREATE_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputCODE.Text = string.Empty;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_BUDGET_CONTROL_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();
				EntityObject_BGT_B_BUDGET_CONTROL baseEntity = new EntityObject_BGT_B_BUDGET_CONTROL();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					baseEntity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					baseEntity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputTYPE_ID = (ComDropDownList)row.FindControl("ddlInputTYPE_ID");
							ComDropDownList ddlInputEDITION_ID = (ComDropDownList)row.FindControl("ddlInputEDITION_ID");
                            ComTextBox txtInputSLIDING_SCALES = (ComTextBox)row.FindControl("txtInputSLIDING_SCALES");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_CONTROL_D detailEntity = new EntityObject_BGT_B_BUDGET_CONTROL_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										detailEntity.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputEDITION_ID.SelectedValue))
										detailEntity.EDITION_ID = ddlInputEDITION_ID.SelectedValue;
                                    if (!string.IsNullOrEmpty(txtInputSLIDING_SCALES.Text))
                                        detailEntity.SLIDING_SCALES = decimal.Parse(txtInputSLIDING_SCALES.Text);
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);        
                ViewState["CUR_OBJ"] = baseEntity;
                        PrepareDetailDataSourceControl(baseEntity.ID);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_BUDGET_CONTROL_D> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();
						List<EntityObject_BGT_B_BUDGET_CONTROL_D> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();
						List<EntityObject_BGT_B_BUDGET_CONTROL_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();

						EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					baseEntity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					baseEntity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputTYPE_ID = (ComDropDownList)row.FindControl("ddlInputTYPE_ID");
							ComDropDownList ddlInputEDITION_ID = (ComDropDownList)row.FindControl("ddlInputEDITION_ID");
                            ComTextBox txtInputSLIDING_SCALES = (ComTextBox)row.FindControl("txtInputSLIDING_SCALES");
							//平台自动生成代码
								EntityObject_BGT_B_BUDGET_CONTROL_D detailEntity = new EntityObject_BGT_B_BUDGET_CONTROL_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputTYPE_ID.SelectedValue))
										detailEntity.TYPE_ID = ddlInputTYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputEDITION_ID.SelectedValue))
										detailEntity.EDITION_ID = ddlInputEDITION_ID.SelectedValue;
                                    if (!string.IsNullOrEmpty(txtInputSLIDING_SCALES.Text))
                                        detailEntity.SLIDING_SCALES = decimal.Parse(txtInputSLIDING_SCALES.Text);
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_BUDGET_CONTROL_D entity = (EntityObject_BGT_B_BUDGET_CONTROL_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComDropDownList ddlInputTYPE_ID= (ComDropDownList)e.Row.FindControl("ddlInputTYPE_ID");
				CopyComDropDownListItem(ddlDataSourceTYPE_ID,ddlInputTYPE_ID, entity.TYPE_ID);
				ComDropDownList ddlInputEDITION_ID= (ComDropDownList)e.Row.FindControl("ddlInputEDITION_ID");
				CopyComDropDownListItem(ddlDataSourceEDITION_ID,ddlInputEDITION_ID, entity.EDITION_ID);

                ComTextBox txtInputSLIDING_SCALES = (ComTextBox)e.Row.FindControl("txtInputSLIDING_SCALES");
                txtInputSLIDING_SCALES.Text = entity.SLIDING_SCALES.ToString();                
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_CONTROL cause = new CauseObject_BGT_B_BUDGET_CONTROL();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_CONTROL>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_CONTROL_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_CONTROL cause = (CauseObject_BGT_B_BUDGET_CONTROL)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_CONTROL baseEntity = new EntityObject_BGT_B_BUDGET_CONTROL();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Get(baseEntity);

                //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR(); p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
                SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
				this.txtInputCREATE_DATE.Text = baseEntity.CREATE_DATE == null ? string.Empty:baseEntity.CREATE_DATE.ToString();
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_CONTROL> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_CONTROL entity = new EntityObject_BGT_B_BUDGET_CONTROL();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_CONTROL.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_B_BUDGET_CONTROL baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_CONTROL;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_BUDGET_CONTROL_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_BUDGET_CONTROL_D> dl = new List<EntityObject_BGT_B_BUDGET_CONTROL_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_BUDGET_CONTROL_D detailEntity = new EntityObject_BGT_B_BUDGET_CONTROL_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_BUDGET_CONTROL_D.Proxy.BatchSave(dl.ToArray());
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {
           
			CauseObject_COM_TYPE cause615 =  new CauseObject_COM_TYPE();
			cause615.PARENT_ID = "0201";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceTYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause615);
			CauseObject_COM_TYPE cause867 =  new CauseObject_COM_TYPE();
			cause867.PARENT_ID = "0202";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceEDITION_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause867);
        }
    }
}

