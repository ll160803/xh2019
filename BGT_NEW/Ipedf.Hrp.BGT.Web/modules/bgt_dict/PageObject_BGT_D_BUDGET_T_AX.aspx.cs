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
    public partial class PageObject_BGT_D_BUDGET_T_AX : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            btnCreateContent.Enabled = btnCreateContent.Visible = command[Ipedf.Web.Control.ButtonType.Save].Visible;
            btnCreateContent.Text = "生成增比/分解模板";
            btnCreateContent.Attributes.Add("onclick","return confirm('此操作将重新生成各级增比/分解表单格式,已填写的数据将会被清空,确定要进行此操作吗?');");
            //此功能页在系统授权中需要授予;修改和删除的权限,以实现对明细内容的修改和删除
            //this.btnDelete.Enabled = false;
        }
        protected override void PrepareCause()
        {
            this.txtInputCODE.Enabled = false;
            this.txtInputNAME.Enabled = false;
            this.ddlInputBUDGET_CONTENTS_ID.Enabled = false;
            this.ddlInputBUDGET_YEAR.Enabled = false;
            this.ddlInputTEMPLET_TYPE_ID.Enabled = false;
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_T_A cause = new CauseObject_BGT_D_BUDGET_T_A();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T).ID;
			dataSource = BizLogicObject_BGT_D_BUDGET_T_A.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_T_A> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_T_A>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_T_A[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_T_A>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_D_BUDGET_T_A),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause423 =  new CauseObject_BGT_D_BUDGET_YEAR();
            //cause423.IS_VALID = 1;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause423);
			this.txtInputCODE.Text = string.Empty;
			this.txtInputNAME.Text = string.Empty;
			CauseObject_COM_TYPE cause429 =  new CauseObject_COM_TYPE();
			cause429.PARENT_ID = "0012";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause429);
			CauseObject_COM_TYPE cause573 =  new CauseObject_COM_TYPE();
			cause573.PARENT_ID = "0009";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputTEMPLET_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause573);
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_D_BUDGET_T_A> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_A>();
				EntityObject_BGT_D_BUDGET_T baseEntity = new EntityObject_BGT_D_BUDGET_T();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					baseEntity.CODE = txtInputCODE.Text;
					baseEntity.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_TYPE_ID.SelectedValue))
										baseEntity.TEMPLET_TYPE_ID = ddlInputTEMPLET_TYPE_ID.SelectedValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_A detailEntity = new EntityObject_BGT_D_BUDGET_T_A();
								
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
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_D_BUDGET_T_A> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_A>();
						List<EntityObject_BGT_D_BUDGET_T_A> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_A>();
						List<EntityObject_BGT_D_BUDGET_T_A> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_A>();
						EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
					baseEntity.CODE = txtInputCODE.Text;
					baseEntity.NAME = txtInputNAME.Text;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_CONTENTS_ID.SelectedValue))
										baseEntity.BUDGET_CONTENTS_ID = ddlInputBUDGET_CONTENTS_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_TYPE_ID.SelectedValue))
										baseEntity.TEMPLET_TYPE_ID = ddlInputTEMPLET_TYPE_ID.SelectedValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_A detailEntity = new EntityObject_BGT_D_BUDGET_T_A();
								
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
										detailEntity.SetNotUpdate("BUDGET_DEPT_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_D_BUDGET_T_A entity = (EntityObject_BGT_D_BUDGET_T_A)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T cause = new CauseObject_BGT_D_BUDGET_T();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_T>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_T_AX_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override string PrepareResultOrderByColumn()
        {
            return "TEMPLET_TYPE_ID_NAME";
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_T cause = (CauseObject_BGT_D_BUDGET_T)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_T.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_T baseEntity = new EntityObject_BGT_D_BUDGET_T();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_D_BUDGET_T.Proxy.Get(baseEntity);
				CauseObject_BGT_D_BUDGET_YEAR cause127 =  new CauseObject_BGT_D_BUDGET_YEAR();
                //cause127.IS_VALID = 1;
				SetForeignKeySelected<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR",cause127);
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
				this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
				CauseObject_COM_TYPE cause133 =  new CauseObject_COM_TYPE();
				cause133.PARENT_ID = "0012";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.BUDGET_CONTENTS_ID,"ID","NAME",cause133);
				CauseObject_COM_TYPE cause767 =  new CauseObject_COM_TYPE();
				cause767.PARENT_ID = "0009";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputTEMPLET_TYPE_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.TEMPLET_TYPE_ID,"ID","NAME",cause767);
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity;
                this.lbAppend.Enabled = baseEntity.TEMPLET_TYPE_ID.Trim() == "00090002";//仅科室类模板添加操作可用
                ShowDetailData();
                SetPageState(PageState.Edit);
                ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_T.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_T.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_T.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_T> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_T entity = new EntityObject_BGT_D_BUDGET_T();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_D_BUDGET_T baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_T_AX_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_BUDGET_T_A> dl = new List<EntityObject_BGT_D_BUDGET_T_A>();
            foreach (string entity in el)
            {
                EntityObject_BGT_D_BUDGET_T_A detailEntity = new EntityObject_BGT_D_BUDGET_T_A();
                detailEntity.BASE_ID = key;
                detailEntity.BUDGET_DEPT_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_BUDGET_T_A.Proxy.BatchSave(dl.ToArray());
        }
    }
}

