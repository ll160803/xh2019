using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.ServiceContract;
using Ipedf.Web.DataAccess;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Web.BizLogic
{
	[CauseObject(typeof(CauseObject_V_SCM_B_QUERYPRICE_GYS))]
	public partial class BizLogicObject_V_SCM_B_QUERYPRICE_GYS: BizLogicBase<EntityObject_V_SCM_B_QUERYPRICE_GYS>,ServiceContract_V_SCM_B_QUERYPRICE_GYS
	{		
		#region Proxy 
		public BizLogicObject_V_SCM_B_QUERYPRICE_GYS() { }
        private static ServiceContract_V_SCM_B_QUERYPRICE_GYS singleton;
        public static ServiceContract_V_SCM_B_QUERYPRICE_GYS Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_SCM_B_QUERYPRICE_GYS();
                    return singleton; 
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_SCM_B_QUERYPRICE_GYS[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUERYPRICE_GYS.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_SCM_B_QUERYPRICE_GYS[] Query(CauseObject_V_SCM_B_QUERYPRICE_GYS cause)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUERYPRICE_GYS.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}	
		public DisplayObject_V_SCM_B_QUERYPRICE_GYS[] Query(CauseObject_V_SCM_B_QUERYPRICE_GYS cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUERYPRICE_GYS.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUERYPRICE_GYS>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}				
		#endregion 
	}
}
