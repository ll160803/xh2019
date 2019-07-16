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
	[CauseObject(typeof(CauseObject_V_BGT_INC_BUDGET_DATA))]
	public partial class BizLogicObject_V_BGT_INC_BUDGET_DATA: BizLogicBase<EntityObject_V_BGT_INC_BUDGET_DATA>,ServiceContract_V_BGT_INC_BUDGET_DATA
	{		
		#region Proxy 
		public BizLogicObject_V_BGT_INC_BUDGET_DATA() { }
        private static ServiceContract_V_BGT_INC_BUDGET_DATA singleton;
        public static ServiceContract_V_BGT_INC_BUDGET_DATA Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_BGT_INC_BUDGET_DATA();
                    return singleton; 
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_BGT_INC_BUDGET_DATA[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_BUDGET_DATA.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA> smgr = new ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_BGT_INC_BUDGET_DATA[] Query(CauseObject_V_BGT_INC_BUDGET_DATA cause)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_BUDGET_DATA.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA> smgr = new ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}	
		public DisplayObject_V_BGT_INC_BUDGET_DATA[] Query(CauseObject_V_BGT_INC_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_BUDGET_DATA.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA> smgr = new ServiceManager<ServiceContract_V_BGT_INC_BUDGET_DATA>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}				
		#endregion 
	}
}
