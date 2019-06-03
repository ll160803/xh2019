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
	[DataObject("V_PURCHARSEPLAN_PRINTHEAD")]
	public partial class CauseObject_V_PURCHARSEPLAN_PRINTHEAD:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _ORDER_MENGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORDER_MENGE{get{ return  _ORDER_MENGE;}set{ _ORDER_MENGE = value;}}
		System.String _FREEUSE1 = string.Empty;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String _EEIND = string.Empty;
		[DataMember]
		public System.String  EEIND{get{ return  _EEIND;}set{ _EEIND = value;}}
		System.String _BEDAT = string.Empty;
		[DataMember]
		public System.String  BEDAT{get{ return  _BEDAT;}set{ _BEDAT = value;}}
		System.String _FACTORY = string.Empty;
		[DataMember]
		public System.String  FACTORY{get{ return  _FACTORY;}set{ _FACTORY = value;}}
		System.String _WERKS = string.Empty;
		[DataMember]
		public System.String  WERKS{get{ return  _WERKS;}set{ _WERKS = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String _BSART = string.Empty;
		[DataMember]
		public System.String  BSART{get{ return  _BSART;}set{ _BSART = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String _GYJH = string.Empty;
		[DataMember]
		public System.String  GYJH{get{ return  _GYJH;}set{ _GYJH = value;}}
		System.String _NETPR = string.Empty;
		[DataMember]
		public System.String  NETPR{get{ return  _NETPR;}set{ _NETPR = value;}}
		System.String _EBELN = string.Empty;
		[DataMember]
		public System.String  EBELN{get{ return  _EBELN;}set{ _EBELN = value;}}
		System.String _WERKST = string.Empty;
		[DataMember]
		public System.String  WERKST{get{ return  _WERKST;}set{ _WERKST = value;}}
		System.String _MSEHT = string.Empty;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String _MEINS = string.Empty;
		[DataMember]
		public System.String  MEINS{get{ return  _MEINS;}set{ _MEINS = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _LGORT = string.Empty;
		[DataMember]
		public System.String  LGORT{get{ return  _LGORT;}set{ _LGORT = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_PURCHARSEPLAN_PRINTHEAD")]
	public partial class DisplayObject_V_PURCHARSEPLAN_PRINTHEAD:EntityObject_V_PURCHARSEPLAN_PRINTHEAD
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_PURCHARSEPLAN_PRINTHEAD")]
	public partial class EntityObject_V_PURCHARSEPLAN_PRINTHEAD:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _ORDER_MENGE;
		[DataMember]
		public System.Decimal  ORDER_MENGE{get{ return  _ORDER_MENGE;}set{ _ORDER_MENGE = value;}}
		System.String  _FREEUSE1;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String  _EEIND;
		[DataMember]
		public System.String  EEIND{get{ return  _EEIND;}set{ _EEIND = value;}}
		System.String  _BEDAT;
		[DataMember]
		public System.String  BEDAT{get{ return  _BEDAT;}set{ _BEDAT = value;}}
		System.String  _FACTORY;
		[DataMember]
		public System.String  FACTORY{get{ return  _FACTORY;}set{ _FACTORY = value;}}
		System.String  _WERKS;
		[DataMember]
		public System.String  WERKS{get{ return  _WERKS;}set{ _WERKS = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _GYSNAME;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String  _BSART;
		[DataMember]
		public System.String  BSART{get{ return  _BSART;}set{ _BSART = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String  _GYJH;
		[DataMember]
		public System.String  GYJH{get{ return  _GYJH;}set{ _GYJH = value;}}
		System.String  _NETPR;
		[DataMember]
		public System.String  NETPR{get{ return  _NETPR;}set{ _NETPR = value;}}
		System.String  _EBELN;
		[DataMember]
		public System.String  EBELN{get{ return  _EBELN;}set{ _EBELN = value;}}
		System.String  _WERKST;
		[DataMember]
		public System.String  WERKST{get{ return  _WERKST;}set{ _WERKST = value;}}
		System.String  _MSEHT;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String  _MEINS;
		[DataMember]
		public System.String  MEINS{get{ return  _MEINS;}set{ _MEINS = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _LGORT;
		[DataMember]
		public System.String  LGORT{get{ return  _LGORT;}set{ _LGORT = value;}}

		#endregion 
	}	
}
