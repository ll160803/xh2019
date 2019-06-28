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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_MENUS))]
	public partial class BizLogicObject_V_COM_QUERY_MENUS: BizLogicBase<EntityObject_V_COM_QUERY_MENUS>
	{		
		#region Proxy 
		private BizLogicObject_V_COM_QUERY_MENUS() { }
        private static BizLogicObject_V_COM_QUERY_MENUS singleton;
        public static BizLogicObject_V_COM_QUERY_MENUS Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_COM_QUERY_MENUS();
                return singleton;
            }
        }
        #endregion
		#region Method Blok		
		public DisplayObject_V_COM_QUERY_MENUS[] List()
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_MENUS.List();
		}		
		public DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_MENUS.Query(cause);
		}	
		public DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			return HelperObject_V_COM_QUERY_MENUS.Query(cause, paging, order);
		}			
		#endregion 
	}
}
