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
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{
	public partial class BizLogicObject_BGT_B_BUDGET_PROJ
	{
        public override void PostSave(EntityObject_BGT_B_BUDGET_PROJ entity, IDbTransaction transaction)
        {
            CauseObject_BGT_B_BUDGET_PROJ_D p = new CauseObject_BGT_B_BUDGET_PROJ_D();
            p.BASE_ID = entity.ID;
            DisplayObject_BGT_B_BUDGET_PROJ_D[] detailArray = HelperObject_BGT_B_BUDGET_PROJ_D.Query(p, transaction);
            entity.REPLY_MONEY = 0;
            entity.APPLY_MONEY = 0;
            foreach (DisplayObject_BGT_B_BUDGET_PROJ_D detail in detailArray)
            {
                entity.REPLY_MONEY += detail.REPLY_MONEY;//累加批复金额
                entity.APPLY_MONEY += detail.APPLY_MONEY;//累加申请金额
                HelperObject_BGT_B_BUDGET_PROJ_D.PrepareAvilableMoney(detail, transaction);
            }
            entity.AVAILABLE_MONEY = entity.REPLY_MONEY + entity.ADJUST_MONEY;
            entity.ClearUpdate();
            entity.SetUpdate("REPLY_MONEY", "APPLY_MONEY", "AVAILABLE_MONEY");
            HelperObject_BGT_B_BUDGET_PROJ.Update(entity, transaction);
            
        }
        public override void PostAudit(EntityObject_BGT_B_BUDGET_PROJ entity, IDbTransaction transaction)
        {
            string outmsg = string.Empty;
            HelperObject_BGT_B_BUDGET_PROJ_CO.CreateProjExecuteData(entity.ID, out outmsg, transaction);
        }
	}
}
