using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataContract]
	[DataObject("COM_FORM")]
	public partial class CauseObject_COM_FORM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _DISPLAY_INDEX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DISPLAY_INDEX{get{ return  _DISPLAY_INDEX;}set{ _DISPLAY_INDEX = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _DEFAULT_PAGE_URL = string.Empty;
		[DataMember]
		public System.String  DEFAULT_PAGE_URL{get{ return  _DEFAULT_PAGE_URL;}set{ _DEFAULT_PAGE_URL = value;}}
		System.String _CONTROL_CODE = string.Empty;
		[DataMember]
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String _FUNCTION_ID = string.Empty;
		[DataMember]
		public System.String  FUNCTION_ID{get{ return  _FUNCTION_ID;}set{ _FUNCTION_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _IMG_URL = string.Empty;
		[DataMember]
		public System.String  IMG_URL{get{ return  _IMG_URL;}set{ _IMG_URL = value;}}
		System.String _VERSION = string.Empty;
		[DataMember]
		public System.String  VERSION{get{ return  _VERSION;}set{ _VERSION = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _AS_MENU = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AS_MENU{get{ return  _AS_MENU;}set{ _AS_MENU = value;}}
		DateSpan _DELIVER_DATE = null;
		[DataMember]
		public DateSpan  DELIVER_DATE{get{ return  _DELIVER_DATE;}set{ _DELIVER_DATE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_FORM")]
	public partial class DisplayObject_COM_FORM:EntityObject_COM_FORM
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_FUNCTION_NAME = string.Empty;
		[DataMember]
		public System.String COM_FUNCTION_NAME{get{ return  _COM_FUNCTION_NAME;}set{ _COM_FUNCTION_NAME = value;}}
		 System.String _AS_MENU_NAME = string.Empty;
		[DataMember]
		public System.String AS_MENU_NAME{get{ return  _AS_MENU_NAME;}set{ _AS_MENU_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_FORM")]
	public partial class EntityObject_COM_FORM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _DISPLAY_INDEX;
		[DataMember]
		public System.Decimal  DISPLAY_INDEX{get{ return  _DISPLAY_INDEX;}set{ _DISPLAY_INDEX = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _DEFAULT_PAGE_URL;
		[DataMember]
		public System.String  DEFAULT_PAGE_URL{get{ return  _DEFAULT_PAGE_URL;}set{ _DEFAULT_PAGE_URL = value;}}
		System.String  _CONTROL_CODE;
		[DataMember]
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String  _FUNCTION_ID;
		[DataMember]
		public System.String  FUNCTION_ID{get{ return  _FUNCTION_ID;}set{ _FUNCTION_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _IMG_URL;
		[DataMember]
		public System.String  IMG_URL{get{ return  _IMG_URL;}set{ _IMG_URL = value;}}
		System.String  _VERSION;
		[DataMember]
		public System.String  VERSION{get{ return  _VERSION;}set{ _VERSION = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _AS_MENU;
		[DataMember]
		public System.Decimal  AS_MENU{get{ return  _AS_MENU;}set{ _AS_MENU = value;}}
		System.DateTime  _DELIVER_DATE;
		[DataMember]
		public System.DateTime  DELIVER_DATE{get{ return  _DELIVER_DATE;}set{ _DELIVER_DATE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
