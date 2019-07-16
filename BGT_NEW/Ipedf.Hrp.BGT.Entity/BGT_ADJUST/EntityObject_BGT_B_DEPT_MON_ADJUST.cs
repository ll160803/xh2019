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
	[DataObject("BGT_B_DEPT_MON_ADJUST")]
	public partial class CauseObject_BGT_B_DEPT_MON_ADJUST:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String _BUDGET_CONTENTS_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _IS_FUNCTION = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_FUNCTION{get{ return  _IS_FUNCTION;}set{ _IS_FUNCTION = value;}}
		System.String _ADJUST_ID = string.Empty;
		[DataMember]
		public System.String  ADJUST_ID{get{ return  _ADJUST_ID;}set{ _ADJUST_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_MON_ADJUST")]
	public partial class DisplayObject_BGT_B_DEPT_MON_ADJUST:EntityObject_BGT_B_DEPT_MON_ADJUST
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}
		 System.String _ADJUST_ID_NAME = string.Empty;
		[DataMember]
		public System.String ADJUST_ID_NAME{get{ return  _ADJUST_ID_NAME;}set{ _ADJUST_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_DEPT_MON_ADJUST")]
	public partial class EntityObject_BGT_B_DEPT_MON_ADJUST:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}
		System.String  _BUDGET_CONTENTS_ID;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _IS_FUNCTION;
		[DataMember]
		public System.Decimal  IS_FUNCTION{get{ return  _IS_FUNCTION;}set{ _IS_FUNCTION = value;}}
		System.String  _ADJUST_ID;
		[DataMember]
		public System.String  ADJUST_ID{get{ return  _ADJUST_ID;}set{ _ADJUST_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}

		#endregion 
	}	
}
