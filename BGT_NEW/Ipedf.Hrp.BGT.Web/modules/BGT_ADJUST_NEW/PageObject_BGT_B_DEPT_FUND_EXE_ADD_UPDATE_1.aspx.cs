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
using Ipedf.Hrp.Web.common;
using System.Linq;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE_1 : ComNestingEditPage
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
                throw new Exception("预算科室不能为空");
            if (string.IsNullOrEmpty(this.ddlInputBUDGET_YEAR.SelectedValue))
                throw new Exception("预算年度不能为空");
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
                if ((count + count2) > 0)//在进入执行区之前 已经申报过 或者在调整时候申报过
                {
                    throw new Exception("此经费预算已经申报，不能重复申报");
                }
            }
        }
        protected override void RegisterGridEvent()
        {
            base.RegisterGridEvent();
            this.gvDetailList.RowDeleting += new GridViewDeleteEventHandler(gvDetailList_RowDeleting);
        }

        protected void gvDetailList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = gvDetailList.DataKeys[e.RowIndex].Value.ToString();
            if (string.IsNullOrEmpty(id))
            {
                gvDetailList.DeleteRow(e.RowIndex);
            }
            else
            {
                BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Delete(new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND { ID = id });
            }
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
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
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)", Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc
            this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            this.ddlInputDEPT_USER_ID.KeyValue = SystemLogic.Proxy.CurrentUser.ID;
            this.ddlInputDEPT_USER_ID.NameValue = SystemLogic.Proxy.CurrentUser.NAME;
            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            this.txtInputCODE.Text = "";
            this.txtInputCODE_H.Value = "";
            this.txtInputFUND_MONEY.Text = "0.00";
            //hsc 附件上传
            upFiles.TableName = "BGT_B_DEPT_FUND_EXE_ADD_UPDATE";
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

                //平台自动生成代码
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
                            BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue,
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

                baseEntity.FUND_TYPE_ID = "BGT_000101";//一般经费预算 hsc
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

                        ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");
                        //    ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");

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


                            //if (!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
                            //    detailEntity.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
                            detailEntity.FUND_NAME = txtInputFUND_NAME.Text;
                            //   detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
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

                //平台自动生成代码
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
                            BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue,
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
                //baseEntity.CODE = txtInputCODE.Text;
                //baseEntity.NAME = txtInputNAME.Text;
                //baseEntity.FREE_FIELD3 = txtInputFREE_FIELD3.Text;
                //baseEntity.FREE_FIELD = txtInputFREE_FIELD.Text;
                //baseEntity.FREE_FIELD2 = txtInputFREE_FIELD2.Text;
                //	baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                baseEntity.FUND_TYPE_ID = "BGT_000101";//一般经费预算 hsc
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

                        ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");
                        //   ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");

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

                            //if (!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
                            //    detailEntity.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
                            detailEntity.FUND_NAME = txtInputFUND_NAME.Text;
                            //     detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
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
                    upFiles.TableName = "BGT_B_DEPT_FUND_EXE_ADD_UPDATE";
                    upFiles.TableId = baseEntity.ID;
                    upFiles.ReadOnly = false;
                    ShowEditState(baseEntity);
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
            ShowDetailData();
            SetPageState(PageState.Edit);
        }
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND entity = (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECLARE_CAUSE");
                txtInputDECLARE_CAUSE.Text = entity.DECLARE_CAUSE == null ? String.Empty : entity.DECLARE_CAUSE.ToString();

                ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();
                ComTextBox txtInputFUND_NAME = (ComTextBox)e.Row.FindControl("txtInputFUND_NAME");
                txtInputFUND_NAME.Text = entity.FUND_NAME;
                //  ComBaseBox txtInputFUND_NAME = (ComBaseBox)e.Row.FindControl("txtInputFUND_NAME");
                //  CopyComDropDownListItem(ddlDataSourceACCOUNT_ITEM_ID, ref ddlInputACCOUNT_ITEM_ID, entity.ACCOUNT_ITEM_ID, "BGT_D_ACCOUNT_ITEM", "ID", "NAME");

                //   ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
                //   txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA;
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
                RegisterSelectedScript(txtInputMONEY, select);
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause = new CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE();
            cause.FUND_TYPE_ID = "BGT_000101";
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
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE_PARAM.aspx", 500, 500);
            return scripts;
        }

        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码

            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Get(baseEntity);
            this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)", Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            //	this.txtInputITEM_NAME.Text = baseEntity.ITEM_NAME == null ? string.Empty:baseEntity.ITEM_NAME.ToString();
            this.ddlInputDEPT_USER_ID.KeyField = "ID";
            this.ddlInputDEPT_USER_ID.NameField = "NAME";
            this.ddlInputDEPT_USER_ID.KeyValue = baseEntity.DEPT_USER_ID;
            //this.ddlInputDEPT_USER_ID.KeyValue = baseEntity.DEPT_USER_ID;
            this.ddlInputDEPT_USER_ID.NameValue = string.IsNullOrEmpty(baseEntity.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = baseEntity.DEPT_USER_ID }).NAME;
            this.ddlInputDEPT_USER_ID.DataTable = "COM_USER";
            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            //this.ddlInputFUND_TYPE_ID.KeyField = "ID";
            //this.ddlInputFUND_TYPE_ID.NameField = "NAME";
            //this.ddlInputFUND_TYPE_ID.KeyValue = baseEntity.FUND_TYPE_ID;
            //this.ddlInputFUND_TYPE_ID.NameValue = string.IsNullOrEmpty(baseEntity.FUND_TYPE_ID)?string.Empty: BizLogicObject_COM_TYPE.Proxy.Get(new EntityObject_COM_TYPE(){ID = baseEntity.FUND_TYPE_ID}).NAME;
            //this.ddlInputFUND_TYPE_ID.DataTable = "COM_TYPE";
            //this.ddlInputFUND_TYPE_ID.Condition = "COM_TYPE.PARENT_ID='BGT_0001'";
            this.txtInputFUND_MONEY.Text = baseEntity.FUND_MONEY == null ? string.Empty : baseEntity.FUND_MONEY.ToString();
            this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            this.txtInputCODE_H.Value = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();


            //    this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? "" : baseEntity.FINANCE_IDEA;
            this.ddlInputFUND_TYPE_ID.Text = "一般经费预算";//每个页面需要修改 hsc
            //this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
            //this.txtInputFREE_FIELD3.Text = baseEntity.FREE_FIELD3 == null ? string.Empty:baseEntity.FREE_FIELD3.ToString();
            //this.txtInputFREE_FIELD.Text = baseEntity.FREE_FIELD == null ? string.Empty:baseEntity.FREE_FIELD.ToString();
            //this.txtInputFREE_FIELD2.Text = baseEntity.FREE_FIELD2 == null ? string.Empty:baseEntity.FREE_FIELD2.ToString();
            //this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty:baseEntity.FINANCE_IDEA.ToString();
            //hsc 附件上传
            upFiles.TableName = "BGT_B_DEPT_FUND_EXE_ADD_UPDATE";
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
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.UndoSubmit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.UndoAudit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
       
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Cancel(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }

        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Archive(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE entity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
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
                BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

