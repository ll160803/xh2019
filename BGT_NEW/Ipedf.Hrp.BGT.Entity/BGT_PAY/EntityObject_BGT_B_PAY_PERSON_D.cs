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
	[DataObject("BGT_B_PAY_PERSON_D")]
	public partial class CauseObject_BGT_B_PAY_PERSON_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _OTHERS = string.Empty;
		[DataMember]
		public System.String  OTHERS{get{ return  _OTHERS;}set{ _OTHERS = value;}}
		System.Decimal _LASTYEAR_COUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  LASTYEAR_COUNT{get{ return  _LASTYEAR_COUNT;}set{ _LASTYEAR_COUNT = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _FINANCE_IDEA = string.Empty;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String _DECLARE_CAUSE = string.Empty;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.Decimal _NOWYEAR_COUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NOWYEAR_COUNT{get{ return  _NOWYEAR_COUNT;}set{ _NOWYEAR_COUNT = value;}}
		System.String _PERSON_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  PERSON_TYPE_ID{get{ return  _PERSON_TYPE_ID;}set{ _PERSON_TYPE_ID = value;}}
		System.Decimal _CONTROL_COUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTROL_COUNT{get{ return  _CONTROL_COUNT;}set{ _CONTROL_COUNT = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_PAY_PERSON_D")]
	public partial class DisplayObject_BGT_B_PAY_PERSON_D:EntityObject_BGT_B_PAY_PERSON_D
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_PAY_PERSON_D")]
	public partial class EntityObject_BGT_B_PAY_PERSON_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _OTHERS;
		[DataMember]
		public System.String  OTHERS{get{ return  _OTHERS;}set{ _OTHERS = value;}}
		System.Decimal  _LASTYEAR_COUNT;
		[DataMember]
		public System.Decimal  LASTYEAR_COUNT{get{ return  _LASTYEAR_COUNT;}set{ _LASTYEAR_COUNT = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _FINANCE_IDEA;
		[DataMember]
		public System.String  FINANCE_IDEA{get{ return  _FINANCE_IDEA;}set{ _FINANCE_IDEA = value;}}
		System.String  _DECLARE_CAUSE;
		[DataMember]
		public System.String  DECLARE_CAUSE{get{ return  _DECLARE_CAUSE;}set{ _DECLARE_CAUSE = value;}}
		System.Decimal  _NOWYEAR_COUNT;
		[DataMember]
		public System.Decimal  NOWYEAR_COUNT{get{ return  _NOWYEAR_COUNT;}set{ _NOWYEAR_COUNT = value;}}
		System.String  _PERSON_TYPE_ID;
		[DataMember]
		public System.String  PERSON_TYPE_ID{get{ return  _PERSON_TYPE_ID;}set{ _PERSON_TYPE_ID = value;}}
		System.Decimal  _CONTROL_COUNT;
		[DataMember]
		public System.Decimal  CONTROL_COUNT{get{ return  _CONTROL_COUNT;}set{ _CONTROL_COUNT = value;}}

		#endregion 
	}	
}
