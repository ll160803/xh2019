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
	public partial class BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST
	{
        public override void PostSave(EntityObject_BGT_B_BUDGET_PROJ_ADJUST entity, IDbTransaction transaction)
        {
            CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D p = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D();
            p.BASE_ID = entity.ID;
            DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D[] detailArray = HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Query(p, transaction);
            foreach (DisplayObject_BGT_B_BUDGET_PROJ_ADJUST_D detail in detailArray)
            {
                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.PrepareAdjustValue(detail, transaction);
            }
           
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    HelperObject_BGT_B_BUDGET_PROJ_ADJUST.ArchiveProjectAdjustData(obj.ID, out outmsg);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }    
	}
}
