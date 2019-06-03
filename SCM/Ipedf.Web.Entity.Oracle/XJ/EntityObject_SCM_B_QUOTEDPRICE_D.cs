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
	[DataObject("SCM_B_QUOTEDPRICE_D")]
	public partial class CauseObject_SCM_B_QUOTEDPRICE_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _COMMENTS_D = string.Empty;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String _HOSPITAL_NAME = string.Empty;
		[DataMember]
		public System.String  HOSPITAL_NAME{get{ return  _HOSPITAL_NAME;}set{ _HOSPITAL_NAME = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _DISPLAY_INDEX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DISPLAY_INDEX{get{ return  _DISPLAY_INDEX;}set{ _DISPLAY_INDEX = value;}}
		System.String _COM_FILE_ID = string.Empty;
		[DataMember]
		public System.String  COM_FILE_ID{get{ return  _COM_FILE_ID;}set{ _COM_FILE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}
	
	[Serializable]
	[DataContract]
	[DataObject("SCM_B_QUOTEDPRICE_D")]
	public partial class EntityObject_SCM_B_QUOTEDPRICE_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _COMMENTS_D;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String  _HOSPITAL_NAME;
		[DataMember]
		public System.String  HOSPITAL_NAME{get{ return  _HOSPITAL_NAME;}set{ _HOSPITAL_NAME = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _DISPLAY_INDEX;
		[DataMember]
		public System.Decimal  DISPLAY_INDEX{get{ return  _DISPLAY_INDEX;}set{ _DISPLAY_INDEX = value;}}
		System.String  _COM_FILE_ID;
		[DataMember]
		public System.String  COM_FILE_ID{get{ return  _COM_FILE_ID;}set{ _COM_FILE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}	
}
