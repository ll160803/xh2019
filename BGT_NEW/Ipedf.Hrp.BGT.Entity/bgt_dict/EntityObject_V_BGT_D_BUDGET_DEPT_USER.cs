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
	[DataObject("V_BGT_D_BUDGET_DEPT_USER")]
	public partial class CauseObject_V_BGT_D_BUDGET_DEPT_USER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _IS_FUNCTION = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_FUNCTION{get{ return  _IS_FUNCTION;}set{ _IS_FUNCTION = value;}}
		System.String _CPN_ID = string.Empty;
		[DataMember]
		public System.String  CPN_ID{get{ return  _CPN_ID;}set{ _CPN_ID = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _HEADNAME = string.Empty;
		[DataMember]
		public System.String  HEADNAME{get{ return  _HEADNAME;}set{ _HEADNAME = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_D_BUDGET_DEPT_USER")]
	public partial class DisplayObject_V_BGT_D_BUDGET_DEPT_USER:EntityObject_V_BGT_D_BUDGET_DEPT_USER
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_D_BUDGET_DEPT_USER")]
	public partial class EntityObject_V_BGT_D_BUDGET_DEPT_USER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _IS_FUNCTION;
		[DataMember]
		public System.Decimal  IS_FUNCTION{get{ return  _IS_FUNCTION;}set{ _IS_FUNCTION = value;}}
		System.String  _CPN_ID;
		[DataMember]
		public System.String  CPN_ID{get{ return  _CPN_ID;}set{ _CPN_ID = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _HEADNAME;
		[DataMember]
		public System.String  HEADNAME{get{ return  _HEADNAME;}set{ _HEADNAME = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
