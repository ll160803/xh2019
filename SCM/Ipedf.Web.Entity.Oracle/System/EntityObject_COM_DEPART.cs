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
	[DataObject("COM_DEPART")]
	public partial class CauseObject_COM_DEPART:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal _IS_USABLE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_USABLE{get{ return  _IS_USABLE;}set{ _IS_USABLE = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _POST_CODE = string.Empty;
		[DataMember]
		public System.String  POST_CODE{get{ return  _POST_CODE;}set{ _POST_CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _SUMMARY = string.Empty;
		[DataMember]
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PARENT_ID = string.Empty;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _DROP_DATE = null;
		[DataMember]
		public DateSpan  DROP_DATE{get{ return  _DROP_DATE;}set{ _DROP_DATE = value;}}
		System.String _ADDRESS = string.Empty;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String _HEAD_USER_ID = string.Empty;
		[DataMember]
		public System.String  HEAD_USER_ID{get{ return  _HEAD_USER_ID;}set{ _HEAD_USER_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _PHONE = string.Empty;
		[DataMember]
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		System.String _FAX = string.Empty;
		[DataMember]
		public System.String  FAX{get{ return  _FAX;}set{ _FAX = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.Decimal _TYPE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  TYPE{get{ return  _TYPE;}set{ _TYPE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_DEPART")]
	public partial class DisplayObject_COM_DEPART:EntityObject_COM_DEPART
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _IS_USABLE_NAME = string.Empty;
		[DataMember]
		public System.String IS_USABLE_NAME{get{ return  _IS_USABLE_NAME;}set{ _IS_USABLE_NAME = value;}}
		 System.String _PARENT_ID_NAME = string.Empty;
		[DataMember]
		public System.String PARENT_ID_NAME{get{ return  _PARENT_ID_NAME;}set{ _PARENT_ID_NAME = value;}}
		 System.String _HEAD_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String HEAD_USER_ID_NAME{get{ return  _HEAD_USER_ID_NAME;}set{ _HEAD_USER_ID_NAME = value;}}
		 System.String _TYPE_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_DEPART")]
	public partial class EntityObject_COM_DEPART:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal  _IS_USABLE;
		[DataMember]
		public System.Decimal  IS_USABLE{get{ return  _IS_USABLE;}set{ _IS_USABLE = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _POST_CODE;
		[DataMember]
		public System.String  POST_CODE{get{ return  _POST_CODE;}set{ _POST_CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _SUMMARY;
		[DataMember]
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PARENT_ID;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _DROP_DATE;
		[DataMember]
		public System.DateTime  DROP_DATE{get{ return  _DROP_DATE;}set{ _DROP_DATE = value;}}
		System.String  _ADDRESS;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String  _HEAD_USER_ID;
		[DataMember]
		public System.String  HEAD_USER_ID{get{ return  _HEAD_USER_ID;}set{ _HEAD_USER_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _PHONE;
		[DataMember]
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		System.String  _FAX;
		[DataMember]
		public System.String  FAX{get{ return  _FAX;}set{ _FAX = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.Decimal  _TYPE;
		[DataMember]
		public System.Decimal  TYPE{get{ return  _TYPE;}set{ _TYPE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
