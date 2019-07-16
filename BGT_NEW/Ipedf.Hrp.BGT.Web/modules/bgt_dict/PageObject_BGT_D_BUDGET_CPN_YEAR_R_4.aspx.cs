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
    public partial class PageObject_BGT_D_BUDGET_CPN_YEAR_R_4 : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R).ID;
			dataSource = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Query2(cause);
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
			CauseObject_COM_TYPE cause874 =  new CauseObject_COM_TYPE();
			cause874.PARENT_ID = "0012";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause874);

            //
            WebControlHelper.SetSelected(this.ddlInputBUDGET_CONTENTS_ID, "00120003");//支出预算
            this.ddlInputBUDGET_CONTENTS_ID.Enabled = false;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputRESOLVE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputRESOLVE_METHOD_ID");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I detailEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputRESOLVE_METHOD_ID.SelectedValue))
										detailEntity.RESOLVE_METHOD_ID = ddlInputRESOLVE_METHOD_ID.SelectedValue;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
						EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComDropDownList ddlInputRESOLVE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputRESOLVE_METHOD_ID");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I detailEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputRESOLVE_METHOD_ID.SelectedValue))
										detailEntity.RESOLVE_METHOD_ID = ddlInputRESOLVE_METHOD_ID.SelectedValue;
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
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ShowEditState(baseEntity);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        //protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I entity = (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I)e.Row.DataItem;
        //        CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
        //        select.Checked = entity.ID != string.Empty;
                
        //        ComDropDownList ddlInputRESOLVE_METHOD_ID= (ComDropDownList)e.Row.FindControl("ddlInputRESOLVE_METHOD_ID");
        //        CopyComDropDownListItem(ddlDataSourceRESOLVE_METHOD_ID,ddlInputRESOLVE_METHOD_ID, entity.RESOLVE_METHOD_ID);
        //        //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
        //    }
        //}      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R cause = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R();
            cause.BUDGET_CONTENTS_ID = "00120003";//支出预算
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_CPN_YEAR_R>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_CPN_YEAR_R_4_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R cause = (CauseObject_BGT_D_BUDGET_CPN_YEAR_R)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
				CauseObject_COM_TYPE cause283 =  new CauseObject_COM_TYPE();
				cause283.PARENT_ID = "0012";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.BUDGET_CONTENTS_ID,"ID","NAME",cause283);
                //
                WebControlHelper.SetSelected(this.ddlInputBUDGET_CONTENTS_ID, "00120003");//支出预算
                this.ddlInputBUDGET_CONTENTS_ID.Enabled = false;
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_COM_TYPE cause378 =  new CauseObject_COM_TYPE();
			cause378.PARENT_ID = "0023";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceRESOLVE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause378);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_CPN_YEAR_R entity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_CPN_YEAR_R_4_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> dl = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
            foreach (string entity in el)
            {
                EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I detailEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.BatchSave(dl.ToArray());
        }
    }
}

