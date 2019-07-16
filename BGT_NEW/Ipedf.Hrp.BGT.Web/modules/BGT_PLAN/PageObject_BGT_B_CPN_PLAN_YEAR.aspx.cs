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
    public partial class PageObject_BGT_B_CPN_PLAN_YEAR : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            //command[Ipedf.Web.Control.ButtonType.Custom].Visible = command[Ipedf.Web.Control.ButtonType.Save].Visible;
            btnCreateContent.Enabled = btnCreateContent.Visible = command[Ipedf.Web.Control.ButtonType.Save].Visible;
            btnCreateContent.Text = "生成内容";
            btnCreateContent.Attributes.Add("onclick", "return confirm('此操作将重新生成内容,已填写的数据将会被清空,确定要进行此操作吗?');");
        }
        protected override void PrepareCause()
        {
			
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
            //this.ddlInputTEMPLET_ID.Condition = "BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090001' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120001' and BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1)";
            CauseObject_BGT_D_BUDGET_T pt = new CauseObject_BGT_D_BUDGET_T();
            pt.SetCustomCondition(" and BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090001' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120001' and BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1)  ");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_T>(this.ddlInputTEMPLET_ID, typeof(BizLogicObject_BGT_D_BUDGET_T), "ID", "NAME", pt);
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_CPN_PLAN_YEAR_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_PLAN_YEAR_D>();
				EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = new EntityObject_BGT_B_CPN_PLAN_YEAR();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                                    if (!string.IsNullOrEmpty(ddlInputTEMPLET_ID.SelectedValue))
                                        baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.SelectedValue;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							//ComTextBox txtInputCONSULT = (ComTextBox)row.FindControl("txtInputCONSULT");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_CPN_PLAN_YEAR_D detailEntity = new EntityObject_BGT_B_CPN_PLAN_YEAR_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					//detailEntity.CONSULT = txtInputCONSULT.Text;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_CPN_PLAN_YEAR_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_PLAN_YEAR_D>();
						List<EntityObject_BGT_B_CPN_PLAN_YEAR_D> updateDetailEntities = new List<EntityObject_BGT_B_CPN_PLAN_YEAR_D>();
						List<EntityObject_BGT_B_CPN_PLAN_YEAR_D> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_PLAN_YEAR_D>();
						EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_ID.SelectedValue))
                                        baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.SelectedValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							//ComTextBox txtInputCONSULT = (ComTextBox)row.FindControl("txtInputCONSULT");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//ComTextBox txtInputBUDGET_BASE = (ComTextBox)row.FindControl("txtInputBUDGET_BASE");
							//平台自动生成代码
								EntityObject_BGT_B_CPN_PLAN_YEAR_D detailEntity = new EntityObject_BGT_B_CPN_PLAN_YEAR_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					//detailEntity.CONSULT = txtInputCONSULT.Text;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputBUDGET_BASE.Text))
                    //detailEntity.BUDGET_BASE = decimal.Parse(txtInputBUDGET_BASE.Text);
                    //else
                    //detailEntity.BUDGET_BASE = 0;
                    detailEntity.SetNotUpdate("ITEM_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_CPN_PLAN_YEAR_D entity = (EntityObject_BGT_B_CPN_PLAN_YEAR_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_PLAN_ITEM","ID","NAME");
				//ComTextBox txtInputCONSULT = (ComTextBox)e.Row.FindControl("txtInputCONSULT");
				//txtInputCONSULT.Text = entity.CONSULT == null ? String.Empty: entity.CONSULT.ToString();
				ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
				txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //ComTextBox txtInputBUDGET_BASE = (ComTextBox)e.Row.FindControl("txtInputBUDGET_BASE");
                //txtInputBUDGET_BASE.Text = entity.BUDGET_BASE == null ? "0": entity.BUDGET_BASE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_CPN_PLAN_YEAR cause = new CauseObject_BGT_B_CPN_PLAN_YEAR();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_CPN_PLAN_YEAR>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_PLAN_YEAR_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_CPN_PLAN_YEAR cause = (CauseObject_BGT_B_CPN_PLAN_YEAR)parameter;
			dataSource = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = new EntityObject_BGT_B_CPN_PLAN_YEAR();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
                //this.ddlInputTEMPLET_ID.KeyField = "ID";
                //this.ddlInputTEMPLET_ID.NameField = "NAME";
                //this.ddlInputTEMPLET_ID.KeyValue = baseEntity.TEMPLET_ID;
                //this.ddlInputTEMPLET_ID.NameValue = string.IsNullOrEmpty(baseEntity.TEMPLET_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_T.Proxy.Get(new EntityObject_BGT_D_BUDGET_T(){ID = baseEntity.TEMPLET_ID}).NAME;
                //this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
                //this.ddlInputTEMPLET_ID.Condition = "BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090001'";
                CauseObject_BGT_D_BUDGET_T pt = new CauseObject_BGT_D_BUDGET_T();
                pt.SetCustomCondition(" and BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090001' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120001' and BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1)  ");
                SetForeignKeySelected<CauseObject_BGT_D_BUDGET_T>(this.ddlInputTEMPLET_ID, typeof(BizLogicObject_BGT_D_BUDGET_T), baseEntity.TEMPLET_ID, "ID", "NAME", pt); 	
            
            ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_D_PLAN_ITEM cause335 =  new CauseObject_BGT_D_PLAN_ITEM();
			cause335.SetCustomCondition(" and BGT_D_PLAN_ITEM.ID in( select BGT_B_CPN_PLAN_YEAR_D.ITEM_ID from BGT_B_CPN_PLAN_YEAR_D where BGT_B_CPN_PLAN_YEAR_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_CPN_PLAN_YEAR_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_PLAN_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_PLAN_ITEM),"ID","NAME",cause335);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_PLAN_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_PLAN_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_PLAN_YEAR> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_PLAN_YEAR>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_PLAN_YEAR entity = new EntityObject_BGT_B_CPN_PLAN_YEAR();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_CPN_PLAN_YEAR.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

