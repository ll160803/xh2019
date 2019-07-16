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
	public partial class PageObject_BGT_B_BUDGET_ADJUST : ComSimplePage
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
			CauseObject_BGT_B_BUDGET_ADJUST cause = (CauseObject_BGT_B_BUDGET_ADJUST)parameter;
            dataSource = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputADJUST_CODE.Text = string.Empty;
			this.txtInputADJUST_NUM.Text = string.Empty;
			this.txtInputCREATE_DATE.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
			this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.NameFieldAlias = "BUDGET_YEAR";
            this.ddlInputBUDGET_YEAR.KeyField = "ID";
            List<FieldItem> List = new List<FieldItem>();
            List.Add(new FieldItem() { Field = "BUDGET_YEAR", Title="预算年度", Width=80 });
            this.ddlInputBUDGET_YEAR.FieldItems = List;
            this.ddlInputBUDGET_YEAR.Condition = "IS_AVAILABE = 1";
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
				EntityObject_BGT_B_BUDGET_ADJUST curObj = new EntityObject_BGT_B_BUDGET_ADJUST();
									//平台自动生成代码
					curObj.ADJUST_CODE = txtInputADJUST_CODE.Text;
					curObj.ADJUST_NUM = txtInputADJUST_NUM.Text;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					curObj.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					curObj.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
				BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_ADJUST curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
									//平台自动生成代码
					curObj.ADJUST_CODE = txtInputADJUST_CODE.Text;
					curObj.ADJUST_NUM = txtInputADJUST_NUM.Text;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					curObj.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					curObj.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
										curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
				BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_BUDGET_ADJUST curObj = new EntityObject_BGT_B_BUDGET_ADJUST();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Get(curObj);
				this.txtInputADJUST_CODE.Text = curObj.ADJUST_CODE == null ? string.Empty:curObj.ADJUST_CODE.ToString();
				this.txtInputADJUST_NUM.Text = curObj.ADJUST_NUM == null ? string.Empty:curObj.ADJUST_NUM.ToString();
				this.txtInputCREATE_DATE.Text = curObj.CREATE_DATE == null ? string.Empty:curObj.CREATE_DATE.ToString();
				this.ddlInputBUDGET_YEAR.KeyField = "ID";
                this.ddlInputBUDGET_YEAR.NameField = "BUDGET_YEAR";
                this.ddlInputBUDGET_YEAR.NameFieldAlias = "BUDGET_YEAR";
                List<FieldItem> List = new List<FieldItem>();
                List.Add(new FieldItem() { Field = "BUDGET_YEAR", Title = "预算年度", Width = 80 });
                this.ddlInputBUDGET_YEAR.FieldItems = List;
				this.ddlInputBUDGET_YEAR.KeyValue = curObj.BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.NameValue = string.IsNullOrEmpty(curObj.BUDGET_YEAR)?string.Empty: BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(new EntityObject_BGT_D_BUDGET_YEAR(){ID = curObj.BUDGET_YEAR}).BUDGET_YEAR;
				this.ddlInputBUDGET_YEAR.DataTable = "BGT_D_BUDGET_YEAR";
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_BUDGET_ADJUST cause = new CauseObject_BGT_B_BUDGET_ADJUST();
            cause.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.IS_AVAILABE = 1");
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_ADJUST>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_ADJUST obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_BUDGET_ADJUST obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_ADJUST obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_ADJUST obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_BUDGET_ADJUST obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_ADJUST;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_ADJUST_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_BUDGET_ADJUST> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_ADJUST>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_BUDGET_ADJUST entity = new EntityObject_BGT_B_BUDGET_ADJUST();
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

            BizLogicMsg msg = BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

