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
	[DataObject("SCM_B_QUERYPRICE_PRODUCT")]
	public partial class CauseObject_SCM_B_QUERYPRICE_PRODUCT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _PRODUCT_NAME = string.Empty;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
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
	[DataObject("SCM_B_QUERYPRICE_PRODUCT")]
	public partial class DisplayObject_SCM_B_QUERYPRICE_PRODUCT:EntityObject_SCM_B_QUERYPRICE_PRODUCT
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUERYPRICE_PRODUCT")]
	public partial class EntityObject_SCM_B_QUERYPRICE_PRODUCT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _PRODUCT_NAME;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
