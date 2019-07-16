
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
using System.Linq;
using System.Web;
using System.Collections;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT
    {
        /// <summary>
        /// 设置某个或几个部门的可编辑
        /// </summary>
        /// <param name="IDS"></param>
        /// <param name="Stage"></param>
        /// <returns></returns>
        public BizLogicMsg SetBudgetDeptEdit(List<string> IDS, decimal Stage)
        {

            var msg = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.Delete(new CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT { });
            if (msg.Succeed)
            {
                List<EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT> listc = new List<EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT>();
                foreach (var b_dpte_id in IDS)
                {
                    listc.Add(new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT { DEPT_ID = b_dpte_id, IS_EDIT = (decimal)Ipedf.Common.是否状态.是, STAGE = Stage });
                }
                return BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.BatchSave(listc.ToArray());
            }
            return msg;
        }
        /// <summary>
        /// 全部可编辑或者全部不可编辑
        /// </summary>
        /// <param name="Stage"></param>
        /// <param name="Flag">0是不可编辑 1可编辑</param>
        /// <returns></returns>
        public BizLogicMsg SetBudgetDeptEdit_All(decimal Stage, int Flag)
        {
            var msg = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.Delete(new CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT { });
            if (Flag == 0)
            {
                return msg;
            }
            else
            {
                var budget_depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(new CauseObject_BGT_D_BUDGET_DEPT { });
                List<EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT> listc = new List<EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT>();
                foreach (var b_dpte_id in budget_depts)
                {
                    listc.Add(new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT { DEPT_ID = b_dpte_id.ID, IS_EDIT = (decimal)Ipedf.Common.是否状态.是, STAGE = Stage });
                }
                return BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.BatchSave(listc.ToArray());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="butdge_dpt_id"></param>
        /// <param name="Stage">0是一上 1是二上</param>
        /// <returns></returns>
        public bool IsEditByButdgeDept(string dpt_id, int Stage)
        {
            //return false;
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            var bud_year = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault().ID;
            var butdge_dpt_en = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(new CauseObject_BGT_D_BUDGET_DEPT { DEPT_ID = dpt_id, BUDGET_YEAR = bud_year }).FirstOrDefault();
            if (butdge_dpt_en == null)
            {
                return false;
            }
            var butdge_dpt_id = butdge_dpt_en.ID;
            var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = bud_year }).FirstOrDefault();
            var cureent_stage = 0;
            if (en != null)
            {
                cureent_stage = Convert.ToInt32(en.STAGE);
            }
            if (cureent_stage <= 2)//一上阶段
            {
                if (Stage == 1)
                {
                    return false;
                }
                if (cureent_stage == 1)
                {
                    return true;
                }
            }
            else if (cureent_stage == 5)//执行阶段
            {
                return false;
            }
            else if (cureent_stage == 3)
            {
                if (Stage == 1)
                {
                    return false;
                }
            }
            else//二上阶段 
            {
                if (Stage == 1)//一上阶段的都不可编辑
                {
                    return false;
                }
            }

            var list = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT
              {
                  DEPT_ID = butdge_dpt_id,
                  STAGE = cureent_stage,
                  IS_EDIT = (decimal)Ipedf.Common.是否状态.是
              });
            if (list.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEditByButdgeDept(string dpt_id,string budget_year, int Stage)
        {
            string Year1 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
            if (budget_year != Year1)
            {
                return false;
            }
            //return false;
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Hrp.BGT.Common.预算阶段.编制阶段;
            var bud_year = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p).FirstOrDefault().ID;
            var butdge_dpt_en = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(new CauseObject_BGT_D_BUDGET_DEPT { DEPT_ID = dpt_id, BUDGET_YEAR = bud_year }).FirstOrDefault();
            if (butdge_dpt_en == null)
            {
                return false;
            }
            var butdge_dpt_id = butdge_dpt_en.ID;
            var en = BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_STAGE { BUDGET_YEAR = bud_year }).FirstOrDefault();
            var cureent_stage = 0;
            if (en != null)
            {
                cureent_stage = Convert.ToInt32(en.STAGE);
            }
            if (cureent_stage <= 2)//一上阶段
            {
                if (Stage == 1)
                {
                    return false;
                }
                if (cureent_stage == 1)
                {
                    return true;
                }
            }
            else if (cureent_stage == 5)//执行阶段
            {
                return false;
            }
            else if (cureent_stage == 3)
            {
                if (Stage == 1)
                {
                    return false;
                }
            }
            else//二上阶段 
            {
                if (Stage == 1)//一上阶段的都不可编辑
                {
                    return false;
                }
            }

            var list = BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.Query(new CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT
            {
                DEPT_ID = butdge_dpt_id,
                STAGE = cureent_stage,
                IS_EDIT = (decimal)Ipedf.Common.是否状态.是
            });
            if (list.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
