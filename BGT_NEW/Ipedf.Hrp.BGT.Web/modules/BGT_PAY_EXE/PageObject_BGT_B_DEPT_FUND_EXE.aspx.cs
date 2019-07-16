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
	public partial class PageObject_BGT_B_DEPT_FUND_EXE : ComSimplePage
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
			CauseObject_BGT_B_DEPT_FUND_EXE cause = (CauseObject_BGT_B_DEPT_FUND_EXE)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
			this.txtInputFREE_FIELD3.Text = string.Empty;
			this.txtInputNEW_FUND_MONEY.Text = "0.00";
			this.txtInputFREE_FIELD.Text = string.Empty;
			this.txtInputDECALRE_CAUSE.Text = string.Empty;
			this.txtInputNAME.Text = string.Empty;
			this.txtInputCONTROL_MONEY.Text = "0.00";
			SetEnumReferenceBinding(this.ddlInputIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.txtInputFREE_FIELD2.Text = string.Empty;
			this.ddlInputFUND_TYPE_ID.DataTable = "COM_TYPE";
			this.txtInputREF_TAB_ID.Text = string.Empty;
			SetEnumReferenceBinding(this.ddlInputIS_UPDATE_ITEM, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.txtInputFUND_MONEY.Text = "0.00";
			this.txtInputFINANCE_IDEA.Text = string.Empty;
			SetEnumReferenceBinding(this.ddlInputIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			this.txtInputITEM_NAME.Text = string.Empty;
			this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
			this.txtInputCODE.Text = string.Empty;
        }
        protected override string PrepareOrderByColumn()
        {
            return "Create_Time";
        }
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_FUND_EXE curObj = new EntityObject_BGT_B_DEPT_FUND_EXE();
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
										curObj.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
					curObj.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
					if(!string.IsNullOrEmpty(txtInputNEW_FUND_MONEY.Text))
					curObj.NEW_FUND_MONEY = decimal.Parse(txtInputNEW_FUND_MONEY.Text);
					else
					curObj.NEW_FUND_MONEY = 0;
					curObj.FREE_FIELD = txtInputFREE_FIELD.Text;
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
					curObj.NAME = txtInputNAME.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					curObj.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					curObj.CONTROL_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_FIXED.SelectedValue))
										curObj.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
					curObj.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
									if(!string.IsNullOrEmpty(ddlInputFUND_TYPE_ID.KeyValue))
										curObj.FUND_TYPE_ID = ddlInputFUND_TYPE_ID.KeyValue;
					curObj.REF_TAB_ID = txtInputREF_TAB_ID.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_UPDATE_ITEM.SelectedValue))
										curObj.IS_UPDATE_ITEM = decimal.Parse(ddlInputIS_UPDATE_ITEM.SelectedValue);
					if(!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
					curObj.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
					else
					curObj.FUND_MONEY = 0;
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_PERFORMANCE.SelectedValue))
										curObj.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
										curObj.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;
					curObj.CODE = txtInputCODE.Text;
				BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_FUND_EXE curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
										curObj.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
					curObj.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
					if(!string.IsNullOrEmpty(txtInputNEW_FUND_MONEY.Text))
					curObj.NEW_FUND_MONEY = decimal.Parse(txtInputNEW_FUND_MONEY.Text);
					else
					curObj.NEW_FUND_MONEY = 0;
					curObj.FREE_FIELD = txtInputFREE_FIELD.Text;
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
					curObj.NAME = txtInputNAME.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					curObj.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					curObj.CONTROL_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputIS_FIXED.SelectedValue))
										curObj.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
					curObj.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
									if(!string.IsNullOrEmpty(ddlInputFUND_TYPE_ID.KeyValue))
										curObj.FUND_TYPE_ID = ddlInputFUND_TYPE_ID.KeyValue;
					curObj.REF_TAB_ID = txtInputREF_TAB_ID.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_UPDATE_ITEM.SelectedValue))
										curObj.IS_UPDATE_ITEM = decimal.Parse(ddlInputIS_UPDATE_ITEM.SelectedValue);
					if(!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
					curObj.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
					else
					curObj.FUND_MONEY = 0;
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
									if(!string.IsNullOrEmpty(ddlInputIS_PERFORMANCE.SelectedValue))
										curObj.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
										curObj.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;
					curObj.CODE = txtInputCODE.Text;
				BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_FUND_EXE curObj = new EntityObject_BGT_B_DEPT_FUND_EXE();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Get(curObj);
				this.ddlInputBUDGET_YEAR.KeyField = "ID";
				this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
				this.ddlInputBUDGET_YEAR.KeyValue = curObj.BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.NameValue = string.IsNullOrEmpty(curObj.BUDGET_YEAR)?string.Empty: BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(new EntityObject_BGT_D_BUDGET_YEAR(){ID = curObj.BUDGET_YEAR}).BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = curObj.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(curObj.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = curObj.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME";
				this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = curObj.BGT_D_BUDGET_ITEM_ID;
				this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(curObj.BGT_D_BUDGET_ITEM_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM(){ID = curObj.BGT_D_BUDGET_ITEM_ID}).NAME;
				this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
				this.txtInputFREE_FIELD3.Text = curObj.FREE_FIELD3 == null ? string.Empty:curObj.FREE_FIELD3.ToString();
				this.txtInputNEW_FUND_MONEY.Text = curObj.NEW_FUND_MONEY == null ? string.Empty:curObj.NEW_FUND_MONEY.ToString();
				this.txtInputFREE_FIELD.Text = curObj.FREE_FIELD == null ? string.Empty:curObj.FREE_FIELD.ToString();
				this.txtInputDECALRE_CAUSE.Text = curObj.DECALRE_CAUSE == null ? string.Empty:curObj.DECALRE_CAUSE.ToString();
				this.txtInputNAME.Text = curObj.NAME == null ? string.Empty:curObj.NAME.ToString();
				this.txtInputCONTROL_MONEY.Text = curObj.CONTROL_MONEY == null ? string.Empty:curObj.CONTROL_MONEY.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_FIXED, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_FIXED);
				this.txtInputFREE_FIELD2.Text = curObj.FREE_FIELD2 == null ? string.Empty:curObj.FREE_FIELD2.ToString();
				this.ddlInputFUND_TYPE_ID.KeyField = "ID";
				this.ddlInputFUND_TYPE_ID.NameField = "NAME";
				this.ddlInputFUND_TYPE_ID.KeyValue = curObj.FUND_TYPE_ID;
				this.ddlInputFUND_TYPE_ID.NameValue = string.IsNullOrEmpty(curObj.FUND_TYPE_ID)?string.Empty: BizLogicObject_COM_TYPE.Proxy.Get(new EntityObject_COM_TYPE(){ID = curObj.FUND_TYPE_ID}).NAME;
				this.ddlInputFUND_TYPE_ID.DataTable = "COM_TYPE";
				this.txtInputREF_TAB_ID.Text = curObj.REF_TAB_ID == null ? string.Empty:curObj.REF_TAB_ID.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_UPDATE_ITEM, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_UPDATE_ITEM);
				this.txtInputFUND_MONEY.Text = curObj.FUND_MONEY == null ? string.Empty:curObj.FUND_MONEY.ToString();
				this.txtInputFINANCE_IDEA.Text = curObj.FINANCE_IDEA == null ? string.Empty:curObj.FINANCE_IDEA.ToString();
				SetEnumReferenceSelected(this.ddlInputIS_PERFORMANCE, Type.GetType( "Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_PERFORMANCE);
				this.txtInputITEM_NAME.Text = curObj.ITEM_NAME == null ? string.Empty:curObj.ITEM_NAME.ToString();
				this.ddlInputDEPT_USER_ID.KeyField = "ID";
				this.ddlInputDEPT_USER_ID.NameField = "NAME";
				this.ddlInputDEPT_USER_ID.KeyValue = curObj.DEPT_USER_ID;
				this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(curObj.DEPT_USER_ID)?string.Empty: BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER(){ID = curObj.DEPT_USER_ID}).NAME;
				this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
				this.txtInputCODE.Text = curObj.CODE == null ? string.Empty:curObj.CODE.ToString();
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_FUND_EXE cause = new CauseObject_BGT_B_DEPT_FUND_EXE();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_FUND_EXE>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_DEPT_FUND_EXE obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_FUND_EXE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_FUND_EXE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_FUND_EXE>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_FUND_EXE entity = new EntityObject_BGT_B_DEPT_FUND_EXE();
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
                BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

