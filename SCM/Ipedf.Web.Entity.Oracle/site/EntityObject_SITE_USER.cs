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
	[DataObject("SITE_USER")]
	public partial class CauseObject_SITE_USER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _QUESTION = string.Empty;
		public System.String  QUESTION{get{ return  _QUESTION;}set{ _QUESTION = value;}}
		System.String _IDENTITY_NUMBER = string.Empty;
		public System.String  IDENTITY_NUMBER{get{ return  _IDENTITY_NUMBER;}set{ _IDENTITY_NUMBER = value;}}
		System.String _ANSWER = string.Empty;
		public System.String  ANSWER{get{ return  _ANSWER;}set{ _ANSWER = value;}}
		System.String _TYPE = string.Empty;
		public System.String  TYPE{get{ return  _TYPE;}set{ _TYPE = value;}}
		System.String _NICKNAME = string.Empty;
		public System.String  NICKNAME{get{ return  _NICKNAME;}set{ _NICKNAME = value;}}
		System.String _POST_CODE = string.Empty;
		public System.String  POST_CODE{get{ return  _POST_CODE;}set{ _POST_CODE = value;}}
		System.Decimal _VALUE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  VALUE{get{ return  _VALUE;}set{ _VALUE = value;}}
		System.String _EMAIL = string.Empty;
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}
		System.String _NAME = string.Empty;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _U_PWD = string.Empty;
		public System.String  U_PWD{get{ return  _U_PWD;}set{ _U_PWD = value;}}
		System.String _ADDRESS = string.Empty;
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String _U_NAME = string.Empty;
		public System.String  U_NAME{get{ return  _U_NAME;}set{ _U_NAME = value;}}
		System.String _PHONE = string.Empty;
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		DateSpan _REGISTER_DATE = null;
		public DateSpan  REGISTER_DATE{get{ return  _REGISTER_DATE;}set{ _REGISTER_DATE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_USER")]
	public partial class DisplayObject_SITE_USER:EntityObject_SITE_USER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_TYPE_NAME = string.Empty;
		public System.String COM_TYPE_NAME{get{ return  _COM_TYPE_NAME;}set{ _COM_TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_USER")]
	public partial class EntityObject_SITE_USER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _QUESTION;
		public System.String  QUESTION{get{ return  _QUESTION;}set{ _QUESTION = value;}}
		System.String  _IDENTITY_NUMBER;
		public System.String  IDENTITY_NUMBER{get{ return  _IDENTITY_NUMBER;}set{ _IDENTITY_NUMBER = value;}}
		System.String  _ANSWER;
		public System.String  ANSWER{get{ return  _ANSWER;}set{ _ANSWER = value;}}
		System.String  _TYPE;
		public System.String  TYPE{get{ return  _TYPE;}set{ _TYPE = value;}}
		System.String  _NICKNAME;
		public System.String  NICKNAME{get{ return  _NICKNAME;}set{ _NICKNAME = value;}}
		System.String  _POST_CODE;
		public System.String  POST_CODE{get{ return  _POST_CODE;}set{ _POST_CODE = value;}}
		System.Decimal  _VALUE;
		public System.Decimal  VALUE{get{ return  _VALUE;}set{ _VALUE = value;}}
		System.String  _EMAIL;
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}
		System.String  _NAME;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _U_PWD;
		public System.String  U_PWD{get{ return  _U_PWD;}set{ _U_PWD = value;}}
		System.String  _ADDRESS;
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String  _U_NAME;
		public System.String  U_NAME{get{ return  _U_NAME;}set{ _U_NAME = value;}}
		System.String  _PHONE;
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		System.DateTime  _REGISTER_DATE;
		public System.DateTime  REGISTER_DATE{get{ return  _REGISTER_DATE;}set{ _REGISTER_DATE = value;}}

		#endregion 
	}	
}
