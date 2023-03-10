using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("V_COM_QUERY_MENUS")]
	public partial class CauseObject_V_COM_QUERY_MENUS:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _MODULE_NAME = string.Empty;
		public System.String  MODULE_NAME{get{ return  _MODULE_NAME;}set{ _MODULE_NAME = value;}}
		System.String _MODULE_CODE = string.Empty;
		public System.String  MODULE_CODE{get{ return  _MODULE_CODE;}set{ _MODULE_CODE = value;}}
		System.String _SYSTEM_PAGE_URL = string.Empty;
		public System.String  SYSTEM_PAGE_URL{get{ return  _SYSTEM_PAGE_URL;}set{ _SYSTEM_PAGE_URL = value;}}
		System.String _SYSTEM_NAME = string.Empty;
		public System.String  SYSTEM_NAME{get{ return  _SYSTEM_NAME;}set{ _SYSTEM_NAME = value;}}
		System.String _PAGE_ID = string.Empty;
		public System.String  PAGE_ID{get{ return  _PAGE_ID;}set{ _PAGE_ID = value;}}
		System.String _FUNCTION_CODE = string.Empty;
		public System.String  FUNCTION_CODE{get{ return  _FUNCTION_CODE;}set{ _FUNCTION_CODE = value;}}
		System.Decimal _PAGE_DISPLAY_INDEX = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  PAGE_DISPLAY_INDEX{get{ return  _PAGE_DISPLAY_INDEX;}set{ _PAGE_DISPLAY_INDEX = value;}}
		System.String _PAGE_NAME = string.Empty;
		public System.String  PAGE_NAME{get{ return  _PAGE_NAME;}set{ _PAGE_NAME = value;}}
		System.String _PAGE_CODE = string.Empty;
		public System.String  PAGE_CODE{get{ return  _PAGE_CODE;}set{ _PAGE_CODE = value;}}
		System.String _SYSTEM_CODE = string.Empty;
		public System.String  SYSTEM_CODE{get{ return  _SYSTEM_CODE;}set{ _SYSTEM_CODE = value;}}
		System.String _PAGE_URL = string.Empty;
		public System.String  PAGE_URL{get{ return  _PAGE_URL;}set{ _PAGE_URL = value;}}
		System.Decimal _FUNCTION_DISPLAY_INDEX = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  FUNCTION_DISPLAY_INDEX{get{ return  _FUNCTION_DISPLAY_INDEX;}set{ _FUNCTION_DISPLAY_INDEX = value;}}
		System.String _FUNCTION_PAGE_URL = string.Empty;
		public System.String  FUNCTION_PAGE_URL{get{ return  _FUNCTION_PAGE_URL;}set{ _FUNCTION_PAGE_URL = value;}}
		System.Decimal _MODULE_DISPALY_INDEX = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  MODULE_DISPALY_INDEX{get{ return  _MODULE_DISPALY_INDEX;}set{ _MODULE_DISPALY_INDEX = value;}}
		System.String _MODULE_PAGE_URL = string.Empty;
		public System.String  MODULE_PAGE_URL{get{ return  _MODULE_PAGE_URL;}set{ _MODULE_PAGE_URL = value;}}
		System.String _SYSTEM_ID = string.Empty;
		public System.String  SYSTEM_ID{get{ return  _SYSTEM_ID;}set{ _SYSTEM_ID = value;}}
		System.Decimal _SYSTEM_DISPLAY_INDEX = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  SYSTEM_DISPLAY_INDEX{get{ return  _SYSTEM_DISPLAY_INDEX;}set{ _SYSTEM_DISPLAY_INDEX = value;}}
		System.String _USER_ID = string.Empty;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _FUNCTION_NAME = string.Empty;
		public System.String  FUNCTION_NAME{get{ return  _FUNCTION_NAME;}set{ _FUNCTION_NAME = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_COM_QUERY_MENUS:EntityObject_V_COM_QUERY_MENUS
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_FORM_NAME = string.Empty;
		public System.String COM_FORM_NAME{get{ return  _COM_FORM_NAME;}set{ _COM_FORM_NAME = value;}}

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_COM_QUERY_MENUS:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _MODULE_NAME;
		public System.String  MODULE_NAME{get{ return  _MODULE_NAME;}set{ _MODULE_NAME = value;}}
		System.String  _MODULE_CODE;
		public System.String  MODULE_CODE{get{ return  _MODULE_CODE;}set{ _MODULE_CODE = value;}}
		System.String  _SYSTEM_PAGE_URL;
		public System.String  SYSTEM_PAGE_URL{get{ return  _SYSTEM_PAGE_URL;}set{ _SYSTEM_PAGE_URL = value;}}
		System.String  _SYSTEM_NAME;
		public System.String  SYSTEM_NAME{get{ return  _SYSTEM_NAME;}set{ _SYSTEM_NAME = value;}}
		System.String  _PAGE_ID;
		public System.String  PAGE_ID{get{ return  _PAGE_ID;}set{ _PAGE_ID = value;}}
		System.String  _FUNCTION_CODE;
		public System.String  FUNCTION_CODE{get{ return  _FUNCTION_CODE;}set{ _FUNCTION_CODE = value;}}
		System.Decimal  _PAGE_DISPLAY_INDEX;
		public System.Decimal  PAGE_DISPLAY_INDEX{get{ return  _PAGE_DISPLAY_INDEX;}set{ _PAGE_DISPLAY_INDEX = value;}}
		System.String  _PAGE_NAME;
		public System.String  PAGE_NAME{get{ return  _PAGE_NAME;}set{ _PAGE_NAME = value;}}
		System.String  _PAGE_CODE;
		public System.String  PAGE_CODE{get{ return  _PAGE_CODE;}set{ _PAGE_CODE = value;}}
		System.String  _SYSTEM_CODE;
		public System.String  SYSTEM_CODE{get{ return  _SYSTEM_CODE;}set{ _SYSTEM_CODE = value;}}
		System.String  _PAGE_URL;
		public System.String  PAGE_URL{get{ return  _PAGE_URL;}set{ _PAGE_URL = value;}}
		System.Decimal  _FUNCTION_DISPLAY_INDEX;
		public System.Decimal  FUNCTION_DISPLAY_INDEX{get{ return  _FUNCTION_DISPLAY_INDEX;}set{ _FUNCTION_DISPLAY_INDEX = value;}}
		System.String  _FUNCTION_PAGE_URL;
		public System.String  FUNCTION_PAGE_URL{get{ return  _FUNCTION_PAGE_URL;}set{ _FUNCTION_PAGE_URL = value;}}
		System.Decimal  _MODULE_DISPALY_INDEX;
		public System.Decimal  MODULE_DISPALY_INDEX{get{ return  _MODULE_DISPALY_INDEX;}set{ _MODULE_DISPALY_INDEX = value;}}
		System.String  _MODULE_PAGE_URL;
		public System.String  MODULE_PAGE_URL{get{ return  _MODULE_PAGE_URL;}set{ _MODULE_PAGE_URL = value;}}
		System.String  _SYSTEM_ID;
		public System.String  SYSTEM_ID{get{ return  _SYSTEM_ID;}set{ _SYSTEM_ID = value;}}
		System.Decimal  _SYSTEM_DISPLAY_INDEX;
		public System.Decimal  SYSTEM_DISPLAY_INDEX{get{ return  _SYSTEM_DISPLAY_INDEX;}set{ _SYSTEM_DISPLAY_INDEX = value;}}
		System.String  _USER_ID;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _FUNCTION_NAME;
		public System.String  FUNCTION_NAME{get{ return  _FUNCTION_NAME;}set{ _FUNCTION_NAME = value;}}

		#endregion 
	}	
}
