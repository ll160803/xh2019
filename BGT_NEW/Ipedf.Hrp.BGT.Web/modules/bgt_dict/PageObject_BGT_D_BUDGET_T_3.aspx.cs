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
    public partial class PageObject_BGT_D_BUDGET_T_3 : ComNestingResourceEditPage
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
            if (string.IsNullOrEmpty(txtInputNAME.Text))
                throw new Exception("方案名称不能为空");
        }
        protected override void OnResultGridRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Copy_Data")
            {
                GridViewRow curRow = (sender as GridView).Rows[Convert.ToInt32(e.CommandArgument)];
                EntityObject_BGT_D_BUDGET_T baseEntity = new EntityObject_BGT_D_BUDGET_T();

                baseEntity.ID = gvResultList.DataKeys[curRow.RowIndex].Value.ToString();

                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T.Proxy.CopyNew(baseEntity);
                    if (!msg.Succeed)
                    {
                        throw new Exception(msg.Message);
                    }
                    else
                    {
                        ShowData();
                    }
                }
                catch (Exception expt)
                {
                    ShowError(expt.Message);
                }

            }
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_YEAR cause121 =  new CauseObject_BGT_D_BUDGET_YEAR();
            cause121.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR),"ID","BUDGET_YEAR",cause121);
			this.txtInputCODE.Text = string.Empty;
			this.txtInputNAME.Text = string.Empty;
            CauseObject_COM_TYPE cause662 =  new CauseObject_COM_TYPE();
            cause662.PARENT_ID = "0012";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause662);

            WebControlHelper.SetSelected(this.ddlInputBUDGET_CONTENTS_ID, "00120003");//支出预算
            this.ddlInputBUDGET_CONTENTS_ID.Enabled = false;

			CauseObject_COM_TYPE cause234 =  new CauseObject_COM_TYPE();
			cause234.PARENT_ID = "0009";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputTEMPLET_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause234);
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_D_BUDGET_T_D> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_D>();
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
								
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputCONSULT = (ComTextBox)row.FindControl("txtInputCONSULT");
							ComDropDownList ddlInputCALCULATE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputCALCULATE_METHOD_ID");
							ComTextBox txtInputCALCULATE_FORMULA = (ComTextBox)row.FindControl("txtInputCALCULATE_FORMULA");
							ComTextBox txtInputCALCULATE_INDEX = (ComTextBox)row.FindControl("txtInputCALCULATE_INDEX");
							ComDropDownList ddlInputPREPARE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputPREPARE_METHOD_ID");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_D detailEntity = new EntityObject_BGT_D_BUDGET_T_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.CONSULT = txtInputCONSULT.Text;
									if(!string.IsNullOrEmpty(ddlInputCALCULATE_METHOD_ID.SelectedValue))
										detailEntity.CALCULATE_METHOD_ID = ddlInputCALCULATE_METHOD_ID.SelectedValue;
					detailEntity.CALCULATE_FORMULA = txtInputCALCULATE_FORMULA.Text;
					if(!string.IsNullOrEmpty(txtInputCALCULATE_INDEX.Text))
					detailEntity.CALCULATE_INDEX = decimal.Parse(txtInputCALCULATE_INDEX.Text);
					else
					detailEntity.CALCULATE_INDEX = 0;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_METHOD_ID.SelectedValue))
										detailEntity.PREPARE_METHOD_ID = ddlInputPREPARE_METHOD_ID.SelectedValue;
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
						List<EntityObject_BGT_D_BUDGET_T_D> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_D>();
						List<EntityObject_BGT_D_BUDGET_T_D> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_D>();
						List<EntityObject_BGT_D_BUDGET_T_D> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_D>();
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
								
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputCONSULT = (ComTextBox)row.FindControl("txtInputCONSULT");
							ComDropDownList ddlInputCALCULATE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputCALCULATE_METHOD_ID");
							ComTextBox txtInputCALCULATE_FORMULA = (ComTextBox)row.FindControl("txtInputCALCULATE_FORMULA");
							ComTextBox txtInputCALCULATE_INDEX = (ComTextBox)row.FindControl("txtInputCALCULATE_INDEX");
							ComDropDownList ddlInputPREPARE_METHOD_ID = (ComDropDownList)row.FindControl("ddlInputPREPARE_METHOD_ID");
							//平台自动生成代码
								EntityObject_BGT_D_BUDGET_T_D detailEntity = new EntityObject_BGT_D_BUDGET_T_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.CONSULT = txtInputCONSULT.Text;
									if(!string.IsNullOrEmpty(ddlInputCALCULATE_METHOD_ID.SelectedValue))
										detailEntity.CALCULATE_METHOD_ID = ddlInputCALCULATE_METHOD_ID.SelectedValue;
					detailEntity.CALCULATE_FORMULA = txtInputCALCULATE_FORMULA.Text;
					if(!string.IsNullOrEmpty(txtInputCALCULATE_INDEX.Text))
					detailEntity.CALCULATE_INDEX = decimal.Parse(txtInputCALCULATE_INDEX.Text);
					else
					detailEntity.CALCULATE_INDEX = 0;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_METHOD_ID.SelectedValue))
										detailEntity.PREPARE_METHOD_ID = ddlInputPREPARE_METHOD_ID.SelectedValue;
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
                EntityObject_BGT_D_BUDGET_T_D entity = (EntityObject_BGT_D_BUDGET_T_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
				ComTextBox txtInputCONSULT = (ComTextBox)e.Row.FindControl("txtInputCONSULT");
				txtInputCONSULT.Text = entity.CONSULT == null ? String.Empty: entity.CONSULT.ToString();
				ComDropDownList ddlInputCALCULATE_METHOD_ID= (ComDropDownList)e.Row.FindControl("ddlInputCALCULATE_METHOD_ID");
				CopyComDropDownListItem(ddlDataSourceCALCULATE_METHOD_ID,ddlInputCALCULATE_METHOD_ID, entity.CALCULATE_METHOD_ID);
				ComTextBox txtInputCALCULATE_FORMULA = (ComTextBox)e.Row.FindControl("txtInputCALCULATE_FORMULA");
				txtInputCALCULATE_FORMULA.Text = entity.CALCULATE_FORMULA == null ? String.Empty: entity.CALCULATE_FORMULA.ToString();
				ComTextBox txtInputCALCULATE_INDEX = (ComTextBox)e.Row.FindControl("txtInputCALCULATE_INDEX");
				txtInputCALCULATE_INDEX.Text = entity.CALCULATE_INDEX == null ? "0": entity.CALCULATE_INDEX.ToString();
				ComDropDownList ddlInputPREPARE_METHOD_ID= (ComDropDownList)e.Row.FindControl("ddlInputPREPARE_METHOD_ID");
				CopyComDropDownListItem(ddlDataSourcePREPARE_METHOD_ID,ddlInputPREPARE_METHOD_ID, entity.PREPARE_METHOD_ID);
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T cause = new CauseObject_BGT_D_BUDGET_T();
            cause.BUDGET_CONTENTS_ID = "00120003";//支出预算
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_T>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_T_3_Param.aspx", 500, 500);
            return scripts;
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
				CauseObject_BGT_D_BUDGET_YEAR cause646 =  new CauseObject_BGT_D_BUDGET_YEAR();
                //cause646.IS_VALID = 1;
				SetForeignKeySelected<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof( BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR,"ID","BUDGET_YEAR",cause646);
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
				this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
				CauseObject_COM_TYPE cause461 =  new CauseObject_COM_TYPE();
				cause461.PARENT_ID = "0012";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputBUDGET_CONTENTS_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.BUDGET_CONTENTS_ID,"ID","NAME",cause461);
                WebControlHelper.SetSelected(this.ddlInputBUDGET_CONTENTS_ID, "00120003");//支出预算
                this.ddlInputBUDGET_CONTENTS_ID.Enabled = false;


				CauseObject_COM_TYPE cause765 =  new CauseObject_COM_TYPE();
				cause765.PARENT_ID = "0009";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputTEMPLET_TYPE_ID, typeof( BizLogicObject_COM_TYPE), baseEntity.TEMPLET_TYPE_ID,"ID","NAME",cause765);
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
            //CauseObject_BGT_D_BUDGET_ITEM cause748 =  new CauseObject_BGT_D_BUDGET_ITEM();
            //cause748.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_D_BUDGET_T_D.ITEM_ID from BGT_D_BUDGET_T_D where BGT_D_BUDGET_T_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_D_BUDGET_T_D.ITEM_ID )");
            //SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause748);
			CauseObject_COM_TYPE cause587 =  new CauseObject_COM_TYPE();
			cause587.PARENT_ID = "0011";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourceCALCULATE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause587);
			CauseObject_COM_TYPE cause312 =  new CauseObject_COM_TYPE();
			cause312.PARENT_ID = "0010";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourcePREPARE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause312);
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
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_T_3_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_BUDGET_T_D> dl = new List<EntityObject_BGT_D_BUDGET_T_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_D_BUDGET_T_D detailEntity = new EntityObject_BGT_D_BUDGET_T_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_BUDGET_T_D.Proxy.BatchSave(dl.ToArray());
        }
    }
}

