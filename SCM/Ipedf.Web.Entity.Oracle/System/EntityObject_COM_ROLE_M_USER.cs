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
	[DataObject("COM_ROLE_M_USER")]
	public partial class CauseObject_COM_ROLE_M_USER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _ROLE_ID = string.Empty;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_USER")]
	public partial class DisplayObject_COM_ROLE_M_USER:EntityObject_COM_ROLE_M_USER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_USER_NAME = string.Empty;
		[DataMember]
		public System.String COM_USER_NAME{get{ return  _COM_USER_NAME;}set{ _COM_USER_NAME = value;}}
		 System.String _COM_ROLE_NAME = string.Empty;
		[DataMember]
		public System.String COM_ROLE_NAME{get{ return  _COM_ROLE_NAME;}set{ _COM_ROLE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_USER")]
	public partial class EntityObject_COM_ROLE_M_USER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _ROLE_ID;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
