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
    public partial class BizLogicObject_V_BGT_PAY_BUDGET_DATA
    {
        public DisplayObject_V_BGT_PAY_BUDGET_DATA_EXT[] QueryExt(CauseObject_V_BGT_PAY_BUDGET_DATA cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_V_BGT_PAY_BUDGET_DATA.QueryExt(cause, paging, order);
            }
            else
            {
                using (ServiceManager<ServiceContract_V_BGT_PAY_BUDGET_DATA> smgr = new ServiceManager<ServiceContract_V_BGT_PAY_BUDGET_DATA>(ServiceUri))
                {
                    return smgr.Service.QueryExt(cause, paging, order);
                }
            }
        }
    }
}
