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
	public partial class PageObject_BGT_D_BUDGET_T_D : ComSimplePage
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
			CauseObject_BGT_D_BUDGET_T_D cause = (CauseObject_BGT_D_BUDGET_T_D)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.ddlInputITEM_ID.DataTable = "BGT_D_PLAN_ITEM";
			this.txtInputCONSULT.Text = string.Empty;
			CauseObject_COM_TYPE cause655 =  new CauseObject_COM_TYPE();
			cause655.PARENT_ID = "0011";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputCALCULATE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause655);
			this.txtInputCALCULATE_FORMULA.Text = string.Empty;
			this.txtInputCALCULATE_INDEX.Text = "0.00";
			CauseObject_COM_TYPE cause345 =  new CauseObject_COM_TYPE();
			cause345.PARENT_ID = "0010";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputPREPARE_METHOD_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause345);
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
				EntityObject_BGT_D_BUDGET_T_D curObj = new EntityObject_BGT_D_BUDGET_T_D();
									//平台自动生成代码
					curObj.CONSULT = txtInputCONSULT.Text;
									if(!string.IsNullOrEmpty(ddlInputCALCULATE_METHOD_ID.SelectedValue))
										curObj.CALCULATE_METHOD_ID = ddlInputCALCULATE_METHOD_ID.SelectedValue;
					curObj.CALCULATE_FORMULA = txtInputCALCULATE_FORMULA.Text;
					if(!string.IsNullOrEmpty(txtInputCALCULATE_INDEX.Text))
					curObj.CALCULATE_INDEX = decimal.Parse(txtInputCALCULATE_INDEX.Text);
					else
					curObj.CALCULATE_INDEX = 0;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_METHOD_ID.SelectedValue))
										curObj.PREPARE_METHOD_ID = ddlInputPREPARE_METHOD_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_T_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
									//平台自动生成代码
					curObj.CONSULT = txtInputCONSULT.Text;
									if(!string.IsNullOrEmpty(ddlInputCALCULATE_METHOD_ID.SelectedValue))
										curObj.CALCULATE_METHOD_ID = ddlInputCALCULATE_METHOD_ID.SelectedValue;
					curObj.CALCULATE_FORMULA = txtInputCALCULATE_FORMULA.Text;
					if(!string.IsNullOrEmpty(txtInputCALCULATE_INDEX.Text))
					curObj.CALCULATE_INDEX = decimal.Parse(txtInputCALCULATE_INDEX.Text);
					else
					curObj.CALCULATE_INDEX = 0;
									if(!string.IsNullOrEmpty(ddlInputPREPARE_METHOD_ID.SelectedValue))
										curObj.PREPARE_METHOD_ID = ddlInputPREPARE_METHOD_ID.SelectedValue;
                                    BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Update(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_T_D curObj = new EntityObject_BGT_D_BUDGET_T_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Get(curObj);
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = curObj.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ITEM_ID)?string.Empty: BizLogicObject_BGT_D_PLAN_ITEM.Proxy.Get(new EntityObject_BGT_D_PLAN_ITEM(){ID = curObj.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_D_PLAN_ITEM";
				this.txtInputCONSULT.Text = curObj.CONSULT == null ? string.Empty:curObj.CONSULT.ToString();
				CauseObject_COM_TYPE cause757 =  new CauseObject_COM_TYPE();
				cause757.PARENT_ID = "0011";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputCALCULATE_METHOD_ID, typeof( BizLogicObject_COM_TYPE), curObj.CALCULATE_METHOD_ID,"ID","NAME",cause757);
				this.txtInputCALCULATE_FORMULA.Text = curObj.CALCULATE_FORMULA == null ? string.Empty:curObj.CALCULATE_FORMULA.ToString();
				this.txtInputCALCULATE_INDEX.Text = curObj.CALCULATE_INDEX == null ? string.Empty:curObj.CALCULATE_INDEX.ToString();
				CauseObject_COM_TYPE cause784 =  new CauseObject_COM_TYPE();
				cause784.PARENT_ID = "0010";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputPREPARE_METHOD_ID, typeof( BizLogicObject_COM_TYPE), curObj.PREPARE_METHOD_ID,"ID","NAME",cause784);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_T_D cause = new CauseObject_BGT_D_BUDGET_T_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_T_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_D_BUDGET_T_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_T_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_T_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_T_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_T_D> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_T_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_T_D entity = new EntityObject_BGT_D_BUDGET_T_D();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_T_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

