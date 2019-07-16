
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
	public partial class BizLogicObject_BGT_B_DEPT_PAY_YEAR_FUND_H
	{
        public BizLogicMsg Action_History(string step_id)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string s_msg="";
                int succ=HelperObject_BGT_B_DEPT_PAY_YEAR_FUND_H.Action_History(step_id, out s_msg);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Action_History(step_id);
                }
            }
        }

        public BizLogicMsg Action_FUND_EXE()
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string s_msg = "";
                int succ = HelperObject_BGT_B_DEPT_PAY_YEAR_FUND_H.Action_FUND_EXE(out s_msg);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Action_FUND_EXE();
                }
            }
        }
	}
}
