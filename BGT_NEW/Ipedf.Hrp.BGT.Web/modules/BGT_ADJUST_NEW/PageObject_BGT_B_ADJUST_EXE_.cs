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
    public partial class PageObject_BGT_B_ADJUST_EXE
    {
        protected override void DeserializeSourceObject(string key, string parameter)
        {
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_B_ADJUST_EXE_D> dl = new List<EntityObject_BGT_B_ADJUST_EXE_D>();

            CauseObject_BGT_B_DEPT_FUND_EXE cause = new CauseObject_BGT_B_DEPT_FUND_EXE();
            foreach (string entity in el)
            {
                cause.SetINValue("ID", entity);
            }
            //平台自动生成代码
            var dataSource = BizLogicObject_BGT_B_DEPT_FUND_EXE.Proxy.Query(cause);


            foreach (string entity in el)
            {
                EntityObject_BGT_B_ADJUST_EXE_D detailEntity = new EntityObject_BGT_B_ADJUST_EXE_D();
                detailEntity.BASE_ID = key;
                detailEntity.REF_TAB_ID = entity;
                detailEntity.ID = Guid.NewGuid().ToString();
                detailEntity.EXE_MONEY = dataSource.Where(p => p.ID == entity).FirstOrDefault().CONTROL_MONEY1;//控制金额 才是真在执行的金额
                var cause1 = new CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT
                {
                    BUDGET_YEAR_ID = dataSource.Where(p => p.ID == entity).FirstOrDefault().BUDGET_YEAR,
                    FUND_CODE = dataSource.Where(p => p.ID == entity).FirstOrDefault().CODE

                };

                cause1.SetCustomCondition(" and V_BGT_ADJUST_FUND_MONEY_ECT.State =3 ORDER BY MODIFY_TIME DESC ");
                if (BizLogicObject_V_BGT_ADJUST_FUND_MONEY_ECT.Proxy.Query(cause1).Count() > 0)
                {
                    DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] bb = BizLogicObject_V_BGT_ADJUST_FUND_MONEY_ECT.Proxy.Query(cause1);
                    detailEntity.EXE_MONEY = bb[0].CHANGE_MONEY;
                }
                detailEntity.FUND_CODE = dataSource.Where(p => p.ID == entity).FirstOrDefault().CODE;
                dl.Add(detailEntity);
            }
            var updateEntity = new EntityObject_BGT_B_ADJUST_EXE { ID = key };
            BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.CommitSaveMainAndSub(updateEntity, dl.ToArray());
            this.txtInputEXE_TOTAL_MONEY.Text = updateEntity.EXE_TOTAL_MONEY.ToString();
            if (!msg.Succeed)
                throw new Exception(msg.Message);
        }
        protected override object PrepareDetailDataSource()
        {


            //平台自动生成代码
            CauseObject_V_BGT_ADJUST_FUND_MONEY cause = new CauseObject_V_BGT_ADJUST_FUND_MONEY();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE).ID;
            var dataSource = BizLogicObject_V_BGT_ADJUST_FUND_MONEY.Proxy.Query(cause).ToList();
            var listCode = dataSource.Select(p => p.FUND_CODE).ToList();
            RfcNOC frc = new RfcNOC();
            var listFund = frc.GetFundLeft("", listCode);
            foreach (var item in dataSource)
            {
                var it = listFund.Where(p => p.Code == item.FUND_CODE).FirstOrDefault();
                if (it != null)
                {
                    item.LeftMoney = it.FundMoney;
                }
            }

            System.Collections.Generic.List<DisplayObject_V_BGT_ADJUST_FUND_MONEY> list = new System.Collections.Generic.List<DisplayObject_V_BGT_ADJUST_FUND_MONEY>();
            list.AddRange(dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_V_BGT_ADJUST_FUND_MONEY>(5));
            dataSource = list;
            return dataSource;
        }
        protected override void OnBeforeSave()
        {
            
            int selectRows = 0;
            //foreach (GridViewRow row in gvDetailList.Rows)
            //{
            //    CheckBox select = (CheckBox)row.FindControl("cbSelect");
            //    if (select.Checked)
            //    {
            //        selectRows += 1;
            //    }
            //}
            //if (selectRows <= 0)
            //{
            //    throw new Exception("请勾选要保存的项目支出明细");
            //}
            foreach (GridViewRow row in gvDetailList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");

                    ComTextBox txtInputCHANGE_MONEY = (ComTextBox)row.FindControl("txtInputCHANGE_MONEY");
                    ComTextBox txtInputCHANGED_MONEY = (ComTextBox)row.FindControl("txtInputCHANGED_MONEY");
                    ComTextBox txtInputEXE_MONEY = (ComTextBox)row.FindControl("txtInputEXE_MONEY");
                    if (select.Checked)
                    {
                        double result;
                        bool isOK = double.TryParse(txtInputEXE_MONEY.Text, out result);
                        bool isOK1 = double.TryParse(txtInputCHANGED_MONEY.Text, out result);
                        if (isOK && isOK1)
                        {
                            if (double.Parse(txtInputEXE_MONEY.Text) + double.Parse(txtInputCHANGED_MONEY.Text) < 0)
                            {
                                throw new Exception("申请金额必须大于0");
                            }
                        }
                        else
                        {
                            throw new Exception("申请金额格式不正确");
                        }
                    }
                }
            }
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_ADJUST_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_ADJUST_EXE_D>();
                EntityObject_BGT_B_ADJUST_EXE baseEntity = new EntityObject_BGT_B_ADJUST_EXE();

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(txtInputEXE_TOTAL_MONEY.Text))
                    baseEntity.EXE_TOTAL_MONEY = decimal.Parse(txtInputEXE_TOTAL_MONEY.Text);
                else
                    baseEntity.EXE_TOTAL_MONEY = 0;
                if (!string.IsNullOrEmpty(txtInputTOTAL_MONEY.Text))
                    baseEntity.TOTAL_MONEY = decimal.Parse(txtInputTOTAL_MONEY.Text);
                else
                    baseEntity.TOTAL_MONEY = 0;
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;

                baseEntity.CHANGE_CAUSE = txtInputCHANGE_CAUSE.Text;
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        //ComTextBox txtInputFUND_CODE = (ComTextBox)row.FindControl("txtInputFUND_CODE");
                        ComTextBox txtInputCHANGE_CAUSE_ = (ComTextBox)row.FindControl("txtInputCHANGE_CAUSE");
                        ComTextBox txtInputEXE_MONEY = (ComTextBox)row.FindControl("txtInputEXE_MONEY");
                        ComTextBox txtInputCHANGE_MONEY = (ComTextBox)row.FindControl("txtInputCHANGE_MONEY");
                        ComTextBox txtInputCHANGED_MONEY = (ComTextBox)row.FindControl("txtInputCHANGED_MONEY");
                        ComTextBox txtInputBASE_ID = (ComTextBox)row.FindControl("txtInputBASE_ID");
                        //平台自动生成代码
                        EntityObject_BGT_B_ADJUST_EXE_D detailEntity = new EntityObject_BGT_B_ADJUST_EXE_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            //detailEntity.FUND_CODE = txtInputFUND_CODE.Text;
                            detailEntity.CHANGE_CAUSE = txtInputCHANGE_CAUSE_.Text;
                            if (!string.IsNullOrEmpty(txtInputEXE_MONEY.Text))
                                detailEntity.EXE_MONEY = decimal.Parse(txtInputEXE_MONEY.Text);
                            else
                                detailEntity.EXE_MONEY = 0;
                            if (!string.IsNullOrEmpty(txtInputCHANGE_MONEY.Text))
                                detailEntity.CHANGE_MONEY = decimal.Parse(txtInputEXE_MONEY.Text) + decimal.Parse(txtInputCHANGED_MONEY.Text);
                            else
                                detailEntity.CHANGE_MONEY = 0;
                            //	detailEntity.BASE_ID = txtInputBASE_ID.Text;
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    #region 判断当前修改的金额不能小于已经使用的经费金额
                    RfcNOC rfc=new RfcNOC();

                    var ListCodeAndMoney=rfc.GetFundLeft(this.ddlInputBUDGET_YEAR.SelectedItem.Text, saveDetailEntities.Select(p => p.FUND_CODE).ToList());
                    foreach (var item in ListCodeAndMoney)
                    {
                        var MoneyEntity = saveDetailEntities.Where(p => p.FUND_CODE == item.Code).FirstOrDefault();
                        if (MoneyEntity.CHANGE_MONEY < item.FundMoney)
                        {
                            throw new Exception("经费编码为：" + MoneyEntity.FUND_CODE + "的经费，变更后的金额不能小于已经支出的金额");
                        }
                    }
                    #endregion

                    BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    this.txtInputEXE_TOTAL_MONEY.Text = baseEntity.EXE_TOTAL_MONEY.ToString();
                    this.txtInputTOTAL_MONEY.Text = baseEntity.TOTAL_MONEY.ToString();
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
                List<EntityObject_BGT_B_ADJUST_EXE_D> saveDetailEntities = new List<EntityObject_BGT_B_ADJUST_EXE_D>();
                List<EntityObject_BGT_B_ADJUST_EXE_D> updateDetailEntities = new List<EntityObject_BGT_B_ADJUST_EXE_D>();
                List<EntityObject_BGT_B_ADJUST_EXE_D> deleteDetailEntities = new List<EntityObject_BGT_B_ADJUST_EXE_D>();
                EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;

                //平台自动生成代码
                if (!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
                    baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
                if (!string.IsNullOrEmpty(txtInputEXE_TOTAL_MONEY.Text))
                    baseEntity.EXE_TOTAL_MONEY = decimal.Parse(txtInputEXE_TOTAL_MONEY.Text);
                else
                    baseEntity.EXE_TOTAL_MONEY = 0;
                if (!string.IsNullOrEmpty(txtInputTOTAL_MONEY.Text))
                    baseEntity.TOTAL_MONEY = decimal.Parse(txtInputTOTAL_MONEY.Text);
                else
                    baseEntity.TOTAL_MONEY = 0;
                if (!string.IsNullOrEmpty(ddlInputDEPT_USER_ID.Text))
                    baseEntity.DEPT_USER_ID = ddlInputDEPT_USER_ID.Text;

                baseEntity.CHANGE_CAUSE = txtInputCHANGE_CAUSE.Text;
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                        //	ComTextBox txtInputFUND_CODE = (ComTextBox)row.FindControl("txtInputFUND_CODE");
                        ComTextBox txtInputCHANGE_CAUSE_ = (ComTextBox)row.FindControl("txtInputCHANGE_CAUSE");
                        ComTextBox txtInputEXE_MONEY = (ComTextBox)row.FindControl("txtInputEXE_MONEY");
                        ComTextBox txtInputCHANGE_MONEY = (ComTextBox)row.FindControl("txtInputCHANGE_MONEY");
                        ComTextBox txtInputCHANGED_MONEY = (ComTextBox)row.FindControl("txtInputCHANGED_MONEY");
                        //	ComTextBox txtInputBASE_ID = (ComTextBox)row.FindControl("txtInputBASE_ID");
                        //平台自动生成代码
                        EntityObject_BGT_B_ADJUST_EXE_D detailEntity = new EntityObject_BGT_B_ADJUST_EXE_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //平台自动生成代码
                            //detailEntity.FUND_CODE = txtInputFUND_CODE.Text;
                            detailEntity.CHANGE_CAUSE = txtInputCHANGE_CAUSE_.Text;
                            if (!string.IsNullOrEmpty(txtInputEXE_MONEY.Text))
                                detailEntity.EXE_MONEY = decimal.Parse(txtInputEXE_MONEY.Text);
                            else
                                detailEntity.EXE_MONEY = 0;
                            if (!string.IsNullOrEmpty(txtInputCHANGED_MONEY.Text))
                                detailEntity.CHANGE_MONEY = decimal.Parse(txtInputEXE_MONEY.Text) + decimal.Parse(txtInputCHANGED_MONEY.Text);
                            else
                                detailEntity.CHANGE_MONEY = 0;
                            //detailEntity.BASE_ID = txtInputBASE_ID.Text;
                            if (detailEntity.ID == string.Empty)
                            {
                                //AuditAdd(detailEntity);
                                saveDetailEntities.Add(detailEntity);
                            }
                            else
                            {
                                detailEntity.SetUpdate("CHANGE_MONEY", "CHANGE_CAUSE");
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
                    #region 判断当前修改的金额不能小于已经使用的经费金额
                    RfcNOC rfc = new RfcNOC();

                    var ListCodeAndMoney = rfc.GetFundLeft(this.ddlInputBUDGET_YEAR.SelectedItem.Text, saveDetailEntities.Select(p => p.FUND_CODE).ToList());
                    foreach (var item in ListCodeAndMoney)
                    {
                        var MoneyEntity = saveDetailEntities.Where(p => p.FUND_CODE == item.Code).FirstOrDefault();
                        if (MoneyEntity.CHANGE_MONEY < item.FundMoney)
                        {
                            throw new Exception("经费编码为：" + MoneyEntity.FUND_CODE + "的经费，变更后的金额不能小于已经支出的金额");
                        }
                    }
                    #endregion
                    BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ShowEditState(baseEntity);
                    this.txtInputEXE_TOTAL_MONEY.Text = baseEntity.EXE_TOTAL_MONEY.ToString();
                    this.txtInputTOTAL_MONEY.Text = baseEntity.TOTAL_MONEY.ToString();
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
                EntityObject_V_BGT_ADJUST_FUND_MONEY entity = (EntityObject_V_BGT_ADJUST_FUND_MONEY)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;


                ComTextBox txtInputCHANGE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputCHANGE_CAUSE");
                txtInputCHANGE_CAUSE.Text = entity.CHANGE_CAUSE == null ? String.Empty : entity.CHANGE_CAUSE.ToString();

                ComTextBox txtInputCHANGE_MONEY = (ComTextBox)e.Row.FindControl("txtInputCHANGE_MONEY");
                txtInputCHANGE_MONEY.Text = entity.CHANGE_MONEY == 0 ? entity.EXE_MONEY.ToString() : entity.CHANGE_MONEY.ToString();

                ComTextBox txtInputCHANGED_MONEY = (ComTextBox)e.Row.FindControl("txtInputCHANGED_MONEY");
                txtInputCHANGED_MONEY.Text = entity.CHANGE_MONEY == 0 ? "0" : (entity.CHANGE_MONEY-entity.EXE_MONEY).ToString();

                ComTextBox txtInputEXE_MONEY = (ComTextBox)e.Row.FindControl("txtInputEXE_MONEY");
                txtInputEXE_MONEY.Text = entity.EXE_MONEY == null ? "0" : entity.EXE_MONEY.ToString();

                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_ADJUST_EXE baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_ADJUST_EXE;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Audit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
                else
                {
                    try
                    {
                        RfcNOC rfc = new RfcNOC();
                        var t_cause = new CauseObject_V_BGT_ADJUST_TO_SAP { ADJUST_ID = baseEntity.ID };
                        var objList = BizLogicObject_V_BGT_ADJUST_TO_SAP.Proxy.Query(t_cause);
                        var Msg_SAP = rfc.SendSAPUpdateFund_RFC(objList.ToList(), "T02", "Z013", "ZFI02_FM_YS001");
                        if(!Msg_SAP[0].IsSuccess)
                        {
                            throw new Exception(Msg_SAP[0].Mess);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
