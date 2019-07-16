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
	[DataObject("BGT_D_BUDGET_PATTERN")]
	public partial class CauseObject_BGT_D_BUDGET_PATTERN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _PAY_PATTERN_ENTRY_ID = string.Empty;
		[DataMember]
		public System.String  PAY_PATTERN_ENTRY_ID{get{ return  _PAY_PATTERN_ENTRY_ID;}set{ _PAY_PATTERN_ENTRY_ID = value;}}
		System.String _INCOME_PATTERN_ID = string.Empty;
		[DataMember]
		public System.String  INCOME_PATTERN_ID{get{ return  _INCOME_PATTERN_ID;}set{ _INCOME_PATTERN_ID = value;}}
		System.String _INCOME_LEVEL_ID = string.Empty;
		[DataMember]
		public System.String  INCOME_LEVEL_ID{get{ return  _INCOME_LEVEL_ID;}set{ _INCOME_LEVEL_ID = value;}}
		System.Decimal _IS_INTERNAL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_INTERNAL{get{ return  _IS_INTERNAL;}set{ _IS_INTERNAL = value;}}
		System.String _PLAN_PATTERN_ID = string.Empty;
		[DataMember]
		public System.String  PLAN_PATTERN_ID{get{ return  _PLAN_PATTERN_ID;}set{ _PLAN_PATTERN_ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _PAY_PATTERN_ID = string.Empty;
		[DataMember]
		public System.String  PAY_PATTERN_ID{get{ return  _PAY_PATTERN_ID;}set{ _PAY_PATTERN_ID = value;}}
		System.String _PAY_LEVEL_ID = string.Empty;
		[DataMember]
		public System.String  PAY_LEVEL_ID{get{ return  _PAY_LEVEL_ID;}set{ _PAY_LEVEL_ID = value;}}
		System.Decimal _IS_PAY_ITEM_MERGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_PAY_ITEM_MERGE{get{ return  _IS_PAY_ITEM_MERGE;}set{ _IS_PAY_ITEM_MERGE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_PATTERN")]
	public partial class DisplayObject_BGT_D_BUDGET_PATTERN:EntityObject_BGT_D_BUDGET_PATTERN
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PAY_PATTERN_ENTRY_ID_NAME = string.Empty;
		[DataMember]
		public System.String PAY_PATTERN_ENTRY_ID_NAME{get{ return  _PAY_PATTERN_ENTRY_ID_NAME;}set{ _PAY_PATTERN_ENTRY_ID_NAME = value;}}
		 System.String _INCOME_PATTERN_ID_NAME = string.Empty;
		[DataMember]
		public System.String INCOME_PATTERN_ID_NAME{get{ return  _INCOME_PATTERN_ID_NAME;}set{ _INCOME_PATTERN_ID_NAME = value;}}
		 System.String _INCOME_LEVEL_ID_NAME = string.Empty;
		[DataMember]
		public System.String INCOME_LEVEL_ID_NAME{get{ return  _INCOME_LEVEL_ID_NAME;}set{ _INCOME_LEVEL_ID_NAME = value;}}
		 System.String _IS_INTERNAL_NAME = string.Empty;
		[DataMember]
		public System.String IS_INTERNAL_NAME{get{ return  _IS_INTERNAL_NAME;}set{ _IS_INTERNAL_NAME = value;}}
		 System.String _PLAN_PATTERN_ID_NAME = string.Empty;
		[DataMember]
		public System.String PLAN_PATTERN_ID_NAME{get{ return  _PLAN_PATTERN_ID_NAME;}set{ _PLAN_PATTERN_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _PAY_PATTERN_ID_NAME = string.Empty;
		[DataMember]
		public System.String PAY_PATTERN_ID_NAME{get{ return  _PAY_PATTERN_ID_NAME;}set{ _PAY_PATTERN_ID_NAME = value;}}
		 System.String _PAY_LEVEL_ID_NAME = string.Empty;
		[DataMember]
		public System.String PAY_LEVEL_ID_NAME{get{ return  _PAY_LEVEL_ID_NAME;}set{ _PAY_LEVEL_ID_NAME = value;}}
		 System.String _IS_PAY_ITEM_MERGE_NAME = string.Empty;
		[DataMember]
		public System.String IS_PAY_ITEM_MERGE_NAME{get{ return  _IS_PAY_ITEM_MERGE_NAME;}set{ _IS_PAY_ITEM_MERGE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_PATTERN")]
	public partial class EntityObject_BGT_D_BUDGET_PATTERN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _PAY_PATTERN_ENTRY_ID;
		[DataMember]
		public System.String  PAY_PATTERN_ENTRY_ID{get{ return  _PAY_PATTERN_ENTRY_ID;}set{ _PAY_PATTERN_ENTRY_ID = value;}}
		System.String  _INCOME_PATTERN_ID;
		[DataMember]
		public System.String  INCOME_PATTERN_ID{get{ return  _INCOME_PATTERN_ID;}set{ _INCOME_PATTERN_ID = value;}}
		System.String  _INCOME_LEVEL_ID;
		[DataMember]
		public System.String  INCOME_LEVEL_ID{get{ return  _INCOME_LEVEL_ID;}set{ _INCOME_LEVEL_ID = value;}}
		System.Decimal  _IS_INTERNAL;
		[DataMember]
		public System.Decimal  IS_INTERNAL{get{ return  _IS_INTERNAL;}set{ _IS_INTERNAL = value;}}
		System.String  _PLAN_PATTERN_ID;
		[DataMember]
		public System.String  PLAN_PATTERN_ID{get{ return  _PLAN_PATTERN_ID;}set{ _PLAN_PATTERN_ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _PAY_PATTERN_ID;
		[DataMember]
		public System.String  PAY_PATTERN_ID{get{ return  _PAY_PATTERN_ID;}set{ _PAY_PATTERN_ID = value;}}
		System.String  _PAY_LEVEL_ID;
		[DataMember]
		public System.String  PAY_LEVEL_ID{get{ return  _PAY_LEVEL_ID;}set{ _PAY_LEVEL_ID = value;}}
		System.Decimal  _IS_PAY_ITEM_MERGE;
		[DataMember]
		public System.Decimal  IS_PAY_ITEM_MERGE{get{ return  _IS_PAY_ITEM_MERGE;}set{ _IS_PAY_ITEM_MERGE = value;}}

		#endregion 
	}	
}
