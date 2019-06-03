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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_DATA_LINK))]
    public partial class BizLogicObject_V_COM_QUERY_DATA_LINK : BizLogicBase<EntityObject_V_COM_QUERY_DATA_LINK>
	{		
		#region Proxy 
		private BizLogicObject_V_COM_QUERY_DATA_LINK() { }
        private static BizLogicObject_V_COM_QUERY_DATA_LINK singleton;
        public static BizLogicObject_V_COM_QUERY_DATA_LINK Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_COM_QUERY_DATA_LINK();
                return singleton;
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_COM_QUERY_DATA_LINK[] List()
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_DATA_LINK.List();
		}		
		public DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_DATA_LINK.Query(cause);
		}	
		public DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_DATA_LINK.Query(cause, paging, order);
		}			
		#endregion 
	}
}
