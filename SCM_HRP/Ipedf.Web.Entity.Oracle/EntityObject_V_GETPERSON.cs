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
	[DataObject("V_GETPERSON")]
	public partial class CauseObject_V_GETPERSON:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ACCOUNT = string.Empty;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _PASSWORD = string.Empty;
		[DataMember]
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}
		System.String _ROLEID = string.Empty;
		[DataMember]
		public System.String  ROLEID{get{ return  _ROLEID;}set{ _ROLEID = value;}}
		System.String _ROLENAME = string.Empty;
		[DataMember]
		public System.String  ROLENAME{get{ return  _ROLENAME;}set{ _ROLENAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _DEPARTMENTID = string.Empty;
		[DataMember]
		public System.String  DEPARTMENTID{get{ return  _DEPARTMENTID;}set{ _DEPARTMENTID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_GETPERSON")]
	public partial class DisplayObject_V_GETPERSON:EntityObject_V_GETPERSON
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_GETPERSON")]
	public partial class EntityObject_V_GETPERSON:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ACCOUNT;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _PASSWORD;
		[DataMember]
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}
		System.String  _ROLEID;
		[DataMember]
		public System.String  ROLEID{get{ return  _ROLEID;}set{ _ROLEID = value;}}
		System.String  _ROLENAME;
		[DataMember]
		public System.String  ROLENAME{get{ return  _ROLENAME;}set{ _ROLENAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _DEPARTMENTID;
		[DataMember]
		public System.String  DEPARTMENTID{get{ return  _DEPARTMENTID;}set{ _DEPARTMENTID = value;}}

		#endregion 
	}	
}
