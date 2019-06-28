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
	[DataObject("COM_ROLE_M_FORM")]
	public partial class CauseObject_COM_ROLE_M_FORM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CONTROL_CODE = string.Empty;
		[DataMember]
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String _ROLE_ID = string.Empty;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _FORM_ID = string.Empty;
		[DataMember]
		public System.String  FORM_ID{get{ return  _FORM_ID;}set{ _FORM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_FORM")]
	public partial class DisplayObject_COM_ROLE_M_FORM:EntityObject_COM_ROLE_M_FORM
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ROLE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ROLE_ID_NAME{get{ return  _ROLE_ID_NAME;}set{ _ROLE_ID_NAME = value;}}
		 System.String _FORM_ID_NAME = string.Empty;
		[DataMember]
		public System.String FORM_ID_NAME{get{ return  _FORM_ID_NAME;}set{ _FORM_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_ROLE_M_FORM")]
	public partial class EntityObject_COM_ROLE_M_FORM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CONTROL_CODE;
		[DataMember]
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String  _ROLE_ID;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _FORM_ID;
		[DataMember]
		public System.String  FORM_ID{get{ return  _FORM_ID;}set{ _FORM_ID = value;}}

		#endregion 
	}	
}
