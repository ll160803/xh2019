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
	public partial class PageObject_BGT_B_BUDGET_PROJ_ADJUST_D : ComSimplePage
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
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D cause = (CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			CauseObject_COM_TYPE cause854 =  new CauseObject_COM_TYPE();
			cause854.PARENT_ID = "0031";
			SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputADJUST_TYPE_ID, typeof( BizLogicObject_COM_TYPE),"ID","NAME",cause854);
			this.ddlInputITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
			this.txtInputADJUST_VALUE.Text = "0.00";
			this.txtInputITEM_BASE_VALUE.Text = "0.00";
			this.txtInputITEM_VALUE.Text = "0.00";
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
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputADJUST_TYPE_ID.SelectedValue))
										curObj.ADJUST_TYPE_ID = ddlInputADJUST_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputADJUST_VALUE.Text))
					curObj.ADJUST_VALUE = decimal.Parse(txtInputADJUST_VALUE.Text);
					else
					curObj.ADJUST_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_BASE_VALUE.Text))
					curObj.ITEM_BASE_VALUE = decimal.Parse(txtInputITEM_BASE_VALUE.Text);
					else
					curObj.ITEM_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					curObj.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					curObj.ITEM_VALUE = 0;
				BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputADJUST_TYPE_ID.SelectedValue))
										curObj.ADJUST_TYPE_ID = ddlInputADJUST_TYPE_ID.SelectedValue;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										curObj.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputADJUST_VALUE.Text))
					curObj.ADJUST_VALUE = decimal.Parse(txtInputADJUST_VALUE.Text);
					else
					curObj.ADJUST_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_BASE_VALUE.Text))
					curObj.ITEM_BASE_VALUE = decimal.Parse(txtInputITEM_BASE_VALUE.Text);
					else
					curObj.ITEM_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputITEM_VALUE.Text))
					curObj.ITEM_VALUE = decimal.Parse(txtInputITEM_VALUE.Text);
					else
					curObj.ITEM_VALUE = 0;
				BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D curObj = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Get(curObj);
				CauseObject_COM_TYPE cause213 =  new CauseObject_COM_TYPE();
				cause213.PARENT_ID = "0031";
				SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputADJUST_TYPE_ID, typeof( BizLogicObject_COM_TYPE), curObj.ADJUST_TYPE_ID,"ID","NAME",cause213);
				this.ddlInputITEM_ID.KeyField = "ID";
				this.ddlInputITEM_ID.NameField = "NAME";
				this.ddlInputITEM_ID.KeyValue = curObj.ITEM_ID;
				this.ddlInputITEM_ID.NameValue = string.IsNullOrEmpty(curObj.ITEM_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_PROJ_D.Proxy.Get(new EntityObject_BGT_B_BUDGET_PROJ_D(){ID = curObj.ITEM_ID}).NAME;
				this.ddlInputITEM_ID.DataTable = "BGT_B_BUDGET_PROJ_D";
				this.txtInputADJUST_VALUE.Text = curObj.ADJUST_VALUE == null ? string.Empty:curObj.ADJUST_VALUE.ToString();
				this.txtInputITEM_BASE_VALUE.Text = curObj.ITEM_BASE_VALUE == null ? string.Empty:curObj.ITEM_BASE_VALUE.ToString();
				this.txtInputITEM_VALUE.Text = curObj.ITEM_VALUE == null ? string.Empty:curObj.ITEM_VALUE.ToString();
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D cause = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_PROJ_ADJUST_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D entity = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D();
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
                BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

