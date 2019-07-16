using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("V_BGT_PLAN_BUDGET_DATA")]
	public partial class CauseObject_V_BGT_PLAN_BUDGET_DATA:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal _DEPT_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DEPT_VALUE{get{ return  _DEPT_VALUE;}set{ _DEPT_VALUE = value;}}
		System.String _BUDGET_DATA_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DATA_ID{get{ return  _BUDGET_DATA_ID;}set{ _BUDGET_DATA_ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _DIFF_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DIFF_VALUE{get{ return  _DIFF_VALUE;}set{ _DIFF_VALUE = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal _CPN_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CPN_VALUE{get{ return  _CPN_VALUE;}set{ _CPN_VALUE = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_BGT_PLAN_BUDGET_DATA:EntityObject_V_BGT_PLAN_BUDGET_DATA
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_BGT_PLAN_BUDGET_DATA:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal  _DEPT_VALUE;
		[DataMember]
		public System.Decimal  DEPT_VALUE{get{ return  _DEPT_VALUE;}set{ _DEPT_VALUE = value;}}
		System.String  _BUDGET_DATA_ID;
		[DataMember]
		public System.String  BUDGET_DATA_ID{get{ return  _BUDGET_DATA_ID;}set{ _BUDGET_DATA_ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _DIFF_VALUE;
		[DataMember]
		public System.Decimal  DIFF_VALUE{get{ return  _DIFF_VALUE;}set{ _DIFF_VALUE = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal  _CPN_VALUE;
		[DataMember]
		public System.Decimal  CPN_VALUE{get{ return  _CPN_VALUE;}set{ _CPN_VALUE = value;}}

		#endregion 
	}	
}
