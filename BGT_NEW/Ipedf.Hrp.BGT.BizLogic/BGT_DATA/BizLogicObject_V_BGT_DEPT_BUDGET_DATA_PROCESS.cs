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
	[CauseObject(typeof(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS))]
	public partial class BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS: BizLogicBase<EntityObject_V_BGT_DEPT_BUDGET_DATA_PROCESS>,ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS
	{		
		#region Proxy 
		public BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS() { }
        private static ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS singleton;
        public static ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
                    return singleton; 
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}	
		public DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}				
		#endregion 
	}
}
