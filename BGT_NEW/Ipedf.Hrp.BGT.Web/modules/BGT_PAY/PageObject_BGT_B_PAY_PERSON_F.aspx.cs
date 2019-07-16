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
    public partial class PageObject_BGT_B_PAY_PERSON_F : ComNestingEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            this.command[Ipedf.Web.Control.ButtonType.Save].Enabled = this.command[Ipedf.Web.Control.ButtonType.Save].Visible = true;
            this.command[Ipedf.Web.Control.ButtonType.CloseAfterSave].Enabled = this.command[Ipedf.Web.Control.ButtonType.CloseAfterSave].Visible = true;
        }
        protected override void PrepareCause()
        {

        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_PAY_PERSON_D cause = new CauseObject_BGT_B_PAY_PERSON_D();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON).ID;
            dataSource = BizLogicObject_BGT_B_PAY_PERSON_D.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_PAY_PERSON_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_PAY_PERSON_D>();
            list.AddRange((DisplayObject_BGT_B_PAY_PERSON_D[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_PAY_PERSON_D>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_PAY_PERSON_D), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            //平台自动生成代码
            this.txtInputFINANCE_IDEA.Text = string.Empty;

            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.是否状态.是;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);
            //平台自动生成代码
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_PAY_PERSON_D> saveDetailEntities = new List<EntityObject_BGT_B_PAY_PERSON_D>();
                EntityObject_BGT_B_PAY_PERSON baseEntity = new EntityObject_BGT_B_PAY_PERSON();

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;


                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputFINANCE_IDEA_ = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");
                        ComTextBox txtInputCONTROL_COUNT = (ComTextBox)row.FindControl("txtInputCONTROL_COUNT");
                        ComTextBox txtInputOTHERS = (ComTextBox)row.FindControl("txtInputOTHERS");
                        ComTextBox txtInputNOWYEAR_COUNT = (ComTextBox)row.FindControl("txtInputNOWYEAR_COUNT");
                        ComBaseBox txtInputPERSON_TYPE_ID = (ComBaseBox)row.FindControl("txtInputPERSON_TYPE_ID");

                        ComTextBox txtInputLASTYEAR_COUNT = (ComTextBox)row.FindControl("txtInputLASTYEAR_COUNT");
                        //平台自动生成代码
                        EntityObject_BGT_B_PAY_PERSON_D detailEntity = new EntityObject_BGT_B_PAY_PERSON_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA_.Text;
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
                            if (!string.IsNullOrEmpty(txtInputCONTROL_COUNT.Text))
                                detailEntity.CONTROL_COUNT = decimal.Parse(txtInputCONTROL_COUNT.Text);
                            else
                                detailEntity.CONTROL_COUNT = 0;
                            detailEntity.OTHERS = txtInputOTHERS.Text;
                            if (!string.IsNullOrEmpty(txtInputNOWYEAR_COUNT.Text))
                                detailEntity.NOWYEAR_COUNT = decimal.Parse(txtInputNOWYEAR_COUNT.Text);
                            else
                                detailEntity.NOWYEAR_COUNT = 0;
                            if (!string.IsNullOrEmpty(txtInputPERSON_TYPE_ID.KeyValue))
                                detailEntity.PERSON_TYPE_ID = txtInputPERSON_TYPE_ID.KeyValue;
                            //detailEntity.BASE_ID = txtInputBASE_ID.Text;
                            if (!string.IsNullOrEmpty(txtInputLASTYEAR_COUNT.Text))
                                detailEntity.LASTYEAR_COUNT = decimal.Parse(txtInputLASTYEAR_COUNT.Text);
                            else
                                detailEntity.LASTYEAR_COUNT = 0;
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
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
                List<EntityObject_BGT_B_PAY_PERSON_D> saveDetailEntities = new List<EntityObject_BGT_B_PAY_PERSON_D>();
                List<EntityObject_BGT_B_PAY_PERSON_D> updateDetailEntities = new List<EntityObject_BGT_B_PAY_PERSON_D>();
                List<EntityObject_BGT_B_PAY_PERSON_D> deleteDetailEntities = new List<EntityObject_BGT_B_PAY_PERSON_D>();
                EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                baseEntity.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;

               
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        ComTextBox txtInputFINANCE_IDEA_ = (ComTextBox)row.FindControl("txtInputFINANCE_IDEA");
                        ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)row.FindControl("txtInputDECLARE_CAUSE");
                        ComTextBox txtInputCONTROL_COUNT = (ComTextBox)row.FindControl("txtInputCONTROL_COUNT");
                        ComTextBox txtInputOTHERS = (ComTextBox)row.FindControl("txtInputOTHERS");
                        ComTextBox txtInputNOWYEAR_COUNT = (ComTextBox)row.FindControl("txtInputNOWYEAR_COUNT");
                        ComBaseBox txtInputPERSON_TYPE_ID = (ComBaseBox)row.FindControl("txtInputPERSON_TYPE_ID");

                        ComTextBox txtInputLASTYEAR_COUNT = (ComTextBox)row.FindControl("txtInputLASTYEAR_COUNT");
                        //平台自动生成代码
                        EntityObject_BGT_B_PAY_PERSON_D detailEntity = new EntityObject_BGT_B_PAY_PERSON_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            detailEntity.FINANCE_IDEA = txtInputFINANCE_IDEA_.Text;
                            detailEntity.DECLARE_CAUSE = txtInputDECLARE_CAUSE.Text;
                            if (!string.IsNullOrEmpty(txtInputCONTROL_COUNT.Text))
                                detailEntity.CONTROL_COUNT = decimal.Parse(txtInputCONTROL_COUNT.Text);
                            else
                                detailEntity.CONTROL_COUNT = 0;
                            detailEntity.OTHERS = txtInputOTHERS.Text;
                            if (!string.IsNullOrEmpty(txtInputNOWYEAR_COUNT.Text))
                                detailEntity.NOWYEAR_COUNT = decimal.Parse(txtInputNOWYEAR_COUNT.Text);
                            else
                                detailEntity.NOWYEAR_COUNT = 0;
                            //detailEntity.PERSON_TYPE_ID = txtInputPERSON_TYPE_ID.Text;

                            if (!string.IsNullOrEmpty(txtInputPERSON_TYPE_ID.KeyValue))
                                detailEntity.PERSON_TYPE_ID = txtInputPERSON_TYPE_ID.KeyValue;


                            if (!string.IsNullOrEmpty(txtInputLASTYEAR_COUNT.Text))
                                detailEntity.LASTYEAR_COUNT = decimal.Parse(txtInputLASTYEAR_COUNT.Text);
                            else
                                detailEntity.LASTYEAR_COUNT = 0;
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
                    BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
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
            SetPageState(PageState.Edit);
        }
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_PAY_PERSON_D entity = (EntityObject_BGT_B_PAY_PERSON_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComTextBox txtInputFINANCE_IDEA = (ComTextBox)e.Row.FindControl("txtInputFINANCE_IDEA");
                txtInputFINANCE_IDEA.Text = entity.FINANCE_IDEA == null ? String.Empty : entity.FINANCE_IDEA.ToString();
                ComTextBox txtInputDECLARE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECLARE_CAUSE");
                txtInputDECLARE_CAUSE.Text = entity.DECLARE_CAUSE == null ? String.Empty : entity.DECLARE_CAUSE.ToString();
                ComTextBox txtInputCONTROL_COUNT = (ComTextBox)e.Row.FindControl("txtInputCONTROL_COUNT");
                txtInputCONTROL_COUNT.Text = entity.CONTROL_COUNT == null ? "0" : entity.CONTROL_COUNT.ToString();
                ComTextBox txtInputOTHERS = (ComTextBox)e.Row.FindControl("txtInputOTHERS");
                txtInputOTHERS.Text = entity.OTHERS == null ? String.Empty : entity.OTHERS.ToString();
                ComTextBox txtInputNOWYEAR_COUNT = (ComTextBox)e.Row.FindControl("txtInputNOWYEAR_COUNT");
                txtInputNOWYEAR_COUNT.Text = entity.NOWYEAR_COUNT == null ? "0" : entity.NOWYEAR_COUNT.ToString();
                ComBaseBox txtInputPERSON_TYPE_ID = (ComBaseBox)e.Row.FindControl("txtInputPERSON_TYPE_ID");
                //	txtInputPERSON_TYPE_ID.Text = entity.PERSON_TYPE_ID == null ? String.Empty: entity.PERSON_TYPE_ID.ToString();

                txtInputPERSON_TYPE_ID.Condition = "COM_TYPE.Parent_id='BGT_0002'";
                txtInputPERSON_TYPE_ID.NameField = "NAME";
                CopyComDropDownListItem(ddlDataSourcePERSON_TYPE_ID, ref txtInputPERSON_TYPE_ID, entity.PERSON_TYPE_ID, "COM_TYPE", "ID", "NAME");


                ComTextBox txtInputLASTYEAR_COUNT = (ComTextBox)e.Row.FindControl("txtInputLASTYEAR_COUNT");
                txtInputLASTYEAR_COUNT.Text = entity.LASTYEAR_COUNT == null ? "0" : entity.LASTYEAR_COUNT.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
                RegisterSelectedScript(txtInputNOWYEAR_COUNT, select);
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_PAY_PERSON cause = new CauseObject_BGT_B_PAY_PERSON();
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_PAY_PERSON>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_PAY_PERSON_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;

            //平台自动生成代码
            CauseObject_BGT_B_PAY_PERSON cause = (CauseObject_BGT_B_PAY_PERSON)parameter;
            dataSource = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override void PrepareBaseEdit(string id)
        {

            //平台自动生成代码
            EntityObject_BGT_B_PAY_PERSON baseEntity = new EntityObject_BGT_B_PAY_PERSON();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Get(baseEntity);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            this.txtInputFINANCE_IDEA.Text = baseEntity.FINANCE_IDEA == null ? string.Empty : baseEntity.FINANCE_IDEA.ToString();
            //this.txtInputCONTROL_COUNT.Text = baseEntity.CONTROL_COUNT == null ? string.Empty:baseEntity.CONTROL_COUNT.ToString();
            //SetEnumReferenceSelected(this.ddlInputSTATE, Type.GetType( "Ipedf.Common.数据状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), baseEntity.STATE);
            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");
            ShowEditState(baseEntity);
            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Submit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.UndoSubmit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.UndoAudit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Audit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Cancel(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }

        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_PAY_PERSON baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_PAY_PERSON;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.Archive(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_PAY_PERSON> deleteDetailEntities = new List<EntityObject_BGT_B_PAY_PERSON>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_PAY_PERSON entity = new EntityObject_BGT_B_PAY_PERSON();
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
                BizLogicMsg msg = BizLogicObject_BGT_B_PAY_PERSON.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

            CauseObject_COM_TYPE cause245 = new CauseObject_COM_TYPE();
            cause245.PARENT_ID = "BGT_0002";
            cause245.SetCustomCondition(" and COM_TYPE.ID in( select BGT_B_PAY_PERSON_D.PERSON_TYPE_ID from BGT_B_PAY_PERSON_D where BGT_B_PAY_PERSON_D.BASE_ID = '" + id + "' group by BGT_B_PAY_PERSON_D.PERSON_TYPE_ID )");
            SetForeignKeyBinding<CauseObject_COM_TYPE>(ddlDataSourcePERSON_TYPE_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause245);
        }
    }
}

