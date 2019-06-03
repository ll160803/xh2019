
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
	public partial class BizLogicObject_SCM_B_PRICEADJUST
	{
        public DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_SCM_B_PRICEADJUST.QueryPost(cause, paging, order);
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_PRICEADJUST> smgr = new ServiceManager<ServiceContract_SCM_B_PRICEADJUST>(ServiceUri))
                {
                    return smgr.Service.QueryPost(cause, paging, order);
                }
            }
        }

        public DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_SCM_B_PRICEADJUST.QueryPost(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_PRICEADJUST> smgr = new ServiceManager<ServiceContract_SCM_B_PRICEADJUST>(ServiceUri))
                {
                    return smgr.Service.QueryPost(cause);
                }
            }
        }
	}
}
