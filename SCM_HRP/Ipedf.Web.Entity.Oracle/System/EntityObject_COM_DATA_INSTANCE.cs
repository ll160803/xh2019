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
	[DataObject("COM_DATA_INSTANCE")]
	public partial class CauseObject_COM_DATA_INSTANCE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _CREATE_TIME = null;
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _MODIFY_TIME = null;
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _DATA_INSTANCE_ID = string.Empty;
		public System.String  DATA_INSTANCE_ID{get{ return  _DATA_INSTANCE_ID;}set{ _DATA_INSTANCE_ID = value;}}
		System.String _PARENT_INSTANCE_ID = string.Empty;
		public System.String  PARENT_INSTANCE_ID{get{ return  _PARENT_INSTANCE_ID;}set{ _PARENT_INSTANCE_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _DATA_ID = string.Empty;
		public System.String  DATA_ID{get{ return  _DATA_ID;}set{ _DATA_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _DATA_INSTANCE_CODE = string.Empty;
		public System.String  DATA_INSTANCE_CODE{get{ return  _DATA_INSTANCE_CODE;}set{ _DATA_INSTANCE_CODE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PARENT_DATA_ID = string.Empty;
		public System.String  PARENT_DATA_ID{get{ return  _PARENT_DATA_ID;}set{ _PARENT_DATA_ID = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("COM_DATA_INSTANCE")]
	public partial class DisplayObject_COM_DATA_INSTANCE:EntityObject_COM_DATA_INSTANCE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_DATA_NAME = string.Empty;
		public System.String COM_DATA_NAME{get{ return  _COM_DATA_NAME;}set{ _COM_DATA_NAME = value;}}
		 System.String _COM_DATA_NAME_1 = string.Empty;
		public System.String COM_DATA_NAME_1{get{ return  _COM_DATA_NAME_1;}set{ _COM_DATA_NAME_1 = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("COM_DATA_INSTANCE")]
	public partial class EntityObject_COM_DATA_INSTANCE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _CREATE_TIME;
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _MODIFY_TIME;
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _DATA_INSTANCE_ID;
		public System.String  DATA_INSTANCE_ID{get{ return  _DATA_INSTANCE_ID;}set{ _DATA_INSTANCE_ID = value;}}
		System.String  _PARENT_INSTANCE_ID;
		public System.String  PARENT_INSTANCE_ID{get{ return  _PARENT_INSTANCE_ID;}set{ _PARENT_INSTANCE_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _MODIFY_USER_ID;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _DATA_ID;
		public System.String  DATA_ID{get{ return  _DATA_ID;}set{ _DATA_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _DATA_INSTANCE_CODE;
		public System.String  DATA_INSTANCE_CODE{get{ return  _DATA_INSTANCE_CODE;}set{ _DATA_INSTANCE_CODE = value;}}
		System.String  _CREATE_USER_ID;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PARENT_DATA_ID;
		public System.String  PARENT_DATA_ID{get{ return  _PARENT_DATA_ID;}set{ _PARENT_DATA_ID = value;}}
		System.String  _MODIFY_DEPART_ID;
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}	
}
