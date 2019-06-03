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
	[DataObject("V_SCM_B_QUOTEDPRICE_DETAIL")]
	public partial class CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _COM_FILE_ID = string.Empty;
		[DataMember]
		public System.String  COM_FILE_ID{get{ return  _COM_FILE_ID;}set{ _COM_FILE_ID = value;}}
		System.String _COM_FILE_ID_S_NAME = string.Empty;
		[DataMember]
		public System.String  COM_FILE_ID_S_NAME{get{ return  _COM_FILE_ID_S_NAME;}set{ _COM_FILE_ID_S_NAME = value;}}
		System.String _QUERY_STATE = string.Empty;
		[DataMember]
		public System.String  QUERY_STATE{get{ return  _QUERY_STATE;}set{ _QUERY_STATE = value;}}
		System.String _MNAME = string.Empty;
		[DataMember]
		public System.String  MNAME{get{ return  _MNAME;}set{ _MNAME = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String  STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _COM_FILE_ID_NAME = string.Empty;
		[DataMember]
		public System.String  COM_FILE_ID_NAME{get{ return  _COM_FILE_ID_NAME;}set{ _COM_FILE_ID_NAME = value;}}
		System.Decimal _QUOTED_PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  QUOTED_PRICE{get{ return  _QUOTED_PRICE;}set{ _QUOTED_PRICE = value;}}
		System.String _PRODUCT_NAME = string.Empty;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
		System.String _GYSPYM = string.Empty;
		[DataMember]
		public System.String  GYSPYM{get{ return  _GYSPYM;}set{ _GYSPYM = value;}}
		System.Decimal _MSTATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MSTATE{get{ return  _MSTATE;}set{ _MSTATE = value;}}
		System.Decimal _SUPPLY_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  SUPPLY_AMOUNT{get{ return  _SUPPLY_AMOUNT;}set{ _SUPPLY_AMOUNT = value;}}
		System.String _MATNR_ID = string.Empty;
		[DataMember]
		public System.String  MATNR_ID{get{ return  _MATNR_ID;}set{ _MATNR_ID = value;}}
		System.String _MDEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String  MDEPT_ID_NAME{get{ return  _MDEPT_ID_NAME;}set{ _MDEPT_ID_NAME = value;}}
		System.String _GYSLABEL = string.Empty;
		[DataMember]
		public System.String  GYSLABEL{get{ return  _GYSLABEL;}set{ _GYSLABEL = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _MSTATE_NAME = string.Empty;
		[DataMember]
		public System.String  MSTATE_NAME{get{ return  _MSTATE_NAME;}set{ _MSTATE_NAME = value;}}
		System.String _MDEPT_ID = string.Empty;
		[DataMember]
		public System.String  MDEPT_ID{get{ return  _MDEPT_ID;}set{ _MDEPT_ID = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		DateSpan _QUERY_DATE = null;
		[DataMember]
		public DateSpan  QUERY_DATE{get{ return  _QUERY_DATE;}set{ _QUERY_DATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _QUERY_TYPE = string.Empty;
		[DataMember]
		public System.String  QUERY_TYPE{get{ return  _QUERY_TYPE;}set{ _QUERY_TYPE = value;}}
		System.String _QUERY_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  QUERY_TYPE_NAME{get{ return  _QUERY_TYPE_NAME;}set{ _QUERY_TYPE_NAME = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		DateSpan _END_DATE = null;
		[DataMember]
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String _COMMENTS_D = string.Empty;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _HOSPITAL_NAME = string.Empty;
		[DataMember]
		public System.String  HOSPITAL_NAME{get{ return  _HOSPITAL_NAME;}set{ _HOSPITAL_NAME = value;}}
		System.String _MSEHT = string.Empty;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String _MCOMMENTS = string.Empty;
		[DataMember]
		public System.String  MCOMMENTS{get{ return  _MCOMMENTS;}set{ _MCOMMENTS = value;}}
		System.String _MCODE = string.Empty;
		[DataMember]
		public System.String  MCODE{get{ return  _MCODE;}set{ _MCODE = value;}}
		System.String _MID = string.Empty;
		[DataMember]
		public System.String  MID{get{ return  _MID;}set{ _MID = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _QUERY_STATE_NAME = string.Empty;
		[DataMember]
		public System.String  QUERY_STATE_NAME{get{ return  _QUERY_STATE_NAME;}set{ _QUERY_STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_B_QUOTEDPRICE_DETAIL")]
	public partial class DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL:EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_B_QUOTEDPRICE_DETAIL")]
	public partial class EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _COM_FILE_ID;
		[DataMember]
		public System.String  COM_FILE_ID{get{ return  _COM_FILE_ID;}set{ _COM_FILE_ID = value;}}
		System.String  _COM_FILE_ID_S_NAME;
		[DataMember]
		public System.String  COM_FILE_ID_S_NAME{get{ return  _COM_FILE_ID_S_NAME;}set{ _COM_FILE_ID_S_NAME = value;}}
		System.String  _QUERY_STATE;
		[DataMember]
		public System.String  QUERY_STATE{get{ return  _QUERY_STATE;}set{ _QUERY_STATE = value;}}
		System.String  _MNAME;
		[DataMember]
		public System.String  MNAME{get{ return  _MNAME;}set{ _MNAME = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _STATE_NAME;
		[DataMember]
		public System.String  STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _COM_FILE_ID_NAME;
		[DataMember]
		public System.String  COM_FILE_ID_NAME{get{ return  _COM_FILE_ID_NAME;}set{ _COM_FILE_ID_NAME = value;}}
		System.Decimal  _QUOTED_PRICE;
		[DataMember]
		public System.Decimal  QUOTED_PRICE{get{ return  _QUOTED_PRICE;}set{ _QUOTED_PRICE = value;}}
		System.String  _PRODUCT_NAME;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
		System.String  _GYSPYM;
		[DataMember]
		public System.String  GYSPYM{get{ return  _GYSPYM;}set{ _GYSPYM = value;}}
		System.Decimal  _MSTATE;
		[DataMember]
		public System.Decimal  MSTATE{get{ return  _MSTATE;}set{ _MSTATE = value;}}
		System.Decimal  _SUPPLY_AMOUNT;
		[DataMember]
		public System.Decimal  SUPPLY_AMOUNT{get{ return  _SUPPLY_AMOUNT;}set{ _SUPPLY_AMOUNT = value;}}
		System.String  _MATNR_ID;
		[DataMember]
		public System.String  MATNR_ID{get{ return  _MATNR_ID;}set{ _MATNR_ID = value;}}
		System.String  _MDEPT_ID_NAME;
		[DataMember]
		public System.String  MDEPT_ID_NAME{get{ return  _MDEPT_ID_NAME;}set{ _MDEPT_ID_NAME = value;}}
		System.String  _GYSLABEL;
		[DataMember]
		public System.String  GYSLABEL{get{ return  _GYSLABEL;}set{ _GYSLABEL = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _MSTATE_NAME;
		[DataMember]
		public System.String  MSTATE_NAME{get{ return  _MSTATE_NAME;}set{ _MSTATE_NAME = value;}}
		System.String  _MDEPT_ID;
		[DataMember]
		public System.String  MDEPT_ID{get{ return  _MDEPT_ID;}set{ _MDEPT_ID = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.DateTime  _QUERY_DATE;
		[DataMember]
		public System.DateTime  QUERY_DATE{get{ return  _QUERY_DATE;}set{ _QUERY_DATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _QUERY_TYPE;
		[DataMember]
		public System.String  QUERY_TYPE{get{ return  _QUERY_TYPE;}set{ _QUERY_TYPE = value;}}
		System.String  _QUERY_TYPE_NAME;
		[DataMember]
		public System.String  QUERY_TYPE_NAME{get{ return  _QUERY_TYPE_NAME;}set{ _QUERY_TYPE_NAME = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.DateTime  _END_DATE;
		[DataMember]
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String  _COMMENTS_D;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _GYSNAME;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String  _HOSPITAL_NAME;
		[DataMember]
		public System.String  HOSPITAL_NAME{get{ return  _HOSPITAL_NAME;}set{ _HOSPITAL_NAME = value;}}
		System.String  _MSEHT;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String  _MCOMMENTS;
		[DataMember]
		public System.String  MCOMMENTS{get{ return  _MCOMMENTS;}set{ _MCOMMENTS = value;}}
		System.String  _MCODE;
		[DataMember]
		public System.String  MCODE{get{ return  _MCODE;}set{ _MCODE = value;}}
		System.String  _MID;
		[DataMember]
		public System.String  MID{get{ return  _MID;}set{ _MID = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _QUERY_STATE_NAME;
		[DataMember]
		public System.String  QUERY_STATE_NAME{get{ return  _QUERY_STATE_NAME;}set{ _QUERY_STATE_NAME = value;}}

		#endregion 
	}	
}
