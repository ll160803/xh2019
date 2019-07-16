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
using System.Data.SqlClient;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_B_BUDGET_PROJ_EXE_D : ComSimplePage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
		}
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause = (CauseObject_BGT_B_BUDGET_PROJ_EXE_D)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputINVOICE_CODE.Text = string.Empty;
			this.ddlInputITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
			this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
			this.txtInputEXECUTE_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputEXECUTE_MONEY.Text = "0.00";
			SetForeignKeyBinding(this.ddlInputEXECUTE_MONTH_ID, typeof( BizLogicObject_BGT_D_BUDGET_MONTH),"ID","BUDGET_MONTH");
			this.txtInputAPPLY_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputAPPLY_MONEY.Text = "0.00";
        }
        protected override string PrepareOrderByColumn()
        {
            return "Id";
        }
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_EXE_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
									//平台自动生成代码
					curObj.INVOICE_CODE = txtInputINVOICE_CODE.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										curObj.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_DATE.Text))
					curObj.EXECUTE_DATE = DateTime.Parse(txtInputEXECUTE_DATE.Text);
					else
					curObj.EXECUTE_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_MONEY.Text))
					curObj.EXECUTE_MONEY = decimal.Parse(txtInputEXECUTE_MONEY.Text);
					else
					curObj.EXECUTE_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputEXECUTE_MONTH_ID.SelectedValue))
										curObj.EXECUTE_MONTH_ID = ddlInputEXECUTE_MONTH_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					curObj.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					curObj.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					curObj.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					curObj.APPLY_MONEY = 0;
				BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_EXE_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
									//平台自动生成代码
					curObj.INVOICE_CODE = txtInputINVOICE_CODE.Text;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputAPPLY_USER_ID.KeyValue))
										curObj.APPLY_USER_ID = ddlInputAPPLY_USER_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_DATE.Text))
					curObj.EXECUTE_DATE = DateTime.Parse(txtInputEXECUTE_DATE.Text);
					else
					curObj.EXECUTE_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputEXECUTE_MONEY.Text))
					curObj.EXECUTE_MONEY = decimal.Parse(txtInputEXECUTE_MONEY.Text);
					else
					curObj.EXECUTE_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputEXECUTE_MONTH_ID.SelectedValue))
										curObj.EXECUTE_MONTH_ID = ddlInputEXECUTE_MONTH_ID.SelectedValue;
					if(!string.IsNullOrEmpty(txtInputAPPLY_DATE.Text))
					curObj.APPLY_DATE = DateTime.Parse(txtInputAPPLY_DATE.Text);
					else
					curObj.APPLY_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					curObj.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					curObj.APPLY_MONEY = 0;
				BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_EXE_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Get(curObj);
				this.txtInputINVOICE_CODE.Text = curObj.INVOICE_CODE == null ? string.Empty:curObj.INVOICE_CODE.ToString();
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = curObj.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ITEM_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Get(new EntityObject_BGT_B_BUDGET_PROJ_D(){ID = curObj.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
				this.ddlInputAPPLY_USER_ID.KeyField = "ID";
				this.ddlInputAPPLY_USER_ID.NameField = "NAME";
				this.ddlInputAPPLY_USER_ID.KeyValue = curObj.APPLY_USER_ID;
				this.ddlInputAPPLY_USER_ID.NameValue = string.IsNullOrEmpty(curObj.APPLY_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = curObj.APPLY_USER_ID}).NAME;
				this.ddlInputAPPLY_USER_ID.DataTable = "COM_USER";
				this.txtInputEXECUTE_DATE.Text = curObj.EXECUTE_DATE == null ? string.Empty:curObj.EXECUTE_DATE.ToString();
				this.txtInputEXECUTE_MONEY.Text = curObj.EXECUTE_MONEY == null ? string.Empty:curObj.EXECUTE_MONEY.ToString();
				SetForeignKeySelected(this.ddlInputEXECUTE_MONTH_ID, typeof( BizLogicObject_BGT_D_BUDGET_MONTH), curObj.EXECUTE_MONTH_ID,"ID","BUDGET_MONTH");
				this.txtInputAPPLY_DATE.Text = curObj.APPLY_DATE == null ? string.Empty:curObj.APPLY_DATE.ToString();
				this.txtInputAPPLY_MONEY.Text = curObj.APPLY_MONEY == null ? string.Empty:curObj.APPLY_MONEY.ToString();
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause = new CauseObject_BGT_B_BUDGET_PROJ_EXE_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_EXE_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_EXE_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_EXE_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_EXE_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_EXE_D entity = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
                    entity.ID = gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities.Add(entity);
                        }
                    }
                }
            }
            try
            {
                BizLogicObject_BGT_B_BUDGET_PROJ_EXE_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
	}
}

