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
	[DataObject("BGT_B_DEPT_EXPENSE")]
	public partial class CauseObject_BGT_B_DEPT_EXPENSE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _APPLY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _SUMARRY = string.Empty;
		[DataMember]
		public System.String  SUMARRY{get{ return  _SUMARRY;}set{ _SUMARRY = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _INSTANCE_ID = string.Empty;
		[DataMember]
		public System.String  INSTANCE_ID{get{ return  _INSTANCE_ID;}set{ _INSTANCE_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _FINANCE_CYCLE = string.Empty;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		DateSpan _PAY_DATE = null;
		[DataMember]
		public DateSpan  PAY_DATE{get{ return  _PAY_DATE;}set{ _PAY_DATE = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String _PAY_USER_ID = string.Empty;
		[DataMember]
		public System.String  PAY_USER_ID{get{ return  _PAY_USER_ID;}set{ _PAY_USER_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _APPLY_DATE = null;
		[DataMember]
		public DateSpan  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _PAY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PAY_MONEY{get{ return  _PAY_MONEY;}set{ _PAY_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_EXPENSE")]
	public partial class DisplayObject_BGT_B_DEPT_EXPENSE:EntityObject_BGT_B_DEPT_EXPENSE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _APPLY_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_DEPT_ID_NAME{get{ return  _APPLY_DEPT_ID_NAME;}set{ _APPLY_DEPT_ID_NAME = value;}}
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _PAY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String PAY_USER_ID_NAME{get{ return  _PAY_USER_ID_NAME;}set{ _PAY_USER_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_EXPENSE")]
	public partial class EntityObject_BGT_B_DEPT_EXPENSE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _APPLY_DEPT_ID;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _SUMARRY;
		[DataMember]
		public System.String  SUMARRY{get{ return  _SUMARRY;}set{ _SUMARRY = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _INSTANCE_ID;
		[DataMember]
		public System.String  INSTANCE_ID{get{ return  _INSTANCE_ID;}set{ _INSTANCE_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _FINANCE_CYCLE;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.DateTime  _PAY_DATE;
		[DataMember]
		public System.DateTime  PAY_DATE{get{ return  _PAY_DATE;}set{ _PAY_DATE = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String  _PAY_USER_ID;
		[DataMember]
		public System.String  PAY_USER_ID{get{ return  _PAY_USER_ID;}set{ _PAY_USER_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _APPLY_DATE;
		[DataMember]
		public System.DateTime  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _PAY_MONEY;
		[DataMember]
		public System.Decimal  PAY_MONEY{get{ return  _PAY_MONEY;}set{ _PAY_MONEY = value;}}

		#endregion 
	}	
}
