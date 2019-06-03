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
	[DataObject("COM_ROLE_M_DATA")]
	public partial class CauseObject_COM_ROLE_M_DATA:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _DATA_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ID{get{ return  _DATA_ID;}set{ _DATA_ID = value;}}
		System.String _ROLE_ID = string.Empty;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String _STRATEGY_ID = string.Empty;
		[DataMember]
		public System.String  STRATEGY_ID{get{ return  _STRATEGY_ID;}set{ _STRATEGY_ID = value;}}
		System.String _DATA_LIMIT = string.Empty;
		[DataMember]
		public System.String  DATA_LIMIT{get{ return  _DATA_LIMIT;}set{ _DATA_LIMIT = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_DATA")]
	public partial class DisplayObject_COM_ROLE_M_DATA:EntityObject_COM_ROLE_M_DATA
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _DATA_ID_NAME = string.Empty;
		[DataMember]
		public System.String DATA_ID_NAME{get{ return  _DATA_ID_NAME;}set{ _DATA_ID_NAME = value;}}
		 System.String _ROLE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ROLE_ID_NAME{get{ return  _ROLE_ID_NAME;}set{ _ROLE_ID_NAME = value;}}
		 System.String _STRATEGY_ID_NAME = string.Empty;
		[DataMember]
		public System.String STRATEGY_ID_NAME{get{ return  _STRATEGY_ID_NAME;}set{ _STRATEGY_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_DATA")]
	public partial class EntityObject_COM_ROLE_M_DATA:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _DATA_ID;
		[DataMember]
		public System.String  DATA_ID{get{ return  _DATA_ID;}set{ _DATA_ID = value;}}
		System.String  _ROLE_ID;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String  _STRATEGY_ID;
		[DataMember]
		public System.String  STRATEGY_ID{get{ return  _STRATEGY_ID;}set{ _STRATEGY_ID = value;}}
		System.String  _DATA_LIMIT;
		[DataMember]
		public System.String  DATA_LIMIT{get{ return  _DATA_LIMIT;}set{ _DATA_LIMIT = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
