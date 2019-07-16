﻿using System;
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
	[DataObject("BGT_B_BUDGET_PROJ_CO")]
	public partial class CauseObject_BGT_B_BUDGET_PROJ_CO:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _EXECUTED_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _IS_RECENTLY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_RECENTLY{get{ return  _IS_RECENTLY;}set{ _IS_RECENTLY = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal _BUDGET_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  BUDGET_MONEY{get{ return  _BUDGET_MONEY;}set{ _BUDGET_MONEY = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _PROJECT_ID = string.Empty;
		[DataMember]
		public System.String  PROJECT_ID{get{ return  _PROJECT_ID;}set{ _PROJECT_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _ADJUST_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_CO")]
	public partial class DisplayObject_BGT_B_BUDGET_PROJ_CO:EntityObject_BGT_B_BUDGET_PROJ_CO
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _IS_RECENTLY_NAME = string.Empty;
		[DataMember]
		public System.String IS_RECENTLY_NAME{get{ return  _IS_RECENTLY_NAME;}set{ _IS_RECENTLY_NAME = value;}}
		 System.String _PROJECT_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROJECT_ID_NAME{get{ return  _PROJECT_ID_NAME;}set{ _PROJECT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_PROJ_CO")]
	public partial class EntityObject_BGT_B_BUDGET_PROJ_CO:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _EXECUTED_MONEY;
		[DataMember]
		public System.Decimal  EXECUTED_MONEY{get{ return  _EXECUTED_MONEY;}set{ _EXECUTED_MONEY = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _IS_RECENTLY;
		[DataMember]
		public System.Decimal  IS_RECENTLY{get{ return  _IS_RECENTLY;}set{ _IS_RECENTLY = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal  _BUDGET_MONEY;
		[DataMember]
		public System.Decimal  BUDGET_MONEY{get{ return  _BUDGET_MONEY;}set{ _BUDGET_MONEY = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _PROJECT_ID;
		[DataMember]
		public System.String  PROJECT_ID{get{ return  _PROJECT_ID;}set{ _PROJECT_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _ADJUST_MONEY;
		[DataMember]
		public System.Decimal  ADJUST_MONEY{get{ return  _ADJUST_MONEY;}set{ _ADJUST_MONEY = value;}}

		#endregion 
	}	
}
