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
	[DataObject("V_GETSCM_COM_DRUG")]
	public partial class CauseObject_V_GETSCM_COM_DRUG:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _HIS_NAME = string.Empty;
		[DataMember]
		public System.String  HIS_NAME{get{ return  _HIS_NAME;}set{ _HIS_NAME = value;}}
		System.String _FACTORY = string.Empty;
		[DataMember]
		public System.String  FACTORY{get{ return  _FACTORY;}set{ _FACTORY = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _HIS_CODE = string.Empty;
		[DataMember]
		public System.String  HIS_CODE{get{ return  _HIS_CODE;}set{ _HIS_CODE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_GETSCM_COM_DRUG")]
	public partial class DisplayObject_V_GETSCM_COM_DRUG:EntityObject_V_GETSCM_COM_DRUG
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_GETSCM_COM_DRUG")]
	public partial class EntityObject_V_GETSCM_COM_DRUG:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _HIS_NAME;
		[DataMember]
		public System.String  HIS_NAME{get{ return  _HIS_NAME;}set{ _HIS_NAME = value;}}
		System.String  _FACTORY;
		[DataMember]
		public System.String  FACTORY{get{ return  _FACTORY;}set{ _FACTORY = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _HIS_CODE;
		[DataMember]
		public System.String  HIS_CODE{get{ return  _HIS_CODE;}set{ _HIS_CODE = value;}}

		#endregion 
	}	
}
