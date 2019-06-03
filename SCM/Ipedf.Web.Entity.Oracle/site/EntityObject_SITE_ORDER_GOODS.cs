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
	[DataObject("SITE_ORDER_GOODS")]
	public partial class CauseObject_SITE_ORDER_GOODS:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ORDER_ID = string.Empty;
		public System.String  ORDER_ID{get{ return  _ORDER_ID;}set{ _ORDER_ID = value;}}
		System.String _GOODS_ID = string.Empty;
		public System.String  GOODS_ID{get{ return  _GOODS_ID;}set{ _GOODS_ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_ORDER_GOODS")]
	public partial class DisplayObject_SITE_ORDER_GOODS:EntityObject_SITE_ORDER_GOODS
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SITE_ORDER_CODE = string.Empty;
		public System.String SITE_ORDER_CODE{get{ return  _SITE_ORDER_CODE;}set{ _SITE_ORDER_CODE = value;}}
		 System.String _SITE_GOODS_NAME = string.Empty;
		public System.String SITE_GOODS_NAME{get{ return  _SITE_GOODS_NAME;}set{ _SITE_GOODS_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_ORDER_GOODS")]
	public partial class EntityObject_SITE_ORDER_GOODS:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ORDER_ID;
		public System.String  ORDER_ID{get{ return  _ORDER_ID;}set{ _ORDER_ID = value;}}
		System.String  _GOODS_ID;
		public System.String  GOODS_ID{get{ return  _GOODS_ID;}set{ _GOODS_ID = value;}}
		System.Decimal  _MONEY;
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _AMOUNT;
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.Decimal  _PRICE;
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}	
}
