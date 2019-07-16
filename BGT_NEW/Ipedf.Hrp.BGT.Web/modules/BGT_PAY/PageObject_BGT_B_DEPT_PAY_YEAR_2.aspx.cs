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
using Ipedf.Common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_2 : ComNestingEditPage
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
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("预算科室不能为空");
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";
            //this.ddlInputTEMPLET_ID.Condition = "BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090002' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120003' and  BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1)";

            CauseObject_BGT_D_BUDGET_T pt = new CauseObject_BGT_D_BUDGET_T();
            pt.SetCustomCondition(" and BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090002' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120003' and  BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1) ");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_T>(this.ddlInputTEMPLET_ID, typeof(BizLogicObject_BGT_D_BUDGET_T), "ID", "NAME", pt);


			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetBusinessBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID);
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION = 2";
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_PAY_YEAR_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_D>();
				EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputTEMPLET_ID.SelectedValue))
                                        baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                                    baseEntity.IS_FUNCTION = (decimal)是否状态.否; //职能科室预算
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PAY_YEAR_D detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_PAY_YEAR_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_D>();
						List<EntityObject_BGT_B_DEPT_PAY_YEAR_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_D>();
						List<EntityObject_BGT_B_DEPT_PAY_YEAR_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_D>();
						EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
										baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                                    if (!string.IsNullOrEmpty(ddlInputTEMPLET_ID.SelectedValue))
                                        baseEntity.TEMPLET_ID = ddlInputTEMPLET_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                                    baseEntity.IS_FUNCTION = (decimal)是否状态.否; //职能科室预算
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputITEM_VALUE = (ComTextBox)row.FindControl("txtInputITEM_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_PAY_YEAR_D detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					detailEntity.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					detailEntity.ITEM_VALUE = 0;
                    detailEntity.SetNotUpdate("ITEM_ID", "MGR_DEPT_ID");
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_DEPT_PAY_YEAR_D entity = (EntityObject_BGT_B_DEPT_PAY_YEAR_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
				ComTextBox txtInputITEM_VALUE = (ComTextBox)e.Row.FindControl("txtInputITEM_VALUE");
				txtInputITEM_VALUE.Text = entity.ITEM_VALUE == null ? "0": entity.ITEM_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_PAY_YEAR cause = new CauseObject_BGT_B_DEPT_PAY_YEAR();
            cause.IS_FUNCTION = (decimal)是否状态.否;
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_PAY_YEAR>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PAY_YEAR_2_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_PAY_YEAR cause = (CauseObject_BGT_B_DEPT_PAY_YEAR)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Get(baseEntity);
				SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR");
                //this.ddlInputTEMPLET_ID.KeyField = "ID";
                //this.ddlInputTEMPLET_ID.NameField = "NAME";
                //this.ddlInputTEMPLET_ID.KeyValue = baseEntity.TEMPLET_ID;
                //this.ddlInputTEMPLET_ID.NameValue = string.IsNullOrEmpty(baseEntity.TEMPLET_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_T.Proxy.Get(new EntityObject_BGT_D_BUDGET_T(){ID = baseEntity.TEMPLET_ID}).NAME;
                //this.ddlInputTEMPLET_ID.DataTable = "BGT_D_BUDGET_T";

                CauseObject_BGT_D_BUDGET_T pt = new CauseObject_BGT_D_BUDGET_T();
                pt.SetCustomCondition(" and BGT_D_BUDGET_T.TEMPLET_TYPE_ID='00090002' and BGT_D_BUDGET_T.BUDGET_CONTENTS_ID = '00120003' and  BGT_D_BUDGET_T.Budget_Year = (select Id from bgt_d_budget_year where IS_AVAILABE = 1 and rownum = 1) ");
                SetForeignKeySelected<CauseObject_BGT_D_BUDGET_T>(this.ddlInputTEMPLET_ID, typeof(BizLogicObject_BGT_D_BUDGET_T), baseEntity.TEMPLET_ID, "ID", "NAME", pt);

				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_D_BUDGET_ITEM cause117 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause117.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_B_DEPT_PAY_YEAR_D.ITEM_ID from BGT_B_DEPT_PAY_YEAR_D where BGT_B_DEPT_PAY_YEAR_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_DEPT_PAY_YEAR_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause117);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_PAY_YEAR> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_PAY_YEAR entity = new EntityObject_BGT_B_DEPT_PAY_YEAR();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

