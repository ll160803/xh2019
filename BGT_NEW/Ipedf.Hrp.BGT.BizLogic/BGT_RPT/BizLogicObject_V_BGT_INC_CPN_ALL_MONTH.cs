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
	[CauseObject(typeof(CauseObject_V_BGT_INC_CPN_ALL_MONTH))]
	public partial class BizLogicObject_V_BGT_INC_CPN_ALL_MONTH: BizLogicBase<EntityObject_V_BGT_INC_CPN_ALL_MONTH>,ServiceContract_V_BGT_INC_CPN_ALL_MONTH
	{		
		#region Proxy 
		public BizLogicObject_V_BGT_INC_CPN_ALL_MONTH() { }
        private static ServiceContract_V_BGT_INC_CPN_ALL_MONTH singleton;
        public static ServiceContract_V_BGT_INC_CPN_ALL_MONTH Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_BGT_INC_CPN_ALL_MONTH();
                    return singleton; 
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_BGT_INC_CPN_ALL_MONTH[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_CPN_ALL_MONTH.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH> smgr = new ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_BGT_INC_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_INC_CPN_ALL_MONTH cause)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_CPN_ALL_MONTH.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH> smgr = new ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}	
		public DisplayObject_V_BGT_INC_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_INC_CPN_ALL_MONTH cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_BGT_INC_CPN_ALL_MONTH.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH> smgr = new ServiceManager<ServiceContract_V_BGT_INC_CPN_ALL_MONTH>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}				
		#endregion 
	}
}
