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
	[DataObject("BGT_D_BUDGET_DEPT_USER")]
	public partial class CauseObject_BGT_D_BUDGET_DEPT_USER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_USER")]
	public partial class DisplayObject_BGT_D_BUDGET_DEPT_USER:EntityObject_BGT_D_BUDGET_DEPT_USER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_USER")]
	public partial class EntityObject_BGT_D_BUDGET_DEPT_USER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
