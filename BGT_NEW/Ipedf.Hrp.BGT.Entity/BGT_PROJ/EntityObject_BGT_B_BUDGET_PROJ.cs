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
	[DataObject("BGT_B_BUDGET_PROJ")]
	public partial class CauseObject_BGT_B_BUDGET_PROJ:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _EXECUTED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String _PROJ_USER_ID = string.Empty;
		[DataMember]
		public System.String  PROJ_USER_ID{get{ return  _PROJ_USER_ID;}set{ _PROJ_USER_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _FINANCE_USER_ID = string.Empty;
		[DataMember]
		public System.String  FINANCE_USER_ID{get{ return  _FINANCE_USER_ID;}set{ _FINANCE_USER_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _NATURE_ID = string.Empty;
		[DataMember]
		public System.String  NATURE_ID{get{ return  _NATURE_ID;}set{ _NATURE_ID = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _BACKDROP = string.Empty;
		[DataMember]
		public System.String  BACKDROP{get{ return  _BACKDROP;}set{ _BACKDROP = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _ADJUST_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal _IS_GOV_PROC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_GOV_PROC{get{ return  _IS_GOV_PROC;}set{ _IS_GOV_PROC = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		DateSpan _PLAN_BEGIN_DATE = null;
		[DataMember]
		public DateSpan  PLAN_BEGIN_DATE{get{ return  _PLAN_BEGIN_DATE;}set{ _PLAN_BEGIN_DATE = value;}}
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		DateSpan _PLAN_END_DATE = null;
		[DataMember]
		public DateSpan  PLAN_END_DATE{get{ return  _PLAN_END_DATE;}set{ _PLAN_END_DATE = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal _AVAILABLE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		DateSpan _REPLY_DATE = null;
		[DataMember]
		public DateSpan  REPLY_DATE{get{ return  _REPLY_DATE;}set{ _REPLY_DATE = value;}}
		System.Decimal _APPLIED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLIED_MONEY{get{ return  _APPLIED_MONEY;}set{ _APPLIED_MONEY = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal _REPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REPLY_MONEY{get{ return  _REPLY_MONEY;}set{ _REPLY_MONEY = value;}}
		System.String _PURPOSE = string.Empty;
		[DataMember]
		public System.String  PURPOSE{get{ return  _PURPOSE;}set{ _PURPOSE = value;}}
		System.String _BIZ_STATE = string.Empty;
		[DataMember]
		public System.String  BIZ_STATE{get{ return  _BIZ_STATE;}set{ _BIZ_STATE = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		DateSpan _APPLY_DATE = null;
		[DataMember]
		public DateSpan  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.String _REPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  REPLY_USER_ID{get{ return  _REPLY_USER_ID;}set{ _REPLY_USER_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ")]
	public partial class DisplayObject_BGT_B_BUDGET_PROJ:EntityObject_BGT_B_BUDGET_PROJ
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PROJ_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROJ_USER_ID_NAME{get{ return  _PROJ_USER_ID_NAME;}set{ _PROJ_USER_ID_NAME = value;}}
		 System.String _FINANCE_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String FINANCE_USER_ID_NAME{get{ return  _FINANCE_USER_ID_NAME;}set{ _FINANCE_USER_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _NATURE_ID_NAME = string.Empty;
		[DataMember]
		public System.String NATURE_ID_NAME{get{ return  _NATURE_ID_NAME;}set{ _NATURE_ID_NAME = value;}}
		 System.String _IS_GOV_PROC_NAME = string.Empty;
		[DataMember]
		public System.String IS_GOV_PROC_NAME{get{ return  _IS_GOV_PROC_NAME;}set{ _IS_GOV_PROC_NAME = value;}}
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		 System.String _BIZ_STATE_NAME = string.Empty;
		[DataMember]
		public System.String BIZ_STATE_NAME{get{ return  _BIZ_STATE_NAME;}set{ _BIZ_STATE_NAME = value;}}
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		 System.String _REPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String REPLY_USER_ID_NAME{get{ return  _REPLY_USER_ID_NAME;}set{ _REPLY_USER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ")]
	public partial class EntityObject_BGT_B_BUDGET_PROJ:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _EXECUTED_MONEY;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String  _PROJ_USER_ID;
		[DataMember]
		public System.String  PROJ_USER_ID{get{ return  _PROJ_USER_ID;}set{ _PROJ_USER_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _FINANCE_USER_ID;
		[DataMember]
		public System.String  FINANCE_USER_ID{get{ return  _FINANCE_USER_ID;}set{ _FINANCE_USER_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _NATURE_ID;
		[DataMember]
		public System.String  NATURE_ID{get{ return  _NATURE_ID;}set{ _NATURE_ID = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _BACKDROP;
		[DataMember]
		public System.String  BACKDROP{get{ return  _BACKDROP;}set{ _BACKDROP = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _ADJUST_MONEY;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}
		System.Decimal  _IS_GOV_PROC;
		[DataMember]
		public System.Decimal  IS_GOV_PROC{get{ return  _IS_GOV_PROC;}set{ _IS_GOV_PROC = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.DateTime  _PLAN_BEGIN_DATE;
		[DataMember]
		public System.DateTime  PLAN_BEGIN_DATE{get{ return  _PLAN_BEGIN_DATE;}set{ _PLAN_BEGIN_DATE = value;}}
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.DateTime  _PLAN_END_DATE;
		[DataMember]
		public System.DateTime  PLAN_END_DATE{get{ return  _PLAN_END_DATE;}set{ _PLAN_END_DATE = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal  _AVAILABLE_MONEY;
		[DataMember]
		public System.Decimal  AVAILABLE_MONEY{get{ return  _AVAILABLE_MONEY;}set{ _AVAILABLE_MONEY = value;}}
		System.DateTime  _REPLY_DATE;
		[DataMember]
		public System.DateTime  REPLY_DATE{get{ return  _REPLY_DATE;}set{ _REPLY_DATE = value;}}
		System.Decimal  _APPLIED_MONEY;
		[DataMember]
		public System.Decimal  APPLIED_MONEY{get{ return  _APPLIED_MONEY;}set{ _APPLIED_MONEY = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal  _REPLY_MONEY;
		[DataMember]
		public System.Decimal  REPLY_MONEY{get{ return  _REPLY_MONEY;}set{ _REPLY_MONEY = value;}}
		System.String  _PURPOSE;
		[DataMember]
		public System.String  PURPOSE{get{ return  _PURPOSE;}set{ _PURPOSE = value;}}
		System.String  _BIZ_STATE;
		[DataMember]
		public System.String  BIZ_STATE{get{ return  _BIZ_STATE;}set{ _BIZ_STATE = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.DateTime  _APPLY_DATE;
		[DataMember]
		public System.DateTime  APPLY_DATE{get{ return  _APPLY_DATE;}set{ _APPLY_DATE = value;}}
		System.String  _REPLY_USER_ID;
		[DataMember]
		public System.String  REPLY_USER_ID{get{ return  _REPLY_USER_ID;}set{ _REPLY_USER_ID = value;}}

		#endregion 
	}	
}
