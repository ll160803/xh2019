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
	[DataObject("BGT_B_DEPT_PAY_YEAY_D_FUND_H")]
	public partial class CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _COMPLETE_TIME = null;
		[DataMember]
		public DateSpan  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String _BUILDING_NAME = string.Empty;
		[DataMember]
		public System.String  BUILDING_NAME{get{ return  _BUILDING_NAME;}set{ _BUILDING_NAME = value;}}
		System.String _FUND_NAME = string.Empty;
		[DataMember]
		public System.String  FUND_NAME{get{ return  _FUND_NAME;}set{ _FUND_NAME = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _STEP_ID = string.Empty;
		[DataMember]
		public System.String  STEP_ID{get{ return  _STEP_ID;}set{ _STEP_ID = value;}}
		System.String _FREE_FIELD = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}
		System.String _FREE_FIELD3 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String _FREE_FIELD2 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String _DECLARE_CAUSE = string.Empty;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.String _ASSET_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String _FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String _ASSET_NAME = string.Empty;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String _BGT_D_ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  BGT_D_ACCOUNT_ITEM_ID{get{ return  _BGT_D_ACCOUNT_ITEM_ID;}set{ _BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.Decimal _CONTROL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_PAY_YEAY_D_FUND_H")]
	public partial class DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H:EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _STEP_ID_NAME = string.Empty;
		[DataMember]
		public System.String STEP_ID_NAME{get{ return  _STEP_ID_NAME;}set{ _STEP_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_PAY_YEAY_D_FUND_H")]
	public partial class EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _COMPLETE_TIME;
		[DataMember]
		public System.DateTime  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String  _BUILDING_NAME;
		[DataMember]
		public System.String  BUILDING_NAME{get{ return  _BUILDING_NAME;}set{ _BUILDING_NAME = value;}}
		System.String  _FUND_NAME;
		[DataMember]
		public System.String  FUND_NAME{get{ return  _FUND_NAME;}set{ _FUND_NAME = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _STEP_ID;
		[DataMember]
		public System.String  STEP_ID{get{ return  _STEP_ID;}set{ _STEP_ID = value;}}
		System.String  _FREE_FIELD;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}
		System.String  _FREE_FIELD3;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String  _FREE_FIELD2;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String  _DECLARE_CAUSE;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.String  _ASSET_ID;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String  _FINANCE_IDEA;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String  _ASSET_NAME;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String  _BGT_D_ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  BGT_D_ACCOUNT_ITEM_ID{get{ return  _BGT_D_ACCOUNT_ITEM_ID;}set{ _BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.Decimal  _CONTROL_MONEY;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}	
}
