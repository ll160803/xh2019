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
    public partial class PageObject_BGT_D_BUDGET_CPN_YEAR_R_I : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            //
            this.command[Ipedf.Web.Control.ButtonType.Add].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Query].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.CloseAfterSave].Enabled = false;
            this.command[Ipedf.Web.Control.ButtonType.Close].Attributes.Add("onclick", "self.close();");
        }
        protected override void PrepareCause()
        {
			
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I_D cause = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I).ID;
			dataSource = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I_D> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            

        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				
			}
			else
			{
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>();
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>();
						List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>();
						EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
									
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputADJUST_SCALE = (ComTextBox)row.FindControl("txtInputADJUST_SCALE");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D detailEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputADJUST_SCALE.Text))
					detailEntity.ADJUST_SCALE = decimal.Parse(txtInputADJUST_SCALE.Text);
					else
					detailEntity.ADJUST_SCALE = 0;
									if (detailEntity.ID == string.Empty)
									{
										//AuditAdd(detailEntity);
										saveDetailEntities.Add(detailEntity);
									}
									else
									{
										detailEntity.SetNotUpdate("BUDGET_MONTH");
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
                        BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ShowEditState(baseEntity);
                        //
                        this.command[Ipedf.Web.Control.ButtonType.Add].Enabled = false;
                        this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
                        this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
                        this.command[Ipedf.Web.Control.ButtonType.Query].Enabled = false;
                        this.command[Ipedf.Web.Control.ButtonType.CloseAfterSave].Enabled = false;
                        this.command[Ipedf.Web.Control.ButtonType.Close].Attributes.Add("onclick", "self.close();");
                        //
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D entity = (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputADJUST_SCALE = (ComTextBox)e.Row.FindControl("txtInputADJUST_SCALE");
				txtInputADJUST_SCALE.Text = entity.ADJUST_SCALE == null ? "0": entity.ADJUST_SCALE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I();
			
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_CPN_YEAR_R_I_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause = (CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Get(baseEntity);				
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity;
                //
                this.command[Ipedf.Web.Control.ButtonType.Add].Enabled = false;
                this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
                this.command[Ipedf.Web.Control.ButtonType.AddAfterSave].Enabled = false;
                this.command[Ipedf.Web.Control.ButtonType.Query].Enabled = false;
                this.command[Ipedf.Web.Control.ButtonType.CloseAfterSave].Enabled = false;
                this.command[Ipedf.Web.Control.ButtonType.Close].Attributes.Add("onclick", "self.close();");
                //
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I entity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_CPN_YEAR_R_I_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D> dl = new List<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D detailEntity = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D();
                detailEntity.BASE_ID = key;
                detailEntity.BUDGET_MONTH = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

