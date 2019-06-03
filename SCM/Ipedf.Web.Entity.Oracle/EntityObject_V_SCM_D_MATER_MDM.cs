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
	[DataObject("V_SCM_D_MATER_MDM")]
	public partial class CauseObject_V_SCM_D_MATER_MDM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _SPELL_CODE = string.Empty;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _FREEUSE3 = string.Empty;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String _FREEUSE2 = string.Empty;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String _PRODUCE_AREA = string.Empty;
		[DataMember]
		public System.String  PRODUCE_AREA{get{ return  _PRODUCE_AREA;}set{ _PRODUCE_AREA = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String _GYS_NAME = string.Empty;
		[DataMember]
		public System.String  GYS_NAME{get{ return  _GYS_NAME;}set{ _GYS_NAME = value;}}
		System.String _FREEUSE1 = string.Empty;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_MATER_MDM")]
	public partial class DisplayObject_V_SCM_D_MATER_MDM:EntityObject_V_SCM_D_MATER_MDM
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_MATER_MDM")]
	public partial class EntityObject_V_SCM_D_MATER_MDM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _SPELL_CODE;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _FREEUSE3;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String  _FREEUSE2;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String  _PRODUCE_AREA;
		[DataMember]
		public System.String  PRODUCE_AREA{get{ return  _PRODUCE_AREA;}set{ _PRODUCE_AREA = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String  _GYS_NAME;
		[DataMember]
		public System.String  GYS_NAME{get{ return  _GYS_NAME;}set{ _GYS_NAME = value;}}
		System.String  _FREEUSE1;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}

		#endregion 
	}	
}
