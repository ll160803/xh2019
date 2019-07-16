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
	[DataObject("BGT_D_MGR_DEPT_ITEM_D")]
	public partial class CauseObject_BGT_D_MGR_DEPT_ITEM_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BIZ_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BIZ_DEPT_ID{get{ return  _BIZ_DEPT_ID;}set{ _BIZ_DEPT_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MGR_DEPT_ITEM_D")]
	public partial class DisplayObject_BGT_D_MGR_DEPT_ITEM_D:EntityObject_BGT_D_MGR_DEPT_ITEM_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _BIZ_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BIZ_DEPT_ID_NAME{get{ return  _BIZ_DEPT_ID_NAME;}set{ _BIZ_DEPT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MGR_DEPT_ITEM_D")]
	public partial class EntityObject_BGT_D_MGR_DEPT_ITEM_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BIZ_DEPT_ID;
		[DataMember]
		public System.String  BIZ_DEPT_ID{get{ return  _BIZ_DEPT_ID;}set{ _BIZ_DEPT_ID = value;}}

		#endregion 
	}	
}
