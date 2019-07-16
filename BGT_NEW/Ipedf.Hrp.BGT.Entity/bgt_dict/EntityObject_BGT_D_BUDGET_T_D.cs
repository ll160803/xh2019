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
	[DataObject("BGT_D_BUDGET_T_D")]
	public partial class CauseObject_BGT_D_BUDGET_T_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CALCULATE_METHOD_ID = string.Empty;
		[DataMember]
		public System.String  CALCULATE_METHOD_ID{get{ return  _CALCULATE_METHOD_ID;}set{ _CALCULATE_METHOD_ID = value;}}
		System.String _CONSULT = string.Empty;
		[DataMember]
		public System.String  CONSULT{get{ return  _CONSULT;}set{ _CONSULT = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal _CALCULATE_INDEX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CALCULATE_INDEX{get{ return  _CALCULATE_INDEX;}set{ _CALCULATE_INDEX = value;}}
		System.String _PREPARE_METHOD_ID = string.Empty;
		[DataMember]
		public System.String  PREPARE_METHOD_ID{get{ return  _PREPARE_METHOD_ID;}set{ _PREPARE_METHOD_ID = value;}}
		System.String _CALCULATE_FORMULA = string.Empty;
		[DataMember]
		public System.String  CALCULATE_FORMULA{get{ return  _CALCULATE_FORMULA;}set{ _CALCULATE_FORMULA = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_T_D")]
	public partial class DisplayObject_BGT_D_BUDGET_T_D:EntityObject_BGT_D_BUDGET_T_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _CALCULATE_METHOD_ID_NAME = string.Empty;
		[DataMember]
		public System.String CALCULATE_METHOD_ID_NAME{get{ return  _CALCULATE_METHOD_ID_NAME;}set{ _CALCULATE_METHOD_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _PREPARE_METHOD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PREPARE_METHOD_ID_NAME{get{ return  _PREPARE_METHOD_ID_NAME;}set{ _PREPARE_METHOD_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_T_D")]
	public partial class EntityObject_BGT_D_BUDGET_T_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CALCULATE_METHOD_ID;
		[DataMember]
		public System.String  CALCULATE_METHOD_ID{get{ return  _CALCULATE_METHOD_ID;}set{ _CALCULATE_METHOD_ID = value;}}
		System.String  _CONSULT;
		[DataMember]
		public System.String  CONSULT{get{ return  _CONSULT;}set{ _CONSULT = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.Decimal  _CALCULATE_INDEX;
		[DataMember]
		public System.Decimal  CALCULATE_INDEX{get{ return  _CALCULATE_INDEX;}set{ _CALCULATE_INDEX = value;}}
		System.String  _PREPARE_METHOD_ID;
		[DataMember]
		public System.String  PREPARE_METHOD_ID{get{ return  _PREPARE_METHOD_ID;}set{ _PREPARE_METHOD_ID = value;}}
		System.String  _CALCULATE_FORMULA;
		[DataMember]
		public System.String  CALCULATE_FORMULA{get{ return  _CALCULATE_FORMULA;}set{ _CALCULATE_FORMULA = value;}}

		#endregion 
	}	
}
