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
	[DataObject("V_SCM_D_SUPPLYPLAN_MATER")]
	public partial class CauseObject_V_SCM_D_SUPPLYPLAN_MATER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _MATER_ID = string.Empty;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CHARG = string.Empty;
		[DataMember]
		public System.String  CHARG{get{ return  _CHARG;}set{ _CHARG = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_SUPPLYPLAN_MATER")]
	public partial class DisplayObject_V_SCM_D_SUPPLYPLAN_MATER:EntityObject_V_SCM_D_SUPPLYPLAN_MATER
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_SUPPLYPLAN_MATER")]
	public partial class EntityObject_V_SCM_D_SUPPLYPLAN_MATER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _MATER_ID;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CHARG;
		[DataMember]
		public System.String  CHARG{get{ return  _CHARG;}set{ _CHARG = value;}}

		#endregion 
	}	
}
