
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
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_D_BUDGET_YEAR
    {
        public BizLogicMsg CreateBudetAccount(string yearId)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string retMsg = string.Empty;
                int succeed = HelperObject_BGT_D_BUDGET_YEAR.CreateBudetAccount(yearId, out retMsg);
                msg.Message = retMsg;
                msg.Succeed = succeed == 1;
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR>(ServiceUri))
                {
                    return smgr.Service.CreateBudetAccount(yearId);
                }
            }
        }

        public override void PostSave(EntityObject_BGT_D_BUDGET_YEAR entity, IDbTransaction transaction)
        {
            //检查所有预算年,有且仅有1条数据的是否启用为是
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)是否状态.是;
            DisplayObject_BGT_D_BUDGET_YEAR[] bgtys = HelperObject_BGT_D_BUDGET_YEAR.Query(p, transaction);
            if (bgtys.Length > 1)
                throw new Exception("有且仅有一条记录的是否可用状态设置为是(默认为当前预算年)");
            //检查预算科目根节点是否存在
            CauseObject_BGT_D_BUDGET_ITEM pitem = new CauseObject_BGT_D_BUDGET_ITEM();
            pitem.BUDGET_YEAR = entity.ID;
            DisplayObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pitem, transaction);
            if (items.Length == 0)//创建根节点
            {
                //EntityObject_BGT_D_BUDGET_ITEM root = new EntityObject_BGT_D_BUDGET_ITEM();
                //root.NAME = "预算科目";
                //root.BUDGET_YEAR = entity.ID;
                //HelperObject_BGT_D_BUDGET_ITEM.Save(root, transaction);
            }

        }
        /// <summary>
        /// 获取编制年、执行年
        /// </summary>
        /// <param name="stage">2是执行年1是编制年3是归档（意义不大）</param>
        /// <returns></returns>
        public string GetCurrentBudgetYear(decimal stage)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
                p.IS_AVAILABE = stage;
                DisplayObject_BGT_D_BUDGET_YEAR[] bgtys = HelperObject_BGT_D_BUDGET_YEAR.Query(p);
                return bgtys.Length == 0 ? null : bgtys[0].ID;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR>(ServiceUri))
                {
                    return smgr.Service.GetCurrentBudgetYear(stage);
                }
            }
        }
        /// <summary>
        /// 获取执行年度名称
        /// </summary>
        /// <param name="stage"></param>
        /// <returns></returns>
        public string GetCurrentBudgetYearName(decimal stage)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
                p.IS_AVAILABE = stage;
                DisplayObject_BGT_D_BUDGET_YEAR[] bgtys = HelperObject_BGT_D_BUDGET_YEAR.Query(p);
                return bgtys.Length == 0 ? null : bgtys[0].BUDGET_YEAR;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_YEAR>(ServiceUri))
                {
                    return smgr.Service.GetCurrentBudgetYearName(stage);
                }
            }
        }
    }
}
