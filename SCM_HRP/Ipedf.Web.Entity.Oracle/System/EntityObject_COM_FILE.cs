using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("COM_FILE")]
	public partial class CauseObject_COM_FILE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _CREATE_TIME = null;
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _SERVER_NAME = string.Empty;
		public System.String  SERVER_NAME{get{ return  _SERVER_NAME;}set{ _SERVER_NAME = value;}}
		System.String _FILE_TYPE = string.Empty;
		public System.String  FILE_TYPE{get{ return  _FILE_TYPE;}set{ _FILE_TYPE = value;}}
		DateSpan _MODIFY_TIME = null;
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _FILE_SIZE = string.Empty;
		public System.String  FILE_SIZE{get{ return  _FILE_SIZE;}set{ _FILE_SIZE = value;}}
		System.Decimal _IS_COMPRESS = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  IS_COMPRESS{get{ return  _IS_COMPRESS;}set{ _IS_COMPRESS = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _COMMENTS = string.Empty;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _REF_TAB_ID = string.Empty;
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _IS_IMPORT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  IS_IMPORT{get{ return  _IS_IMPORT;}set{ _IS_IMPORT = value;}}
		System.String _CONTENT_TYPE = string.Empty;
		public System.String  CONTENT_TYPE{get{ return  _CONTENT_TYPE;}set{ _CONTENT_TYPE = value;}}
		System.String _CLIENT_NAME = string.Empty;
		public System.String  CLIENT_NAME{get{ return  _CLIENT_NAME;}set{ _CLIENT_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("COM_FILE")]
	public partial class DisplayObject_COM_FILE:EntityObject_COM_FILE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _IS_COMPRESS_NAME = string.Empty;
		public System.String IS_COMPRESS_NAME{get{ return  _IS_COMPRESS_NAME;}set{ _IS_COMPRESS_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _IS_IMPORT_NAME = string.Empty;
		public System.String IS_IMPORT_NAME{get{ return  _IS_IMPORT_NAME;}set{ _IS_IMPORT_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("COM_FILE")]
	public partial class EntityObject_COM_FILE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _CREATE_TIME;
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _SERVER_NAME;
		public System.String  SERVER_NAME{get{ return  _SERVER_NAME;}set{ _SERVER_NAME = value;}}
		System.String  _FILE_TYPE;
		public System.String  FILE_TYPE{get{ return  _FILE_TYPE;}set{ _FILE_TYPE = value;}}
		System.DateTime  _MODIFY_TIME;
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _FILE_SIZE;
		public System.String  FILE_SIZE{get{ return  _FILE_SIZE;}set{ _FILE_SIZE = value;}}
		System.Decimal  _IS_COMPRESS;
		public System.Decimal  IS_COMPRESS{get{ return  _IS_COMPRESS;}set{ _IS_COMPRESS = value;}}
		System.String  _CREATE_DEPT_ID;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _REF_TAB_NAME;
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _MODIFY_DEPT_ID;
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _MODIFY_USER_ID;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _COMMENTS;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _CREATE_USER_ID;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _REF_TAB_ID;
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _STATE;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _IS_IMPORT;
		public System.Decimal  IS_IMPORT{get{ return  _IS_IMPORT;}set{ _IS_IMPORT = value;}}
		System.String  _CONTENT_TYPE;
		public System.String  CONTENT_TYPE{get{ return  _CONTENT_TYPE;}set{ _CONTENT_TYPE = value;}}
		System.String  _CLIENT_NAME;
		public System.String  CLIENT_NAME{get{ return  _CLIENT_NAME;}set{ _CLIENT_NAME = value;}}

		#endregion 
	}	
}
