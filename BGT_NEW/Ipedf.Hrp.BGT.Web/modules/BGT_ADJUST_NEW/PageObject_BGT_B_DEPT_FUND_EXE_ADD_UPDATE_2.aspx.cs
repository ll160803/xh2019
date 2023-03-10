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
using Ipedf.Hrp.Web.common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE_2 : ComNestingEditPage
    {
        public string Tip { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Tip = BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART { ID = SystemLogic.Proxy.CurrentUser.DEPART_ID }).SUMMARY;
            base.Page_Load(sender, e);
            //Ipedf.Hrp.Web.common.ComControlBar_State.SettingComControlBar_Dept(this.command, 0);
            //if (this.btnDelete.Visible)
            //{
            //    this.btnDelete.Visible = this.command[Ipedf.Web.Control.ButtonType.Add].Visible;
            //}
        }
        protected override void PrepareCause()
        {

            SetForeignKeyBinding(ddlDataSourceACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME");
            SetForeignKeyBinding(ddlDataSourceBGT_D_ACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME");
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                throw new Exception("Ԥ?????Ҳ???Ϊ??");
            if (!string.IsNullOrEmpty(this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
            {
                var count = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Query(new CauseObject_BGT_B_DEPT_FUND_EXE
                {
                    BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue,
                    BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue,
                    BGT_D_BUDGET_ITEM_ID = this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue

                }).Count();
                var cause = new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE
                {
                    BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue,
                    BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue,
                    BGT_D_BUDGET_ITEM_ID = this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue

                };
                if (ViewState["CUR_OBJ"] != null)
                {
                    EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
                    cause.SetCustomCondition(string.Format(" and BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID !='{0}'", baseEntity.ID));
                }
                var count2 = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Query(cause).Count();
                if ((count + count2) > 0)//?ڽ???ִ????֮ǰ ?Ѿ??걨?? ?????ڵ???ʱ???걨??
                {
                    throw new Exception("?˾???Ԥ???Ѿ??걨???????ظ??걨");
                }
            }
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //ƽ̨?Զ????ɴ???
            CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE).ID;
            dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
            list.AddRange((DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.Ԥ???׶?.ִ?н׶?; ;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //ƽ̨?Զ????ɴ???
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)",Ipedf.Hrp.BGT.Common.Ԥ???׶?.ִ?н׶?);
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.Ԥ???׶?.ִ?н׶?);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputFUND_TYPE_ID.Text = "???????????ʱ?????";//ÿ??ҳ????Ҫ?޸? hsc
            this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            this.ddlInputDEPT_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            this.ddlInputDEPT_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            this.txtInputCODE.Text = "";
            this.txtInputCODE_H.Value = "";
            this.txtInputFUND_MONEY.Text = "0.00";
            //hsc ?????ϴ?
            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = "";
            upFiles.ReadOnly = true;
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
                EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();

                //ƽ̨?Զ????ɴ???
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
                    baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
                else
                {
                    var newcode = txtInputNewItem.Text;
                    if (newcode != "")
                    {
                        var obj_En = new EntityObject_BGT_D_BUDGET_ITEM
                        {
                            ID = Guid.NewGuid().ToString(),
                            BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue,
                            NAME = newcode,
                            IS_END = 2,
                            PARENT_ID = "01"
                        };

                        BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Save(obj_En);
                        BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Proxy.Save(new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM
                        {
                            ID = Guid.NewGuid().ToString(),
                            BASE_ID = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString())[0].ID,
                            BUDGET_ITEM_ID = obj_En.ID
                        });
                        baseEntity.BGT_D_BUDGET_ITEM_ID = obj_En.ID;
                        this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = obj_En.ID;
                        this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = newcode;
                    }
                }
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;

                if (!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
                    baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
                else
                    baseEntity.FUND_MONEY = 0;
                baseEntity.FUND_TYPE_ID = "BGT_00010201";//һ?㾭??Ԥ?? hsc
                baseEntity.CODE = txtInputCODE_H.Value;
                //  baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");


                        ComTextBox txtInputCOMPLETE_TIME = (ComTextBox)row.FindControl("txtInputCOMPLETE_TIME");

                        ComTextBox txtInputBUILDING_NAME = (ComTextBox)row.FindControl("txtInputBUILDING_NAME");
                        //    ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        //ƽ̨?Զ????ɴ???
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //ƽ̨?Զ????ɴ???
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;

                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;


                            if (!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
                                detailEntity.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
                            else
                                detailEntity.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;

                            detailEntity.BUILDING_NAME = txtInputBUILDING_NAME.Text;
                            // detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;			
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    upFiles.TableName = "BGT_B_DEPT_FUND_EXE_ADD_UPDATE";
                    upFiles.TableId = baseEntity.ID;
                    upFiles.ReadOnly = false;
                    this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY.ToString();
                    this.txtInputCODE.Text = baseEntity.CODE;
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
                EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;

                //ƽ̨?Զ????ɴ???
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue))
                    baseEntity.BGT_D_BUDGET_ITEM_ID = ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue;
                else
                {
                    var newcode = txtInputNewItem.Text;
                    if (newcode != "")
                    {
                        var obj_En = new EntityObject_BGT_D_BUDGET_ITEM
                        {
                            ID = Guid.NewGuid().ToString(),
                            BUDGET_YEAR = this.ddlInputBUDGET_YEAR.SelectedValue,
                            NAME = newcode,
                            IS_END = 2,
                            PARENT_ID = "01"
                        };

                        BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Save(obj_En);
                        BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Proxy.Save(new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM
                        {
                            ID = Guid.NewGuid().ToString(),
                            BASE_ID = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString())[0].ID,
                            BUDGET_ITEM_ID = obj_En.ID
                        });
                        baseEntity.BGT_D_BUDGET_ITEM_ID = obj_En.ID;
                        this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = obj_En.ID;
                        this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = newcode;
                    }
                }
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.KeyValue))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.KeyValue;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                //if(!string.IsNullOrEmpty(ddlInputFUND_TYPE_ID.KeyValue))
                //    baseEntity.FUND_TYPE_ID = ddlInputFUND_TYPE_ID.KeyValue;
                if (!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
                    baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
                else
                    baseEntity.FUND_MONEY = 0;

                //baseEntity.NAME = txtInputNAME.Text;
                //baseEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
                //baseEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
                //baseEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;

                baseEntity.FUND_TYPE_ID = "BGT_00010201";//һ?㾭??Ԥ?? hsc
                baseEntity.CODE = txtInputCODE_H.Value;
                //   baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");

                        ComTextBox txtInputCOMPLETE_TIME = (ComTextBox)row.FindControl("txtInputCOMPLETE_TIME");

                        ComTextBox txtInputBUILDING_NAME = (ComTextBox)row.FindControl("txtInputBUILDING_NAME");
                        //     ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        //ƽ̨?Զ????ɴ???
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //ƽ̨?Զ????ɴ???
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;

                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;

                            if (!string.IsNullOrEmpty(txtInputCOMPLETE_TIME.Text))
                                detailEntity.COMPLETE_TIME = DateTime.Parse(txtInputCOMPLETE_TIME.Text);
                            else
                                detailEntity.COMPLETE_TIME = Ipedf.Common.Template.UndefineDatetime;

                            detailEntity.BUILDING_NAME = txtInputBUILDING_NAME.Text;
                            // detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
                            detailEntity.FINANCE_IDEA = "";
                            detailEntity.MONEY1 = detailEntity.MONEY;
                            detailEntity.CONTROL_MONEY1 = detailEntity.CONTROL_MONEY;
                            detailEntity.FINANCE_IDEA1 = detailEntity.FINANCE_IDEA;
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
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY.ToString();
                    this.txtInputCODE.Text = baseEntity.CODE;
                    upFiles.TableName = "BGT_B_DEPT_FUND_EXE_ADD_UPDATE";
                    upFiles.TableId = baseEntity.ID;
                    upFiles.ReadOnly = false;
                    ShowEditState(baseEntity);
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


        protected override object PrepareQueryParameter()
        {
            CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause = new CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE();
            cause.FUND_TYPE_ID = "BGT_00010201";
            // cause.STATE = 1;
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                cause.BUDGET_DEPT_ID = depts[0].ID;
            }

            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PAY_YEAR_FUND_PARAM.aspx", 500, 500);
            return scripts;
        }
       
        protected override void PrepareBaseEdit(string id)
        {

            //ƽ̨?Զ????ɴ???
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Get(baseEntity);
            this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)",Ipedf.Hrp.BGT.Common.Ԥ???׶?.ִ?н׶?);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.Ԥ???׶?.ִ?н׶?);
            //	this.txtInputITEM_NAME.Text = baseEntity.ITEM_NAME == null ? string.Empty:baseEntity.ITEM_NAME.ToString();
            this.ddlInputDEPT_USER_ID.KeyField = "ID";
            this.ddlInputDEPT_USER_ID.NameField = "NAME";
            //this.ddlInputDEPT_USER_ID.KeyValue = baseEntity.DEPT_USER_ID;
            this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = baseEntity.DEPT_USER_ID }).NAME;
            this.ddlInputDEPT_USER_ID.NameValue = baseEntity.DEPT_USER_ID;
            this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            //this.ddlInputFUND_TYPE_ID.KeyField = "ID";
            //this.ddlInputFUND_TYPE_ID.NameField = "NAME";
            //this.ddlInputFUND_TYPE_ID.KeyValue = baseEntity.FUND_TYPE_ID;
            //this.ddlInputFUND_TYPE_ID.NameValue = string.IsNullOrEmpty(baseEntity.FUND_TYPE_ID)?string.Empty: BizLogicObject_COM_TYPE.Proxy.Get(new EntityObject_COM_TYPE(){ID = baseEntity.FUND_TYPE_ID}).NAME;
            //this.ddlInputFUND_TYPE_ID.DataTable = "COM_TYPE";
            //this.ddlInputFUND_TYPE_ID.Condition = "COM_TYPE.PARENT_ID='BGT_0001'";
            this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY == null ? string.Empty : baseEntity.FUND_MONEY.ToString();
            this.ddlInputFUND_TYPE_ID.Text = "???????????ʱ?????";//ÿ??ҳ????Ҫ?޸? hsc
            this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            this.txtInputCODE_H.Value = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            //  this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? "" : baseEntity.FINANCE_IDEA;
            //this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
            //this.txtInputFREE_FIELD3.Text = baseEntity.FREE_FIELD3 == null ? string.Empty:baseEntity.FREE_FIELD3.ToString();
            //this.txtInputFREE_FIELD.Text = baseEntity.FREE_FIELD == null ? string.Empty:baseEntity.FREE_FIELD.ToString();
            //this.txtInputFREE_FIELD2.Text = baseEntity.FREE_FIELD2 == null ? string.Empty:baseEntity.FREE_FIELD2.ToString();
            //this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty:baseEntity.FINANCE_IDEA.ToString();
            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = baseEntity.ID;
            upFiles.ReadOnly = false;

            ShowEditState(baseEntity);
            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Submit(baseEntity);
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
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Audit(baseEntity);
                if (msg.Succeed)
                {
                    msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Action_FUND_UPDATE_EXE(baseEntity.ID);//???µ?ִ?б???
                    if (!msg.Succeed)
                    {
                        throw new Exception(msg.Message);
                    }
                    else
                    {
                        try
                        {
                            var list = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Query(new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE { ID = baseEntity.ID }).ToList();


                            RfcNOC rfc = new RfcNOC();
                            var Msg_SAP = rfc.SendSAP_NewAdd_Fund_RFC(list, this.ddlInputBUDGET_YEAR.SelectedItem.Text, "A01", "Z013", "ZFI02_FM_YS001");
                            if (!Msg_SAP[0].IsSuccess)
                            {
                                lblState.Text = "?ϴ?SAPʧ??!,??ֹͣ??????????ϵ??????Ա";
                            }
                        }
                        catch (Exception ex)
                        {
                            lblState.Text = "?ϴ?SAPʧ??!,??ֹͣ??????????ϵ??????Ա";
                        }
                    }
                }
                else
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

