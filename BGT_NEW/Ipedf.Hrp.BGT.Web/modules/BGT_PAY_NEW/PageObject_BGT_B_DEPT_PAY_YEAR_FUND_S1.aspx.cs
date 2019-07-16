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
using System.Linq;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_S1 : ComNestingEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);//财务是可编辑的
            this.command[Ipedf.Web.Control.ButtonType.Query].Visible = false;
            Ipedf.Hrp.Web.common.ComControlBar_State.SettingComControlBar_Dept(this.command, 1);
            if (this.btnDelete.Visible)
            {
                this.btnDelete.Visible = this.command[Ipedf.Web.Control.ButtonType.Add].Visible;
            }
        }
        protected override void PrepareCause()
        {
            SetForeignKeyBinding(ddlDataSourceACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME");
            SetForeignKeyBinding(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME");
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("预算科室不能为空");
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_V_BGT_FIRST_UP cause = new CauseObject_V_BGT_FIRST_UP();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND).ID;
            dataSource = BizLogicObject_V_BGT_FIRST_UP.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_V_BGT_FIRST_UP> list = new System.Collections.Generic.List<DisplayObject_V_BGT_FIRST_UP>();
            list.AddRange((DisplayObject_V_BGT_FIRST_UP[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_V_BGT_FIRST_UP>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_V_BGT_FIRST_UP), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = 1;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);

            //2016 1107 添加是否
            SetEnumReferenceBinding(this.ddlInputIS_FIXED, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            SetEnumReferenceBinding(this.ddlInputIS_PERFORMANCE, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));

            //平台自动生成代码
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = "";
            this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc
            this.ddlInputDEPT_USER_ID.Text = BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART { ID = SystemLogic.Proxy.CurrentUser.DEPART_ID }).HEAD_USER_ID;
            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            this.txtInputFUND_MONEY.Text = "0.00";

        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
                EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
                    baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;

                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;

                if (!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
                    baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
                else
                    baseEntity.FUND_MONEY = 0;

                if (!string.IsNullOrEmpty(this.ddlInputIS_FIXED.SelectedValue))
                    baseEntity.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
                if (!string.IsNullOrEmpty(this.ddlInputIS_PERFORMANCE.SelectedValue))
                    baseEntity.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);

                baseEntity.FUND_TYPE_ID = "BGT_000101";//一般经费预算 hsc
                baseEntity.CODE = txtInputCODE.Text;
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
                    baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
                else
                    baseEntity.CONTROL_MONEY = 0;
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");

                        ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");
                        ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        ComTextBox txtCONTROL_MONEY = (ComTextBox)row.FindControl("txtCONTROL_MONEY");
                        //平台自动生成代码
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;

                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;


                            if (!string.IsNullOrEmpty(txtInputFUND_NAME.Text))
                                detailEntity.FUND_NAME = txtInputFUND_NAME.Text;

                            if (!string.IsNullOrEmpty(txtCONTROL_MONEY.Text))
                                detailEntity.CONTROL_MONEY = decimal.Parse(txtCONTROL_MONEY.Text);
                            else
                                detailEntity.CONTROL_MONEY = 0;

                            detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY.ToString();
                    this.txtInputCODE.Text = baseEntity.CODE;
                    this.txtInputCONTROL_MONEY.Text = baseEntity.CONTROL_MONEY.ToString();
                    PrepareDetailDataSourceControl(baseEntity.ID);
                    ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
                }
                catch (Exception expt)
                {
                    throw expt;
                }

            }
            else
            {
                List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
                List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
                List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
                EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
                    baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;

                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                //if(!string.IsNullOrEmpty(ddlInputFUND_TYPE_ID.KeyValue))
                //    baseEntity.FUND_TYPE_ID = ddlInputFUND_TYPE_ID.KeyValue;
                if (!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
                    baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
                else
                    baseEntity.FUND_MONEY = 0;
                //baseEntity.CODE = txtInputCODE.Text;
                //baseEntity.NAME = txtInputNAME.Text;
                //baseEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
                //baseEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
                //baseEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
                //	baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                baseEntity.FUND_TYPE_ID = "BGT_000101";//一般经费预算 hsc
                baseEntity.CODE = txtInputCODE.Text;
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
                    baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
                else
                    baseEntity.CONTROL_MONEY = 0;

                if (!string.IsNullOrEmpty(this.ddlInputIS_FIXED.SelectedValue))
                    baseEntity.IS_FIXED = decimal.Parse(ddlInputIS_FIXED.SelectedValue);
                if (!string.IsNullOrEmpty(this.ddlInputIS_PERFORMANCE.SelectedValue))
                    baseEntity.IS_PERFORMANCE = decimal.Parse(ddlInputIS_PERFORMANCE.SelectedValue);

                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");

                        ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");

                        //   ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");

                        //   ComTextBox txtCONTROL_MONEY = (ComTextBox)row.FindControl("txtCONTROL_MONEY");

                        //平台自动生成代码
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
                            //detailEntity.ASSET_ID = txtInputASSET_ID.Text;
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;

                            if (!string.IsNullOrEmpty(txtInputFUND_NAME.Text))
                                detailEntity.FUND_NAME = txtInputFUND_NAME.Text;
                            //解决ORA-01008错误
                            detailEntity.FINANCE_IDEA1 = detailEntity.FINANCE_IDEA1 == null?"": detailEntity.FINANCE_IDEA1;//txtInputFINANCE_IDEA.Text;
                            //if (!string.IsNullOrEmpty(txtCONTROL_MONEY.Text))
                            //    detailEntity.CONTROL_MONEY = decimal.Parse(txtCONTROL_MONEY.Text);
                            //else
                            //    detailEntity.CONTROL_MONEY = 0;
                            if (detailEntity.ID == string.Empty)
                            {
                                //AuditAdd(detailEntity);
                                saveDetailEntities.Add(detailEntity);
                            }
                            else
                            {
                                //AuditEdit(detailEntity);
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
                try
                {
                    var totalMoney = saveDetailEntities.Sum(p => p.MONEY) + updateDetailEntities.Sum(p => p.MONEY);
                    if (totalMoney > baseEntity.CONTROL_MONEY && baseEntity.CONTROL_MONEY > 0)
                    {
                        throw new Exception("明细金额不能超出预算办公室核定金额");
                    }
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ShowEditState(baseEntity);
                    this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY.ToString();
                    this.txtInputCODE.Text = baseEntity.CODE;
                    this.txtInputCONTROL_MONEY.Text = baseEntity.CONTROL_MONEY.ToString();

                    PrepareDetailDataSourceControl(baseEntity.ID);
                    ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
                }
                catch (Exception expt)
                {
                    throw expt;
                }

            }
            ShowDetailData();
            SetPageState(PageState.Edit);
        }

        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_V_BGT_FIRST_UP entity = (EntityObject_V_BGT_FIRST_UP)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECLARE_CAUSE");
                txtInputDECLARE_CAUSE.Text = entity.DECLARE_CAUSE == null ? String.Empty : entity.DECLARE_CAUSE.ToString();

                ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();

                //  ComTextBox txtCONTROL_MONEY = (ComTextBox)e.Row.FindControl("txtCONTROL_MONEY");
                // txtCONTROL_MONEY.Text = entity.CONTROL_MONEY == null ? "0" : entity.CONTROL_MONEY.ToString();
                //  ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
                // txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA;
                ComTextBox txtInputFUND_NAME = (ComTextBox)e.Row.FindControl("txtInputFUND_NAME");
                txtInputFUND_NAME.Text = entity.FUND_NAME;

                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
            cause.FUND_TYPE_ID = "BGT_000101";
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                cause.BUDGET_DEPT_ID = depts[0].ID;
                gvResultList.Field_Value = "BUDGET_DEPT_ID";
                gvResultList.KeyValue = depts[0].ID;
            }

            //  cause.SetCustomCondition(" and BGT_B_DEPT_PAY_YEAR_FUND.STATE !=1");
            //模拟标准查询
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = JsonConvert.DeserializeObject<CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND>(parameter);
            cause.FUND_TYPE_ID = "BGT_000101";
            if (!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
            {
                gvResultList.Field_Value = "BUDGET_DEPT_ID";
                gvResultList.KeyValue = cause.BUDGET_DEPT_ID;
            }
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PAY_YEAR_FUND_PARAM.aspx", 500, 500);
            return scripts;
        }

        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Get(baseEntity);
            this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            //	this.txtInputITEM_NAME.Text = baseEntity.ITEM_NAME == null ? string.Empty:baseEntity.ITEM_NAME.ToString();

            this.ddlInputDEPT_USER_ID.Text = baseEntity.DEPT_USER_ID ?? "";

            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            //this.ddlInputFUND_TYPE_ID.KeyField = "ID";
            //this.ddlInputFUND_TYPE_ID.NameField = "NAME";
            //this.ddlInputFUND_TYPE_ID.KeyValue = baseEntity.FUND_TYPE_ID;
            //this.ddlInputFUND_TYPE_ID.NameValue = string.IsNullOrEmpty(baseEntity.FUND_TYPE_ID)?string.Empty: BizLogicObject_COM_TYPE.Proxy.Get(new EntityObject_COM_TYPE(){ID = baseEntity.FUND_TYPE_ID}).NAME;
            //this.ddlInputFUND_TYPE_ID.DataTable = "COM_TYPE";
            //this.ddlInputFUND_TYPE_ID.Condition = "COM_TYPE.PARENT_ID='BGT_0001'";
            this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY == null ? string.Empty : baseEntity.FUND_MONEY.ToString();
            this.txtInputCONTROL_MONEY.Text = baseEntity.CONTROL_MONEY == null ? string.Empty : baseEntity.CONTROL_MONEY.ToString();
            this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? "" : baseEntity.FINANCE_IDEA;
            this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc

            SetEnumReferenceSelected(this.ddlInputIS_FIXED, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_FIXED);
            SetEnumReferenceSelected(this.ddlInputIS_PERFORMANCE, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.IS_PERFORMANCE);

            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = baseEntity.ID;
            upFiles.ReadOnly = false;
            //this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
            //this.txtInputFREE_FIELD3.Text = baseEntity.FREE_FIELD3 == null ? string.Empty:baseEntity.FREE_FIELD3.ToString();
            //this.txtInputFREE_FIELD.Text = baseEntity.FREE_FIELD == null ? string.Empty:baseEntity.FREE_FIELD.ToString();
            //this.txtInputFREE_FIELD2.Text = baseEntity.FREE_FIELD2 == null ? string.Empty:baseEntity.FREE_FIELD2.ToString();
            //this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty:baseEntity.FINANCE_IDEA.ToString();
            ShowEditState(baseEntity);

            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Submit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.UndoSubmit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.UndoAudit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Audit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Cancel(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }

        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Archive(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_PAY_YEAR_FUND> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAR_FUND>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_PAY_YEAR_FUND entity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();
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
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
        protected override void PrepareDetailDataSourceControl(string id)
        {

            CauseObject_BGT_D_ACCOUNT_ITEM cause787 = new CauseObject_BGT_D_ACCOUNT_ITEM();
            cause787.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID from BGT_B_DEPT_PAY_YEAY_D_FUND where BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID = '" + id + "' group by BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME", cause787);
            CauseObject_BGT_D_ACCOUNT_ITEM cause417 = new CauseObject_BGT_D_ACCOUNT_ITEM();
            cause417.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID from BGT_B_DEPT_PAY_YEAY_D_FUND where BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID = '" + id + "' group by BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME", cause417);
        }
    }
}

