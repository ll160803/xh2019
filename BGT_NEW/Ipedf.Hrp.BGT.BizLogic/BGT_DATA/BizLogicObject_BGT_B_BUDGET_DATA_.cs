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

	public partial class BizLogicObject_BGT_B_BUDGET_DATA
	{
        public BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_DATA obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    switch (obj.BUDGET_CONTENTS_ID.Trim())
                    {
                        case "00120001":
                            {
                                HelperObject_BGT_B_BUDGET_DATA.PubPlanData(obj.ID, out outmsg);
                                break;
                            }
                        case "00120002":
                            {
                                HelperObject_BGT_B_BUDGET_DATA.PubIncomeData(obj.ID, out outmsg);
                                break;
                            }
                        case "00120003":
                            {
                                HelperObject_BGT_B_BUDGET_DATA.PubPayData(obj.ID, out outmsg);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                catch (Exception expt)
                {
                    msg = new BizLogicMsg(false, expt.Message);
                    Error(expt);
                }
                finally
                {}
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_DATA> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_DATA>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
	}
}
