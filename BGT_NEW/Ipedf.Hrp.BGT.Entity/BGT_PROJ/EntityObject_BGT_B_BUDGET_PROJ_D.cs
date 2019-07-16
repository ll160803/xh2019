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
	[DataObject("BGT_B_BUDGET_PROJ_D")]
	public partial class CauseObject_BGT_B_BUDGET_PROJ_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _EXECUTED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _SOURCE_ID = string.Empty;
		[DataMember]
		public System.String  SOURCE_ID{get{ return  _SOURCE_ID;}set{ _SOURCE_ID = value;}}
		System.Decimal _AVAILABLE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		System.Decimal _REPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REPLY_MONEY{get{ return  _REPLY_MONEY;}set{ _REPLY_MONEY = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _ADJUST_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.Decimal _IS_GOV_PROC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_GOV_PROC{get{ return  _IS_GOV_PROC;}set{ _IS_GOV_PROC = value;}}
		System.String _ADJUST_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ADJUST_TYPE_ID{get{ return  _ADJUST_TYPE_ID;}set{ _ADJUST_TYPE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _APPLIED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLIED_MONEY{get{ return  _APPLIED_MONEY;}set{ _APPLIED_MONEY = value;}}
		System.Decimal _BUDEGT_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  BUDEGT_MONEY{get{ return  _BUDEGT_MONEY;}set{ _BUDEGT_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_D")]
	public partial class DisplayObject_BGT_B_BUDGET_PROJ_D:EntityObject_BGT_B_BUDGET_PROJ_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _SOURCE_ID_NAME = string.Empty;
		[DataMember]
		public System.String SOURCE_ID_NAME{get{ return  _SOURCE_ID_NAME;}set{ _SOURCE_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _IS_GOV_PROC_NAME = string.Empty;
		[DataMember]
		public System.String IS_GOV_PROC_NAME{get{ return  _IS_GOV_PROC_NAME;}set{ _IS_GOV_PROC_NAME = value;}}
		 System.String _ADJUST_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ADJUST_TYPE_ID_NAME{get{ return  _ADJUST_TYPE_ID_NAME;}set{ _ADJUST_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_D")]
	public partial class EntityObject_BGT_B_BUDGET_PROJ_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _EXECUTED_MONEY;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _SOURCE_ID;
		[DataMember]
		public System.String  SOURCE_ID{get{ return  _SOURCE_ID;}set{ _SOURCE_ID = value;}}
		System.Decimal  _AVAILABLE_MONEY;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		System.Decimal  _REPLY_MONEY;
		[DataMember]
		public System.Decimal  REPLY_MONEY{get{ return  _REPLY_MONEY;}set{ _REPLY_MONEY = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _ADJUST_MONEY;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.Decimal  _IS_GOV_PROC;
		[DataMember]
		public System.Decimal  IS_GOV_PROC{get{ return  _IS_GOV_PROC;}set{ _IS_GOV_PROC = value;}}
		System.String  _ADJUST_TYPE_ID;
		[DataMember]
		public System.String  ADJUST_TYPE_ID{get{ return  _ADJUST_TYPE_ID;}set{ _ADJUST_TYPE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _APPLIED_MONEY;
		[DataMember]
		public System.Decimal  APPLIED_MONEY{get{ return  _APPLIED_MONEY;}set{ _APPLIED_MONEY = value;}}
		System.Decimal  _BUDEGT_MONEY;
		[DataMember]
		public System.Decimal  BUDEGT_MONEY{get{ return  _BUDEGT_MONEY;}set{ _BUDEGT_MONEY = value;}}

		#endregion 
	}	
}
