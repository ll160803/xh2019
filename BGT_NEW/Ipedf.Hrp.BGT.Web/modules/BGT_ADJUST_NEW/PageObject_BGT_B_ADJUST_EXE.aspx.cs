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
    public partial class PageObject_BGT_B_ADJUST_EXE : ComNestingResourceEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
        }            
       
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_V_BGT_ADJUST_FUND_MONEY), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            
            //平台自动生成代码
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
           // this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID,(decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
			this.txtInputEXE_TOTAL_MONEY.Text = "0.00";
			this.txtInputTOTAL_MONEY.Text = "0.00";

            this.ddlInputDEPT_USER_ID.Text = BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART { ID = SystemLogic.Proxy.CurrentUser.DEPART_ID }).HEAD_USER_ID;
			
			this.txtInputCHANGE_CAUSE.Text = string.Empty;
        }  
       
       
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_ADJUST_EXE cause = new CauseObject_BGT_B_ADJUST_EXE();
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_ADJUST_EXE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_ADJUST_EXE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_ADJUST_EXE cause = (CauseObject_BGT_B_ADJUST_EXE)parameter;
            string dept_name = SystemLogic.Proxy.CurrentUser.ACCOUNT;
            if (dept_name != "预算办公室")
            {
                cause.CREATE_DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            }
			dataSource = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_ADJUST_EXE baseEntity = new EntityObject_BGT_B_ADJUST_EXE();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
                this.ddlInputBUDGET_YEAR.Enabled = false;
                SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR",new  CauseObject_BGT_D_BUDGET_YEAR { });
				this.txtInputEXE_TOTAL_MONEY.Text = baseEntity.EXE_TOTAL_MONEY == null ? string.Empty:baseEntity.EXE_TOTAL_MONEY.ToString();
				this.txtInputTOTAL_MONEY.Text = baseEntity.TOTAL_MONEY == null ? string.Empty:baseEntity.TOTAL_MONEY.ToString();

                this.ddlInputDEPT_USER_ID.Text = baseEntity.DEPT_USER_ID;
				
				this.txtInputCHANGE_CAUSE.Text = baseEntity.CHANGE_CAUSE == null ? string.Empty:baseEntity.CHANGE_CAUSE.ToString();
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Submit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.UndoSubmit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
       
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Cancel(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_ADJUST_EXE> deleteDetailEntities = new List<EntityObject_BGT_B_ADJUST_EXE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_ADJUST_EXE entity = new EntityObject_BGT_B_ADJUST_EXE();
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
            try
            {
                BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                if (!msg.Succeed)
					throw new Exception(msg.Message);
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
        protected override void OnResourceAppend(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity == null)
            {
                OnSave(sender, e);
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
			parameters.Add("linkid", baseEntity.ID);
			string url = WebControlHelper.EncodeUrl("PageObject_BGT_B_ADJUST_EXE_Resource.aspx", parameters);
			base.OpenWindow(url, 800, 360);
        }
        
        protected override void PrepareDetailDataSourceControl(string id)
        {
           
        }
    }
}

