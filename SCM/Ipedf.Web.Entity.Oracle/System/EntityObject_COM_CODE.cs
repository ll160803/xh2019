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
	[DataObject("COM_CODE")]
	public partial class CauseObject_COM_CODE:CauseBase
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
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_CODE")]
	public partial class DisplayObject_COM_CODE:EntityObject_COM_CODE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_CODE")]
	public partial class EntityObject_COM_CODE:EntityBase
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
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
