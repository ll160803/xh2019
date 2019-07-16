
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
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_D_BUDGET_PATTERN
    {
        public override void PostSave(EntityObject_BGT_D_BUDGET_PATTERN entity, IDbTransaction transaction)
        {
            //检查所有在用模式,有且仅有1条数据的是否启用为是
            decimal rpt = HelperObject_BGT_D_BUDGET_PATTERN.GetRepeartBudgetYear(transaction);
            if (rpt != 0)
                throw new Exception("每个预算年只能设置一条预算模式");
            base.PostSave(entity, transaction);
        }
    }
}
