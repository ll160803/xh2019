using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.DataAccess;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.BizLogic
{
	[CauseObject(typeof(CauseObject_V_COM_QUERY_CODE))]
    public partial class BizLogicObject_V_COM_QUERY_CODE : BizLogicBase<EntityObject_V_COM_QUERY_CODE>
	{		
		#region Proxy 
		private BizLogicObject_V_COM_QUERY_CODE() { }
        private static BizLogicObject_V_COM_QUERY_CODE singleton;
        public static BizLogicObject_V_COM_QUERY_CODE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_COM_QUERY_CODE();
                return singleton;
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_COM_QUERY_CODE[] List()
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_CODE.List();
		}		
		public DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_CODE.Query(cause);
		}	
		public DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_CODE.Query(cause, paging, order);
		}			
		#endregion 
	}
}
