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
	[DataObject("BGT_D_BUDGET_ACCOUNT")]
	public partial class CauseObject_BGT_D_BUDGET_ACCOUNT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ACCOUNT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.String _BUDGET_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_ITEM_ID{get{ return  _BUDGET_ITEM_ID;}set{ _BUDGET_ITEM_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_ACCOUNT")]
	public partial class DisplayObject_BGT_D_BUDGET_ACCOUNT:EntityObject_BGT_D_BUDGET_ACCOUNT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ACCOUNT_ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ACCOUNT_ITEM_ID_NAME{get{ return  _ACCOUNT_ITEM_ID_NAME;}set{ _ACCOUNT_ITEM_ID_NAME = value;}}
		 System.String _BUDGET_ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_ITEM_ID_NAME{get{ return  _BUDGET_ITEM_ID_NAME;}set{ _BUDGET_ITEM_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_ACCOUNT")]
	public partial class EntityObject_BGT_D_BUDGET_ACCOUNT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ACCOUNT_ITEM_ID;
		[DataMember]
		public System.String  ACCOUNT_ITEM_ID{get{ return  _ACCOUNT_ITEM_ID;}set{ _ACCOUNT_ITEM_ID = value;}}
		System.String  _BUDGET_ITEM_ID;
		[DataMember]
		public System.String  BUDGET_ITEM_ID{get{ return  _BUDGET_ITEM_ID;}set{ _BUDGET_ITEM_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}

		#endregion 
	}	
}
