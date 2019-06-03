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
	[DataObject("SCM_B_QUERYPRICE_D")]
	public partial class CauseObject_SCM_B_QUERYPRICE_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _COMMENTS_D = string.Empty;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _GYSPYM = string.Empty;
		[DataMember]
		public System.String  GYSPYM{get{ return  _GYSPYM;}set{ _GYSPYM = value;}}
		System.String _GYSLABEL = string.Empty;
		[DataMember]
		public System.String  GYSLABEL{get{ return  _GYSLABEL;}set{ _GYSLABEL = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUERYPRICE_D")]
	public partial class DisplayObject_SCM_B_QUERYPRICE_D:EntityObject_SCM_B_QUERYPRICE_D
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUERYPRICE_D")]
	public partial class EntityObject_SCM_B_QUERYPRICE_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _COMMENTS_D;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String  _GYSPYM;
		[DataMember]
		public System.String  GYSPYM{get{ return  _GYSPYM;}set{ _GYSPYM = value;}}
		System.String  _GYSLABEL;
		[DataMember]
		public System.String  GYSLABEL{get{ return  _GYSLABEL;}set{ _GYSLABEL = value;}}
		System.String  _GYSNAME;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}

		#endregion 
	}	
}
