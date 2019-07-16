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
	[DataObject("V_BGT_ADJUST_FUND_MONEY")]
	public partial class CauseObject_V_BGT_ADJUST_FUND_MONEY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _FUND_CODE = string.Empty;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _CHANGE_CAUSE = string.Empty;
		[DataMember]
		public System.String  CHANGE_CAUSE{get{ return  _CHANGE_CAUSE;}set{ _CHANGE_CAUSE = value;}}
		System.Decimal _CHANGE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _EXE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXE_MONEY{get{ return  _EXE_MONEY;}set{ _EXE_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_ADJUST_FUND_MONEY")]
	public partial class DisplayObject_V_BGT_ADJUST_FUND_MONEY:EntityObject_V_BGT_ADJUST_FUND_MONEY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_ADJUST_FUND_MONEY")]
	public partial class EntityObject_V_BGT_ADJUST_FUND_MONEY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _FUND_CODE;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _CHANGE_CAUSE;
		[DataMember]
		public System.String  CHANGE_CAUSE{get{ return  _CHANGE_CAUSE;}set{ _CHANGE_CAUSE = value;}}
		System.Decimal  _CHANGE_MONEY;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _EXE_MONEY;
		[DataMember]
		public System.Decimal  EXE_MONEY{get{ return  _EXE_MONEY;}set{ _EXE_MONEY = value;}}

		#endregion 
	}	
}
