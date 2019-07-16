
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
	public partial class BizLogicObject_BGT_B_BUDGET_CONTROL_STAGE
	{
        public BizLogicMsg Action_NewYear(string old_year_id, string new_year_id)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string s_msg = "";
                int succ = HelperObject_BGT_B_BUDGET_CONTROL_STAGE.Action_NewYear(old_year_id, new_year_id, out s_msg);
                if (succ == 1)
                {
                    msg.Succeed = true;
                    msg.Message = "";
                }
                else
                {
                    msg.Succeed = false;
                    msg.Message = s_msg;
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL_STAGE> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL_STAGE>(ServiceUri))
                {
                    return smgr.Service.Action_NewYear(old_year_id, new_year_id);
                }
            }
        }
	}
}
