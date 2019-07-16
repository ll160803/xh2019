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
	[DataObject("BGT_D_MACHINE")]
	public partial class CauseObject_BGT_D_MACHINE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BASEID = string.Empty;
		[DataMember]
		public System.String  BASEID{get{ return  _BASEID;}set{ _BASEID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _INSTALL = string.Empty;
		[DataMember]
		public System.String  INSTALL{get{ return  _INSTALL;}set{ _INSTALL = value;}}
		System.String _CONDITION = string.Empty;
		[DataMember]
		public System.String  CONDITION{get{ return  _CONDITION;}set{ _CONDITION = value;}}
		System.String _PROJECT = string.Empty;
		[DataMember]
		public System.String  PROJECT{get{ return  _PROJECT;}set{ _PROJECT = value;}}
		System.String _FREQUENCY = string.Empty;
		[DataMember]
		public System.String  FREQUENCY{get{ return  _FREQUENCY;}set{ _FREQUENCY = value;}}
		System.String _BUY = string.Empty;
		[DataMember]
		public System.String  BUY{get{ return  _BUY;}set{ _BUY = value;}}
		System.String _NUM = string.Empty;
		[DataMember]
		public System.String  NUM{get{ return  _NUM;}set{ _NUM = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _NEED = string.Empty;
		[DataMember]
		public System.String  NEED{get{ return  _NEED;}set{ _NEED = value;}}
		System.String _NO = string.Empty;
		[DataMember]
		public System.String  NO{get{ return  _NO;}set{ _NO = value;}}
		System.String _PRICE = string.Empty;
		[DataMember]
		public System.String  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _MAN = string.Empty;
		[DataMember]
		public System.String  MAN{get{ return  _MAN;}set{ _MAN = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MACHINE")]
	public partial class DisplayObject_BGT_D_MACHINE:EntityObject_BGT_D_MACHINE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MACHINE")]
	public partial class EntityObject_BGT_D_MACHINE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BASEID;
		[DataMember]
		public System.String  BASEID{get{ return  _BASEID;}set{ _BASEID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _INSTALL;
		[DataMember]
		public System.String  INSTALL{get{ return  _INSTALL;}set{ _INSTALL = value;}}
		System.String  _CONDITION;
		[DataMember]
		public System.String  CONDITION{get{ return  _CONDITION;}set{ _CONDITION = value;}}
		System.String  _PROJECT;
		[DataMember]
		public System.String  PROJECT{get{ return  _PROJECT;}set{ _PROJECT = value;}}
		System.String  _FREQUENCY;
		[DataMember]
		public System.String  FREQUENCY{get{ return  _FREQUENCY;}set{ _FREQUENCY = value;}}
		System.String  _BUY;
		[DataMember]
		public System.String  BUY{get{ return  _BUY;}set{ _BUY = value;}}
		System.String  _NUM;
		[DataMember]
		public System.String  NUM{get{ return  _NUM;}set{ _NUM = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _NEED;
		[DataMember]
		public System.String  NEED{get{ return  _NEED;}set{ _NEED = value;}}
		System.String  _NO;
		[DataMember]
		public System.String  NO{get{ return  _NO;}set{ _NO = value;}}
		System.String  _PRICE;
		[DataMember]
		public System.String  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _MAN;
		[DataMember]
		public System.String  MAN{get{ return  _MAN;}set{ _MAN = value;}}

		#endregion 
	}	
}
