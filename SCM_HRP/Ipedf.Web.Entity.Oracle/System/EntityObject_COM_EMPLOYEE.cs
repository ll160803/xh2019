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
	[DataObject("COM_EMPLOYEE")]
	public partial class CauseObject_COM_EMPLOYEE:CauseBase
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有
		System.String _CREATE_DEPART_ID = string.Empty;
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		DateSpan _CREATE_TIME = null;
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _EMPLOYEE_ADDRESS = string.Empty;
		public System.String  EMPLOYEE_ADDRESS{get{ return  _EMPLOYEE_ADDRESS;}set{ _EMPLOYEE_ADDRESS = value;}}
		System.String _EMPLOYEE_COMMENT = string.Empty;
		public System.String  EMPLOYEE_COMMENT{get{ return  _EMPLOYEE_COMMENT;}set{ _EMPLOYEE_COMMENT = value;}}
		System.String _EMPLOYEE_DEPT_ID = string.Empty;
		public System.String  EMPLOYEE_DEPT_ID{get{ return  _EMPLOYEE_DEPT_ID;}set{ _EMPLOYEE_DEPT_ID = value;}}
		System.String _EMPLOYEE_MOBILE = string.Empty;
		public System.String  EMPLOYEE_MOBILE{get{ return  _EMPLOYEE_MOBILE;}set{ _EMPLOYEE_MOBILE = value;}}
		System.String _EMPLOYEE_NAME = string.Empty;
		public System.String  EMPLOYEE_NAME{get{ return  _EMPLOYEE_NAME;}set{ _EMPLOYEE_NAME = value;}}
		System.Decimal _EMPLOYEE_STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  EMPLOYEE_STATE{get{ return  _EMPLOYEE_STATE;}set{ _EMPLOYEE_STATE = value;}}
		DateSpan _ENTRY_DATE = null;
		public DateSpan  ENTRY_DATE{get{ return  _ENTRY_DATE;}set{ _ENTRY_DATE = value;}}
		DateSpan _EXIT_DATE = null;
		public DateSpan  EXIT_DATE{get{ return  _EXIT_DATE;}set{ _EXIT_DATE = value;}}
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_COM_EMPLOYEE:EntityObject_COM_EMPLOYEE
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有
		 System.String _COM_DEPART_NAME = string.Empty;
		public System.String COM_DEPART_NAME{get{ return  _COM_DEPART_NAME;}set{ _COM_DEPART_NAME = value;}}
		 System.String _EMPLOYEE_STATE_NAME = string.Empty;
		public System.String EMPLOYEE_STATE_NAME{get{ return  _EMPLOYEE_STATE_NAME;}set{ _EMPLOYEE_STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_COM_EMPLOYEE
	{
		#region Attribute Block:EntityBase
		
			//试用版本,平纹软件,版权所有
		System.String  _CREATE_DEPART_ID;
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.DateTime  _CREATE_TIME;
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _CREATE_USER_ID;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _EMPLOYEE_ADDRESS;
		public System.String  EMPLOYEE_ADDRESS{get{ return  _EMPLOYEE_ADDRESS;}set{ _EMPLOYEE_ADDRESS = value;}}
		System.String  _EMPLOYEE_COMMENT;
		public System.String  EMPLOYEE_COMMENT{get{ return  _EMPLOYEE_COMMENT;}set{ _EMPLOYEE_COMMENT = value;}}
		System.String  _EMPLOYEE_DEPT_ID;
		public System.String  EMPLOYEE_DEPT_ID{get{ return  _EMPLOYEE_DEPT_ID;}set{ _EMPLOYEE_DEPT_ID = value;}}
		System.String  _EMPLOYEE_MOBILE;
		public System.String  EMPLOYEE_MOBILE{get{ return  _EMPLOYEE_MOBILE;}set{ _EMPLOYEE_MOBILE = value;}}
		System.String  _EMPLOYEE_NAME;
		public System.String  EMPLOYEE_NAME{get{ return  _EMPLOYEE_NAME;}set{ _EMPLOYEE_NAME = value;}}
		System.Decimal  _EMPLOYEE_STATE;
		public System.Decimal  EMPLOYEE_STATE{get{ return  _EMPLOYEE_STATE;}set{ _EMPLOYEE_STATE = value;}}
		System.DateTime  _ENTRY_DATE;
		public System.DateTime  ENTRY_DATE{get{ return  _ENTRY_DATE;}set{ _ENTRY_DATE = value;}}
		System.DateTime  _EXIT_DATE;
		public System.DateTime  EXIT_DATE{get{ return  _EXIT_DATE;}set{ _EXIT_DATE = value;}}
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MODIFY_DEPART_ID;
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}

		#endregion 
	}	
}
