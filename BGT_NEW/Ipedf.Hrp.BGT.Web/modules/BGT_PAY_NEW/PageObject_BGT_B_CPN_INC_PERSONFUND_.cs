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
    public partial class PageObject_BGT_B_CPN_INC_PERSONFUND
    {
        private EntityObject_BGT_B_CPN_INC_PF_D pfD1;
        private EntityObject_BGT_B_CPN_INC_PF_D pfD2;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);

            this.txtInputTOTAL_MONEY.ReadOnly = true;
            this.txtInputType1.ReadOnly = true;
            this.txtInputType2.ReadOnly = true;
            //Ipedf.Hrp.Web.common.ComControlBar_State.SettingComControlBar_Dept(this.command, 0);
            //if (this.btnDelete.Visible)
            //{
            //    this.btnDelete.Visible = this.command[Ipedf.Web.Control.ButtonType.Add].Visible;
            //}
        }
        protected override void RegisterGridEvent()
        {
            base.RegisterGridEvent();
            this.gvDetailList2.RowDataBound += new GridViewRowEventHandler(OnDetailGridRowDataBound2);
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_CPN_INC_PF_D_D cause = new CauseObject_BGT_B_CPN_INC_PF_D_D();
            if (this.pfD1 != null)
                cause.BASE_ID = pfD1.ID;
            else
                cause.BASE_ID = Ipedf.Common.Template.UndefineGuid;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = true;
            orderBy.OrderBy = "ITEM_CODE";
            dataSource = BizLogicObject_BGT_B_CPN_INC_PF_D_D.Proxy.Query(cause, null, orderBy);
            System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PF_D_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PF_D_D>();
            list.AddRange((DisplayObject_BGT_B_CPN_INC_PF_D_D[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_CPN_INC_PF_D_D>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareCause()
        {

            CauseObject_BGT_D_BUDGET_ITEM cause742 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause742.ITEM_TYPE_ID = "00180005";
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause742);
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_CPN_INC_PF_D_D), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        private void BindDetailGrid2()
        {
            EntityObject_BGT_B_CPN_INC_PF_D_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PF_D_D;
            CauseObject_BGT_B_CPN_INC_PF_D_D cause = new CauseObject_BGT_B_CPN_INC_PF_D_D();
            if (pfD2 != null)
                cause.BASE_ID = pfD2.ID;
            else
                cause.BASE_ID = Ipedf.Common.Template.UndefineGuid;
            OrderByParameter orderby = new OrderByParameter();
            orderby.OrderBy = "ITEM_CODE";
            orderby.Asc = true;
            DisplayObject_BGT_B_CPN_INC_PF_D_D[] result = BizLogicObject_BGT_B_CPN_INC_PF_D_D.Proxy.Query(cause, null, orderby);
            System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PF_D_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PF_D_D>();
            list.AddRange(result);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_CPN_INC_PF_D_D>(5));
            this.gvDetailList2.DataKeyNames = new string[] { "ID" };
            this.gvDetailList2.DataSource = list.ToArray();
            this.gvDetailList2.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            //平台自动生成代码

           
            this.txtInputNAME.Text = string.Empty;
            CauseObject_BGT_D_BUDGET_YEAR pYear = new CauseObject_BGT_D_BUDGET_YEAR();
            pYear.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", pYear);
            this.ddlInputDEPT_ID.DataTable = "COM_DEPART";
            this.ddlInputDEPT_ID.KeyField = "ID";
            this.ddlInputDEPT_ID.NameField = "NAME";
            this.ddlInputDEPT_ID.KeyValue = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            this.ddlInputDEPT_ID.NameValue = SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME;
            this.txtInputTOTAL_MONEY.Text = "0.00";

            CauseObject_BGT_D_BUDGET_ITEM cause583 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause583.CODE = "BGT_PERSON_0001";
            SetForeignKeyBinding(this.ddlInputType1, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause583);
            CauseObject_BGT_D_BUDGET_ITEM cause538 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause538.CODE = "BGT_PERSON_0002";
            SetForeignKeyBinding(this.ddlInputType2, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause538);
            this.txtInputType1.Text = "0.00";
            this.txtInputType2.Text = "0.00";

            BindDetailGrid2();
        }
        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码
            EntityObject_BGT_B_CPN_INC_PERSONFUND baseEntity = new EntityObject_BGT_B_CPN_INC_PERSONFUND();
            baseEntity.ID = id;

            CauseObject_BGT_B_CPN_INC_PF_D cause = new CauseObject_BGT_B_CPN_INC_PF_D();
            cause.BASE_ID = id;
            EntityObject_BGT_B_CPN_INC_PF_D[] pfDs = BizLogicObject_BGT_B_CPN_INC_PF_D.Proxy.Query(cause);
            if (pfDs != null && pfDs.Length != 0)
            {
                EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD1 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0001").ToArray();
                if (tmpPfD1 != null && tmpPfD1.Length != 0)
                    this.pfD1 = tmpPfD1[0];

                EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD2 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0002").ToArray();
                if (tmpPfD1 != null && tmpPfD1.Length != 0)
                    this.pfD2 = tmpPfD2[0];
            }

            baseEntity = BizLogicObject_BGT_B_CPN_INC_PERSONFUND.Proxy.Get(baseEntity);
          //  this.txtInputCODE.Text = baseEntity.CODE == null ? string.Empty : baseEntity.CODE.ToString();
            this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty : baseEntity.NAME.ToString();
            CauseObject_BGT_D_BUDGET_YEAR pYear = new CauseObject_BGT_D_BUDGET_YEAR();
            pYear.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeySelected<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR", pYear);
            this.ddlInputDEPT_ID.KeyField = "ID";
            this.ddlInputDEPT_ID.NameField = "NAME";
            this.ddlInputDEPT_ID.KeyValue = baseEntity.DEPT_ID;
            this.ddlInputDEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.DEPT_ID) ? string.Empty : BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART() { ID = baseEntity.DEPT_ID }).NAME;
            this.ddlInputDEPT_ID.DataTable = "COM_DEPART";
            this.txtInputTOTAL_MONEY.Text = baseEntity.TOTAL_MONEY == null ? string.Empty : baseEntity.TOTAL_MONEY.ToString();

            CauseObject_BGT_D_BUDGET_ITEM cause583 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause583.CODE = "BGT_PERSON_0001";
            SetForeignKeySelected(this.ddlInputType1, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), pfD1.ITEM_ID, "ID", "NAME", cause583);
            CauseObject_BGT_D_BUDGET_ITEM cause538 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause538.CODE = "BGT_PERSON_0002";
            SetForeignKeySelected(this.ddlInputType2, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), pfD2.ITEM_ID, "ID", "NAME", cause538);

            this.txtInputType1.Text = Math.Round(this.pfD1.TOTAL_MONEY, 2).ToString();
            this.txtInputType2.Text = Math.Round(this.pfD2.TOTAL_MONEY, 2).ToString();

            ShowEditState(baseEntity);
            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);

            BindDetailGrid2();
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> detail1 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> detail2 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                EntityObject_BGT_B_CPN_INC_PERSONFUND baseEntity = new EntityObject_BGT_B_CPN_INC_PERSONFUND();
                EntityObject_BGT_B_CPN_INC_PF_D tmpPfD1 = new EntityObject_BGT_B_CPN_INC_PF_D();
                EntityObject_BGT_B_CPN_INC_PF_D tmpPfD2 = new EntityObject_BGT_B_CPN_INC_PF_D();
                decimal sum1 = 0;
                decimal sum2 = 0;
                //平台自动生成代码
              
                baseEntity.NAME = txtInputNAME.Text;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputDEPT_ID.KeyValue))
                    baseEntity.DEPT_ID = ddlInputDEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(txtInputTOTAL_MONEY.Text))
                    baseEntity.TOTAL_MONEY = decimal.Parse(txtInputTOTAL_MONEY.Text);
                else
                    baseEntity.TOTAL_MONEY = 0;

                if (!string.IsNullOrEmpty(ddlInputType1.SelectedValue))
                    tmpPfD1.ITEM_ID = ddlInputType1.SelectedValue;
                tmpPfD1.ITEM_CODE = "BGT_PERSON_0001";
                if (!string.IsNullOrEmpty(ddlInputType2.SelectedValue))
                    tmpPfD2.ITEM_ID = ddlInputType2.SelectedValue;
                tmpPfD2.ITEM_CODE = "BGT_PERSON_0002";
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                        ComMoneyBox txtInputMONEY = (ComMoneyBox)row.FindControl("txtInputMONEY");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_PF_D_D detailEntity = new EntityObject_BGT_B_CPN_INC_PF_D_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {
                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                            else
                                continue;
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                            {
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                                sum1 += detailEntity.MONEY;
                            }
                            else
                                detailEntity.MONEY = 0;
                            //AuditAdd(detailEntity);
                            detail1.Add(detailEntity);
                        }
                    }
                }
                foreach (GridViewRow row in gvDetailList2.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                        ComMoneyBox txtInputMONEY = (ComMoneyBox)row.FindControl("txtInputMONEY");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_PF_D_D detailEntity = new EntityObject_BGT_B_CPN_INC_PF_D_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList2.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {
                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                            else
                                continue;
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                            {
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                                sum2 += detailEntity.MONEY;
                            }
                            else
                                detailEntity.MONEY = 0;
                            //AuditAdd(detailEntity);
                            detail2.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PERSONFUND.Proxy.CommitSaveExt(baseEntity, tmpPfD1, tmpPfD2, detail1.ToArray(), detail2.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    PrepareDetailDataSourceControl(baseEntity.ID);
                    this.pfD1 = tmpPfD1;
                    this.pfD1.TOTAL_MONEY = sum1;
                    this.pfD2 = tmpPfD2;
                    this.pfD2.TOTAL_MONEY = sum2;
                    this.txtInputType1.Text = Math.Round(sum1, 2).ToString();
                    this.txtInputType2.Text = Math.Round(sum2, 2).ToString();
                    this.txtInputTOTAL_MONEY.Text = Math.Round(sum1 + sum2, 2).ToString();
                    ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
                }
                catch (Exception expt)
                {
                    throw expt;
                }
            }
            else
            {
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> saveDetail1 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> updateDetail1 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> deleteDetail1 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> saveDetail2 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> updateDetail2 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                List<EntityObject_BGT_B_CPN_INC_PF_D_D> deleteDetail2 = new List<EntityObject_BGT_B_CPN_INC_PF_D_D>();
                EntityObject_BGT_B_CPN_INC_PERSONFUND baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PERSONFUND;

                CauseObject_BGT_B_CPN_INC_PF_D cause = new CauseObject_BGT_B_CPN_INC_PF_D();
                cause.BASE_ID = baseEntity.ID;
                EntityObject_BGT_B_CPN_INC_PF_D[] pfDs = BizLogicObject_BGT_B_CPN_INC_PF_D.Proxy.Query(cause);
                if (pfDs != null && pfDs.Length != 0)
                {
                    EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD1 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0001").ToArray();
                    if (tmpPfD1 != null && tmpPfD1.Length != 0)
                        this.pfD1 = tmpPfD1[0];

                    EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD2 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0002").ToArray();
                    if (tmpPfD1 != null && tmpPfD1.Length != 0)
                        this.pfD2 = tmpPfD2[0];
                }

                //平台自动生成代码
              
                baseEntity.NAME = txtInputNAME.Text;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputDEPT_ID.KeyValue))
                    baseEntity.DEPT_ID = ddlInputDEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(txtInputTOTAL_MONEY.Text))
                    baseEntity.TOTAL_MONEY = decimal.Parse(txtInputTOTAL_MONEY.Text);
                else
                    baseEntity.TOTAL_MONEY = 0;
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                        ComMoneyBox txtInputMONEY = (ComMoneyBox)row.FindControl("txtInputMONEY");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_PF_D_D detailEntity = new EntityObject_BGT_B_CPN_INC_PF_D_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;
                            if (detailEntity.ID == string.Empty)
                            {
                                //AuditAdd(detailEntity);
                                if(string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    continue;
                                saveDetail1.Add(detailEntity);
                            }
                            else
                            {
                                //AuditEdit(detailEntity);
                                detailEntity.SetNotUpdate("BASE_ID");
                                updateDetail1.Add(detailEntity);
                            }
                        }
                        else
                        {
                            if (IsDeleteAble)
                            {
                                deleteDetail1.Add(detailEntity);
                            }
                        }
                    }
                }
                foreach (GridViewRow row in gvDetailList2.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
                        ComMoneyBox txtInputMONEY = (ComMoneyBox)row.FindControl("txtInputMONEY");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_PF_D_D detailEntity = new EntityObject_BGT_B_CPN_INC_PF_D_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList2.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;
                            if (detailEntity.ID == string.Empty)
                            {
                                //AuditAdd(detailEntity);
                                if(string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    continue;
                                saveDetail2.Add(detailEntity);
                            }
                            else
                            {
                                //AuditEdit(detailEntity);
                                detailEntity.SetNotUpdate("BASE_ID");
                                updateDetail2.Add(detailEntity);
                            }
                        }
                        else
                        {
                            if (IsDeleteAble)
                            {
                                deleteDetail2.Add(detailEntity);
                            }
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PERSONFUND.Proxy.CommitUpdateExt(baseEntity, this.pfD1, this.pfD2, saveDetail1.ToArray(), updateDetail1.ToArray(), deleteDetail1.ToArray(), saveDetail2.ToArray(), updateDetail2.ToArray(), deleteDetail2.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
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
            BindDetailGrid2();
            SetPageState(PageState.Edit);
        }
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_CPN_INC_PF_D_D entity = (EntityObject_BGT_B_CPN_INC_PF_D_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComBaseBox ddlInputITEM_ID = (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                CopyComDropDownListItem(ddlDataSourceITEM_ID, ref ddlInputITEM_ID, entity.ITEM_ID, "BGT_D_BUDGET_ITEM", "ID", "NAME");
                ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005'";
                ComMoneyBox txtInputMONEY = (ComMoneyBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        private void OnDetailGridRowDataBound2(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_CPN_INC_PF_D_D entity = (EntityObject_BGT_B_CPN_INC_PF_D_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComBaseBox ddlInputITEM_ID = (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                CopyComDropDownListItem(ddlDataSourceITEM_ID, ref ddlInputITEM_ID, entity.ITEM_ID, "BGT_D_BUDGET_ITEM", "ID", "NAME");
                ddlInputITEM_ID.Condition = "BGT_D_BUDGET_ITEM.ITEM_TYPE_ID='00180005'";
                ComMoneyBox txtInputMONEY = (ComMoneyBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {

            CauseObject_BGT_D_BUDGET_ITEM cause432 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause432.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_B_CPN_INC_PF_D_D.ITEM_ID from BGT_B_CPN_INC_PF_D_D where BGT_B_CPN_INC_PF_D_D.BASE_ID in (select id from BGT_B_CPN_INC_PF_D where base_id = '" + id + "') group by BGT_B_CPN_INC_PF_D_D.ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause432);
        }
        public override void ShowEditState(object entity)
        {
            base.ShowEditState(entity);
            CauseObject_BGT_B_CPN_INC_PF_D cause = new CauseObject_BGT_B_CPN_INC_PF_D();
            cause.BASE_ID = ((EntityObject_BGT_B_CPN_INC_PERSONFUND)entity).ID;
            EntityObject_BGT_B_CPN_INC_PF_D[] pfDs = BizLogicObject_BGT_B_CPN_INC_PF_D.Proxy.Query(cause);
            decimal sum = 0;
            if (pfDs != null && pfDs.Length != 0)
            {
                EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD1 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0001").ToArray();
                if (tmpPfD1 != null && tmpPfD1.Length != 0)
                {
                    this.pfD1 = tmpPfD1[0];
                    this.txtInputType1.Text = Math.Round(this.pfD1.TOTAL_MONEY, 2).ToString();
                    sum += pfD1.TOTAL_MONEY;
                }

                EntityObject_BGT_B_CPN_INC_PF_D[] tmpPfD2 = pfDs.Where<EntityObject_BGT_B_CPN_INC_PF_D>(p => p.ITEM_CODE == "BGT_PERSON_0002").ToArray();
                if (tmpPfD1 != null && tmpPfD1.Length != 0)
                {
                    this.pfD2 = tmpPfD2[0];
                    this.txtInputType2.Text = Math.Round(this.pfD2.TOTAL_MONEY, 2).ToString();
                    sum += pfD2.TOTAL_MONEY;
                }
            }
            this.txtInputTOTAL_MONEY.Text = Math.Round(sum, 2).ToString();
        }
    }
}
