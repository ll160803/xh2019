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
	[DataObject("BGT_D_ACCOUNT_ITEM")]
	public partial class CauseObject_BGT_D_ACCOUNT_ITEM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _PROPERTY_ID = string.Empty;
		[DataMember]
		public System.String  PROPERTY_ID{get{ return  _PROPERTY_ID;}set{ _PROPERTY_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PARENT_ID = string.Empty;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _FULL_NAME = string.Empty;
		[DataMember]
		public System.String  FULL_NAME{get{ return  _FULL_NAME;}set{ _FULL_NAME = value;}}
		System.Decimal _IS_ASSSIST = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_ASSSIST{get{ return  _IS_ASSSIST;}set{ _IS_ASSSIST = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _DIRECTION_ID = string.Empty;
		[DataMember]
		public System.String  DIRECTION_ID{get{ return  _DIRECTION_ID;}set{ _DIRECTION_ID = value;}}
		System.String _IS_END = string.Empty;
		[DataMember]
		public System.String  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String _ITEM_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.Decimal _IS_CASH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CASH{get{ return  _IS_CASH;}set{ _IS_CASH = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_ACCOUNT_ITEM")]
	public partial class DisplayObject_BGT_D_ACCOUNT_ITEM:EntityObject_BGT_D_ACCOUNT_ITEM
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PROPERTY_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROPERTY_ID_NAME{get{ return  _PROPERTY_ID_NAME;}set{ _PROPERTY_ID_NAME = value;}}
		 System.String _PARENT_ID_NAME = string.Empty;
		[DataMember]
		public System.String PARENT_ID_NAME{get{ return  _PARENT_ID_NAME;}set{ _PARENT_ID_NAME = value;}}
		 System.String _IS_ASSSIST_NAME = string.Empty;
		[DataMember]
		public System.String IS_ASSSIST_NAME{get{ return  _IS_ASSSIST_NAME;}set{ _IS_ASSSIST_NAME = value;}}
		 System.String _DIRECTION_ID_NAME = string.Empty;
		[DataMember]
		public System.String DIRECTION_ID_NAME{get{ return  _DIRECTION_ID_NAME;}set{ _DIRECTION_ID_NAME = value;}}
		 System.String _IS_END_NAME = string.Empty;
		[DataMember]
		public System.String IS_END_NAME{get{ return  _IS_END_NAME;}set{ _IS_END_NAME = value;}}
		 System.String _ITEM_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_TYPE_ID_NAME{get{ return  _ITEM_TYPE_ID_NAME;}set{ _ITEM_TYPE_ID_NAME = value;}}
		 System.String _IS_CASH_NAME = string.Empty;
		[DataMember]
		public System.String IS_CASH_NAME{get{ return  _IS_CASH_NAME;}set{ _IS_CASH_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_ACCOUNT_ITEM")]
	public partial class EntityObject_BGT_D_ACCOUNT_ITEM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _PROPERTY_ID;
		[DataMember]
		public System.String  PROPERTY_ID{get{ return  _PROPERTY_ID;}set{ _PROPERTY_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PARENT_ID;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _FULL_NAME;
		[DataMember]
		public System.String  FULL_NAME{get{ return  _FULL_NAME;}set{ _FULL_NAME = value;}}
		System.Decimal  _IS_ASSSIST;
		[DataMember]
		public System.Decimal  IS_ASSSIST{get{ return  _IS_ASSSIST;}set{ _IS_ASSSIST = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _DIRECTION_ID;
		[DataMember]
		public System.String  DIRECTION_ID{get{ return  _DIRECTION_ID;}set{ _DIRECTION_ID = value;}}
		System.String  _IS_END;
		[DataMember]
		public System.String  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String  _ITEM_TYPE_ID;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.Decimal  _IS_CASH;
		[DataMember]
		public System.Decimal  IS_CASH{get{ return  _IS_CASH;}set{ _IS_CASH = value;}}

		#endregion 
	}	
}
