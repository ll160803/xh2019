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
	[DataObject("BGT_B_BUDGET_PROJ_EXE_D")]
	public partial class CauseObject_BGT_B_BUDGET_PROJ_EXE_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _EXECUTE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTE_MONEY{get{ return  _EXECUTE_MONEY;}set{ _EXECUTE_MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		DateSpan _EXECUTE_DATE = null;
		[DataMember]
		public DateSpan  EXECUTE_DATE{get{ return  _EXECUTE_DATE;}set{ _EXECUTE_DATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String _INVOICE_CODE = string.Empty;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		DateSpan _APPLY_DATE = null;
		[DataMember]
		public DateSpan  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String _EXECUTE_MONTH_ID = string.Empty;
		[DataMember]
		public System.String  EXECUTE_MONTH_ID{get{ return  _EXECUTE_MONTH_ID;}set{ _EXECUTE_MONTH_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_EXE_D")]
	public partial class DisplayObject_BGT_B_BUDGET_PROJ_EXE_D:EntityObject_BGT_B_BUDGET_PROJ_EXE_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _EXECUTE_MONTH_ID_NAME = string.Empty;
		[DataMember]
		public System.String EXECUTE_MONTH_ID_NAME{get{ return  _EXECUTE_MONTH_ID_NAME;}set{ _EXECUTE_MONTH_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_EXE_D")]
	public partial class EntityObject_BGT_B_BUDGET_PROJ_EXE_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _EXECUTE_MONEY;
		[DataMember]
		public System.Decimal  EXECUTE_MONEY{get{ return  _EXECUTE_MONEY;}set{ _EXECUTE_MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.DateTime  _EXECUTE_DATE;
		[DataMember]
		public System.DateTime  EXECUTE_DATE{get{ return  _EXECUTE_DATE;}set{ _EXECUTE_DATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String  _INVOICE_CODE;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.DateTime  _APPLY_DATE;
		[DataMember]
		public System.DateTime  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String  _EXECUTE_MONTH_ID;
		[DataMember]
		public System.String  EXECUTE_MONTH_ID{get{ return  _EXECUTE_MONTH_ID;}set{ _EXECUTE_MONTH_ID = value;}}

		#endregion 
	}	
}
