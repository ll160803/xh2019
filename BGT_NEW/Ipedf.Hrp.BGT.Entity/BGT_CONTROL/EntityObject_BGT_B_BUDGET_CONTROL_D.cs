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
	[DataObject("BGT_B_BUDGET_CONTROL_D")]
	public partial class CauseObject_BGT_B_BUDGET_CONTROL_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal _SLIDING_SCALES = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  SLIDING_SCALES{get{ return  _SLIDING_SCALES;}set{ _SLIDING_SCALES = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String _EDITION_ID = string.Empty;
		[DataMember]
		public System.String  EDITION_ID{get{ return  _EDITION_ID;}set{ _EDITION_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_D")]
	public partial class DisplayObject_BGT_B_BUDGET_CONTROL_D:EntityObject_BGT_B_BUDGET_CONTROL_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _EDITION_ID_NAME = string.Empty;
		[DataMember]
		public System.String EDITION_ID_NAME{get{ return  _EDITION_ID_NAME;}set{ _EDITION_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_D")]
	public partial class EntityObject_BGT_B_BUDGET_CONTROL_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal  _SLIDING_SCALES;
		[DataMember]
		public System.Decimal  SLIDING_SCALES{get{ return  _SLIDING_SCALES;}set{ _SLIDING_SCALES = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String  _EDITION_ID;
		[DataMember]
		public System.String  EDITION_ID{get{ return  _EDITION_ID;}set{ _EDITION_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
