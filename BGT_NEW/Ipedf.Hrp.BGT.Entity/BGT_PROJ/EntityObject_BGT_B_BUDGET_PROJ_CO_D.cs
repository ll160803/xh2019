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
	[DataObject("BGT_B_BUDGET_PROJ_CO_D")]
	public partial class CauseObject_BGT_B_BUDGET_PROJ_CO_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _ADJUST_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal _EXECUTED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _BUDGET_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  BUDGET_MONEY{get{ return  _BUDGET_MONEY;}set{ _BUDGET_MONEY = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_CO_D")]
	public partial class DisplayObject_BGT_B_BUDGET_PROJ_CO_D:EntityObject_BGT_B_BUDGET_PROJ_CO_D
	{
		#region Attribute Block
		
			//平台自动生成代码
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
	[DataObject("BGT_B_BUDGET_PROJ_CO_D")]
	public partial class EntityObject_BGT_B_BUDGET_PROJ_CO_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _ADJUST_MONEY;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal  _EXECUTED_MONEY;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _BUDGET_MONEY;
		[DataMember]
		public System.Decimal  BUDGET_MONEY{get{ return  _BUDGET_MONEY;}set{ _BUDGET_MONEY = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}	
}
