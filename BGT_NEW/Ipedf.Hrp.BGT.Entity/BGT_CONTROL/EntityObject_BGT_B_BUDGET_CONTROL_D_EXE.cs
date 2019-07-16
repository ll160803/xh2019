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
	[DataObject("BGT_B_BUDGET_CONTROL_D_EXE")]
	public partial class CauseObject_BGT_B_BUDGET_CONTROL_D_EXE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _AVAILABLE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _FINANCE_CYCLE = string.Empty;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.Decimal _IS_PASS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_PASS{get{ return  _IS_PASS;}set{ _IS_PASS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_D_EXE")]
	public partial class DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE:EntityObject_BGT_B_BUDGET_CONTROL_D_EXE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _IS_PASS_NAME = string.Empty;
		[DataMember]
		public System.String IS_PASS_NAME{get{ return  _IS_PASS_NAME;}set{ _IS_PASS_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_D_EXE")]
	public partial class EntityObject_BGT_B_BUDGET_CONTROL_D_EXE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _AVAILABLE_MONEY;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _FINANCE_CYCLE;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.Decimal  _IS_PASS;
		[DataMember]
		public System.Decimal  IS_PASS{get{ return  _IS_PASS;}set{ _IS_PASS = value;}}

		#endregion 
	}	
}
