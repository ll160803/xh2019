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
	[DataObject("SCM_D_PURCHARSEPLAN")]
	public partial class CauseObject_SCM_D_PURCHARSEPLAN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _WERKS = string.Empty;
		[DataMember]
		public System.String  WERKS{get{ return  _WERKS;}set{ _WERKS = value;}}
		System.String _FREEUSE3 = string.Empty;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String _LGORT = string.Empty;
		[DataMember]
		public System.String  LGORT{get{ return  _LGORT;}set{ _LGORT = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _SUREMENGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  SUREMENGE{get{ return  _SUREMENGE;}set{ _SUREMENGE = value;}}
		System.String _EBELN = string.Empty;
		[DataMember]
		public System.String  EBELN{get{ return  _EBELN;}set{ _EBELN = value;}}
		System.String _MEINS = string.Empty;
		[DataMember]
		public System.String  MEINS{get{ return  _MEINS;}set{ _MEINS = value;}}
		System.String _NETPR = string.Empty;
		[DataMember]
		public System.String  NETPR{get{ return  _NETPR;}set{ _NETPR = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _WERKST = string.Empty;
		[DataMember]
		public System.String  WERKST{get{ return  _WERKST;}set{ _WERKST = value;}}
		System.String _FREEUSE1 = string.Empty;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String _LIFNR = string.Empty;
		[DataMember]
		public System.String  LIFNR{get{ return  _LIFNR;}set{ _LIFNR = value;}}
		System.String _STATUS = string.Empty;
		[DataMember]
		public System.String  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _MSEHT = string.Empty;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal _ALLMENGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ALLMENGE{get{ return  _ALLMENGE;}set{ _ALLMENGE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal _MENGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MENGE{get{ return  _MENGE;}set{ _MENGE = value;}}
		System.String _EBELP = string.Empty;
		[DataMember]
		public System.String  EBELP{get{ return  _EBELP;}set{ _EBELP = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _FREEUSE2 = string.Empty;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _BEDAT = string.Empty;
		[DataMember]
		public System.String  BEDAT{get{ return  _BEDAT;}set{ _BEDAT = value;}}
		System.String _EINDT = string.Empty;
		[DataMember]
		public System.String  EINDT{get{ return  _EINDT;}set{ _EINDT = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_D_PURCHARSEPLAN")]
	public partial class DisplayObject_SCM_D_PURCHARSEPLAN:EntityObject_SCM_D_PURCHARSEPLAN
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_D_PURCHARSEPLAN")]
	public partial class EntityObject_SCM_D_PURCHARSEPLAN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _WERKS;
		[DataMember]
		public System.String  WERKS{get{ return  _WERKS;}set{ _WERKS = value;}}
		System.String  _FREEUSE3;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String  _LGORT;
		[DataMember]
		public System.String  LGORT{get{ return  _LGORT;}set{ _LGORT = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _SUREMENGE;
		[DataMember]
		public System.Decimal  SUREMENGE{get{ return  _SUREMENGE;}set{ _SUREMENGE = value;}}
		System.String  _EBELN;
		[DataMember]
		public System.String  EBELN{get{ return  _EBELN;}set{ _EBELN = value;}}
		System.String  _MEINS;
		[DataMember]
		public System.String  MEINS{get{ return  _MEINS;}set{ _MEINS = value;}}
		System.String  _NETPR;
		[DataMember]
		public System.String  NETPR{get{ return  _NETPR;}set{ _NETPR = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _WERKST;
		[DataMember]
		public System.String  WERKST{get{ return  _WERKST;}set{ _WERKST = value;}}
		System.String  _FREEUSE1;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String  _LIFNR;
		[DataMember]
		public System.String  LIFNR{get{ return  _LIFNR;}set{ _LIFNR = value;}}
		System.String  _STATUS;
		[DataMember]
		public System.String  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _MSEHT;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal  _ALLMENGE;
		[DataMember]
		public System.Decimal  ALLMENGE{get{ return  _ALLMENGE;}set{ _ALLMENGE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal  _MENGE;
		[DataMember]
		public System.Decimal  MENGE{get{ return  _MENGE;}set{ _MENGE = value;}}
		System.String  _EBELP;
		[DataMember]
		public System.String  EBELP{get{ return  _EBELP;}set{ _EBELP = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _FREEUSE2;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _BEDAT;
		[DataMember]
		public System.String  BEDAT{get{ return  _BEDAT;}set{ _BEDAT = value;}}
		System.String  _EINDT;
		[DataMember]
		public System.String  EINDT{get{ return  _EINDT;}set{ _EINDT = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}	
}
