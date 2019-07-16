#define NESTING
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{

	public partial class BizLogicObject_BGT_B_DEPT_EXPENSE
	{
        public override void PostSave(EntityObject_BGT_B_DEPT_EXPENSE entity, IDbTransaction transaction)
        {
            CauseObject_BGT_B_DEPT_EXPENSE_D p = new CauseObject_BGT_B_DEPT_EXPENSE_D();
            p.BASE_ID = entity.ID;
            DisplayObject_BGT_B_DEPT_EXPENSE_D[] expenseDs = HelperObject_BGT_B_DEPT_EXPENSE_D.Query(p,transaction);
            foreach (DisplayObject_BGT_B_DEPT_EXPENSE_D expenseD in expenseDs)
            {
                entity.APPLY_MONEY += expenseD.APPLY_MONEY;
            }
            entity.SetUpdate("APPLY_MONEY");
            HelperObject_BGT_B_DEPT_EXPENSE.Update(entity, transaction);
        }
        public override void PostAudit(EntityObject_BGT_B_DEPT_EXPENSE entity, IDbTransaction transaction)
        {
            //向BGT_B_BUDGET_CONTROL_D_EXE表写入
            CauseObject_BGT_B_DEPT_EXPENSE_D pExpenseDs = new CauseObject_BGT_B_DEPT_EXPENSE_D();
            pExpenseDs.BASE_ID = entity.ID;
            DisplayObject_BGT_B_DEPT_EXPENSE_D[] expenseDs = HelperObject_BGT_B_DEPT_EXPENSE_D.Query(pExpenseDs, transaction);
            string budgeYear = entity.FINANCE_CYCLE.Substring(0, 4);//获取预算年
            foreach (DisplayObject_BGT_B_DEPT_EXPENSE_D expenseD in expenseDs)
            {
                CauseObject_BGT_B_BUDGET_CONTROL_D p = new CauseObject_BGT_B_BUDGET_CONTROL_D();
                p.ITEM_ID = expenseD.ITEM_ID;
                p.SetCustomCondition(string.Format(" and BGT_B_BUDGET_CONTROL_D.BASE_ID in (select id from BGT_B_BUDGET_CONTROL where budget_year in (select id from BGT_D_BUDGET_YEAR where BUDGET_YEAR='{0}'))", budgeYear));
                DisplayObject_BGT_B_BUDGET_CONTROL_D[] controlDs = HelperObject_BGT_B_BUDGET_CONTROL_D.Query(p, transaction);
                if (controlDs.Length == 0) continue;
                //先删除
                CauseObject_BGT_B_BUDGET_CONTROL_D_EXE pExe = new CauseObject_BGT_B_BUDGET_CONTROL_D_EXE();
                pExe.REF_TAB_ID = entity.ID;
                HelperObject_BGT_B_BUDGET_CONTROL_D_EXE.Delete(pExe, transaction);
                //再创建
                EntityObject_BGT_B_BUDGET_CONTROL_D_EXE newExeEntity = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE();
                newExeEntity.BASE_ID = controlDs[0].ID;
                newExeEntity.REF_TAB_ID = entity.ID;
                newExeEntity.REF_TAB_NAME = "BGT_B_DEPT_EXPENSE";
                newExeEntity.APPLY_MONEY = expenseD.APPLY_MONEY;
                newExeEntity.BUDGET_DEPT_ID = entity.APPLY_DEPT_ID;
                newExeEntity.CREATE_DATE = System.DateTime.Now;
                newExeEntity.FINANCE_CYCLE = entity.FINANCE_CYCLE;
                newExeEntity.IS_PASS = (decimal)Ipedf.Common.是否状态.是;//默认为检查通过
                newExeEntity.ITEM_ID = expenseD.ITEM_ID;//冗余设计
                HelperObject_BGT_B_BUDGET_CONTROL_D_EXE.Save(newExeEntity, transaction);
            }
            //调用校验存储过程(SP_bgt_check_execute_data)
            string msg = string.Empty;
            HelperObject_BGT_B_BUDGET_CONTROL.CheckExecuteData(entity.ID,out msg,transaction);
            //读取BGT_B_BUDGET_CONTROL_D_EXE表结果中所有未通过的项目
            CauseObject_BGT_B_BUDGET_CONTROL_D_EXE pExeResult = new CauseObject_BGT_B_BUDGET_CONTROL_D_EXE();
            pExeResult.REF_TAB_ID = entity.ID;
            pExeResult.IS_PASS = (decimal)Ipedf.Common.是否状态.否;
            DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] nopassAll = HelperObject_BGT_B_BUDGET_CONTROL_D_EXE.Query(pExeResult, transaction);
            //向客户端返回
            if (nopassAll.Length != 0)
            {
                List<string> itemArray = new List<string>();
                foreach (DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE nopass in nopassAll)
                {
                    itemArray.Add(nopass.ITEM_ID_NAME);
                }
                throw new Exception(string.Format("科目{0}的可用预算不足!", string.Join(",", itemArray.ToArray())));
            }
            else
            {
                //调用预算核销存储过程(SP_bgt_pub_pay_exe_data)
                HelperObject_BGT_B_BUDGET_CONTROL.PubExecuteData(entity.ID, out msg, transaction);
            }
        }
	}
}
