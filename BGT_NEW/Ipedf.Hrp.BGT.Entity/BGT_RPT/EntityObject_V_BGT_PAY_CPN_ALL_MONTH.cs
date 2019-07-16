using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("V_BGT_PAY_CPN_ALL_MONTH")]
	public partial class CauseObject_V_BGT_PAY_CPN_ALL_MONTH:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _M12TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M12TH{get{ return  _M12TH;}set{ _M12TH = value;}}
		System.Decimal _M1TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M1TH{get{ return  _M1TH;}set{ _M1TH = value;}}
		System.Decimal _MALL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MALL{get{ return  _MALL;}set{ _MALL = value;}}
		System.Decimal _M4TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M4TH{get{ return  _M4TH;}set{ _M4TH = value;}}
		System.Decimal _M5TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M5TH{get{ return  _M5TH;}set{ _M5TH = value;}}
		System.Decimal _M11TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M11TH{get{ return  _M11TH;}set{ _M11TH = value;}}
		System.Decimal _M2TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M2TH{get{ return  _M2TH;}set{ _M2TH = value;}}
		System.Decimal _M3TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M3TH{get{ return  _M3TH;}set{ _M3TH = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _M6TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M6TH{get{ return  _M6TH;}set{ _M6TH = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal _M10TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M10TH{get{ return  _M10TH;}set{ _M10TH = value;}}
		System.Decimal _M7TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M7TH{get{ return  _M7TH;}set{ _M7TH = value;}}
		System.Decimal _M8TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M8TH{get{ return  _M8TH;}set{ _M8TH = value;}}
		System.Decimal _M9TH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M9TH{get{ return  _M9TH;}set{ _M9TH = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_BGT_PAY_CPN_ALL_MONTH:EntityObject_V_BGT_PAY_CPN_ALL_MONTH
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_BGT_PAY_CPN_ALL_MONTH:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _M12TH;
		[DataMember]
		public System.Decimal  M12TH{get{ return  _M12TH;}set{ _M12TH = value;}}
		System.Decimal  _M1TH;
		[DataMember]
		public System.Decimal  M1TH{get{ return  _M1TH;}set{ _M1TH = value;}}
		System.Decimal  _MALL;
		[DataMember]
		public System.Decimal  MALL{get{ return  _MALL;}set{ _MALL = value;}}
		System.Decimal  _M4TH;
		[DataMember]
		public System.Decimal  M4TH{get{ return  _M4TH;}set{ _M4TH = value;}}
		System.Decimal  _M5TH;
		[DataMember]
		public System.Decimal  M5TH{get{ return  _M5TH;}set{ _M5TH = value;}}
		System.Decimal  _M11TH;
		[DataMember]
		public System.Decimal  M11TH{get{ return  _M11TH;}set{ _M11TH = value;}}
		System.Decimal  _M2TH;
		[DataMember]
		public System.Decimal  M2TH{get{ return  _M2TH;}set{ _M2TH = value;}}
		System.Decimal  _M3TH;
		[DataMember]
		public System.Decimal  M3TH{get{ return  _M3TH;}set{ _M3TH = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _M6TH;
		[DataMember]
		public System.Decimal  M6TH{get{ return  _M6TH;}set{ _M6TH = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal  _M10TH;
		[DataMember]
		public System.Decimal  M10TH{get{ return  _M10TH;}set{ _M10TH = value;}}
		System.Decimal  _M7TH;
		[DataMember]
		public System.Decimal  M7TH{get{ return  _M7TH;}set{ _M7TH = value;}}
		System.Decimal  _M8TH;
		[DataMember]
		public System.Decimal  M8TH{get{ return  _M8TH;}set{ _M8TH = value;}}
		System.Decimal  _M9TH;
		[DataMember]
		public System.Decimal  M9TH{get{ return  _M9TH;}set{ _M9TH = value;}}

		#endregion 
	}	
}
