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
	[DataObject("SCM_B_QUERYPRICE")]
	public partial class CauseObject_SCM_B_QUERYPRICE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _MSEHT = string.Empty;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _QUERY_STATE = string.Empty;
		[DataMember]
		public System.String  QUERY_STATE{get{ return  _QUERY_STATE;}set{ _QUERY_STATE = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _MATNR_ID = string.Empty;
		[DataMember]
		public System.String  MATNR_ID{get{ return  _MATNR_ID;}set{ _MATNR_ID = value;}}
		DateSpan _END_DATE = null;
		[DataMember]
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _ADJUSTPRICE_ID = string.Empty;
		[DataMember]
		public System.String  ADJUSTPRICE_ID{get{ return  _ADJUSTPRICE_ID;}set{ _ADJUSTPRICE_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _QUERY_TYPE = string.Empty;
		[DataMember]
		public System.String  QUERY_TYPE{get{ return  _QUERY_TYPE;}set{ _QUERY_TYPE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MATNR = string.Empty;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String _TXZ01 = string.Empty;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _QUERY_DATE = null;
		[DataMember]
		public DateSpan  QUERY_DATE{get{ return  _QUERY_DATE;}set{ _QUERY_DATE = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUERYPRICE")]
	public partial class DisplayObject_SCM_B_QUERYPRICE:EntityObject_SCM_B_QUERYPRICE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _QUERY_STATE_NAME = string.Empty;
		[DataMember]
		public System.String QUERY_STATE_NAME{get{ return  _QUERY_STATE_NAME;}set{ _QUERY_STATE_NAME = value;}}
		 System.String _DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_ID_NAME{get{ return  _DEPT_ID_NAME;}set{ _DEPT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _QUERY_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String QUERY_TYPE_NAME{get{ return  _QUERY_TYPE_NAME;}set{ _QUERY_TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUERYPRICE")]
	public partial class EntityObject_SCM_B_QUERYPRICE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _MSEHT;
		[DataMember]
		public System.String  MSEHT{get{ return  _MSEHT;}set{ _MSEHT = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _QUERY_STATE;
		[DataMember]
		public System.String  QUERY_STATE{get{ return  _QUERY_STATE;}set{ _QUERY_STATE = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _MATNR_ID;
		[DataMember]
		public System.String  MATNR_ID{get{ return  _MATNR_ID;}set{ _MATNR_ID = value;}}
		System.DateTime  _END_DATE;
		[DataMember]
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _ADJUSTPRICE_ID;
		[DataMember]
		public System.String  ADJUSTPRICE_ID{get{ return  _ADJUSTPRICE_ID;}set{ _ADJUSTPRICE_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _QUERY_TYPE;
		[DataMember]
		public System.String  QUERY_TYPE{get{ return  _QUERY_TYPE;}set{ _QUERY_TYPE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MATNR;
		[DataMember]
		public System.String  MATNR{get{ return  _MATNR;}set{ _MATNR = value;}}
		System.String  _TXZ01;
		[DataMember]
		public System.String  TXZ01{get{ return  _TXZ01;}set{ _TXZ01 = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _QUERY_DATE;
		[DataMember]
		public System.DateTime  QUERY_DATE{get{ return  _QUERY_DATE;}set{ _QUERY_DATE = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}

		#endregion 
	}	
}
