using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("V_COM_QUERY_CODE")]
	public partial class CauseObject_V_COM_QUERY_CODE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _NAME = string.Empty;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CODE = string.Empty;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _CODE_ID = string.Empty;
		public System.String  CODE_ID{get{ return  _CODE_ID;}set{ _CODE_ID = value;}}
		System.Decimal _CODE_WIDTH = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  CODE_WIDTH{get{ return  _CODE_WIDTH;}set{ _CODE_WIDTH = value;}}
		System.Decimal _CODE_INDEX = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  CODE_INDEX{get{ return  _CODE_INDEX;}set{ _CODE_INDEX = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _CODE_VALUE = string.Empty;
		public System.String  CODE_VALUE{get{ return  _CODE_VALUE;}set{ _CODE_VALUE = value;}}
		System.Decimal _CODE_TYPE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  CODE_TYPE{get{ return  _CODE_TYPE;}set{ _CODE_TYPE = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_COM_QUERY_CODE:EntityObject_V_COM_QUERY_CODE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_COM_QUERY_CODE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _NAME;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _DATA_ORGANISE_ID;
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CODE;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _CODE_ID;
		public System.String  CODE_ID{get{ return  _CODE_ID;}set{ _CODE_ID = value;}}
		System.Decimal  _CODE_WIDTH;
		public System.Decimal  CODE_WIDTH{get{ return  _CODE_WIDTH;}set{ _CODE_WIDTH = value;}}
		System.Decimal  _CODE_INDEX;
		public System.Decimal  CODE_INDEX{get{ return  _CODE_INDEX;}set{ _CODE_INDEX = value;}}
		System.Decimal  _STATE;
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _CODE_VALUE;
		public System.String  CODE_VALUE{get{ return  _CODE_VALUE;}set{ _CODE_VALUE = value;}}
		System.Decimal  _CODE_TYPE;
		public System.Decimal  CODE_TYPE{get{ return  _CODE_TYPE;}set{ _CODE_TYPE = value;}}

		#endregion 
	}	
}
