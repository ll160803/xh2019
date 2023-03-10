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
	[DataObject("V_SCM_D_MATER_PIC_COM_FILE")]
	public partial class CauseObject_V_SCM_D_MATER_PIC_COM_FILE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String _PRODUCE_AREA = string.Empty;
		[DataMember]
		public System.String  PRODUCE_AREA{get{ return  _PRODUCE_AREA;}set{ _PRODUCE_AREA = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _CHARGE = string.Empty;
		[DataMember]
		public System.String  CHARGE{get{ return  _CHARGE;}set{ _CHARGE = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _SPELL_CODE = string.Empty;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String _CLIENT_NAME = string.Empty;
		[DataMember]
		public System.String  CLIENT_NAME{get{ return  _CLIENT_NAME;}set{ _CLIENT_NAME = value;}}
		System.String _SERVER_NAME = string.Empty;
		[DataMember]
		public System.String  SERVER_NAME{get{ return  _SERVER_NAME;}set{ _SERVER_NAME = value;}}
		System.String _MATER_ID = string.Empty;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_MATER_PIC_COM_FILE")]
	public partial class DisplayObject_V_SCM_D_MATER_PIC_COM_FILE:EntityObject_V_SCM_D_MATER_PIC_COM_FILE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_D_MATER_PIC_COM_FILE")]
	public partial class EntityObject_V_SCM_D_MATER_PIC_COM_FILE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _GYSNAME;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String  _PRODUCE_AREA;
		[DataMember]
		public System.String  PRODUCE_AREA{get{ return  _PRODUCE_AREA;}set{ _PRODUCE_AREA = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _CHARGE;
		[DataMember]
		public System.String  CHARGE{get{ return  _CHARGE;}set{ _CHARGE = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _SPELL_CODE;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String  _CLIENT_NAME;
		[DataMember]
		public System.String  CLIENT_NAME{get{ return  _CLIENT_NAME;}set{ _CLIENT_NAME = value;}}
		System.String  _SERVER_NAME;
		[DataMember]
		public System.String  SERVER_NAME{get{ return  _SERVER_NAME;}set{ _SERVER_NAME = value;}}
		System.String  _MATER_ID;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}

		#endregion 
	}	
}
