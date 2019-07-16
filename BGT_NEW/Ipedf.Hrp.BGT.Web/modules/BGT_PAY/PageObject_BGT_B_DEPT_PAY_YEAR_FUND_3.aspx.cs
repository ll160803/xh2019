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

    public partial class PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3 : ComNestingEditPage
    {

        public int Stage { get; set; }

        public bool IsFirst()
        {
            return IsFirstStart() || IsFirstEnd();
        }

        public bool IsSecond()
        {
            return IsSecondStart() || IsSecondEnd();
        }

        public bool IsFirstStart()
        {
            return this.Stage == 1;
        }

        public bool IsFirstEnd()
        {
            return this.Stage == 2;
        }

        public bool IsSecondStart()
        {
            return this.Stage == 3;
        }

        public bool IsSecondEnd()
        {
            return this.Stage == 4;
        }

        public bool IsOneShangEnable()
        {
            return IsFirst();
        }

        public bool IsOneXiaEnable()
        {
            return false;
        }

        public bool IsTwoShangEnable()
        {
            return IsSecond() && !IsAgree();
        }

        public bool IsTwoXiaEnable()
        {
            return false;
        }

        public bool IsAddNew()
        {
            return ViewState["CUR_OBJ"] == null;
        }

        public bool IsAgree()
        {
            return this.ddlInputIS_AGREE.SelectedValue == "1";
        }

        public string Tip { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string budget_year = Session["budget_year"].ToString();
            var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = budget_year }).FirstOrDefault();
            if (en != null)
            {
                this.Stage = Convert.ToInt32(en.STAGE);
            }
            else
            {
                this.Stage = 0;
            }

            Tip = BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART { ID = SystemLogic.Proxy.CurrentUser.DEPART_ID }).SUMMARY;
            base.Page_Load(sender, e);
            if (!string.IsNullOrEmpty(Session["budget_year"].ToString()))
            {
                Ipedf.Hrp.Web.common.ComControlBar_State.SettingComControlBar_Dept(this.command, Session["budget_year"].ToString(), 0);
            }
            else
            {
                Ipedf.Hrp.Web.common.ComControlBar_State.SettingComControlBar_Dept(this.command, 0);
            }
            if (this.btnDelete.Visible)
            {
                this.btnDelete.Visible = this.command[Ipedf.Web.Control.ButtonType.Add].Visible;
                this.btnSeSubmit.Visible = this.command[Ipedf.Web.Control.ButtonType.Add].Visible; 
            }

            //this.txtInputFUND_MONEY.Attributes.Add("readonly", "true");
            //this.txtInputFUND_MONEY1.Attributes.Add("readonly", "true");
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
            if (string.IsNullOrEmpty(ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue) && string.IsNullOrEmpty(txtInputNewItem.Text))
                throw new Exception("经费名称不能为空");

            if (IsOneShangEnable() && string.IsNullOrEmpty(txtInputDECALRE_CAUSE.Text))
                throw new Exception("申请说明不能为空");

            decimal fund_money = decimal.Parse(this.txtInputFUND_MONEY.Text);

            if (IsTwoShangEnable() && fund_money > 0 && ddlInputIS_AGREE.SelectedValue == "0")
                throw new Exception("请选择是否同意调整");

            if (IsTwoShangEnable() && string.IsNullOrEmpty(txtInputFUND_MONEY1.Text))
                throw new Exception("二上经费金额不能为空");

            if (IsOneShangEnable() && double.Parse(this.txtInputFUND_MONEY.Text) <= 0)
            {
                throw new Exception("一上经费金额必须大于零");
            }

       

            int selectRows = 0;
            foreach (GridViewRow row in gvDetailList.Rows)
            {
                CheckBox select = (CheckBox)row.FindControl("cbSelect");
                if (select.Checked)
                {
                    selectRows += 1;
                }
            }
            if (selectRows <= 0)
            {
                throw new Exception("请勾选要保存的项目支出明细");
            }
            foreach (GridViewRow row in gvDetailList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");

                    ComTextBox txtInputFUND_NAME = (ComTextBox)row.FindControl("txtInputFUND_NAME");

                    ComTextBox txtInputASSET_NAME = (ComTextBox)row.FindControl("txtInputASSET_NAME");
                    ComTextBox txtInputPRICE = (ComTextBox)row.FindControl("txtInputPRICE");
                    ComTextBox txtInputAMOUNT = (ComTextBox)row.FindControl("txtInputAMOUNT");
                    ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
                    ComTextBox txtInputMONEY1 = (ComTextBox)row.FindControl("txtInputMONEY1");
                    ComTextBox InputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");
                    
                    if (select.Checked)
                    {
                        if (IsOneShangEnable())
                        {
                            if (string.IsNullOrEmpty(txtInputASSET_NAME.Text))
                            {
                                throw new Exception("设备名称不能为空");
                            }
                            double result;
                            bool isOK = double.TryParse(txtInputPRICE.Text, out result);
                            if (isOK)
                            {
                                if (double.Parse(txtInputPRICE.Text) <= 0)
                                {
                                    throw new Exception("设备单价必须大于0");
                                }
                            }
                            bool isOK1 = double.TryParse(txtInputAMOUNT.Text, out result);
                            if (isOK1)
                            {
                                if (double.Parse(txtInputAMOUNT.Text) <= 0)
                                {
                                    throw new Exception("设备数量必须大于0");
                                }
                            }
                            else
                            {
                                throw new Exception("设备数量格式不正确");
                            }
                            bool isOK2 = double.TryParse(txtInputMONEY.Text, out result);
                            if (isOK2)
                            {
                                if (double.Parse(txtInputMONEY.Text) <= 0)
                                {
                                    throw new Exception("申请金额必须大于0");
                                }
                            }
                            else
                            {
                                throw new Exception("申请金额格式不正确");
                            }
                            if (string.IsNullOrEmpty(InputDECLARE_CAUSE.Text))
                            {
                                throw new Exception("依据说明不能为空");
                            }
                        }
                        else if (IsTwoShangEnable() && fund_money <= 0)
                        {
                            if (string.IsNullOrEmpty(txtInputASSET_NAME.Text))
                            {
                                throw new Exception("设备名称不能为空");
                            }
                            double result;
                            bool isOK = double.TryParse(txtInputPRICE.Text, out result);
                            if (isOK)
                            {
                                if (double.Parse(txtInputPRICE.Text) <= 0)
                                {
                                    throw new Exception("设备单价必须大于0");
                                }
                            }
                            bool isOK1 = double.TryParse(txtInputAMOUNT.Text, out result);
                            if (isOK1)
                            {
                                if (double.Parse(txtInputAMOUNT.Text) <= 0)
                                {
                                    throw new Exception("设备数量必须大于0");
                                }
                            }
                            else
                            {
                                throw new Exception("设备数量格式不正确");
                            }
                            bool isOK2 = double.TryParse(txtInputMONEY1.Text, out result);
                            if (isOK2)
                            {
                                if (double.Parse(txtInputMONEY1.Text) <= 0)
                                {
                                    throw new Exception("申请金额必须大于0");
                                }
                            }
                            else
                            {
                                throw new Exception("申请金额格式不正确");
                            }
                            if (string.IsNullOrEmpty(InputDECLARE_CAUSE.Text))
                            {
                                throw new Exception("依据说明不能为空");
                            }
                        }
                       
                    }
                }
            }
            if (string.IsNullOrEmpty(this.ddlInputBUDGET_YEAR.SelectedValue))
                throw new Exception("没有预算执行中的年份");
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
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND).ID;
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
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)",Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
            if (depts.Length != 0)
            {
                this.ddlInputBUDGET_DEPT_ID.KeyValue = depts[0].ID;
                this.ddlInputBUDGET_DEPT_ID.NameValue = depts[0].NAME;
            }
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = "";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputFUND_TYPE_ID.Text = "资产购置预算";//每个页面需要修改 hsc
            this.ddlInputDEPT_USER_ID.Text = BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART { ID = SystemLogic.Proxy.CurrentUser.DEPART_ID }).HEAD_USER_ID;
            this.txtInputDECALRE_CAUSE.Text = string.Empty;
            this.txtInputCODE.Text = "";
            this.txtInputCODE_H.Value = "";
            this.txtInputFUND_MONEY.Text = "0.00";

            SetEnumReferenceBinding(this.ddlInputIS_AGREE, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            ListItem LI = new ListItem();
            LI.Value = "0";
            LI.Text = "";
            this.ddlInputIS_AGREE.Items.Add(LI);
            this.ddlInputIS_AGREE.SelectedValue = "0";

            //hsc 附件上传
            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = "";
            upFiles.ReadOnly = true;
            this.btnSeSubmit.Enabled = false;


            txtInputFINANCE_IDEA.Enabled = IsOneXiaEnable();
            txtInputFINANCE_IDEA1.Enabled = IsTwoXiaEnable();
            this.txtInputFUND_MONEY.Enabled = IsOneShangEnable();
            this.txtInputFUND_MONEY1.Enabled = IsTwoShangEnable();
            this.txtInputDECALRE_CAUSE.Enabled = IsOneShangEnable();
            this.txtInputDECALRE_CAUSE1.Enabled = IsTwoShangEnable();
            this.ddlInputIS_AGREE.Enabled = false;
            this.txtInputCONTROL_MONEY.Enabled = IsOneXiaEnable();
            this.txtInputCONTROL_MONEY1.Enabled = IsTwoXiaEnable();
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
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;

                if (!string.IsNullOrEmpty(txtInputFUND_MONEY.Text))
                    baseEntity.FUND_MONEY = decimal.Parse(txtInputFUND_MONEY.Text);
                else
                    baseEntity.FUND_MONEY = 0;

                baseEntity.FUND_TYPE_ID = "BGT_00010202";//一般经费预算 hsc
                baseEntity.CODE = txtInputCODE_H.Value;
                baseEntity.IS_PERFORMANCE = 2;
                baseEntity.IS_FIXED = 2;

                if (!string.IsNullOrEmpty(txtInputFUND_MONEY1.Text))
                {
                    baseEntity.FUND_MONEY1 = decimal.Parse(txtInputFUND_MONEY1.Text);
                }
                else
                {
                    baseEntity.FUND_MONEY1 = 0;
                }
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
                {
                    baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
                }
                else
                {
                    baseEntity.CONTROL_MONEY = 0;
                }
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY1.Text))
                {
                    baseEntity.CONTROL_MONEY1 = decimal.Parse(txtInputCONTROL_MONEY1.Text);
                }
                else
                {
                    baseEntity.CONTROL_MONEY1 = 0;
                }
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text.ToString();
                baseEntity.FINANCE_IDEA1 = txtInputFINANCE_IDEA1.Text.ToString();
                baseEntity.DECALRE_CAUSE1 = txtInputDECALRE_CAUSE1.Text.ToString();
                baseEntity.ISAGREE = ddlInputIS_AGREE.SelectedValue;

                //    baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");;

                        ComTextBox txtInputAMOUNT = (ComTextBox)row.FindControl("txtInputAMOUNT");
                        ComTextBox txtInputPRICE = (ComTextBox)row.FindControl("txtInputPRICE");

                        ComTextBox txtInputASSET_NAME = (ComTextBox)row.FindControl("txtInputASSET_NAME");
                        ComTextBox txtCONTROL_MONEY = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY");
                        ComTextBox txtInputMONEY1 = (ComTextBox)row.FindControl("txtInputMONEY1");
                        ComTextBox txtCONTROL_MONEY1 = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY1");
                        ComTextBox txtFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        ComTextBox txtFINANCE_IDEA1 = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA1");
                        //      ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        //平台自动生成代码
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;

                            //if(!string.IsNullOrEmpty(txtInputMONEY.Text))
                            //detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            //else
                            //detailEntity.MONEY = 0;

                            if (!string.IsNullOrEmpty(txtInputAMOUNT.Text))
                                detailEntity.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
                            else
                                detailEntity.AMOUNT = 0;
                            if (!string.IsNullOrEmpty(txtInputPRICE.Text))
                                detailEntity.PRICE = decimal.Parse(txtInputPRICE.Text);
                            else
                                detailEntity.PRICE = 0;
                            detailEntity.MONEY = detailEntity.PRICE * detailEntity.AMOUNT;

                            if (!string.IsNullOrEmpty(txtInputMONEY1.Text))
                                detailEntity.MONEY1 = decimal.Parse(txtInputMONEY1.Text);
                            else
                                detailEntity.MONEY1 = 0;

                            if (!string.IsNullOrEmpty(txtCONTROL_MONEY.Text))
                                detailEntity.CONTROL_MONEY = decimal.Parse(txtCONTROL_MONEY.Text);
                            else
                                detailEntity.CONTROL_MONEY = 0;

                            if (!string.IsNullOrEmpty(txtCONTROL_MONEY1.Text))
                                detailEntity.CONTROL_MONEY1 = decimal.Parse(txtCONTROL_MONEY1.Text);
                            else
                                detailEntity.CONTROL_MONEY1 = 0;

                            detailEntity.FINANCE_IDEA = txtFINANCE_IDEA.Text;
                            detailEntity.FINANCE_IDEA1 = txtFINANCE_IDEA1.Text;

                            txtInputMONEY.Text = detailEntity.MONEY.ToString();
                            detailEntity.ASSET_NAME = txtInputASSET_NAME.Text;
                            //  detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
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
                    upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
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
                EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;

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
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;
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

                baseEntity.FUND_TYPE_ID = "BGT_00010202";//一般经费预算 hsc
                baseEntity.CODE = txtInputCODE_H.Value;

                if (!string.IsNullOrEmpty(txtInputFUND_MONEY1.Text))
                {
                    baseEntity.FUND_MONEY1 = decimal.Parse(txtInputFUND_MONEY1.Text);
                }
                else
                {
                    baseEntity.FUND_MONEY1 = 0;
                }
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
                {
                    baseEntity.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
                }
                else
                {
                    baseEntity.CONTROL_MONEY = 0;
                }
                if (!string.IsNullOrEmpty(txtInputCONTROL_MONEY1.Text))
                {
                    baseEntity.CONTROL_MONEY1 = decimal.Parse(txtInputCONTROL_MONEY1.Text);
                }
                else
                {
                    baseEntity.CONTROL_MONEY1 = 0;
                }
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text.ToString();
                baseEntity.FINANCE_IDEA1 = txtInputFINANCE_IDEA1.Text.ToString();
                baseEntity.DECALRE_CAUSE1 = txtInputDECALRE_CAUSE1.Text.ToString();
                baseEntity.ISAGREE = ddlInputIS_AGREE.SelectedValue;
                //     baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA2.Text;
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");

                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");

                        ComTextBox txtInputAMOUNT = (ComTextBox)row.FindControl("txtInputAMOUNT");
                        ComTextBox txtInputPRICE = (ComTextBox)row.FindControl("txtInputPRICE");

                        ComTextBox txtInputASSET_NAME = (ComTextBox)row.FindControl("txtInputASSET_NAME");
                        ComTextBox txtCONTROL_MONEY = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY");
                        ComTextBox txtInputMONEY1 = (ComTextBox)row.FindControl("txtInputMONEY1");
                        ComTextBox txtCONTROL_MONEY1 = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY1");
                        ComTextBox txtFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        ComTextBox txtFINANCE_IDEA1 = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA1");
                        //       ComTextBox txtInputFINANCE_IDEA = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        //平台自动生成代码
                        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND detailEntity = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;

                            //if(!string.IsNullOrEmpty(txtInputMONEY.Text))
                            //detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            //else
                            //detailEntity.MONEY = 0;

                            if (!string.IsNullOrEmpty(txtInputAMOUNT.Text))
                                detailEntity.AMOUNT = decimal.Parse(txtInputAMOUNT.Text);
                            else
                                detailEntity.AMOUNT = 0;
                            if (!string.IsNullOrEmpty(txtInputPRICE.Text))
                                detailEntity.PRICE = decimal.Parse(txtInputPRICE.Text);
                            else
                                detailEntity.PRICE = 0;

                            detailEntity.ASSET_NAME = txtInputASSET_NAME.Text;
                            detailEntity.MONEY = detailEntity.PRICE * detailEntity.AMOUNT;
                            txtInputMONEY.Text = detailEntity.MONEY.ToString();

                            if (!string.IsNullOrEmpty(txtInputMONEY1.Text))
                                detailEntity.MONEY1 = decimal.Parse(txtInputMONEY1.Text);
                            else
                                detailEntity.MONEY1 = 0;

                            if (!string.IsNullOrEmpty(txtCONTROL_MONEY.Text))
                                detailEntity.CONTROL_MONEY = decimal.Parse(txtCONTROL_MONEY.Text);
                            else
                                detailEntity.CONTROL_MONEY = 0;

                            if (!string.IsNullOrEmpty(txtCONTROL_MONEY1.Text))
                                detailEntity.CONTROL_MONEY1 = decimal.Parse(txtCONTROL_MONEY1.Text);
                            else
                                detailEntity.CONTROL_MONEY1 = 0;

                            detailEntity.FINANCE_IDEA = txtFINANCE_IDEA.Text;
                            detailEntity.FINANCE_IDEA1 = txtFINANCE_IDEA1.Text;

                            //     detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
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
                    BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
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

                ComTextBox txtInputAMOUNT = (ComTextBox)e.Row.FindControl("txtInputAMOUNT");
                txtInputAMOUNT.Text = entity.AMOUNT == null ? "0" : entity.AMOUNT.ToString();
                ComTextBox txtInputPRICE = (ComTextBox)e.Row.FindControl("txtInputPRICE");
                txtInputPRICE.Text = entity.PRICE == null ? "0" : entity.PRICE.ToString();

                ComTextBox txtInputASSET_NAME = (ComTextBox)e.Row.FindControl("txtInputASSET_NAME");
                txtInputASSET_NAME.Text = entity.ASSET_NAME == null ? String.Empty : entity.ASSET_NAME.ToString();

                ComTextBox txtInputMONEY1 = (ComTextBox)e.Row.FindControl("txtInputMONEY1");
                txtInputMONEY1.Text = entity.MONEY1 == null ? "0" : entity.MONEY1.ToString();

                ComTextBox txtInputCONTROL_MONEY = (ComTextBox)e.Row.FindControl("txtInputCONTROL_MONEY");
                txtInputCONTROL_MONEY.Text = entity.CONTROL_MONEY == null ? "0" : entity.CONTROL_MONEY.ToString();
                ComTextBox txtInputCONTROL_MONEY1 = (ComTextBox)e.Row.FindControl("txtInputCONTROL_MONEY1");
                txtInputCONTROL_MONEY1.Text = entity.CONTROL_MONEY1 == null ? "0" : entity.CONTROL_MONEY1.ToString();

                ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
                txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA;

                ComTextBox txtInputFINANCE_IDEA1 = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA1");
                txtInputFINANCE_IDEA1.Text = entity.FINANCE_IDEA1;
                //   ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
                //    txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA;
                RegisterCalculateAndSelectedScript(txtInputPRICE, txtInputMONEY, txtInputAMOUNT, txtInputPRICE, select);
                if (ViewState["CUR_OBJ"] != null)
                {
                    decimal state;
                    state = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND).STATE;
                    if (state == (decimal)Ipedf.Common.数据状态.编辑中)
                    {
                        LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton1");
                        lb.Visible = true;
                    }
                    else
                    {
                        LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton1");
                        lb.Visible = false;
                    }
                }
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select

                decimal fund_money = decimal.Parse(this.txtInputFUND_MONEY.Text);

                txtInputASSET_NAME.Enabled = IsOneShangEnable() || (IsTwoShangEnable() && fund_money <=0);
                txtInputAMOUNT.Enabled = IsOneShangEnable() || IsTwoShangEnable();
                txtInputPRICE.Enabled = IsOneShangEnable() || IsTwoShangEnable();

                txtInputMONEY.Enabled = IsOneShangEnable();
                txtInputDECLARE_CAUSE.Enabled = IsOneShangEnable() || IsTwoShangEnable();

                txtInputMONEY1.Text = this.ddlInputIS_AGREE.SelectedValue == "1" ? txtInputCONTROL_MONEY.Text : txtInputMONEY1.Text;
                txtInputMONEY1.Enabled = IsTwoShangEnable() && this.ddlInputIS_AGREE.SelectedValue != "1";

                txtInputCONTROL_MONEY.Enabled = IsOneXiaEnable();
                txtInputCONTROL_MONEY1.Enabled = IsTwoXiaEnable();

                txtInputFINANCE_IDEA.Enabled = IsOneXiaEnable();
                txtInputFINANCE_IDEA1.Enabled = IsTwoXiaEnable();

            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
            cause.FUND_TYPE_ID = "BGT_00010202";
            if (!string.IsNullOrEmpty(Session["budget_year"].ToString()))
            {
                cause.SetCustomCondition(" and V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR='" + Session["budget_year"].ToString() + "'");
            }
            else
            {
                cause.SetCustomCondition(" and V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR=(SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)");
            }
            //cause.STATE = 1;
            if (!string.IsNullOrEmpty(Session["budget_year"].ToString()))
            {
                DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
                if (depts.Length != 0)
                {
                    cause.BUDGET_DEPT_ID = depts[0].ID;
                }
                else
                {
                    cause.BUDGET_DEPT_ID = "un";
                }
            }
            else
            {
                DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.GetFunctionBudgetDepartByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, Session["budget_year"].ToString());
                if (depts.Length != 0)
                {
                    cause.BUDGET_DEPT_ID = depts[0].ID;
                }
            }
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Get(baseEntity);
            btnSeSubmit.Visible = false;
            //如果年度不再执行年度或编制年度，隐藏按钮
            string Year1 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
            string Year2 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(2);
            if (baseEntity.BUDGET_YEAR != Year1 && baseEntity.BUDGET_YEAR != Year1)
                this.command.Visible = false;
            else
                this.command.Visible = true;
            this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition =string.Format( "BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)",Ipedf.Hrp.BGT.Common.预算阶段.执行阶段);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
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
            this.ddlInputFUND_TYPE_ID.Text = "资产购置预算";//每个页面需要修改 hsc
            this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            this.txtInputCODE_H.Value = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();

            SetEnumReferenceBinding(this.ddlInputIS_AGREE, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            ListItem LI = new ListItem();
            LI.Value = "0";
            LI.Text = "";
            this.ddlInputIS_AGREE.Items.Add(LI);
            if (baseEntity.ISAGREE != null)
            {
                this.ddlInputIS_AGREE.SelectedValue = baseEntity.ISAGREE.ToString();
            }
            else
            {
                this.ddlInputIS_AGREE.SelectedValue = "0";
            }
            this.txtInputCONTROL_MONEY.Text = baseEntity.CONTROL_MONEY == null ? null : baseEntity.CONTROL_MONEY.ToString();
            this.txtInputFUND_MONEY1.ReadOnly = false;
            this.txtInputFUND_MONEY1.Text = baseEntity.FUND_MONEY1 == null ? string.Empty : baseEntity.FUND_MONEY1.ToString();
            this.txtInputCONTROL_MONEY1.Text = baseEntity.CONTROL_MONEY1 == null ? string.Empty : baseEntity.CONTROL_MONEY1.ToString();
            this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty : baseEntity.FINANCE_IDEA.ToString();
            this.txtInputFINANCE_IDEA1.Text = baseEntity.FINANCE_IDEA1 == null ? string.Empty : baseEntity.FINANCE_IDEA1.ToString(); ;
            this.ddlInputDEPT_USER_ID.Text = baseEntity.DEPT_USER_ID ?? "";

            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            this.txtInputDECALRE_CAUSE1.Text = baseEntity.DECALRE_CAUSE1 == null ? string.Empty : baseEntity.DECALRE_CAUSE1.ToString();
            //    this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? "" : baseEntity.FINANCE_IDEA;
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


            ddlInputBUDGET_DEPT_ID.Enabled = false;
            ddlInputBGT_D_BUDGET_ITEM_ID.Enabled = IsOneShangEnable();
            txtInputFUND_MONEY.Enabled = IsOneShangEnable();
            txtInputFUND_MONEY1.Text = this.ddlInputIS_AGREE.SelectedValue == "1" ? txtInputCONTROL_MONEY.Text : txtInputFUND_MONEY1.Text;
            txtInputFUND_MONEY1.Enabled = IsTwoShangEnable() && this.ddlInputIS_AGREE.SelectedValue != "1";

            txtInputDECALRE_CAUSE.Enabled = IsOneShangEnable();
            txtInputDECALRE_CAUSE1.Enabled = IsTwoShangEnable() && this.ddlInputIS_AGREE.SelectedValue != "1";
            txtInputFINANCE_IDEA.Enabled = IsOneXiaEnable();
            txtInputFINANCE_IDEA1.Enabled = IsTwoXiaEnable();
            txtInputCONTROL_MONEY.Enabled = IsOneXiaEnable();
            txtInputCONTROL_MONEY1.Enabled = IsTwoXiaEnable();

            decimal fund_money = decimal.Parse(this.txtInputFUND_MONEY.Text);
            ddlInputIS_AGREE.Enabled = IsTwoShangEnable() && fund_money > 0;

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
                else
                    foreach (GridViewRow row in gvDetailList.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            LinkButton select = (LinkButton)row.FindControl("LinkButton1");
                            select.Visible = false;
                        }
                    }
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
                else
                    foreach (GridViewRow row in gvDetailList.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            LinkButton select = (LinkButton)row.FindControl("LinkButton1");
                            select.Visible = true;
                        }
                    }
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

        protected void ddlInputIS_AGREE_Change(object sender, EventArgs e)
        {
            if (this.ddlInputIS_AGREE.SelectedValue == "1")
            {
                this.txtInputFUND_MONEY1.Enabled = false;
                this.txtInputFUND_MONEY1.Text = this.txtInputCONTROL_MONEY.Text;
                this.txtInputDECALRE_CAUSE1.Enabled = false;
            }
            else if (this.ddlInputIS_AGREE.SelectedValue == "2")
            {
                this.txtInputFUND_MONEY1.Enabled = true;
                this.txtInputFUND_MONEY1.Text = "0";
                this.txtInputDECALRE_CAUSE1.Enabled = true;
            }
            else
            {
                this.txtInputFUND_MONEY1.Enabled = true;
                this.txtInputFUND_MONEY1.Text = "0";
                this.txtInputDECALRE_CAUSE1.Enabled = true;
            }

            foreach (GridViewRow row in gvDetailList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    ComTextBox txtInputMONEY1 = (ComTextBox)row.FindControl("txtInputMONEY1");
                    ComTextBox txtInputCONTROL_MONEY = (ComTextBox)row.FindControl("txtInputCONTROL_MONEY");
                    txtInputMONEY1.Text = this.ddlInputIS_AGREE.SelectedValue == "1" ? txtInputCONTROL_MONEY.Text : "0";
                    txtInputMONEY1.Enabled = IsTwoShangEnable() && this.ddlInputIS_AGREE.SelectedValue != "1";
                }
            }
        }

        protected void OnResourceAppend(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            if (baseEntity == null)
            {
                OnSave(sender, e);
                baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_PAY_YEAR_FUND;
            }
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("linkid", baseEntity.ID);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_MACHINE.aspx", parameters);
            base.OpenWindow(url, 800, 375);
        }
    }
}

