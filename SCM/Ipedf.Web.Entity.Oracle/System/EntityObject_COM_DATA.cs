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
	[DataObject("COM_DATA")]
	public partial class CauseObject_COM_DATA:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_DATA")]
	public partial class DisplayObject_COM_DATA:EntityObject_COM_DATA
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_DATA")]
	public partial class EntityObject_COM_DATA:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
