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
    public partial class PageObject_BGT_B_CPN_INC_MEDICAL3 : ComSimplePage
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
            CauseObject_BGT_B_CPN_INC_MEDICAL cause = (CauseObject_BGT_B_CPN_INC_MEDICAL)parameter;
            dataSource = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override void PrepareInput()
        {

            //平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
            //this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            //this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            //DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            //if (depts.Length != 0)
            //{
            //    this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
            //    this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            //}
            //this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            //this.ddlInputDEPT_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            //this.ddlInputDEPT_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
            this.txtInputMONEY.Text = "0.00";


            this.txtInputITEM_NAME.Text = string.Empty;



            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            //hsc 附件上传
            upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
            upFiles.TableId = "";
            upFiles.ReadOnly = true;

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
                EntityObject_BGT_B_CPN_INC_MEDICAL curObj = new EntityObject_BGT_B_CPN_INC_MEDICAL();
                //平台自动生成代码
                //if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                //    curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;

                curObj.COM_TYPE_ID = "BGT_00030003";//医疗收入		
                if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                    curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
                else
                    curObj.MONEY = 0;

                curObj.ITEM_NAME = txtInputITEM_NAME.Text;

                ;

                curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;

                BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Save(curObj);
                ShowEditState(curObj);
                upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
                upFiles.TableId = curObj.ID;
                upFiles.ReadOnly = false;
                ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {

                //平台自动生成代码
                EntityObject_BGT_B_CPN_INC_MEDICAL curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
                //平台自动生成代码
                //if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                //    curObj.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    curObj.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;

                curObj.COM_TYPE_ID = "BGT_00030003";//医疗收入
                if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                    curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
                else
                    curObj.MONEY = 0;

                curObj.ITEM_NAME = txtInputITEM_NAME.Text;






                curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;

                BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Update(curObj);
                ShowEditState(curObj);
                upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
                upFiles.TableId = curObj.ID;
                upFiles.ReadOnly = false;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }
        protected override void PrepareEdit(string id)
        {

            //平台自动生成代码
            EntityObject_BGT_B_CPN_INC_MEDICAL curObj = new EntityObject_BGT_B_CPN_INC_MEDICAL();
            curObj.ID = id;
            curObj = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Get(curObj);

            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), curObj.BUDGET_YEAR, "ID", "BUDGET_YEAR");


            //this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            //this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            //this.ddlInputBUDGET_DEPT_ID.KeyValue = curObj.BUDGET_DEPT_ID;
            //this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(curObj.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = curObj.BUDGET_DEPT_ID}).NAME;
            //this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";

            this.txtInputMONEY.Text = curObj.MONEY == null ? string.Empty : curObj.MONEY.ToString();
            //this.ddlInputDEPT_USER_ID.KeyField = "ID";
            //this.ddlInputDEPT_USER_ID.NameField = "NAME";
            //this.ddlInputDEPT_USER_ID.KeyValue = curObj.DEPT_USER_ID;
            //this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(curObj.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = curObj.DEPT_USER_ID }).NAME;
            //this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";

            this.txtInputITEM_NAME.Text = curObj.ITEM_NAME == null ? string.Empty : curObj.ITEM_NAME.ToString();



            this.txtInputDECALRE_CAUSE.Text = curObj.DECALRE_CAUSE == null ? string.Empty : curObj.DECALRE_CAUSE.ToString();
            upFiles.TableName = "BGT_B_CPN_INC_MEDICAL";
            upFiles.TableId = curObj.ID;
            upFiles.ReadOnly = false;
            ShowEditState(curObj);
            ViewState["CUR_OBJ"] = curObj;
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_CPN_INC_MEDICAL cause = new CauseObject_BGT_B_CPN_INC_MEDICAL();
            cause.COM_TYPE_ID = "BGT_00030003";
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_CPN_INC_MEDICAL>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID" };
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
                obj.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Audit(obj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }

        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {

            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
                obj.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.UndoAudit(obj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }

        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
                obj.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Submit(obj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
                obj.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.UndoSubmit(obj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_MEDICAL obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_MEDICAL;
            if (obj != null)
            {
                obj.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.Archive(obj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_INC_MEDICAL_PARAM3.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_INC_MEDICAL> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_MEDICAL>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_INC_MEDICAL entity = new EntityObject_BGT_B_CPN_INC_MEDICAL();
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
                BizLogicObject_BGT_B_CPN_INC_MEDICAL.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

