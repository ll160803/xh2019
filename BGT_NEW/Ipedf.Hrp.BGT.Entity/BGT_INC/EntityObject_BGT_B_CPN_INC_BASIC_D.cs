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
	[DataObject("BGT_B_CPN_INC_BASIC_D")]
	public partial class CauseObject_BGT_B_CPN_INC_BASIC_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _BUDGRT_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  BUDGRT_ITEM_ID{get{ return  _BUDGRT_ITEM_ID;}set{ _BUDGRT_ITEM_ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String _DECALRE_CAUSE = string.Empty;
		[DataMember]
		public System.String  DECALRE_CAUSE{get{ return  _DECALRE_CAUSE;}set{ _DECALRE_CAUSE = value;}}
		System.Decimal _CONTROL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_BASIC_D")]
	public partial class DisplayObject_BGT_B_CPN_INC_BASIC_D:EntityObject_BGT_B_CPN_INC_BASIC_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGRT_ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGRT_ITEM_ID_NAME{get{ return  _BUDGRT_ITEM_ID_NAME;}set{ _BUDGRT_ITEM_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_BASIC_D")]
	public partial class EntityObject_BGT_B_CPN_INC_BASIC_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _BUDGRT_ITEM_ID;
		[DataMember]
		public System.String  BUDGRT_ITEM_ID{get{ return  _BUDGRT_ITEM_ID;}set{ _BUDGRT_ITEM_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _FINANCE_IDEA;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String  _DECALRE_CAUSE;
		[DataMember]
		public System.String  DECALRE_CAUSE{get{ return  _DECALRE_CAUSE;}set{ _DECALRE_CAUSE = value;}}
		System.Decimal  _CONTROL_MONEY;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}	
}
