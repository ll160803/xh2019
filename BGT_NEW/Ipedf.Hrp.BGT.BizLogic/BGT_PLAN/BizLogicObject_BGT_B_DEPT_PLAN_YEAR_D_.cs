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
    public partial class BizLogicObject_BGT_B_DEPT_PLAN_YEAR_D
    {
        //public DisplayObject_BGT_B_DEPT_PLAN_YEAR_D_EXT[] QueryExt(CauseObject_BGT_B_DEPT_PLAN_YEAR_D cause, PagingParamter paging, OrderByParameter order)
        //{
        //    if (LocalMode)
        //    {
        //        SystemLogic.Proxy.AuditQuery(cause);

        //        //平台自动生成代码
        //        return HelperObject_BGT_B_DEPT_PLAN_YEAR_D.QueryExt(cause, paging, order);
        //    }
        //    else
        //    {
        //        using (ServiceManager<ServiceContract_BGT_B_DEPT_PLAN_YEAR_D> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PLAN_YEAR_D>(ServiceUri))
        //        {
        //            return smgr.Service.QueryExt(cause, paging, order);
        //        }
        //    }
        //}	
    }
}
