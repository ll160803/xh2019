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
	[DataObject("SITE_ORDER")]
	public partial class CauseObject_SITE_ORDER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _USER_ID = string.Empty;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _CREATE_DATE = null;
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _ORDER_STATE = string.Empty;
		public System.String  ORDER_STATE{get{ return  _ORDER_STATE;}set{ _ORDER_STATE = value;}}
		System.String _PAYMENT_STATE = string.Empty;
		public System.String  PAYMENT_STATE{get{ return  _PAYMENT_STATE;}set{ _PAYMENT_STATE = value;}}
		System.String _PAYMENT_TYPE = string.Empty;
		public System.String  PAYMENT_TYPE{get{ return  _PAYMENT_TYPE;}set{ _PAYMENT_TYPE = value;}}
		System.Decimal _DUE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  DUE{get{ return  _DUE;}set{ _DUE = value;}}
		DateSpan _COMPLETE_DATE = null;
		public DateSpan  COMPLETE_DATE{get{ return  _COMPLETE_DATE;}set{ _COMPLETE_DATE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		DateSpan _SUBMIT_DATE = null;
		public DateSpan  SUBMIT_DATE{get{ return  _SUBMIT_DATE;}set{ _SUBMIT_DATE = value;}}
		System.String _PAYMENT_CODE = string.Empty;
		public System.String  PAYMENT_CODE{get{ return  _PAYMENT_CODE;}set{ _PAYMENT_CODE = value;}}
		System.String _CODE = string.Empty;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _PURCHASE_TYPE = string.Empty;
		public System.String  PURCHASE_TYPE{get{ return  _PURCHASE_TYPE;}set{ _PURCHASE_TYPE = value;}}
		System.Decimal _ACTUAL_PAYMENT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  ACTUAL_PAYMENT{get{ return  _ACTUAL_PAYMENT;}set{ _ACTUAL_PAYMENT = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_ORDER")]
	public partial class DisplayObject_SITE_ORDER:EntityObject_SITE_ORDER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SITE_USER_NAME = string.Empty;
		public System.String SITE_USER_NAME{get{ return  _SITE_USER_NAME;}set{ _SITE_USER_NAME = value;}}
		 System.String _COM_TYPE_NAME = string.Empty;
		public System.String COM_TYPE_NAME{get{ return  _COM_TYPE_NAME;}set{ _COM_TYPE_NAME = value;}}
		 System.String _COM_TYPE_NAME_1 = string.Empty;
		public System.String COM_TYPE_NAME_1{get{ return  _COM_TYPE_NAME_1;}set{ _COM_TYPE_NAME_1 = value;}}
		 System.String _COM_TYPE_NAME_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1{get{ return  _COM_TYPE_NAME_1_1;}set{ _COM_TYPE_NAME_1_1 = value;}}
		 System.String _COM_TYPE_NAME_1_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1_1{get{ return  _COM_TYPE_NAME_1_1_1;}set{ _COM_TYPE_NAME_1_1_1 = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_ORDER")]
	public partial class EntityObject_SITE_ORDER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _USER_ID;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _CREATE_DATE;
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _ORDER_STATE;
		public System.String  ORDER_STATE{get{ return  _ORDER_STATE;}set{ _ORDER_STATE = value;}}
		System.String  _PAYMENT_STATE;
		public System.String  PAYMENT_STATE{get{ return  _PAYMENT_STATE;}set{ _PAYMENT_STATE = value;}}
		System.String  _PAYMENT_TYPE;
		public System.String  PAYMENT_TYPE{get{ return  _PAYMENT_TYPE;}set{ _PAYMENT_TYPE = value;}}
		System.Decimal  _DUE;
		public System.Decimal  DUE{get{ return  _DUE;}set{ _DUE = value;}}
		System.DateTime  _COMPLETE_DATE;
		public System.DateTime  COMPLETE_DATE{get{ return  _COMPLETE_DATE;}set{ _COMPLETE_DATE = value;}}
		System.Decimal  _MONEY;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.DateTime  _SUBMIT_DATE;
		public System.DateTime  SUBMIT_DATE{get{ return  _SUBMIT_DATE;}set{ _SUBMIT_DATE = value;}}
		System.String  _PAYMENT_CODE;
		public System.String  PAYMENT_CODE{get{ return  _PAYMENT_CODE;}set{ _PAYMENT_CODE = value;}}
		System.String  _CODE;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _PURCHASE_TYPE;
		public System.String  PURCHASE_TYPE{get{ return  _PURCHASE_TYPE;}set{ _PURCHASE_TYPE = value;}}
		System.Decimal  _ACTUAL_PAYMENT;
		public System.Decimal  ACTUAL_PAYMENT{get{ return  _ACTUAL_PAYMENT;}set{ _ACTUAL_PAYMENT = value;}}

		#endregion 
	}	
}
