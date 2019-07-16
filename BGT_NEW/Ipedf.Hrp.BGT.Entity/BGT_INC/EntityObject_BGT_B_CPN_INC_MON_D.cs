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
	[DataObject("BGT_B_CPN_INC_MON_D")]
	public partial class CauseObject_BGT_B_CPN_INC_MON_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _M_9_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_9_VALUE{get{ return  _M_9_VALUE;}set{ _M_9_VALUE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TEMPLET_ITEM_ID = string.Empty;
		[DataMember]
		public System.String  TEMPLET_ITEM_ID{get{ return  _TEMPLET_ITEM_ID;}set{ _TEMPLET_ITEM_ID = value;}}
		System.Decimal _M_7_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_7_VALUE{get{ return  _M_7_VALUE;}set{ _M_7_VALUE = value;}}
		System.Decimal _M_8_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_8_VALUE{get{ return  _M_8_VALUE;}set{ _M_8_VALUE = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _M_1_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_1_VALUE{get{ return  _M_1_VALUE;}set{ _M_1_VALUE = value;}}
		System.Decimal _M_2_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_2_VALUE{get{ return  _M_2_VALUE;}set{ _M_2_VALUE = value;}}
		System.Decimal _M_10_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_10_VALUE{get{ return  _M_10_VALUE;}set{ _M_10_VALUE = value;}}
		System.Decimal _M_11_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_11_VALUE{get{ return  _M_11_VALUE;}set{ _M_11_VALUE = value;}}
		System.Decimal _M_5_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_5_VALUE{get{ return  _M_5_VALUE;}set{ _M_5_VALUE = value;}}
		System.Decimal _M_3_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_3_VALUE{get{ return  _M_3_VALUE;}set{ _M_3_VALUE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _M_12_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_12_VALUE{get{ return  _M_12_VALUE;}set{ _M_12_VALUE = value;}}
		System.Decimal _M_6_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_6_VALUE{get{ return  _M_6_VALUE;}set{ _M_6_VALUE = value;}}
		System.Decimal _M_4_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  M_4_VALUE{get{ return  _M_4_VALUE;}set{ _M_4_VALUE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_MON_D")]
	public partial class DisplayObject_BGT_B_CPN_INC_MON_D:EntityObject_BGT_B_CPN_INC_MON_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_CPN_INC_MON_D")]
	public partial class EntityObject_BGT_B_CPN_INC_MON_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _M_9_VALUE;
		[DataMember]
		public System.Decimal  M_9_VALUE{get{ return  _M_9_VALUE;}set{ _M_9_VALUE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TEMPLET_ITEM_ID;
		[DataMember]
		public System.String  TEMPLET_ITEM_ID{get{ return  _TEMPLET_ITEM_ID;}set{ _TEMPLET_ITEM_ID = value;}}
		System.Decimal  _M_7_VALUE;
		[DataMember]
		public System.Decimal  M_7_VALUE{get{ return  _M_7_VALUE;}set{ _M_7_VALUE = value;}}
		System.Decimal  _M_8_VALUE;
		[DataMember]
		public System.Decimal  M_8_VALUE{get{ return  _M_8_VALUE;}set{ _M_8_VALUE = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _M_1_VALUE;
		[DataMember]
		public System.Decimal  M_1_VALUE{get{ return  _M_1_VALUE;}set{ _M_1_VALUE = value;}}
		System.Decimal  _M_2_VALUE;
		[DataMember]
		public System.Decimal  M_2_VALUE{get{ return  _M_2_VALUE;}set{ _M_2_VALUE = value;}}
		System.Decimal  _M_10_VALUE;
		[DataMember]
		public System.Decimal  M_10_VALUE{get{ return  _M_10_VALUE;}set{ _M_10_VALUE = value;}}
		System.Decimal  _M_11_VALUE;
		[DataMember]
		public System.Decimal  M_11_VALUE{get{ return  _M_11_VALUE;}set{ _M_11_VALUE = value;}}
		System.Decimal  _M_5_VALUE;
		[DataMember]
		public System.Decimal  M_5_VALUE{get{ return  _M_5_VALUE;}set{ _M_5_VALUE = value;}}
		System.Decimal  _M_3_VALUE;
		[DataMember]
		public System.Decimal  M_3_VALUE{get{ return  _M_3_VALUE;}set{ _M_3_VALUE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _M_12_VALUE;
		[DataMember]
		public System.Decimal  M_12_VALUE{get{ return  _M_12_VALUE;}set{ _M_12_VALUE = value;}}
		System.Decimal  _M_6_VALUE;
		[DataMember]
		public System.Decimal  M_6_VALUE{get{ return  _M_6_VALUE;}set{ _M_6_VALUE = value;}}
		System.Decimal  _M_4_VALUE;
		[DataMember]
		public System.Decimal  M_4_VALUE{get{ return  _M_4_VALUE;}set{ _M_4_VALUE = value;}}

		#endregion 
	}	
}
