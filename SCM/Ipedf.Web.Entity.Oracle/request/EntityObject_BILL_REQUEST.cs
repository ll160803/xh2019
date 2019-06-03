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
	[DataObject("BILL_REQUEST")]
	public partial class CauseObject_BILL_REQUEST:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _RECEIVE_DEPT_ADDRESS = string.Empty;
		public System.String  RECEIVE_DEPT_ADDRESS{get{ return  _RECEIVE_DEPT_ADDRESS;}set{ _RECEIVE_DEPT_ADDRESS = value;}}
		System.String _RECEIVE_DEPT_ADDRESS_ID = string.Empty;
		public System.String  RECEIVE_DEPT_ADDRESS_ID{get{ return  _RECEIVE_DEPT_ADDRESS_ID;}set{ _RECEIVE_DEPT_ADDRESS_ID = value;}}
		System.Decimal _IS_COLLECTION_PAYMENT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  IS_COLLECTION_PAYMENT{get{ return  _IS_COLLECTION_PAYMENT;}set{ _IS_COLLECTION_PAYMENT = value;}}
		DateSpan _CREATE_TIME = null;
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _RECEIVE_DEPT_ID = string.Empty;
		public System.String  RECEIVE_DEPT_ID{get{ return  _RECEIVE_DEPT_ID;}set{ _RECEIVE_DEPT_ID = value;}}
		System.String _REQUEST_BILL_TYPE_ID = string.Empty;
		public System.String  REQUEST_BILL_TYPE_ID{get{ return  _REQUEST_BILL_TYPE_ID;}set{ _REQUEST_BILL_TYPE_ID = value;}}
		System.String _SEND_DEPT_ID = string.Empty;
		public System.String  SEND_DEPT_ID{get{ return  _SEND_DEPT_ID;}set{ _SEND_DEPT_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal _TOTAL_MONEY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.String _REQUEST_SOURCE_TYPE_ID = string.Empty;
		public System.String  REQUEST_SOURCE_TYPE_ID{get{ return  _REQUEST_SOURCE_TYPE_ID;}set{ _REQUEST_SOURCE_TYPE_ID = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _COLLECTION_PAYMENT_TYPE_ID = string.Empty;
		public System.String  COLLECTION_PAYMENT_TYPE_ID{get{ return  _COLLECTION_PAYMENT_TYPE_ID;}set{ _COLLECTION_PAYMENT_TYPE_ID = value;}}
		System.Decimal _COLLECTION_PAYMENT_MONEY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  COLLECTION_PAYMENT_MONEY{get{ return  _COLLECTION_PAYMENT_MONEY;}set{ _COLLECTION_PAYMENT_MONEY = value;}}
		System.String _CARRIER_ID = string.Empty;
		public System.String  CARRIER_ID{get{ return  _CARRIER_ID;}set{ _CARRIER_ID = value;}}
		System.Decimal _TOTAL_VOLUME = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_VOLUME{get{ return  _TOTAL_VOLUME;}set{ _TOTAL_VOLUME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal _TOTAL_TYPE_ITEMS = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_TYPE_ITEMS{get{ return  _TOTAL_TYPE_ITEMS;}set{ _TOTAL_TYPE_ITEMS = value;}}
		System.String _REF_TAB_ID = string.Empty;
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _SEND_DEPT_PHONE = string.Empty;
		public System.String  SEND_DEPT_PHONE{get{ return  _SEND_DEPT_PHONE;}set{ _SEND_DEPT_PHONE = value;}}
		System.String _CARRY_FEE_TYPE_ID = string.Empty;
		public System.String  CARRY_FEE_TYPE_ID{get{ return  _CARRY_FEE_TYPE_ID;}set{ _CARRY_FEE_TYPE_ID = value;}}
		DateSpan _CREATE_DATE = null;
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal _TOTAL_NET_WEIGHT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_NET_WEIGHT{get{ return  _TOTAL_NET_WEIGHT;}set{ _TOTAL_NET_WEIGHT = value;}}
		DateSpan _MODIFY_TIME = null;
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _SEND_DEPT_ADDRESS = string.Empty;
		public System.String  SEND_DEPT_ADDRESS{get{ return  _SEND_DEPT_ADDRESS;}set{ _SEND_DEPT_ADDRESS = value;}}
		System.String _SEND_DEPT_LINK_PERSON = string.Empty;
		public System.String  SEND_DEPT_LINK_PERSON{get{ return  _SEND_DEPT_LINK_PERSON;}set{ _SEND_DEPT_LINK_PERSON = value;}}
		System.String _REQUEST_DEPT_ID = string.Empty;
		public System.String  REQUEST_DEPT_ID{get{ return  _REQUEST_DEPT_ID;}set{ _REQUEST_DEPT_ID = value;}}
		System.Decimal _TOTAL_WEIGHT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_WEIGHT{get{ return  _TOTAL_WEIGHT;}set{ _TOTAL_WEIGHT = value;}}
		DateSpan _PLAN_RECEIVE_DATE = null;
		public DateSpan  PLAN_RECEIVE_DATE{get{ return  _PLAN_RECEIVE_DATE;}set{ _PLAN_RECEIVE_DATE = value;}}
		System.Decimal _IS_EMERGENCY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  IS_EMERGENCY{get{ return  _IS_EMERGENCY;}set{ _IS_EMERGENCY = value;}}
		System.Decimal _TOTAL_ITEMS = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  TOTAL_ITEMS{get{ return  _TOTAL_ITEMS;}set{ _TOTAL_ITEMS = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _RECEIVE_DEPT_PHONE = string.Empty;
		public System.String  RECEIVE_DEPT_PHONE{get{ return  _RECEIVE_DEPT_PHONE;}set{ _RECEIVE_DEPT_PHONE = value;}}
		System.String _COMMENTS = string.Empty;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _OWNER_ID = string.Empty;
		public System.String  OWNER_ID{get{ return  _OWNER_ID;}set{ _OWNER_ID = value;}}
		System.Decimal _EXEC_STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  EXEC_STATE{get{ return  _EXEC_STATE;}set{ _EXEC_STATE = value;}}
		System.String _CODE = string.Empty;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _EXEC_DESC = string.Empty;
		public System.String  EXEC_DESC{get{ return  _EXEC_DESC;}set{ _EXEC_DESC = value;}}
		System.String _SEND_DEPT_ADDRESS_ID = string.Empty;
		public System.String  SEND_DEPT_ADDRESS_ID{get{ return  _SEND_DEPT_ADDRESS_ID;}set{ _SEND_DEPT_ADDRESS_ID = value;}}
		System.String _RECEIVE_DEPT_LINK_PERSON = string.Empty;
		public System.String  RECEIVE_DEPT_LINK_PERSON{get{ return  _RECEIVE_DEPT_LINK_PERSON;}set{ _RECEIVE_DEPT_LINK_PERSON = value;}}
		System.String _CARRY_TYPE_ID = string.Empty;
		public System.String  CARRY_TYPE_ID{get{ return  _CARRY_TYPE_ID;}set{ _CARRY_TYPE_ID = value;}}
		System.String _OWNER_COMMAND = string.Empty;
		public System.String  OWNER_COMMAND{get{ return  _OWNER_COMMAND;}set{ _OWNER_COMMAND = value;}}
		System.String _REQUEST_TYPE_ID = string.Empty;
		public System.String  REQUEST_TYPE_ID{get{ return  _REQUEST_TYPE_ID;}set{ _REQUEST_TYPE_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("BILL_REQUEST")]
	public partial class DisplayObject_BILL_REQUEST:EntityObject_BILL_REQUEST
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _DICT_DEPT_DETAIL_ADDRESS = string.Empty;
		public System.String DICT_DEPT_DETAIL_ADDRESS{get{ return  _DICT_DEPT_DETAIL_ADDRESS;}set{ _DICT_DEPT_DETAIL_ADDRESS = value;}}
		 System.String _IS_COLLECTION_PAYMENT_NAME = string.Empty;
		public System.String IS_COLLECTION_PAYMENT_NAME{get{ return  _IS_COLLECTION_PAYMENT_NAME;}set{ _IS_COLLECTION_PAYMENT_NAME = value;}}
		 System.String _DICT_DEPT_NAME = string.Empty;
		public System.String DICT_DEPT_NAME{get{ return  _DICT_DEPT_NAME;}set{ _DICT_DEPT_NAME = value;}}
		 System.String _COM_TYPE_NAME = string.Empty;
		public System.String COM_TYPE_NAME{get{ return  _COM_TYPE_NAME;}set{ _COM_TYPE_NAME = value;}}
		 System.String _DICT_DEPT_NAME_1 = string.Empty;
		public System.String DICT_DEPT_NAME_1{get{ return  _DICT_DEPT_NAME_1;}set{ _DICT_DEPT_NAME_1 = value;}}
		 System.String _COM_TYPE_NAME_1 = string.Empty;
		public System.String COM_TYPE_NAME_1{get{ return  _COM_TYPE_NAME_1;}set{ _COM_TYPE_NAME_1 = value;}}
		 System.String _COM_TYPE_NAME_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1{get{ return  _COM_TYPE_NAME_1_1;}set{ _COM_TYPE_NAME_1_1 = value;}}
		 System.String _DICT_DEPT_NAME_1_1 = string.Empty;
		public System.String DICT_DEPT_NAME_1_1{get{ return  _DICT_DEPT_NAME_1_1;}set{ _DICT_DEPT_NAME_1_1 = value;}}
		 System.String _STATE_NAME = string.Empty;
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _COM_TYPE_NAME_1_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1_1{get{ return  _COM_TYPE_NAME_1_1_1;}set{ _COM_TYPE_NAME_1_1_1 = value;}}
		 System.String _DICT_DEPT_NAME_1_1_1 = string.Empty;
		public System.String DICT_DEPT_NAME_1_1_1{get{ return  _DICT_DEPT_NAME_1_1_1;}set{ _DICT_DEPT_NAME_1_1_1 = value;}}
		 System.String _IS_EMERGENCY_NAME = string.Empty;
		public System.String IS_EMERGENCY_NAME{get{ return  _IS_EMERGENCY_NAME;}set{ _IS_EMERGENCY_NAME = value;}}
		 System.String _DICT_DEPT_NAME_1_1_1_1 = string.Empty;
		public System.String DICT_DEPT_NAME_1_1_1_1{get{ return  _DICT_DEPT_NAME_1_1_1_1;}set{ _DICT_DEPT_NAME_1_1_1_1 = value;}}
		 System.String _DICT_DEPT_DETAIL_ADDRESS_1 = string.Empty;
		public System.String DICT_DEPT_DETAIL_ADDRESS_1{get{ return  _DICT_DEPT_DETAIL_ADDRESS_1;}set{ _DICT_DEPT_DETAIL_ADDRESS_1 = value;}}
		 System.String _COM_TYPE_NAME_1_1_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1_1_1{get{ return  _COM_TYPE_NAME_1_1_1_1;}set{ _COM_TYPE_NAME_1_1_1_1 = value;}}
		 System.String _COM_TYPE_NAME_1_1_1_1_1 = string.Empty;
		public System.String COM_TYPE_NAME_1_1_1_1_1{get{ return  _COM_TYPE_NAME_1_1_1_1_1;}set{ _COM_TYPE_NAME_1_1_1_1_1 = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("BILL_REQUEST")]
	public partial class EntityObject_BILL_REQUEST:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _RECEIVE_DEPT_ADDRESS;
		public System.String  RECEIVE_DEPT_ADDRESS{get{ return  _RECEIVE_DEPT_ADDRESS;}set{ _RECEIVE_DEPT_ADDRESS = value;}}
		System.String  _RECEIVE_DEPT_ADDRESS_ID;
		public System.String  RECEIVE_DEPT_ADDRESS_ID{get{ return  _RECEIVE_DEPT_ADDRESS_ID;}set{ _RECEIVE_DEPT_ADDRESS_ID = value;}}
		System.Decimal  _IS_COLLECTION_PAYMENT;
		public System.Decimal  IS_COLLECTION_PAYMENT{get{ return  _IS_COLLECTION_PAYMENT;}set{ _IS_COLLECTION_PAYMENT = value;}}
		System.DateTime  _CREATE_TIME;
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _RECEIVE_DEPT_ID;
		public System.String  RECEIVE_DEPT_ID{get{ return  _RECEIVE_DEPT_ID;}set{ _RECEIVE_DEPT_ID = value;}}
		System.String  _REQUEST_BILL_TYPE_ID;
		public System.String  REQUEST_BILL_TYPE_ID{get{ return  _REQUEST_BILL_TYPE_ID;}set{ _REQUEST_BILL_TYPE_ID = value;}}
		System.String  _SEND_DEPT_ID;
		public System.String  SEND_DEPT_ID{get{ return  _SEND_DEPT_ID;}set{ _SEND_DEPT_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal  _TOTAL_MONEY;
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.String  _REQUEST_SOURCE_TYPE_ID;
		public System.String  REQUEST_SOURCE_TYPE_ID{get{ return  _REQUEST_SOURCE_TYPE_ID;}set{ _REQUEST_SOURCE_TYPE_ID = value;}}
		System.String  _REF_TAB_NAME;
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _COLLECTION_PAYMENT_TYPE_ID;
		public System.String  COLLECTION_PAYMENT_TYPE_ID{get{ return  _COLLECTION_PAYMENT_TYPE_ID;}set{ _COLLECTION_PAYMENT_TYPE_ID = value;}}
		System.Decimal  _COLLECTION_PAYMENT_MONEY;
		public System.Decimal  COLLECTION_PAYMENT_MONEY{get{ return  _COLLECTION_PAYMENT_MONEY;}set{ _COLLECTION_PAYMENT_MONEY = value;}}
		System.String  _CARRIER_ID;
		public System.String  CARRIER_ID{get{ return  _CARRIER_ID;}set{ _CARRIER_ID = value;}}
		System.Decimal  _TOTAL_VOLUME;
		public System.Decimal  TOTAL_VOLUME{get{ return  _TOTAL_VOLUME;}set{ _TOTAL_VOLUME = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal  _TOTAL_TYPE_ITEMS;
		public System.Decimal  TOTAL_TYPE_ITEMS{get{ return  _TOTAL_TYPE_ITEMS;}set{ _TOTAL_TYPE_ITEMS = value;}}
		System.String  _REF_TAB_ID;
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _STATE;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _SEND_DEPT_PHONE;
		public System.String  SEND_DEPT_PHONE{get{ return  _SEND_DEPT_PHONE;}set{ _SEND_DEPT_PHONE = value;}}
		System.String  _CARRY_FEE_TYPE_ID;
		public System.String  CARRY_FEE_TYPE_ID{get{ return  _CARRY_FEE_TYPE_ID;}set{ _CARRY_FEE_TYPE_ID = value;}}
		System.DateTime  _CREATE_DATE;
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal  _TOTAL_NET_WEIGHT;
		public System.Decimal  TOTAL_NET_WEIGHT{get{ return  _TOTAL_NET_WEIGHT;}set{ _TOTAL_NET_WEIGHT = value;}}
		System.DateTime  _MODIFY_TIME;
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _SEND_DEPT_ADDRESS;
		public System.String  SEND_DEPT_ADDRESS{get{ return  _SEND_DEPT_ADDRESS;}set{ _SEND_DEPT_ADDRESS = value;}}
		System.String  _SEND_DEPT_LINK_PERSON;
		public System.String  SEND_DEPT_LINK_PERSON{get{ return  _SEND_DEPT_LINK_PERSON;}set{ _SEND_DEPT_LINK_PERSON = value;}}
		System.String  _REQUEST_DEPT_ID;
		public System.String  REQUEST_DEPT_ID{get{ return  _REQUEST_DEPT_ID;}set{ _REQUEST_DEPT_ID = value;}}
		System.Decimal  _TOTAL_WEIGHT;
		public System.Decimal  TOTAL_WEIGHT{get{ return  _TOTAL_WEIGHT;}set{ _TOTAL_WEIGHT = value;}}
		System.DateTime  _PLAN_RECEIVE_DATE;
		public System.DateTime  PLAN_RECEIVE_DATE{get{ return  _PLAN_RECEIVE_DATE;}set{ _PLAN_RECEIVE_DATE = value;}}
		System.Decimal  _IS_EMERGENCY;
		public System.Decimal  IS_EMERGENCY{get{ return  _IS_EMERGENCY;}set{ _IS_EMERGENCY = value;}}
		System.Decimal  _TOTAL_ITEMS;
		public System.Decimal  TOTAL_ITEMS{get{ return  _TOTAL_ITEMS;}set{ _TOTAL_ITEMS = value;}}
		System.String  _MODIFY_DEPT_ID;
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _MODIFY_USER_ID;
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _RECEIVE_DEPT_PHONE;
		public System.String  RECEIVE_DEPT_PHONE{get{ return  _RECEIVE_DEPT_PHONE;}set{ _RECEIVE_DEPT_PHONE = value;}}
		System.String  _COMMENTS;
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _OWNER_ID;
		public System.String  OWNER_ID{get{ return  _OWNER_ID;}set{ _OWNER_ID = value;}}
		System.Decimal  _EXEC_STATE;
		public System.Decimal  EXEC_STATE{get{ return  _EXEC_STATE;}set{ _EXEC_STATE = value;}}
		System.String  _CODE;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _CREATE_USER_ID;
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _EXEC_DESC;
		public System.String  EXEC_DESC{get{ return  _EXEC_DESC;}set{ _EXEC_DESC = value;}}
		System.String  _SEND_DEPT_ADDRESS_ID;
		public System.String  SEND_DEPT_ADDRESS_ID{get{ return  _SEND_DEPT_ADDRESS_ID;}set{ _SEND_DEPT_ADDRESS_ID = value;}}
		System.String  _RECEIVE_DEPT_LINK_PERSON;
		public System.String  RECEIVE_DEPT_LINK_PERSON{get{ return  _RECEIVE_DEPT_LINK_PERSON;}set{ _RECEIVE_DEPT_LINK_PERSON = value;}}
		System.String  _CARRY_TYPE_ID;
		public System.String  CARRY_TYPE_ID{get{ return  _CARRY_TYPE_ID;}set{ _CARRY_TYPE_ID = value;}}
		System.String  _OWNER_COMMAND;
		public System.String  OWNER_COMMAND{get{ return  _OWNER_COMMAND;}set{ _OWNER_COMMAND = value;}}
		System.String  _REQUEST_TYPE_ID;
		public System.String  REQUEST_TYPE_ID{get{ return  _REQUEST_TYPE_ID;}set{ _REQUEST_TYPE_ID = value;}}

		#endregion 
	}	
}
