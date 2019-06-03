using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("BILL_WORK_FLOW")]
	public partial class CauseObject_BILL_WORK_FLOW:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _CREATE_TIME = null;
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _NEXT_BILL_ID = string.Empty;
		public System.String  NEXT_BILL_ID{get{ return  _NEXT_BILL_ID;}set{ _NEXT_BILL_ID = value;}}
		System.String _BILL_ID = string.Empty;
		public System.String  BILL_ID{get{ return  _BILL_ID;}set{ _BILL_ID = value;}}
		System.Decimal _BILL_STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  BILL_STATE{get{ return  _BILL_STATE;}set{ _BILL_STATE = value;}}
		System.String _NEXT_BILL_NAME = string.Empty;
		public System.String  NEXT_BILL_NAME{get{ return  _NEXT_BILL_NAME;}set{ _NEXT_BILL_NAME = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _BILL_CODE = string.Empty;
		public System.String  BILL_CODE{get{ return  _BILL_CODE;}set{ _BILL_CODE = value;}}
		System.Decimal _BILL_OPT_COUNTER = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  BILL_OPT_COUNTER{get{ return  _BILL_OPT_COUNTER;}set{ _BILL_OPT_COUNTER = value;}}
		System.String _BILL_MSG = string.Empty;
		public System.String  BILL_MSG{get{ return  _BILL_MSG;}set{ _BILL_MSG = value;}}
		System.String _COMMENTS = string.Empty;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _BILL_NAME = string.Empty;
		public System.String  BILL_NAME{get{ return  _BILL_NAME;}set{ _BILL_NAME = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _BILL_TYPE = string.Empty;
		public System.String  BILL_TYPE{get{ return  _BILL_TYPE;}set{ _BILL_TYPE = value;}}
		System.String _NEXT_BILL_CODE = string.Empty;
		public System.String  NEXT_BILL_CODE{get{ return  _NEXT_BILL_CODE;}set{ _NEXT_BILL_CODE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("BILL_WORK_FLOW")]
	public partial class DisplayObject_BILL_WORK_FLOW:EntityObject_BILL_WORK_FLOW
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_DEPART_NAME = string.Empty;
		public System.String COM_DEPART_NAME{get{ return  _COM_DEPART_NAME;}set{ _COM_DEPART_NAME = value;}}
		 System.String _COM_USER_NAME = string.Empty;
		public System.String COM_USER_NAME{get{ return  _COM_USER_NAME;}set{ _COM_USER_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("BILL_WORK_FLOW")]
	public partial class EntityObject_BILL_WORK_FLOW:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _CREATE_TIME;
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _NEXT_BILL_ID;
		public System.String  NEXT_BILL_ID{get{ return  _NEXT_BILL_ID;}set{ _NEXT_BILL_ID = value;}}
		System.String  _BILL_ID;
		public System.String  BILL_ID{get{ return  _BILL_ID;}set{ _BILL_ID = value;}}
		System.Decimal  _BILL_STATE;
		public System.Decimal  BILL_STATE{get{ return  _BILL_STATE;}set{ _BILL_STATE = value;}}
		System.String  _NEXT_BILL_NAME;
		public System.String  NEXT_BILL_NAME{get{ return  _NEXT_BILL_NAME;}set{ _NEXT_BILL_NAME = value;}}
		System.String  _CREATE_DEPT_ID;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _BILL_CODE;
		public System.String  BILL_CODE{get{ return  _BILL_CODE;}set{ _BILL_CODE = value;}}
		System.Decimal  _BILL_OPT_COUNTER;
		public System.Decimal  BILL_OPT_COUNTER{get{ return  _BILL_OPT_COUNTER;}set{ _BILL_OPT_COUNTER = value;}}
		System.String  _BILL_MSG;
		public System.String  BILL_MSG{get{ return  _BILL_MSG;}set{ _BILL_MSG = value;}}
		System.String  _COMMENTS;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _BILL_NAME;
		public System.String  BILL_NAME{get{ return  _BILL_NAME;}set{ _BILL_NAME = value;}}
		System.String  _CREATE_USER_ID;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _BILL_TYPE;
		public System.String  BILL_TYPE{get{ return  _BILL_TYPE;}set{ _BILL_TYPE = value;}}
		System.String  _NEXT_BILL_CODE;
		public System.String  NEXT_BILL_CODE{get{ return  _NEXT_BILL_CODE;}set{ _NEXT_BILL_CODE = value;}}

		#endregion 
	}	
}
