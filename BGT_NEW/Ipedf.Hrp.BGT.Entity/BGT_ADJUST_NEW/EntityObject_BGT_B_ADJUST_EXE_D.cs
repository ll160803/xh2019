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
	[DataObject("BGT_B_ADJUST_EXE_D")]
	public partial class CauseObject_BGT_B_ADJUST_EXE_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _CHANGE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String _FUND_CODE = string.Empty;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _EXE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXE_MONEY{get{ return  _EXE_MONEY;}set{ _EXE_MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CHANGE_CAUSE = string.Empty;
		[DataMember]
		public System.String  CHANGE_CAUSE{get{ return  _CHANGE_CAUSE;}set{ _CHANGE_CAUSE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_ADJUST_EXE_D")]
	public partial class DisplayObject_BGT_B_ADJUST_EXE_D:EntityObject_BGT_B_ADJUST_EXE_D
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_ADJUST_EXE_D")]
	public partial class EntityObject_BGT_B_ADJUST_EXE_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _CHANGE_MONEY;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String  _FUND_CODE;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _EXE_MONEY;
		[DataMember]
		public System.Decimal  EXE_MONEY{get{ return  _EXE_MONEY;}set{ _EXE_MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CHANGE_CAUSE;
		[DataMember]
		public System.String  CHANGE_CAUSE{get{ return  _CHANGE_CAUSE;}set{ _CHANGE_CAUSE = value;}}

		#endregion 
	}	
}
