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
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R_I_D")]
	public partial class CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_MONTH = string.Empty;
		[DataMember]
		public System.String  BUDGET_MONTH{get{ return  _BUDGET_MONTH;}set{ _BUDGET_MONTH = value;}}
		System.Decimal _ADJUST_SCALE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADJUST_SCALE{get{ return  _ADJUST_SCALE;}set{ _ADJUST_SCALE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R_I_D")]
	public partial class DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D:EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_MONTH_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_MONTH_NAME{get{ return  _BUDGET_MONTH_NAME;}set{ _BUDGET_MONTH_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R_I_D")]
	public partial class EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_MONTH;
		[DataMember]
		public System.String  BUDGET_MONTH{get{ return  _BUDGET_MONTH;}set{ _BUDGET_MONTH = value;}}
		System.Decimal  _ADJUST_SCALE;
		[DataMember]
		public System.Decimal  ADJUST_SCALE{get{ return  _ADJUST_SCALE;}set{ _ADJUST_SCALE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
