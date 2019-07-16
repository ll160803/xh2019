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
using System.Linq;
using Ipedf.Hrp.Web.common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_YEAR
    {
       
        /// <summary>
        /// 一上完成阶段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnFirstUp_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 二上开始阶段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnFirstDown_Click(object sender, EventArgs e)
        {
            //首先 向历史记录表里面插入数据 
            var msg = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND_H.Proxy.Action_History("BGT_00050001");
            if (msg.Succeed)
            {

                // lblState.Text = "操作成功";
            }
            else
            {
                // lblState.Text = "操作失败：" + msg.Message;
            }
        }
        /// <summary>
        /// 二上完成阶段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSecondUp_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 执行阶段 需要向执行表写入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSecondDown_Click(object sender, EventArgs e)
        {

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            // CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR(); p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            var bud_year =curObj.ID;
            var msg = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Save(new EntityObject_BGT_B_BUDGET_CONTROL_STAGE
            {
                STAGE = 1,
                BUDGET_YEAR = bud_year,
                IS_AVAILABE = 1
            });
            if (msg.Succeed)
            {
                BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.SetBudgetDeptEdit_All(1, 1);
                lblState.Text = "操作成功";
            }
            else
            {
                lblState.Text = msg.Message;
            }
            UpdateControl_Dept(1, 1);
            GenerateCheckBoxAndSetValue();
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.BUDGET_YEAR=(Convert.ToInt32(this.txtInputBUDGET_YEAR.Text)-1).ToString();
            var old_year_id=BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault().ID;
            BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Action_NewYear(old_year_id, bud_year);//新增年度  需要把之前年的经费  进行复制
        }
        protected void GenerateCheckBoxAndSetValue()
        {
            CheckBoxList_Dept.Items.Clear();
            //CauseObject_BGT_D_BUDGET_YEAR p1 = this.txtInputBUDGET_YEAR.Text CauseObject_BGT_D_BUDGET_YEAR();
            //p1.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            var bud_year = curObj.ID;//BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p1).FirstOrDefault().ID;
            var budget_depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(new CauseObject_BGT_D_BUDGET_DEPT { BUDGET_YEAR = bud_year });
            var Edit_depts = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT { });
            foreach (var item in budget_depts)
            {
                var isCheck = Edit_depts.Count(p => p.DEPT_ID == item.ID) > 0 ? true : false;
                CheckBoxList_Dept.Items.Add(new ListItem { Selected = isCheck, Text = item.NAME, Value = item.ID });
            }


        }
        /// <summary>
        /// 一上完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnFrUp_Click(object sender, EventArgs e)
        {
            UpdateControl_Dept(2, 0);
            GenerateCheckBoxAndSetValue();
        }
        /// <summary>
        /// 二上开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnScStart_Click(object sender, EventArgs e)
        {
            UpdateControl_Dept(3, 1);
            GenerateCheckBoxAndSetValue();
            BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND_H.Proxy.Action_History("BGT_00050001");//把以上的申报数据 写入历史表
        }
        protected void UpdateControl_Dept(decimal satage, int flag)
        {
            //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            //p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            var bud_year = curObj.ID;//BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault().ID;
            var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = bud_year }).FirstOrDefault();
            en.STAGE = satage;
            var msg = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Update(en);
            if (msg.Succeed)
            {
                BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.SetBudgetDeptEdit_All(satage, flag);
                ShowButtonState(Convert.ToInt32(satage));
                lblState.Text = "操作成功";
            }
            else
            {
                lblState.Text = msg.Message;
            }

        }
        protected void ShowButtonState(int Stage)
        {
            this.btnStart.Enabled = false;
            this.btnScDone.Enabled = false;
            this.btnFrUp.Enabled = false;
            this.btnScDone.Enabled = false;
            btnSave.Enabled = false;
            btnScStart.Enabled = false;
            btnExe.Enabled = false;
            btnDone.Enabled = false;
            switch (Stage)
            {
                case 0:
                    this.btnStart.Enabled = true;//开始申报
                    break;
                case 1:
                    this.btnFrUp.Enabled = true;//一上完成

                    break;
                case 2:
                    btnSave.Enabled = true;
                    this.btnScStart.Enabled = true;//二上开始
                    break;
                case 3:
                    this.btnScDone.Enabled = true;//二上完成

                    break;
                case 4:
                    btnSave.Enabled = true;
                    this.btnExe.Enabled = true;//二上执行
                    break;
                case 5:
                    btnDone.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        protected void BindBtn(string BudgetYear_ID)
        {
            //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            //p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            var bud_year = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Get(new EntityObject_BGT_D_BUDGET_YEAR { ID = BudgetYear_ID });
            if (bud_year.IS_AVAILABE == (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段)
            {
                ShowButtonState(-1);
                btnDone.Enabled = true;//归档可以使用 其余均不可用
            }
            else if (bud_year.IS_AVAILABE == (decimal)Ipedf.Hrp.BGT.Common.预算阶段.归档)
            {
                ShowButtonState(-1);
            }
            else
            {

                var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = BudgetYear_ID }).FirstOrDefault();
                if (en == null)
                {
                    ShowButtonState(0);
                }
                else
                {
                    ShowButtonState(Convert.ToInt32(en.STAGE));
                    GenerateCheckBoxAndSetValue();//绑定部门
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<string> list_depts = new List<string>();

            foreach (ListItem item in CheckBoxList_Dept.Items)
            {
                if (item.Selected)
                {
                    list_depts.Add(item.Value);
                }
            }
            //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            //p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            var bud_year = curObj.ID;// BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault().ID;
            var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = bud_year }).FirstOrDefault();
            var msg = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.SetBudgetDeptEdit(list_depts, en.STAGE);
            if (msg.Succeed)
            {
                lblState.Text = "操作成功";
            }
            else
            {
                lblState.Text = msg.Message;
            }
        }
        /// <summary>
        /// 二上完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnScDone_Click(object sender, EventArgs e)
        {
            UpdateControl_Dept(4, 0);//0是不可编辑
            GenerateCheckBoxAndSetValue();
        }

        protected void btnExe_Click(object sender, EventArgs e)
        {
            //测试接口
            UpdateControl_Dept(5, 0);//0不可编辑  1 可编辑
            GenerateCheckBoxAndSetValue();

            //CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            //p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            //var bud_year = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault();
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            curObj.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            curObj.SetUpdate("IS_AVAILABE");
            BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Update(curObj);

            BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND_H.Proxy.Action_FUND_EXE();//把以上的申报数据 写入执行表
            #region 执行 传给SAP数据
            try
            {
                RfcNOC rfc = new RfcNOC();
                var t_cause = new CauseObject_BGT_B_DEPT_PAY_YEAR_FUND { BUDGET_YEAR = curObj.ID };
                t_cause.SetCustomCondition(" and BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY1>0");
                var objList = BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND.Proxy.Query(t_cause);
                var Msg_SAP = rfc.SendSAPFund_RFC(objList.ToList(), this.txtInputBUDGET_YEAR.Text, "A01", "Z013", "ZFI02_FM_YS001");
                if (Msg_SAP[0].IsSuccess)
                {
                    var personList = BizLogicObject_V_BGT_B_CPN_INC_PERSONFUND.Proxy.Query(new CauseObject_V_BGT_B_CPN_INC_PERSONFUND { BUDGET_YEAR = curObj.ID });
                    rfc.SendSAPPersonFund_RFC(personList.ToList(), this.txtInputBUDGET_YEAR.Text, "A01", "Z013", "ZFI02_FM_YS001");
                }
            }
            catch (Exception ex)
            {
                lblState.Text = "上传SAP失败!,请停止操作，并联系开发人员";
            }
            #endregion
        }
        protected void btnDone_Click(object sender, EventArgs e)
        {
            // CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            //p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.执行阶段;
            EntityObject_BGT_D_BUDGET_YEAR curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_YEAR;
            curObj.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.归档;
            curObj.SetUpdate("IS_AVAILABE");
            BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Update(curObj);

        }
    }
}
