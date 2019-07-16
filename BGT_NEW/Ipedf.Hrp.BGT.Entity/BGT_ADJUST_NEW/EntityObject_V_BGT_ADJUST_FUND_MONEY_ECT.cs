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
	[DataObject("V_BGT_ADJUST_FUND_MONEY_ECT")]
	public partial class CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _FUND_CODE = string.Empty;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _USERNAME = string.Empty;
		[DataMember]
		public System.String  USERNAME{get{ return  _USERNAME;}set{ _USERNAME = value;}}
		System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		System.String _BGT_D_BUDGET_ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String  BGT_D_BUDGET_ITEM_ID_NAME{get{ return  _BGT_D_BUDGET_ITEM_ID_NAME;}set{ _BGT_D_BUDGET_ITEM_ID_NAME = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal _CHANGE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String _BUDGET_YEAR_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR_ID{get{ return  _BUDGET_YEAR_ID;}set{ _BUDGET_YEAR_ID = value;}}
		System.String _ADJUST_ID = string.Empty;
		[DataMember]
		public System.String  ADJUST_ID{get{ return  _ADJUST_ID;}set{ _ADJUST_ID = value;}}
		System.String _BGT_D_BUDGET_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  BGT_D_BUDGET_ITEM_ID{get{ return  _BGT_D_BUDGET_ITEM_ID;}set{ _BGT_D_BUDGET_ITEM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_ADJUST_FUND_MONEY_ECT")]
	public partial class DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT:EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_ADJUST_FUND_MONEY_ECT")]
	public partial class EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _FUND_CODE;
		[DataMember]
		public System.String  FUND_CODE{get{ return  _FUND_CODE;}set{ _FUND_CODE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _USERNAME;
		[DataMember]
		public System.String  USERNAME{get{ return  _USERNAME;}set{ _USERNAME = value;}}
		System.String  _BUDGET_DEPT_ID_NAME;
		[DataMember]
		public System.String  BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		System.String  _BGT_D_BUDGET_ITEM_ID_NAME;
		[DataMember]
		public System.String  BGT_D_BUDGET_ITEM_ID_NAME{get{ return  _BGT_D_BUDGET_ITEM_ID_NAME;}set{ _BGT_D_BUDGET_ITEM_ID_NAME = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal  _CHANGE_MONEY;
		[DataMember]
		public System.Decimal  CHANGE_MONEY{get{ return  _CHANGE_MONEY;}set{ _CHANGE_MONEY = value;}}
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String  _BUDGET_YEAR_ID;
		[DataMember]
		public System.String  BUDGET_YEAR_ID{get{ return  _BUDGET_YEAR_ID;}set{ _BUDGET_YEAR_ID = value;}}
		System.String  _ADJUST_ID;
		[DataMember]
		public System.String  ADJUST_ID{get{ return  _ADJUST_ID;}set{ _ADJUST_ID = value;}}
		System.String  _BGT_D_BUDGET_ITEM_ID;
		[DataMember]
		public System.String  BGT_D_BUDGET_ITEM_ID{get{ return  _BGT_D_BUDGET_ITEM_ID;}set{ _BGT_D_BUDGET_ITEM_ID = value;}}

		#endregion 
	}	
}
