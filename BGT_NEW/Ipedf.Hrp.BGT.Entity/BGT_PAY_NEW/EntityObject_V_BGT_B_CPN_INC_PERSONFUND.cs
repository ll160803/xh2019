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
	[DataObject("V_BGT_B_CPN_INC_PERSONFUND")]
	public partial class CauseObject_V_BGT_B_CPN_INC_PERSONFUND:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String _DEPT_NAME = string.Empty;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _ADDRESS = string.Empty;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_B_CPN_INC_PERSONFUND")]
	public partial class DisplayObject_V_BGT_B_CPN_INC_PERSONFUND:EntityObject_V_BGT_B_CPN_INC_PERSONFUND
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_B_CPN_INC_PERSONFUND")]
	public partial class EntityObject_V_BGT_B_CPN_INC_PERSONFUND:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String  _DEPT_NAME;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _ADDRESS;
		[DataMember]
		public System.String  ADDRESS{get{ return  _ADDRESS;}set{ _ADDRESS = value;}}

		#endregion 
	}	
}
