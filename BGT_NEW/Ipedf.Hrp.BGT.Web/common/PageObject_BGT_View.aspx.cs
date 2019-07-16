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
using Ipedf.Web.Entity;
using Ipedf.Hrp.Web.common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_View : Page
    {
        public string Tip { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gvDetailList.Attributes.Add("style", "word-break:break-all !important ;word-wrap:break-word !important ;");
            string year = Request.QueryString["YEAR"];
            string code = Request.QueryString["CODE"];
            CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = new CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
            baseEntity.BUDGET_YEAR_NAME = year;
            baseEntity.CODE = code;
            EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] eb = BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(baseEntity);
            if (eb.Length > 0)
            {
                string id = eb[0].ID.ToString();
                PrepareBaseEdit(id);
                PrepareDetailInput(PrepareDetailDataSource(id), eb[0].FUND_TYPE_ID.Trim());
                editPannel_1.Visible = false;
            }
            else
            { 
                CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity1 = new CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
                baseEntity1.CODE = code;
                baseEntity1.SetCustomCondition(" and BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR = '" + year + "'");
                EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] ea = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Query(baseEntity1);
                if (ea.Length > 0)
                {
                    editPannel.Visible = false;
                    editPannel_1.Visible = true;
                    string id = ea[0].ID.ToString();
                    PrepareBaseUpdate(id);
                    PrepareUpdateDetailInput(PrepareDetailDataSource(id), ea[0].FUND_TYPE_ID.Trim());
                }
            }
        }

        protected void PrepareBaseEdit(string id)
        {

            //平台自动生成代码

            EntityObject_BGT_B_DEPT_PAY_YEAR_FUND baseEntity = new EntityObject_BGT_B_DEPT_PAY_YEAR_FUND();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Get(baseEntity);
            //btnSeSubmit.Visible = false;
            //如果年度不再执行年度或编制年度，隐藏按钮
            string Year1 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
            string Year2 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(2);
            //if (baseEntity.BUDGET_YEAR != Year1 && baseEntity.BUDGET_YEAR != Year1)
            //    this.command.Visible = false;
            //else
            //    this.command.Visible = true;
            this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)", Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            //SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            ListItem liyear = new ListItem();
            liyear.Value = Request.QueryString["YEAR"];
            liyear.Text = Request.QueryString["YEAR"];
            this.ddlInputBUDGET_YEAR.Items.Add(liyear);
            this.ddlInputBUDGET_YEAR.Enabled = false;

            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.ClientFunction = "ClientFun";
            this.ddlInputBGT_D_BUDGET_ITEM_ID.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            //this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={1} AND ROWNUM = 1) and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID, (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            this.ddlInputBGT_D_BUDGET_ITEM_ID.DataTable = "BGT_D_BUDGET_ITEM";
            //this.ddlInputBGT_D_BUDGET_ITEM_ID.Condition = string.Format("BGT_D_BUDGET_ITEM.IS_END=2 and BGT_D_BUDGET_ITEM.ID in (select t.budget_item_id from BGT_D_BUDGET_DEPT_BUDGET_ITEM t where base_ID in (select ID from bgt_d_budget_dept where dept_id='{0}'))", SystemLogic.Proxy.CurrentUser.DEPART_ID);
            //	this.txtInputITEM_NAME.Text = baseEntity.ITEM_NAME == null ? string.Empty:baseEntity.ITEM_NAME.ToString();

            //SetEnumReferenceBinding(this.ddlInputIS_AGREE, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            ListItem LI = new ListItem();
            LI.Value = "0";
            LI.Text = "";
            this.ddlInputIS_AGREE.Items.Add(LI);
            ListItem LI1 = new ListItem();
            LI1.Value = Ipedf.Common.是否状态.是.ToString();
            LI1.Text = "是";
            this.ddlInputIS_AGREE.Items.Add(LI1);
            ListItem LI2 = new ListItem();
            LI2.Value = Ipedf.Common.是否状态.否.ToString();
            LI2.Text = "否";
            this.ddlInputIS_AGREE.Items.Add(LI1);
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
            this.txtInputFINANCE_IDEA1.Text = baseEntity.FINANCE_IDEA1 == null ? string.Empty : baseEntity.FINANCE_IDEA1.ToString();
            this.ddlInputDEPT_USER_ID.Text = baseEntity.DEPT_USER_ID ?? "";

            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            this.txtInputDECALRE_CAUSE1.Text = baseEntity.DECALRE_CAUSE1 == null ? string.Empty : baseEntity.DECALRE_CAUSE1.ToString();
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
            string fundtype = "";
            switch (baseEntity.FUND_TYPE_ID.Trim())
            {
                case "BGT_000101":
                    fundtype = "一般经费预算";
                    break;
                case "BGT_00010201":
                    fundtype = "基建及修缮资本预算";
                    break;
                case "BGT_00010202":
                    fundtype = "资产购置预算";
                    break;
            }
            this.ddlInputFUND_TYPE_ID.Text = fundtype;
            //this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty:baseEntity.NAME.ToString();
            //this.txtInputFREE_FIELD3.Text = baseEntity.FREE_FIELD3 == null ? string.Empty:baseEntity.FREE_FIELD3.ToString();
            //this.txtInputFREE_FIELD.Text = baseEntity.FREE_FIELD == null ? string.Empty:baseEntity.FREE_FIELD.ToString();
            //this.txtInputFREE_FIELD2.Text = baseEntity.FREE_FIELD2 == null ? string.Empty:baseEntity.FREE_FIELD2.ToString();
            //this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty:baseEntity.FINANCE_IDEA.ToString();
            //hsc 附件上传
            upFiles.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles.TableId = baseEntity.ID;
            upFiles.ReadOnly = true;

            //ShowEditState(baseEntity);
            //ViewState["CUR_OBJ"] = baseEntity;
            //PrepareDetailDataSourceControl(id);
            //ShowDetailData();
            //SetPageState(PageState.Edit);
            //ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }

        protected void PrepareBaseUpdate(string id)
        {

            //平台自动生成代码

            EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE baseEntity = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE.Proxy.Get(baseEntity);
    
            this.ddlInputBUDGET_DEPT_ID_1.KeyField = "ID";
            this.ddlInputBUDGET_DEPT_ID_1.NameField = "NAME";
            this.ddlInputBUDGET_DEPT_ID_1.KeyValue = baseEntity.BUDGET_DEPT_ID;
            this.ddlInputBUDGET_DEPT_ID_1.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT() { ID = baseEntity.BUDGET_DEPT_ID }).NAME;
            this.ddlInputBUDGET_DEPT_ID_1.DataTable = "BGT_D_BUDGET_DEPT";
            this.ddlInputBUDGET_DEPT_ID_1.Condition = string.Format("BGT_D_BUDGET_DEPT.IS_FUNCTION=1 AND BGT_D_BUDGET_DEPT.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE={0} AND ROWNUM = 1)", Ipedf.Hrp.BGT.Common.预算阶段.编制阶段);
            //SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            ListItem liyear = new ListItem();
            liyear.Value = Request.QueryString["YEAR"];
            liyear.Text = Request.QueryString["YEAR"];
            this.ddlInputBUDGET_YEAR_1.Items.Add(liyear);
            this.ddlInputBUDGET_YEAR_1.Enabled = false;

            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.KeyField = "ID";
            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.NameField = "NAME||CODE";
            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.ClientFunction = "ClientFun";
            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.KeyValue = baseEntity.BGT_D_BUDGET_ITEM_ID;
            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.NameValue = string.IsNullOrEmpty(baseEntity.BGT_D_BUDGET_ITEM_ID) ? string.Empty : BizLogicObject_BGT_D_BUDGET_ITEM.Proxy.Get(new EntityObject_BGT_D_BUDGET_ITEM() { ID = baseEntity.BGT_D_BUDGET_ITEM_ID }).NAME;
            this.ddlInputBGT_D_BUDGET_ITEM_ID_1.DataTable = "BGT_D_BUDGET_ITEM";;

            string UserName = string.IsNullOrEmpty(baseEntity.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = baseEntity.DEPT_USER_ID }).NAME;
            this.ddlInputDEPT_USER_ID_1.Text = UserName ?? "";

            this.txtInputDECALRE_CAUSE_1.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();;
            this.txtInputFUND_MONEY_1.Text = baseEntity.FUND_MONEY == null ? string.Empty : baseEntity.FUND_MONEY.ToString();
            this.txtInputCODE_1.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();


            //    this.txtInputFINANCE_IDEA2.Text = baseEntity.FINANCE_IDEA == null ? "" : baseEntity.FINANCE_IDEA;
            string fundtype = "";
            switch (baseEntity.FUND_TYPE_ID.Trim())
            {
                case "BGT_000101":
                    fundtype = "一般经费预算";
                    break;
                case "BGT_00010201":
                    fundtype = "基建及修缮资本预算";
                    break;
                case "BGT_00010202":
                    fundtype = "资产购置预算";
                    break;
            }
            this.ddlInputFUND_TYPE_ID_1.Text = fundtype;
            //hsc 附件上传
            upFiles_1.TableName = "BGT_B_DEPT_PAY_YEAR_FUND";
            upFiles_1.TableId = baseEntity.ID;
            upFiles_1.ReadOnly = true;

        }

        protected object PrepareDetailDataSource(string id)
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
            cause.BASE_ID = id;
            dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
            list.AddRange((DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[])dataSource);
            //list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected void PrepareDetailInput(object dataSource,string type)
        {
            switch (type)
            {
                case "BGT_000101":
                    this.gvDetailList.DataSource = dataSource;
                    this.gvDetailList.DataBind();
                    this.gvDetailList1.Visible = false;
                    this.gvDetailList2.Visible = false;
                    break;
                case "BGT_00010201":
                    this.gvDetailList1.DataSource = dataSource;
                    this.gvDetailList1.DataBind();
                    this.gvDetailList.Visible = false;
                    this.gvDetailList2.Visible = false;
                    break;
                case "BGT_00010202":
                    this.gvDetailList2.DataSource = dataSource;
                    this.gvDetailList2.DataBind();
                    this.gvDetailList.Visible = false;
                    this.gvDetailList1.Visible = false;
                    break;
            }
            //this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            //this.gvDetailList.DataSource = dataSource;
            //this.gvDetailList.DataBind();
        }

        protected object PrepareUpdateDetailDataSource(string id)
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause = new CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
            cause.BASE_ID = id;
            dataSource = BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND> list = new System.Collections.Generic.List<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>();
            list.AddRange((DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[])dataSource);
            //list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected void PrepareUpdateDetailInput(object dataSource, string type)
        {
            switch (type)
            {
                case "BGT_000101":
                    this.gvDetailList_1.DataSource = dataSource;
                    this.gvDetailList_1.DataBind();
                    this.gvDetailList_2.Visible = false;
                    this.gvDetailList_3.Visible = false;
                    break;
                case "BGT_00010201":
                    this.gvDetailList_2.DataSource = dataSource;
                    this.gvDetailList_2.DataBind();
                    this.gvDetailList_1.Visible = false;
                    this.gvDetailList_3.Visible = false;
                    break;
                case "BGT_00010202":
                    this.gvDetailList_3.DataSource = dataSource;
                    this.gvDetailList_3.DataBind();
                    this.gvDetailList_1.Visible = false;
                    this.gvDetailList_2.Visible = false;
                    break;
            }
            //this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            //this.gvDetailList.DataSource = dataSource;
            //this.gvDetailList.DataBind();
        }
    }
}

