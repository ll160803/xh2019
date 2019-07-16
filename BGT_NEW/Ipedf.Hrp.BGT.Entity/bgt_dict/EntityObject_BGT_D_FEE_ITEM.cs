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
	[DataObject("BGT_D_FEE_ITEM")]
	public partial class CauseObject_BGT_D_FEE_ITEM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _PREPARE_PATTERN_ID = string.Empty;
		[DataMember]
		public System.String  PREPARE_PATTERN_ID{get{ return  _PREPARE_PATTERN_ID;}set{ _PREPARE_PATTERN_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _IMPORT_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  IMPORT_TYPE_ID{get{ return  _IMPORT_TYPE_ID;}set{ _IMPORT_TYPE_ID = value;}}
		System.Decimal _IS_CARRYOVER = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CARRYOVER{get{ return  _IS_CARRYOVER;}set{ _IS_CARRYOVER = value;}}
		System.Decimal _IS_CALCULATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CALCULATE{get{ return  _IS_CALCULATE;}set{ _IS_CALCULATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _IS_DISABLE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_DISABLE{get{ return  _IS_DISABLE;}set{ _IS_DISABLE = value;}}
		System.String _ADVICE_CLASSIFY_ID = string.Empty;
		[DataMember]
		public System.String  ADVICE_CLASSIFY_ID{get{ return  _ADVICE_CLASSIFY_ID;}set{ _ADVICE_CLASSIFY_ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _ITEM_CLASSIFY_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_CLASSIFY_ID{get{ return  _ITEM_CLASSIFY_ID;}set{ _ITEM_CLASSIFY_ID = value;}}
		System.String _DATA_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_TYPE_ID{get{ return  _DATA_TYPE_ID;}set{ _DATA_TYPE_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ITEM_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String _SOURCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  SOURCE_TYPE_ID{get{ return  _SOURCE_TYPE_ID;}set{ _SOURCE_TYPE_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_FEE_ITEM")]
	public partial class DisplayObject_BGT_D_FEE_ITEM:EntityObject_BGT_D_FEE_ITEM
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PREPARE_PATTERN_ID_NAME = string.Empty;
		[DataMember]
		public System.String PREPARE_PATTERN_ID_NAME{get{ return  _PREPARE_PATTERN_ID_NAME;}set{ _PREPARE_PATTERN_ID_NAME = value;}}
		 System.String _IMPORT_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String IMPORT_TYPE_ID_NAME{get{ return  _IMPORT_TYPE_ID_NAME;}set{ _IMPORT_TYPE_ID_NAME = value;}}
		 System.String _IS_CARRYOVER_NAME = string.Empty;
		[DataMember]
		public System.String IS_CARRYOVER_NAME{get{ return  _IS_CARRYOVER_NAME;}set{ _IS_CARRYOVER_NAME = value;}}
		 System.String _IS_CALCULATE_NAME = string.Empty;
		[DataMember]
		public System.String IS_CALCULATE_NAME{get{ return  _IS_CALCULATE_NAME;}set{ _IS_CALCULATE_NAME = value;}}
		 System.String _IS_DISABLE_NAME = string.Empty;
		[DataMember]
		public System.String IS_DISABLE_NAME{get{ return  _IS_DISABLE_NAME;}set{ _IS_DISABLE_NAME = value;}}
		 System.String _ADVICE_CLASSIFY_ID_NAME = string.Empty;
		[DataMember]
		public System.String ADVICE_CLASSIFY_ID_NAME{get{ return  _ADVICE_CLASSIFY_ID_NAME;}set{ _ADVICE_CLASSIFY_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _ITEM_CLASSIFY_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_CLASSIFY_ID_NAME{get{ return  _ITEM_CLASSIFY_ID_NAME;}set{ _ITEM_CLASSIFY_ID_NAME = value;}}
		 System.String _DATA_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String DATA_TYPE_ID_NAME{get{ return  _DATA_TYPE_ID_NAME;}set{ _DATA_TYPE_ID_NAME = value;}}
		 System.String _ITEM_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_TYPE_ID_NAME{get{ return  _ITEM_TYPE_ID_NAME;}set{ _ITEM_TYPE_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _SOURCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String SOURCE_TYPE_ID_NAME{get{ return  _SOURCE_TYPE_ID_NAME;}set{ _SOURCE_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_FEE_ITEM")]
	public partial class EntityObject_BGT_D_FEE_ITEM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _PREPARE_PATTERN_ID;
		[DataMember]
		public System.String  PREPARE_PATTERN_ID{get{ return  _PREPARE_PATTERN_ID;}set{ _PREPARE_PATTERN_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _IMPORT_TYPE_ID;
		[DataMember]
		public System.String  IMPORT_TYPE_ID{get{ return  _IMPORT_TYPE_ID;}set{ _IMPORT_TYPE_ID = value;}}
		System.Decimal  _IS_CARRYOVER;
		[DataMember]
		public System.Decimal  IS_CARRYOVER{get{ return  _IS_CARRYOVER;}set{ _IS_CARRYOVER = value;}}
		System.Decimal  _IS_CALCULATE;
		[DataMember]
		public System.Decimal  IS_CALCULATE{get{ return  _IS_CALCULATE;}set{ _IS_CALCULATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _IS_DISABLE;
		[DataMember]
		public System.Decimal  IS_DISABLE{get{ return  _IS_DISABLE;}set{ _IS_DISABLE = value;}}
		System.String  _ADVICE_CLASSIFY_ID;
		[DataMember]
		public System.String  ADVICE_CLASSIFY_ID{get{ return  _ADVICE_CLASSIFY_ID;}set{ _ADVICE_CLASSIFY_ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _ITEM_CLASSIFY_ID;
		[DataMember]
		public System.String  ITEM_CLASSIFY_ID{get{ return  _ITEM_CLASSIFY_ID;}set{ _ITEM_CLASSIFY_ID = value;}}
		System.String  _DATA_TYPE_ID;
		[DataMember]
		public System.String  DATA_TYPE_ID{get{ return  _DATA_TYPE_ID;}set{ _DATA_TYPE_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ITEM_TYPE_ID;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String  _SOURCE_TYPE_ID;
		[DataMember]
		public System.String  SOURCE_TYPE_ID{get{ return  _SOURCE_TYPE_ID;}set{ _SOURCE_TYPE_ID = value;}}

		#endregion 
	}	
}
