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
	[DataObject("V_BGT_FIRST_UP")]
	public partial class CauseObject_V_BGT_FIRST_UP:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _F_FREE_FIELD2 = string.Empty;
		[DataMember]
		public System.String  F_FREE_FIELD2{get{ return  _F_FREE_FIELD2;}set{ _F_FREE_FIELD2 = value;}}
		System.Decimal _F_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  F_AMOUNT{get{ return  _F_AMOUNT;}set{ _F_AMOUNT = value;}}
		DateSpan _F_COMPLETE_TIME = null;
		[DataMember]
		public DateSpan  F_COMPLETE_TIME{get{ return  _F_COMPLETE_TIME;}set{ _F_COMPLETE_TIME = value;}}
		System.String _BUILDING_NAME = string.Empty;
		[DataMember]
		public System.String  BUILDING_NAME{get{ return  _BUILDING_NAME;}set{ _BUILDING_NAME = value;}}
		System.String _F_ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  F_ACCOUNT_ITEM_ID{get{ return  _F_ACCOUNT_ITEM_ID;}set{ _F_ACCOUNT_ITEM_ID = value;}}
		System.String _F_BGT_D_ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  F_BGT_D_ACCOUNT_ITEM_ID{get{ return  _F_BGT_D_ACCOUNT_ITEM_ID;}set{ _F_BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _F_FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  F_FINANCE_IDEA{get{ return  _F_FINANCE_IDEA;}set{ _F_FINANCE_IDEA = value;}}
		DateSpan _COMPLETE_TIME = null;
		[DataMember]
		public DateSpan  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String _BGT_D_ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  BGT_D_ACCOUNT_ITEM_ID{get{ return  _BGT_D_ACCOUNT_ITEM_ID;}set{ _BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.String _F_ASSET_NAME = string.Empty;
		[DataMember]
		public System.String  F_ASSET_NAME{get{ return  _F_ASSET_NAME;}set{ _F_ASSET_NAME = value;}}
		System.String _ASSET_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String _F_BUILDING_NAME = string.Empty;
		[DataMember]
		public System.String  F_BUILDING_NAME{get{ return  _F_BUILDING_NAME;}set{ _F_BUILDING_NAME = value;}}
		System.Decimal _F_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  F_MONEY{get{ return  _F_MONEY;}set{ _F_MONEY = value;}}
		System.String _F_FUND_NAME = string.Empty;
		[DataMember]
		public System.String  F_FUND_NAME{get{ return  _F_FUND_NAME;}set{ _F_FUND_NAME = value;}}
		System.String _ASSET_NAME = string.Empty;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _DECLARE_CAUSE = string.Empty;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.String _F_FREE_FIELD = string.Empty;
		[DataMember]
		public System.String  F_FREE_FIELD{get{ return  _F_FREE_FIELD;}set{ _F_FREE_FIELD = value;}}
		System.String _F_ASSET_ID = string.Empty;
		[DataMember]
		public System.String  F_ASSET_ID{get{ return  _F_ASSET_ID;}set{ _F_ASSET_ID = value;}}
		System.Decimal _F_CONTROL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  F_CONTROL_MONEY{get{ return  _F_CONTROL_MONEY;}set{ _F_CONTROL_MONEY = value;}}
		System.String _FREE_FIELD3 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String _FREE_FIELD2 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String _ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.Decimal _F_PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  F_PRICE{get{ return  _F_PRICE;}set{ _F_PRICE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _FUND_NAME = string.Empty;
		[DataMember]
		public System.String  FUND_NAME{get{ return  _FUND_NAME;}set{ _FUND_NAME = value;}}
		System.String _F_DECLARE_CAUSE = string.Empty;
		[DataMember]
		public System.String  F_DECLARE_CAUSE{get{ return  _F_DECLARE_CAUSE;}set{ _F_DECLARE_CAUSE = value;}}
		System.String _F_FREE_FIELD3 = string.Empty;
		[DataMember]
		public System.String  F_FREE_FIELD3{get{ return  _F_FREE_FIELD3;}set{ _F_FREE_FIELD3 = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _CONTROL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}
		System.String _FREE_FIELD = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_FIRST_UP")]
	public partial class DisplayObject_V_BGT_FIRST_UP:EntityObject_V_BGT_FIRST_UP
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_FIRST_UP")]
	public partial class EntityObject_V_BGT_FIRST_UP:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _F_FREE_FIELD2;
		[DataMember]
		public System.String  F_FREE_FIELD2{get{ return  _F_FREE_FIELD2;}set{ _F_FREE_FIELD2 = value;}}
		System.Decimal  _F_AMOUNT;
		[DataMember]
		public System.Decimal  F_AMOUNT{get{ return  _F_AMOUNT;}set{ _F_AMOUNT = value;}}
		System.DateTime  _F_COMPLETE_TIME;
		[DataMember]
		public System.DateTime  F_COMPLETE_TIME{get{ return  _F_COMPLETE_TIME;}set{ _F_COMPLETE_TIME = value;}}
		System.String  _BUILDING_NAME;
		[DataMember]
		public System.String  BUILDING_NAME{get{ return  _BUILDING_NAME;}set{ _BUILDING_NAME = value;}}
		System.String  _F_ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  F_ACCOUNT_ITEM_ID{get{ return  _F_ACCOUNT_ITEM_ID;}set{ _F_ACCOUNT_ITEM_ID = value;}}
		System.String  _F_BGT_D_ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  F_BGT_D_ACCOUNT_ITEM_ID{get{ return  _F_BGT_D_ACCOUNT_ITEM_ID;}set{ _F_BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _F_FINANCE_IDEA;
		[DataMember]
		public System.String  F_FINANCE_IDEA{get{ return  _F_FINANCE_IDEA;}set{ _F_FINANCE_IDEA = value;}}
		System.DateTime  _COMPLETE_TIME;
		[DataMember]
		public System.DateTime  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String  _BGT_D_ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  BGT_D_ACCOUNT_ITEM_ID{get{ return  _BGT_D_ACCOUNT_ITEM_ID;}set{ _BGT_D_ACCOUNT_ITEM_ID = value;}}
		System.String  _F_ASSET_NAME;
		[DataMember]
		public System.String  F_ASSET_NAME{get{ return  _F_ASSET_NAME;}set{ _F_ASSET_NAME = value;}}
		System.String  _ASSET_ID;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String  _F_BUILDING_NAME;
		[DataMember]
		public System.String  F_BUILDING_NAME{get{ return  _F_BUILDING_NAME;}set{ _F_BUILDING_NAME = value;}}
		System.Decimal  _F_MONEY;
		[DataMember]
		public System.Decimal  F_MONEY{get{ return  _F_MONEY;}set{ _F_MONEY = value;}}
		System.String  _F_FUND_NAME;
		[DataMember]
		public System.String  F_FUND_NAME{get{ return  _F_FUND_NAME;}set{ _F_FUND_NAME = value;}}
		System.String  _ASSET_NAME;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _DECLARE_CAUSE;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.String  _F_FREE_FIELD;
		[DataMember]
		public System.String  F_FREE_FIELD{get{ return  _F_FREE_FIELD;}set{ _F_FREE_FIELD = value;}}
		System.String  _F_ASSET_ID;
		[DataMember]
		public System.String  F_ASSET_ID{get{ return  _F_ASSET_ID;}set{ _F_ASSET_ID = value;}}
		System.Decimal  _F_CONTROL_MONEY;
		[DataMember]
		public System.Decimal  F_CONTROL_MONEY{get{ return  _F_CONTROL_MONEY;}set{ _F_CONTROL_MONEY = value;}}
		System.String  _FREE_FIELD3;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String  _FREE_FIELD2;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String  _ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.Decimal  _F_PRICE;
		[DataMember]
		public System.Decimal  F_PRICE{get{ return  _F_PRICE;}set{ _F_PRICE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _FUND_NAME;
		[DataMember]
		public System.String  FUND_NAME{get{ return  _FUND_NAME;}set{ _FUND_NAME = value;}}
		System.String  _F_DECLARE_CAUSE;
		[DataMember]
		public System.String  F_DECLARE_CAUSE{get{ return  _F_DECLARE_CAUSE;}set{ _F_DECLARE_CAUSE = value;}}
		System.String  _F_FREE_FIELD3;
		[DataMember]
		public System.String  F_FREE_FIELD3{get{ return  _F_FREE_FIELD3;}set{ _F_FREE_FIELD3 = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _FINANCE_IDEA;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _CONTROL_MONEY;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}
		System.String  _FREE_FIELD;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}

		#endregion 
	}	
}
