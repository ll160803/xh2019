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
	[DataObject("SCM_B_SENDINFO")]
	public partial class CauseObject_SCM_B_SENDINFO:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _LINK_PERSON = string.Empty;
		[DataMember]
		public System.String  LINK_PERSON{get{ return  _LINK_PERSON;}set{ _LINK_PERSON = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _MATER_CODE = string.Empty;
		[DataMember]
		public System.String  MATER_CODE{get{ return  _MATER_CODE;}set{ _MATER_CODE = value;}}
		System.String _SEND_DEPART = string.Empty;
		[DataMember]
		public System.String  SEND_DEPART{get{ return  _SEND_DEPART;}set{ _SEND_DEPART = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.String _LINK_TELEPHONE = string.Empty;
		[DataMember]
		public System.String  LINK_TELEPHONE{get{ return  _LINK_TELEPHONE;}set{ _LINK_TELEPHONE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _MSEHT = string.Empty;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _MEINS = string.Empty;
		[DataMember]
		public System.String  MEINS{get{ return  _MEINS;}set{ _MEINS = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_SENDINFO")]
	public partial class DisplayObject_SCM_B_SENDINFO:EntityObject_SCM_B_SENDINFO
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SEND_DEPART_NAME = string.Empty;
		[DataMember]
		public System.String SEND_DEPART_NAME{get{ return  _SEND_DEPART_NAME;}set{ _SEND_DEPART_NAME = value;}}
        System.String _WERKS = string.Empty;
        [DataMember]
        public System.String WERKS { get { return _WERKS; } set { _WERKS = value; } }
        System.String _WERKST = string.Empty;
        [DataMember]
        public System.String WERKST { get { return _WERKST; } set { _WERKST = value; } }

		#endregion 
	}
}
