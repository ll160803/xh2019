
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
    public partial class BizLogicObject_BGT_B_BUDGET_ADJUST 
    {
        public override void PostAudit(EntityObject_BGT_B_BUDGET_ADJUST entity, IDbTransaction transaction)
        {
            string outmsg = string.Empty;
            HelperObject_BGT_B_BUDGET_ADJUST.CreateAdjustData(entity.ID, out outmsg,transaction);
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_ADJUST obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    HelperObject_BGT_B_BUDGET_ADJUST.ApplyAdjustData(obj.ID, out outmsg);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
    }
}
