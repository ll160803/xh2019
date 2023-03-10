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
	[DataObject("MDM_D_DEPT")]
	public partial class CauseObject_MDM_D_DEPT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _LAW_PERSON = string.Empty;
		[DataMember]
		public System.String  LAW_PERSON{get{ return  _LAW_PERSON;}set{ _LAW_PERSON = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _REGISTER_FUND = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REGISTER_FUND{get{ return  _REGISTER_FUND;}set{ _REGISTER_FUND = value;}}
		System.String _LINK_PERSON = string.Empty;
		[DataMember]
		public System.String  LINK_PERSON{get{ return  _LINK_PERSON;}set{ _LINK_PERSON = value;}}
		System.String _BANK_ADDRESS = string.Empty;
		[DataMember]
		public System.String  BANK_ADDRESS{get{ return  _BANK_ADDRESS;}set{ _BANK_ADDRESS = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _TAX_HEAD = string.Empty;
		[DataMember]
		public System.String  TAX_HEAD{get{ return  _TAX_HEAD;}set{ _TAX_HEAD = value;}}
		System.String _FAX = string.Empty;
		[DataMember]
		public System.String  FAX{get{ return  _FAX;}set{ _FAX = value;}}
		System.String _BALANCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  BALANCE_TYPE_ID{get{ return  _BALANCE_TYPE_ID;}set{ _BALANCE_TYPE_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _BANK_NAME = string.Empty;
		[DataMember]
		public System.String  BANK_NAME{get{ return  _BANK_NAME;}set{ _BANK_NAME = value;}}
		System.String _ADDRESS = string.Empty;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String _SERVICES = string.Empty;
		[DataMember]
		public System.String  SERVICES{get{ return  _SERVICES;}set{ _SERVICES = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _EMAIL = string.Empty;
		[DataMember]
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _URL = string.Empty;
		[DataMember]
		public System.String  URL{get{ return  _URL;}set{ _URL = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _PHONE = string.Empty;
		[DataMember]
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		System.String _BANK_NUMBER = string.Empty;
		[DataMember]
		public System.String  BANK_NUMBER{get{ return  _BANK_NUMBER;}set{ _BANK_NUMBER = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _TAX_NUMBER = string.Empty;
		[DataMember]
		public System.String  TAX_NUMBER{get{ return  _TAX_NUMBER;}set{ _TAX_NUMBER = value;}}
		System.String _DEPT_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_TYPE_ID{get{ return  _DEPT_TYPE_ID;}set{ _DEPT_TYPE_ID = value;}}
		System.String _SHORT_NAME = string.Empty;
		[DataMember]
		public System.String  SHORT_NAME{get{ return  _SHORT_NAME;}set{ _SHORT_NAME = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MDM_D_DEPT")]
	public partial class DisplayObject_MDM_D_DEPT:EntityObject_MDM_D_DEPT
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MDM_D_DEPT")]
	public partial class EntityObject_MDM_D_DEPT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _LAW_PERSON;
		[DataMember]
		public System.String  LAW_PERSON{get{ return  _LAW_PERSON;}set{ _LAW_PERSON = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _REGISTER_FUND;
		[DataMember]
		public System.Decimal  REGISTER_FUND{get{ return  _REGISTER_FUND;}set{ _REGISTER_FUND = value;}}
		System.String  _LINK_PERSON;
		[DataMember]
		public System.String  LINK_PERSON{get{ return  _LINK_PERSON;}set{ _LINK_PERSON = value;}}
		System.String  _BANK_ADDRESS;
		[DataMember]
		public System.String  BANK_ADDRESS{get{ return  _BANK_ADDRESS;}set{ _BANK_ADDRESS = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _TAX_HEAD;
		[DataMember]
		public System.String  TAX_HEAD{get{ return  _TAX_HEAD;}set{ _TAX_HEAD = value;}}
		System.String  _FAX;
		[DataMember]
		public System.String  FAX{get{ return  _FAX;}set{ _FAX = value;}}
		System.String  _BALANCE_TYPE_ID;
		[DataMember]
		public System.String  BALANCE_TYPE_ID{get{ return  _BALANCE_TYPE_ID;}set{ _BALANCE_TYPE_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _BANK_NAME;
		[DataMember]
		public System.String  BANK_NAME{get{ return  _BANK_NAME;}set{ _BANK_NAME = value;}}
		System.String  _ADDRESS;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}
		System.String  _SERVICES;
		[DataMember]
		public System.String  SERVICES{get{ return  _SERVICES;}set{ _SERVICES = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _EMAIL;
		[DataMember]
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _URL;
		[DataMember]
		public System.String  URL{get{ return  _URL;}set{ _URL = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _PHONE;
		[DataMember]
		public System.String  PHONE{get{ return  _PHONE;}set{ _PHONE = value;}}
		System.String  _BANK_NUMBER;
		[DataMember]
		public System.String  BANK_NUMBER{get{ return  _BANK_NUMBER;}set{ _BANK_NUMBER = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _TAX_NUMBER;
		[DataMember]
		public System.String  TAX_NUMBER{get{ return  _TAX_NUMBER;}set{ _TAX_NUMBER = value;}}
		System.String  _DEPT_TYPE_ID;
		[DataMember]
		public System.String  DEPT_TYPE_ID{get{ return  _DEPT_TYPE_ID;}set{ _DEPT_TYPE_ID = value;}}
		System.String  _SHORT_NAME;
		[DataMember]
		public System.String  SHORT_NAME{get{ return  _SHORT_NAME;}set{ _SHORT_NAME = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
