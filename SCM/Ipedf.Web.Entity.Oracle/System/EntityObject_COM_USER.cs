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
	[DataObject("COM_USER")]
	public partial class CauseObject_COM_USER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _DEPART_ID = string.Empty;
		[DataMember]
		public System.String  DEPART_ID{get{ return  _DEPART_ID;}set{ _DEPART_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _STAFF_ID = string.Empty;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.Decimal _IS_USABLE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_USABLE{get{ return  _IS_USABLE;}set{ _IS_USABLE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _ACCOUNT = string.Empty;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal _ENTRY_COUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ENTRY_COUNT{get{ return  _ENTRY_COUNT;}set{ _ENTRY_COUNT = value;}}
		DateSpan _LAST_ENTRY_TIME = null;
		[DataMember]
		public DateSpan  LAST_ENTRY_TIME{get{ return  _LAST_ENTRY_TIME;}set{ _LAST_ENTRY_TIME = value;}}
		System.String _PASSWORD = string.Empty;
		[DataMember]
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_USER")]
	public partial class DisplayObject_COM_USER:EntityObject_COM_USER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _DEPART_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPART_ID_NAME{get{ return  _DEPART_ID_NAME;}set{ _DEPART_ID_NAME = value;}}
		 System.String _IS_USABLE_NAME = string.Empty;
		[DataMember]
		public System.String IS_USABLE_NAME{get{ return  _IS_USABLE_NAME;}set{ _IS_USABLE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_USER")]
	public partial class EntityObject_COM_USER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _DEPART_ID;
		[DataMember]
		public System.String  DEPART_ID{get{ return  _DEPART_ID;}set{ _DEPART_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _STAFF_ID;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.Decimal  _IS_USABLE;
		[DataMember]
		public System.Decimal  IS_USABLE{get{ return  _IS_USABLE;}set{ _IS_USABLE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _ACCOUNT;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal  _ENTRY_COUNT;
		[DataMember]
		public System.Decimal  ENTRY_COUNT{get{ return  _ENTRY_COUNT;}set{ _ENTRY_COUNT = value;}}
		System.DateTime  _LAST_ENTRY_TIME;
		[DataMember]
		public System.DateTime  LAST_ENTRY_TIME{get{ return  _LAST_ENTRY_TIME;}set{ _LAST_ENTRY_TIME = value;}}
		System.String  _PASSWORD;
		[DataMember]
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}

		#endregion 
	}	
}
