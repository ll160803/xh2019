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
    public partial class PageObject_BGT_B_DEPT_EXPENSE : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
			CauseObject_BGT_D_BUDGET_ITEM cause773 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause773.IS_END = 1;
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause773);
        }            
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_EXPENSE_D cause = new CauseObject_BGT_B_DEPT_EXPENSE_D();
			if (ViewState["CUR_OBJ"] != null)
				cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE).ID;
			dataSource = BizLogicObject_BGT_B_DEPT_EXPENSE_D.Proxy.Query(cause);
			System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_EXPENSE_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_EXPENSE_D>();
			list.AddRange((DisplayObject_BGT_B_DEPT_EXPENSE_D[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_EXPENSE_D>(5));
			dataSource = list.ToArray();
            return dataSource;
        }       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_DEPT_EXPENSE_D),NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
            this.ddlInputAPPLY_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            this.ddlInputAPPLY_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
			this.txtInputAPPLY_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputSUMARRY.Text = string.Empty;
            this.txtInputPAY_DATE.Text = string.Empty;
			this.txtInputCODE.Text = string.Empty;
			this.ddlInputAPPLY_DEPT_ID.DataTable = "COM_DEPART";
            this.ddlInputAPPLY_DEPT_ID.KeyValue = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            this.ddlInputAPPLY_DEPT_ID.NameValue = SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME;
			this.txtInputPAY_MONEY.Text = "0.00";
			this.ddlInputPAY_USER_ID.DataTable = "COM_USER";
            this.ddlInputPAY_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
			this.txtInputAPPLY_MONEY.Text = "0.00";
			this.txtInputFINANCE_CYCLE.Text = string.Empty;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_EXPENSE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_EXPENSE_D>();
				EntityObject_BGT_B_DEPT_EXPENSE baseEntity = new EntityObject_BGT_B_DEPT_EXPENSE();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										baseEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					baseEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					baseEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.SUMARRY = txtInputSUMARRY.Text;
					if(!string.IsNullOrEmpty(txtInputPAY_DATE.Text))
					baseEntity.PAY_DATE = DateTime.Parse(txtInputPAY_DATE.Text);
					else
					baseEntity.PAY_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_DEPT_ID.KeyValue))
										baseEntity.APPLY_DEPT_ID = ddlInputAPPLY_DEPT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputPAY_MONEY.Text))
					baseEntity.PAY_MONEY = decimal.Parse(txtInputPAY_MONEY.Text);
					else
					baseEntity.PAY_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputPAY_USER_ID.KeyValue))
										baseEntity.PAY_USER_ID = ddlInputPAY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					baseEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					baseEntity.APPLY_MONEY = 0;
					baseEntity.FINANCE_CYCLE = txtInputFINANCE_CYCLE.Text;
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputSUMARRY1 = (ComTextBox)row.FindControl("txtInputSUMARRY");
							ComTextBox txtInputPAY_MONEY1 = (ComTextBox)row.FindControl("txtInputPAY_MONEY");
							ComTextBox txtInputAPPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_EXPENSE_D detailEntity = new EntityObject_BGT_B_DEPT_EXPENSE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.SUMARRY = txtInputSUMARRY1.Text;
					if(!string.IsNullOrEmpty(txtInputPAY_MONEY1.Text))
					detailEntity.PAY_MONEY = decimal.Parse(txtInputPAY_MONEY1.Text);
					else
					detailEntity.PAY_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY1.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY1.Text);
					else
					detailEntity.APPLY_MONEY = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);        
                ViewState["CUR_OBJ"] = baseEntity;
                        PrepareDetailDataSourceControl(baseEntity.ID);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_EXPENSE_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_EXPENSE_D>();
						List<EntityObject_BGT_B_DEPT_EXPENSE_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_EXPENSE_D>();
						List<EntityObject_BGT_B_DEPT_EXPENSE_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_EXPENSE_D>();
						EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										baseEntity.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					baseEntity.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					baseEntity.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.SUMARRY = txtInputSUMARRY.Text;
					if(!string.IsNullOrEmpty(txtInputPAY_DATE.Text))
					baseEntity.PAY_DATE = DateTime.Parse(txtInputPAY_DATE.Text);
					else
					baseEntity.PAY_DATE = Ipedf.Common.Template.UndefineDatetime;
					baseEntity.CODE = txtInputCODE.Text;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_DEPT_ID.KeyValue))
										baseEntity.APPLY_DEPT_ID = ddlInputAPPLY_DEPT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputPAY_MONEY.Text))
					baseEntity.PAY_MONEY = decimal.Parse(txtInputPAY_MONEY.Text);
					else
					baseEntity.PAY_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputPAY_USER_ID.KeyValue))
										baseEntity.PAY_USER_ID = ddlInputPAY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					baseEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					baseEntity.APPLY_MONEY = 0;
					baseEntity.FINANCE_CYCLE = txtInputFINANCE_CYCLE.Text;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputSUMARRY1 = (ComTextBox)row.FindControl("txtInputSUMARRY");
							ComTextBox txtInputPAY_MONEY1 = (ComTextBox)row.FindControl("txtInputPAY_MONEY");
							ComTextBox txtInputAPPLY_MONEY1 = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_EXPENSE_D detailEntity = new EntityObject_BGT_B_DEPT_EXPENSE_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					detailEntity.SUMARRY = txtInputSUMARRY1.Text;
					if(!string.IsNullOrEmpty(txtInputPAY_MONEY1.Text))
					detailEntity.PAY_MONEY = decimal.Parse(txtInputPAY_MONEY1.Text);
					else
					detailEntity.PAY_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY1.Text))
					detailEntity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY1.Text);
					else
					detailEntity.APPLY_MONEY = 0;
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
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
                EntityObject_BGT_B_DEPT_EXPENSE_D entity = (EntityObject_BGT_B_DEPT_EXPENSE_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputSUMARRY = (ComTextBox)e.Row.FindControl("txtInputSUMARRY");
				txtInputSUMARRY.Text = entity.SUMARRY == null ? String.Empty: entity.SUMARRY.ToString();
				ComTextBox txtInputPAY_MONEY = (ComTextBox)e.Row.FindControl("txtInputPAY_MONEY");
				txtInputPAY_MONEY.Text = entity.PAY_MONEY == null ? "0": entity.PAY_MONEY.ToString();
				ComTextBox txtInputAPPLY_MONEY = (ComTextBox)e.Row.FindControl("txtInputAPPLY_MONEY");
				txtInputAPPLY_MONEY.Text = entity.APPLY_MONEY == null ? "0": entity.APPLY_MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select

                ComUpFile upfile = (ComUpFile)e.Row.FindControl("upfile");
                upfile.TableId = entity.ID;
                upfile.TableName = "BGT_B_DEPT_EXPENSE_D";
                upfile.ReadOnly= entity.ID == string.Empty;
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_EXPENSE cause = new CauseObject_BGT_B_DEPT_EXPENSE();
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_EXPENSE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_EXPENSE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_EXPENSE cause = (CauseObject_BGT_B_DEPT_EXPENSE)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_EXPENSE baseEntity = new EntityObject_BGT_B_DEPT_EXPENSE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Get(baseEntity);
				this.ddlInputAPPLY_USER_ID.KeyField = "ID";
				this.ddlInputAPPLY_USER_ID.NameField = "NAME";
				this.ddlInputAPPLY_USER_ID.KeyValue = baseEntity.APPLY_USER_ID;
				this.ddlInputAPPLY_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.APPLY_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.APPLY_USER_ID}).NAME;
				this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
				this.txtInputAPPLY_DATE.Text = baseEntity.APPLY_DATE == null ? string.Empty:baseEntity.APPLY_DATE.ToString();
				this.txtInputSUMARRY.Text = baseEntity.SUMARRY == null ? string.Empty:baseEntity.SUMARRY.ToString();
				this.txtInputPAY_DATE.Text = baseEntity.PAY_DATE == null ? string.Empty:baseEntity.PAY_DATE.ToString();
				this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty:baseEntity.CODE.ToString();
				this.ddlInputAPPLY_DEPT_ID.KeyField = "ID";
				this.ddlInputAPPLY_DEPT_ID.NameField = "NAME";
				this.ddlInputAPPLY_DEPT_ID.KeyValue = baseEntity.APPLY_DEPT_ID;
				this.ddlInputAPPLY_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.APPLY_DEPT_ID)?string.Empty: BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART(){ID = baseEntity.APPLY_DEPT_ID}).NAME;
				this.ddlInputAPPLY_DEPT_ID.DataTable = "COM_DEPART";
				this.txtInputPAY_MONEY.Text = baseEntity.PAY_MONEY == null ? string.Empty:baseEntity.PAY_MONEY.ToString();
				this.ddlInputPAY_USER_ID.KeyField = "ID";
				this.ddlInputPAY_USER_ID.NameField = "NAME";
				this.ddlInputPAY_USER_ID.KeyValue = baseEntity.PAY_USER_ID;
				this.ddlInputPAY_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.PAY_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = baseEntity.PAY_USER_ID}).NAME;
				this.ddlInputPAY_USER_ID.DataTable = "COM_USER";
				this.txtInputAPPLY_MONEY.Text = baseEntity.APPLY_MONEY == null ? string.Empty:baseEntity.APPLY_MONEY.ToString();
				this.txtInputFINANCE_CYCLE.Text = baseEntity.FINANCE_CYCLE == null ? string.Empty:baseEntity.FINANCE_CYCLE.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg =BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Submit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_EXPENSE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_EXPENSE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_EXPENSE entity = new EntityObject_BGT_B_DEPT_EXPENSE();
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
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_EXPENSE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_BGT_B_DEPT_EXPENSE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            if (baseEntity == null)
            {
                try { OnSave(sender, e); }
                catch (Exception expt) { ShowError(expt.Message); return; }
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_EXPENSE;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_DEPT_EXPENSE_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        protected override void DeserializeSourceObject(string key, string parameter)
        {            
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_DEPT_EXPENSE_D> dl = new List<EntityObject_BGT_B_DEPT_EXPENSE_D>();
            foreach (string entity in el)
            {
                EntityObject_BGT_B_DEPT_EXPENSE_D detailEntity = new EntityObject_BGT_B_DEPT_EXPENSE_D();
                detailEntity.BASE_ID = key;
                detailEntity.ITEM_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_B_DEPT_EXPENSE_D.Proxy.BatchSave(dl.ToArray());
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {
           
        }
    }
}

