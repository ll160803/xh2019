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
	[DataObject("COM_FORM_ROLE_TOOLBAR")]
	public partial class CauseObject_COM_FORM_ROLE_TOOLBAR:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ROLE_ID = string.Empty;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TOOLBAR_ID = string.Empty;
		[DataMember]
		public System.String  TOOLBAR_ID{get{ return  _TOOLBAR_ID;}set{ _TOOLBAR_ID = value;}}
		System.String _FORM_ID = string.Empty;
		[DataMember]
		public System.String  FORM_ID{get{ return  _FORM_ID;}set{ _FORM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_FORM_ROLE_TOOLBAR")]
	public partial class DisplayObject_COM_FORM_ROLE_TOOLBAR:EntityObject_COM_FORM_ROLE_TOOLBAR
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_FORM_ROLE_TOOLBAR")]
	public partial class EntityObject_COM_FORM_ROLE_TOOLBAR:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ROLE_ID;
		[DataMember]
		public System.String  ROLE_ID{get{ return  _ROLE_ID;}set{ _ROLE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TOOLBAR_ID;
		[DataMember]
		public System.String  TOOLBAR_ID{get{ return  _TOOLBAR_ID;}set{ _TOOLBAR_ID = value;}}
		System.String  _FORM_ID;
		[DataMember]
		public System.String  FORM_ID{get{ return  _FORM_ID;}set{ _FORM_ID = value;}}

		#endregion 
	}	
}
