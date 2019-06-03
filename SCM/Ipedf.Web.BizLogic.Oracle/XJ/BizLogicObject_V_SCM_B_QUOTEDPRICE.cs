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
	[CauseObject(typeof(CauseObject_V_SCM_B_QUOTEDPRICE))]
	public partial class BizLogicObject_V_SCM_B_QUOTEDPRICE: BizLogicBase<EntityObject_V_SCM_B_QUOTEDPRICE>,ServiceContract_V_SCM_B_QUOTEDPRICE
	{		
		#region Proxy 
		public BizLogicObject_V_SCM_B_QUOTEDPRICE() { }
        private static ServiceContract_V_SCM_B_QUOTEDPRICE singleton;
        public static ServiceContract_V_SCM_B_QUOTEDPRICE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_SCM_B_QUOTEDPRICE();
                    return singleton; 
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_SCM_B_QUOTEDPRICE[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}	
		public DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}				
		#endregion 
	}
}
