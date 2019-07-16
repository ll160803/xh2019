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
namespace Ipedf.Web.BizLogic
{
	public partial class BizLogicObject_BGT_B_BUDGET_PROJ_EXE
	{
        public override void PostSave(EntityObject_BGT_B_BUDGET_PROJ_EXE entity, IDbTransaction transaction)
        {
            CauseObject_BGT_B_BUDGET_PROJ_EXE_D p = new CauseObject_BGT_B_BUDGET_PROJ_EXE_D();
            p.BASE_ID = entity.ID;
            DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] detailArray = HelperObject_BGT_B_BUDGET_PROJ_EXE_D.Query(p, transaction);
            entity.EXECUTE_MONEY = 0;
            entity.APPLY_MONEY = 0;
            foreach (DisplayObject_BGT_B_BUDGET_PROJ_EXE_D detail in detailArray)
            {
                entity.EXECUTE_MONEY += detail.EXECUTE_MONEY;//累加执行金额
                entity.APPLY_MONEY += detail.APPLY_MONEY;//累加申领金额
            }
            entity.ClearUpdate();
            entity.SetUpdate("EXECUTE_MONEY", "APPLY_MONEY");
            HelperObject_BGT_B_BUDGET_PROJ_EXE.Update(entity, transaction);
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    HelperObject_BGT_B_BUDGET_PROJ_EXE.ArchiveProjectExecuteData(obj.ID, out outmsg);
                }
                catch (Exception expt)
                {
                    msg = new BizLogicMsg(false, expt.Message);
                    Error(expt);
                }
                finally
                { }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_EXE>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
	}
}
