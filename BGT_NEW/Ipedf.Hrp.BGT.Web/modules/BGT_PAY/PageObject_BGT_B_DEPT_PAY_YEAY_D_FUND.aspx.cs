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
	public partial class PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND : ComSimplePage
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
			CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = (CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputDECLARE_CAUSE.Text = string.Empty;
			this.txtInputASSET_ID.Text = string.Empty;
			this.txtInputMONEY.Text = "0.00";
			this.txtInputFUND_NAME.Text = string.Empty;
			this.txtInputAMOUNT.Text = "0.00";
			this.txtInputPRICE.Text = "0.00";
			this.txtInputCOMPLETE_TIME.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.txtInputASSET_NAME.Text = string.Empty;
			this.txtInputBUILDING_NAME.Text = string.Empty;
			this.ddlInputACCOUNT_ITEM_ID.DataTable = "BGT_D_ACCOUNT_ITEM";
			this.ddlInputBGT_D_ACCOUNT_ITEM_ID.DataTable = "BGT_D_ACCOUNT_ITEM";
			this.txtInputFINANCE_IDEA.Text = string.Empty;
			this.txtInputFREE_FIELD3.Text = string.Empty;
			this.txtInputFREE_FIELD.Text = string.Empty;
			this.txtInputFREE_FIELD2.Text = string.Empty;
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
				EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND curObj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
									//平台自动生成代码
					curObj.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
					curObj.ASSET_ID = txtInputASSET_ID.Text;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					curObj.FUND_NAME = txtInputFUND_NAME.Text;
					if(!string.IsNullOrEmpty(txtInputAMOUNT.Text))
					curObj.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
					else
					curObj.AMOUNT = 0;
					if(!string.IsNullOrEmpty(txtInputPRICE.Text))
					curObj.PRICE = decimal.Parse(txtInputPRICE.Text);
					else
					curObj.PRICE = 0;
					if(!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
					curObj.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
					else
					curObj.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;
					curObj.ASSET_NAME = txtInputASSET_NAME.Text;
					curObj.BUILDING_NAME = txtInputBUILDING_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
										curObj.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue))
										curObj.BGT_D_ACCOUNT_ITEM_ID = ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue;
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
					curObj.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
					curObj.FREE_FIELD = txtInputFREE_FIELD.Text;
					curObj.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
				BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
									//平台自动生成代码
					curObj.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
					curObj.ASSET_ID = txtInputASSET_ID.Text;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					curObj.FUND_NAME = txtInputFUND_NAME.Text;
					if(!string.IsNullOrEmpty(txtInputAMOUNT.Text))
					curObj.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
					else
					curObj.AMOUNT = 0;
					if(!string.IsNullOrEmpty(txtInputPRICE.Text))
					curObj.PRICE = decimal.Parse(txtInputPRICE.Text);
					else
					curObj.PRICE = 0;
					if(!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
					curObj.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
					else
					curObj.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;
					curObj.ASSET_NAME = txtInputASSET_NAME.Text;
					curObj.BUILDING_NAME = txtInputBUILDING_NAME.Text;
									if(!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
										curObj.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue))
										curObj.BGT_D_ACCOUNT_ITEM_ID = ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue;
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
					curObj.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
					curObj.FREE_FIELD = txtInputFREE_FIELD.Text;
					curObj.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
				BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND curObj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Get(curObj);
				this.txtInputDECLARE_CAUSE.Text = curObj.DECLARE_CAUSE == null ? string.Empty:curObj.DECLARE_CAUSE.ToString();
				this.txtInputASSET_ID.Text = curObj.ASSET_ID == null ? string.Empty:curObj.ASSET_ID.ToString();
				this.txtInputMONEY.Text = curObj.MONEY == null ? string.Empty:curObj.MONEY.ToString();
				this.txtInputFUND_NAME.Text = curObj.FUND_NAME == null ? string.Empty:curObj.FUND_NAME.ToString();
				this.txtInputAMOUNT.Text = curObj.AMOUNT == null ? string.Empty:curObj.AMOUNT.ToString();
				this.txtInputPRICE.Text = curObj.PRICE == null ? string.Empty:curObj.PRICE.ToString();
				this.txtInputCOMPLETE_TIME.Text = curObj.COMPLETE_TIME == null ? string.Empty:curObj.COMPLETE_TIME.ToString();
				this.txtInputASSET_NAME.Text = curObj.ASSET_NAME == null ? string.Empty:curObj.ASSET_NAME.ToString();
				this.txtInputBUILDING_NAME.Text = curObj.BUILDING_NAME == null ? string.Empty:curObj.BUILDING_NAME.ToString();
				this.ddlInputACCOUNT_ITEM_ID.KeyField = "ID";
				this.ddlInputACCOUNT_ITEM_ID.NameField = "NAME";
				this.ddlInputACCOUNT_ITEM_ID.KeyValue = curObj.ACCOUNT_ITEM_ID;
				this.ddlInputACCOUNT_ITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ACCOUNT_ITEM_ID)?string.Empty: BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Get(new EntityObject_BGT_D_ACCOUNT_ITEM(){ID = curObj.ACCOUNT_ITEM_ID}).NAME;
				this.ddlInputACCOUNT_ITEM_ID.DataTable = "BGT_D_ACCOUNT_ITEM";
				this.ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyField = "ID";
				this.ddlInputBGT_D_ACCOUNT_ITEM_ID.NameField = "NAME";
				this.ddlInputBGT_D_ACCOUNT_ITEM_ID.KeyValue = curObj.BGT_D_ACCOUNT_ITEM_ID;
				this.ddlInputBGT_D_ACCOUNT_ITEM_ID.NameValue = string.IsNullOrEmpty(curObj.BGT_D_ACCOUNT_ITEM_ID)?string.Empty: BizLogicObject_BGT_D_ACCOUNT_ITEM.Proxy.Get(new EntityObject_BGT_D_ACCOUNT_ITEM(){ID = curObj.BGT_D_ACCOUNT_ITEM_ID}).NAME;
				this.ddlInputBGT_D_ACCOUNT_ITEM_ID.DataTable = "BGT_D_ACCOUNT_ITEM";
				this.txtInputFINANCE_IDEA.Text = curObj.FINANCE_IDEA == null ? string.Empty:curObj.FINANCE_IDEA.ToString();
				this.txtInputFREE_FIELD3.Text = curObj.FREE_FIELD3 == null ? string.Empty:curObj.FREE_FIELD3.ToString();
				this.txtInputFREE_FIELD.Text = curObj.FREE_FIELD == null ? string.Empty:curObj.FREE_FIELD.ToString();
				this.txtInputFREE_FIELD2.Text = curObj.FREE_FIELD2 == null ? string.Empty:curObj.FREE_FIELD2.ToString();
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND entity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
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
                BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

