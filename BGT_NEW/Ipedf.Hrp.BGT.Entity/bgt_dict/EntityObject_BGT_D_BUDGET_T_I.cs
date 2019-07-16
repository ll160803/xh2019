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
	[DataObject("BGT_D_BUDGET_T_DEPT_I")]
	public partial class CauseObject_BGT_D_BUDGET_T_DEPT_I:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _INCREASE_SCALE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  INCREASE_SCALE{get{ return  _INCREASE_SCALE;}set{ _INCREASE_SCALE = value;}}
		System.Decimal _BUDGET_YEAR_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  BUDGET_YEAR_VALUE{get{ return  _BUDGET_YEAR_VALUE;}set{ _BUDGET_YEAR_VALUE = value;}}
		System.Decimal _LAST_YEAR_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  LAST_YEAR_VALUE{get{ return  _LAST_YEAR_VALUE;}set{ _LAST_YEAR_VALUE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_T_DEPT_I")]
	public partial class DisplayObject_BGT_D_BUDGET_T_DEPT_I:EntityObject_BGT_D_BUDGET_T_DEPT_I
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_T_DEPT_I")]
	public partial class EntityObject_BGT_D_BUDGET_T_DEPT_I:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _INCREASE_SCALE;
		[DataMember]
		public System.Decimal  INCREASE_SCALE{get{ return  _INCREASE_SCALE;}set{ _INCREASE_SCALE = value;}}
		System.Decimal  _BUDGET_YEAR_VALUE;
		[DataMember]
		public System.Decimal  BUDGET_YEAR_VALUE{get{ return  _BUDGET_YEAR_VALUE;}set{ _BUDGET_YEAR_VALUE = value;}}
		System.Decimal  _LAST_YEAR_VALUE;
		[DataMember]
		public System.Decimal  LAST_YEAR_VALUE{get{ return  _LAST_YEAR_VALUE;}set{ _LAST_YEAR_VALUE = value;}}

		#endregion 
	}	
}
