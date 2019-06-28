using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("SITE_USER_ACCOUNT_TRADE")]
	public partial class CauseObject_SITE_USER_ACCOUNT_TRADE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ACCOUNT_ID = string.Empty;
		public System.String  ACCOUNT_ID{get{ return  _ACCOUNT_ID;}set{ _ACCOUNT_ID = value;}}
		System.String _ORDER_ID = string.Empty;
		public System.String  ORDER_ID{get{ return  _ORDER_ID;}set{ _ORDER_ID = value;}}
		DateSpan _TRADE_DATE = null;
		public DateSpan  TRADE_DATE{get{ return  _TRADE_DATE;}set{ _TRADE_DATE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _TRADE_TYPE = string.Empty;
		public System.String  TRADE_TYPE{get{ return  _TRADE_TYPE;}set{ _TRADE_TYPE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_USER_ACCOUNT_TRADE")]
	public partial class DisplayObject_SITE_USER_ACCOUNT_TRADE:EntityObject_SITE_USER_ACCOUNT_TRADE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SITE_USER_ACCOUNT_NAME = string.Empty;
		public System.String SITE_USER_ACCOUNT_NAME{get{ return  _SITE_USER_ACCOUNT_NAME;}set{ _SITE_USER_ACCOUNT_NAME = value;}}
		 System.String _SITE_ORDER_CODE = string.Empty;
		public System.String SITE_ORDER_CODE{get{ return  _SITE_ORDER_CODE;}set{ _SITE_ORDER_CODE = value;}}
		 System.String _COM_TYPE_NAME = string.Empty;
		public System.String COM_TYPE_NAME{get{ return  _COM_TYPE_NAME;}set{ _COM_TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_USER_ACCOUNT_TRADE")]
	public partial class EntityObject_SITE_USER_ACCOUNT_TRADE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ACCOUNT_ID;
		public System.String  ACCOUNT_ID{get{ return  _ACCOUNT_ID;}set{ _ACCOUNT_ID = value;}}
		System.String  _ORDER_ID;
		public System.String  ORDER_ID{get{ return  _ORDER_ID;}set{ _ORDER_ID = value;}}
		System.DateTime  _TRADE_DATE;
		public System.DateTime  TRADE_DATE{get{ return  _TRADE_DATE;}set{ _TRADE_DATE = value;}}
		System.Decimal  _MONEY;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _TRADE_TYPE;
		public System.String  TRADE_TYPE{get{ return  _TRADE_TYPE;}set{ _TRADE_TYPE = value;}}

		#endregion 
	}	
}
