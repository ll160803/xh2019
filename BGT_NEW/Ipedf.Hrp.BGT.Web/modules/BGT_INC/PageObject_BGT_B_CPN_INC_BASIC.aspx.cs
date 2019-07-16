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
    public partial class PageObject_BGT_B_CPN_INC_BASIC : ComNestingEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {

            SetForeignKeyBinding(ddlDataSourceBUDGRT_ITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME");
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_CPN_INC_BASIC_D cause = new CauseObject_BGT_B_CPN_INC_BASIC_D();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC).ID;
            dataSource = BizLogicObject_BGT_B_CPN_INC_BASIC_D.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_BASIC_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_BASIC_D>();
            list.AddRange((DisplayObject_BGT_B_CPN_INC_BASIC_D[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_CPN_INC_BASIC_D>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_CPN_INC_BASIC_D), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            //平台自动生成代码
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);

            this.txtInputMONEY.Text = "0.00";

            this.txtInputDECALRE_CAUSE.Text = string.Empty;
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_CPN_INC_BASIC_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_INC_BASIC_D>();
                EntityObject_BGT_B_CPN_INC_BASIC baseEntity = new EntityObject_BGT_B_CPN_INC_BASIC();

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;

                if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                    baseEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                else
                    baseEntity.MONEY = 0;

                baseEntity.NAME = txtInputNAME.Text;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputBUDGRT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputBUDGRT_ITEM_ID");
                       
                        ComTextBox txtInputMONEY_ = (ComTextBox)row.FindControl("txtInputMONEY");

                        ComTextBox txtInputDECALRE_CAUSE_ = (ComTextBox)row.FindControl("txtInputDECALRE_CAUSE");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_BASIC_D detailEntity = new EntityObject_BGT_B_CPN_INC_BASIC_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputBUDGRT_ITEM_ID.KeyValue))
                                detailEntity.BUDGRT_ITEM_ID = ddlInputBUDGRT_ITEM_ID.KeyValue;


                            if (!string.IsNullOrEmpty(txtInputMONEY_.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY_.Text);
                            else
                                detailEntity.MONEY = 0;

                            detailEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE_.Text;
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    this.txtInputMONEY.Text = baseEntity.MONEY.ToString();
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
                List<EntityObject_BGT_B_CPN_INC_BASIC_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_INC_BASIC_D>();
                List<EntityObject_BGT_B_CPN_INC_BASIC_D> updateDetailEntities = new List<EntityObject_BGT_B_CPN_INC_BASIC_D>();
                List<EntityObject_BGT_B_CPN_INC_BASIC_D> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_BASIC_D>();
                EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
               
                if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                    baseEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                else
                    baseEntity.MONEY = 0;
               
                baseEntity.NAME = txtInputNAME.Text;
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
               
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComBaseBox ddlInputBUDGRT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputBUDGRT_ITEM_ID");
                        ComTextBox txtInputMONEY_ = (ComTextBox)row.FindControl("txtInputMONEY");
                        ComTextBox txtInputDECALRE_CAUSE_ = (ComTextBox)row.FindControl("txtInputDECALRE_CAUSE");
                        //平台自动生成代码
                        EntityObject_BGT_B_CPN_INC_BASIC_D detailEntity = new EntityObject_BGT_B_CPN_INC_BASIC_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            if (!string.IsNullOrEmpty(ddlInputBUDGRT_ITEM_ID.KeyValue))
                                detailEntity.BUDGRT_ITEM_ID = ddlInputBUDGRT_ITEM_ID.KeyValue;
                          
                            if (!string.IsNullOrEmpty(txtInputMONEY_.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY_.Text);
                            else
                                detailEntity.MONEY = 0;
                           
                            detailEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE_.Text;
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
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ShowEditState(baseEntity);
                    this.txtInputMONEY.Text = baseEntity.MONEY.ToString();
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
                EntityObject_BGT_B_CPN_INC_BASIC_D entity = (EntityObject_BGT_B_CPN_INC_BASIC_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComBaseBox ddlInputBUDGRT_ITEM_ID = (ComBaseBox)e.Row.FindControl("ddlInputBUDGRT_ITEM_ID");
                ddlInputBUDGRT_ITEM_ID.Condition = " BGT_D_BUDGET_ITEM.item_type_id='001800050003' and BGT_D_BUDGET_ITEM.BUDGET_YEAR = (SELECT ID FROM BGT_D_BUDGET_YEAR WHERE IS_AVAILABE=1 AND ROWNUM = 1)";
                CopyComDropDownListItem(ddlDataSourceBUDGRT_ITEM_ID, ref ddlInputBUDGRT_ITEM_ID, entity.BUDGRT_ITEM_ID, "BGT_D_BUDGET_ITEM", "ID", "NAME");
              
                ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();
             
                ComTextBox txtInputDECALRE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECALRE_CAUSE");
                txtInputDECALRE_CAUSE.Text = entity.DECALRE_CAUSE == null ? String.Empty : entity.DECALRE_CAUSE.ToString();
                RegisterSelectedScript(txtInputMONEY, select);
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_CPN_INC_BASIC cause = new CauseObject_BGT_B_CPN_INC_BASIC();
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_CPN_INC_BASIC>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_INC_BASIC_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_CPN_INC_BASIC cause = (CauseObject_BGT_B_CPN_INC_BASIC)parameter;
            dataSource = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = new EntityObject_BGT_B_CPN_INC_BASIC();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Get(baseEntity);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.txtInputMONEY.Text = baseEntity.MONEY == null ? string.Empty : baseEntity.MONEY.ToString();
           
            this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty : baseEntity.NAME.ToString();
            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
           
            ShowEditState(baseEntity);
            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Submit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.UndoSubmit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.UndoAudit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Audit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Cancel(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }

        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_BASIC baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_BASIC;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.Archive(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_INC_BASIC> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_BASIC>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_INC_BASIC entity = new EntityObject_BGT_B_CPN_INC_BASIC();
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
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_BASIC.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

            CauseObject_BGT_D_BUDGET_ITEM cause368 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause368.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_B_CPN_INC_BASIC_D.BUDGRT_ITEM_ID from BGT_B_CPN_INC_BASIC_D where BGT_B_CPN_INC_BASIC_D.BASE_ID = '" + id + "' group by BGT_B_CPN_INC_BASIC_D.BUDGRT_ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceBUDGRT_ITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause368);
        }
    }
}

