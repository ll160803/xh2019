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
	[DataObject("BGT_B_BUDGET_CONTROL_S_DEPT")]
	public partial class CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.Decimal _IS_EDIT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_EDIT{get{ return  _IS_EDIT;}set{ _IS_EDIT = value;}}
		System.Decimal _STAGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STAGE{get{ return  _STAGE;}set{ _STAGE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_S_DEPT")]
	public partial class DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT:EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_ID_NAME{get{ return  _DEPT_ID_NAME;}set{ _DEPT_ID_NAME = value;}}
		 System.String _IS_EDIT_NAME = string.Empty;
		[DataMember]
		public System.String IS_EDIT_NAME{get{ return  _IS_EDIT_NAME;}set{ _IS_EDIT_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_CONTROL_S_DEPT")]
	public partial class EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.Decimal  _IS_EDIT;
		[DataMember]
		public System.Decimal  IS_EDIT{get{ return  _IS_EDIT;}set{ _IS_EDIT = value;}}
		System.Decimal  _STAGE;
		[DataMember]
		public System.Decimal  STAGE{get{ return  _STAGE;}set{ _STAGE = value;}}

		#endregion 
	}	
}
