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
	[DataObject("BGT_B_CPN_INC_PROJECT")]
	public partial class CauseObject_BGT_B_CPN_INC_PROJECT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DEPT_USER_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_USER_ID{get{ return  _DEPT_USER_ID;}set{ _DEPT_USER_ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _FREE_FIELD = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _FREE_FIELD3 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String _FREE_FIELD2 = string.Empty;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _DECALRE_CAUSE = string.Empty;
		[DataMember]
		public System.String  DECALRE_CAUSE{get{ return  _DECALRE_CAUSE;}set{ _DECALRE_CAUSE = value;}}
		System.String _FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _IS_PERFORMANCE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_PERFORMANCE{get{ return  _IS_PERFORMANCE;}set{ _IS_PERFORMANCE = value;}}
		System.Decimal _IS_FIXED = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_FIXED{get{ return  _IS_FIXED;}set{ _IS_FIXED = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal _CONTROL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_PROJECT")]
	public partial class DisplayObject_BGT_B_CPN_INC_PROJECT:EntityObject_BGT_B_CPN_INC_PROJECT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _DEPT_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_USER_ID_NAME{get{ return  _DEPT_USER_ID_NAME;}set{ _DEPT_USER_ID_NAME = value;}}
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_PROJECT")]
	public partial class EntityObject_BGT_B_CPN_INC_PROJECT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DEPT_USER_ID;
		[DataMember]
		public System.String  DEPT_USER_ID{get{ return  _DEPT_USER_ID;}set{ _DEPT_USER_ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _FREE_FIELD;
		[DataMember]
		public System.String  FREE_FIELD{get{ return  _FREE_FIELD;}set{ _FREE_FIELD = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _FREE_FIELD3;
		[DataMember]
		public System.String  FREE_FIELD3{get{ return  _FREE_FIELD3;}set{ _FREE_FIELD3 = value;}}
		System.String  _FREE_FIELD2;
		[DataMember]
		public System.String  FREE_FIELD2{get{ return  _FREE_FIELD2;}set{ _FREE_FIELD2 = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _DECALRE_CAUSE;
		[DataMember]
		public System.String  DECALRE_CAUSE{get{ return  _DECALRE_CAUSE;}set{ _DECALRE_CAUSE = value;}}
		System.String  _FINANCE_IDEA;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _IS_PERFORMANCE;
		[DataMember]
		public System.Decimal  IS_PERFORMANCE{get{ return  _IS_PERFORMANCE;}set{ _IS_PERFORMANCE = value;}}
		System.Decimal  _IS_FIXED;
		[DataMember]
		public System.Decimal  IS_FIXED{get{ return  _IS_FIXED;}set{ _IS_FIXED = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal  _CONTROL_MONEY;
		[DataMember]
		public System.Decimal  CONTROL_MONEY{get{ return  _CONTROL_MONEY;}set{ _CONTROL_MONEY = value;}}

		#endregion 
	}	
}
