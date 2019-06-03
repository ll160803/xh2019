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
	[DataObject("COM_PARAMETER")]
	public partial class CauseObject_COM_PARAMETER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PARAMETER_CODE = string.Empty;
		[DataMember]
		public System.String  PARAMETER_CODE{get{ return  _PARAMETER_CODE;}set{ _PARAMETER_CODE = value;}}
		System.String _PARAMETER_VALUE = string.Empty;
		[DataMember]
		public System.String  PARAMETER_VALUE{get{ return  _PARAMETER_VALUE;}set{ _PARAMETER_VALUE = value;}}
		System.String _PARAMETER_COMMENT = string.Empty;
		[DataMember]
		public System.String  PARAMETER_COMMENT{get{ return  _PARAMETER_COMMENT;}set{ _PARAMETER_COMMENT = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _PARAMETER_KEY = string.Empty;
		[DataMember]
		public System.String  PARAMETER_KEY{get{ return  _PARAMETER_KEY;}set{ _PARAMETER_KEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_PARAMETER")]
	public partial class DisplayObject_COM_PARAMETER:EntityObject_COM_PARAMETER
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_PARAMETER")]
	public partial class EntityObject_COM_PARAMETER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PARAMETER_CODE;
		[DataMember]
		public System.String  PARAMETER_CODE{get{ return  _PARAMETER_CODE;}set{ _PARAMETER_CODE = value;}}
		System.String  _PARAMETER_VALUE;
		[DataMember]
		public System.String  PARAMETER_VALUE{get{ return  _PARAMETER_VALUE;}set{ _PARAMETER_VALUE = value;}}
		System.String  _PARAMETER_COMMENT;
		[DataMember]
		public System.String  PARAMETER_COMMENT{get{ return  _PARAMETER_COMMENT;}set{ _PARAMETER_COMMENT = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _PARAMETER_KEY;
		[DataMember]
		public System.String  PARAMETER_KEY{get{ return  _PARAMETER_KEY;}set{ _PARAMETER_KEY = value;}}

		#endregion 
	}	
}
