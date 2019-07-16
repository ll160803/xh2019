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
	[DataObject("BGT_B_DEPT_INC_MON_FACT_D")]
	public partial class CauseObject_BGT_B_DEPT_INC_MON_FACT_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _SOURCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  SOURCE_TYPE_ID{get{ return  _SOURCE_TYPE_ID;}set{ _SOURCE_TYPE_ID = value;}}
		System.Decimal _FACT_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  FACT_VALUE{get{ return  _FACT_VALUE;}set{ _FACT_VALUE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_INC_MON_FACT_D")]
	public partial class DisplayObject_BGT_B_DEPT_INC_MON_FACT_D:EntityObject_BGT_B_DEPT_INC_MON_FACT_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SOURCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String SOURCE_TYPE_ID_NAME{get{ return  _SOURCE_TYPE_ID_NAME;}set{ _SOURCE_TYPE_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_INC_MON_FACT_D")]
	public partial class EntityObject_BGT_B_DEPT_INC_MON_FACT_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _SOURCE_TYPE_ID;
		[DataMember]
		public System.String  SOURCE_TYPE_ID{get{ return  _SOURCE_TYPE_ID;}set{ _SOURCE_TYPE_ID = value;}}
		System.Decimal  _FACT_VALUE;
		[DataMember]
		public System.Decimal  FACT_VALUE{get{ return  _FACT_VALUE;}set{ _FACT_VALUE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}	
}
