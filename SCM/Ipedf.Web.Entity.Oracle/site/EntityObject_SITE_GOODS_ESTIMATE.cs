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
	[DataObject("SITE_GOODS_ESTIMATE")]
	public partial class CauseObject_SITE_GOODS_ESTIMATE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _GOODS_ID = string.Empty;
		public System.String  GOODS_ID{get{ return  _GOODS_ID;}set{ _GOODS_ID = value;}}
		System.String _USER_ID = string.Empty;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _ESTIMATE_DATE = null;
		public DateSpan  ESTIMATE_DATE{get{ return  _ESTIMATE_DATE;}set{ _ESTIMATE_DATE = value;}}
		System.String _SUMMARY = string.Empty;
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.Decimal _GRADE = ConstLibrary.Template.UndefineDecimal;
		public System.Decimal  GRADE{get{ return  _GRADE;}set{ _GRADE = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_GOODS_ESTIMATE")]
	public partial class DisplayObject_SITE_GOODS_ESTIMATE:EntityObject_SITE_GOODS_ESTIMATE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _SITE_GOODS_NAME = string.Empty;
		public System.String SITE_GOODS_NAME{get{ return  _SITE_GOODS_NAME;}set{ _SITE_GOODS_NAME = value;}}
		 System.String _SITE_USER_NICKNAME = string.Empty;
		public System.String SITE_USER_NICKNAME{get{ return  _SITE_USER_NICKNAME;}set{ _SITE_USER_NICKNAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("SITE_GOODS_ESTIMATE")]
	public partial class EntityObject_SITE_GOODS_ESTIMATE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _GOODS_ID;
		public System.String  GOODS_ID{get{ return  _GOODS_ID;}set{ _GOODS_ID = value;}}
		System.String  _USER_ID;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _ESTIMATE_DATE;
		public System.DateTime  ESTIMATE_DATE{get{ return  _ESTIMATE_DATE;}set{ _ESTIMATE_DATE = value;}}
		System.String  _SUMMARY;
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.Decimal  _GRADE;
		public System.Decimal  GRADE{get{ return  _GRADE;}set{ _GRADE = value;}}

		#endregion 
	}	
}
