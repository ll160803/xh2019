using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("SITE_GOODS")]
	public partial class CauseObject_SITE_GOODS:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _NAME = string.Empty;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _SUMMARY = string.Empty;
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.Decimal _BROWSE_COUNT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  BROWSE_COUNT{get{ return  _BROWSE_COUNT;}set{ _BROWSE_COUNT = value;}}
		System.Decimal _PURCHASE_COUNT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  PURCHASE_COUNT{get{ return  _PURCHASE_COUNT;}set{ _PURCHASE_COUNT = value;}}
		System.String _GOODS_STATE = string.Empty;
		public System.String  GOODS_STATE{get{ return  _GOODS_STATE;}set{ _GOODS_STATE = value;}}
		System.String _CODE = string.Empty;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _IMAGE_URL = string.Empty;
		public System.String  IMAGE_URL{get{ return  _IMAGE_URL;}set{ _IMAGE_URL = value;}}
		System.Decimal _PRAISE_COUNT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  PRAISE_COUNT{get{ return  _PRAISE_COUNT;}set{ _PRAISE_COUNT = value;}}
		DateSpan _PUBLISH_DATE = null;
		public DateSpan  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_GOODS")]
	public partial class DisplayObject_SITE_GOODS:EntityObject_SITE_GOODS
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COM_TYPE_NAME = string.Empty;
		public System.String COM_TYPE_NAME{get{ return  _COM_TYPE_NAME;}set{ _COM_TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_GOODS")]
	public partial class EntityObject_SITE_GOODS:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _NAME;
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _SUMMARY;
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.Decimal  _BROWSE_COUNT;
		public System.Decimal  BROWSE_COUNT{get{ return  _BROWSE_COUNT;}set{ _BROWSE_COUNT = value;}}
		System.Decimal  _PURCHASE_COUNT;
		public System.Decimal  PURCHASE_COUNT{get{ return  _PURCHASE_COUNT;}set{ _PURCHASE_COUNT = value;}}
		System.String  _GOODS_STATE;
		public System.String  GOODS_STATE{get{ return  _GOODS_STATE;}set{ _GOODS_STATE = value;}}
		System.String  _CODE;
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _PRICE;
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _IMAGE_URL;
		public System.String  IMAGE_URL{get{ return  _IMAGE_URL;}set{ _IMAGE_URL = value;}}
		System.Decimal  _PRAISE_COUNT;
		public System.Decimal  PRAISE_COUNT{get{ return  _PRAISE_COUNT;}set{ _PRAISE_COUNT = value;}}
		System.DateTime  _PUBLISH_DATE;
		public System.DateTime  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}

		#endregion 
	}	
}
