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
	[DataObject("BGT_B_BUDGET_DATA")]
	public partial class CauseObject_BGT_B_BUDGET_DATA:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _TEMPLET_ID = string.Empty;
		[DataMember]
		public System.String  TEMPLET_ID{get{ return  _TEMPLET_ID;}set{ _TEMPLET_ID = value;}}
		System.String _BUDGET_CPN_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_CPN_ID{get{ return  _BUDGET_CPN_ID;}set{ _BUDGET_CPN_ID = value;}}
		System.String _BUDGET_CONTENTS_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_DATA")]
	public partial class DisplayObject_BGT_B_BUDGET_DATA:EntityObject_BGT_B_BUDGET_DATA
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _TEMPLET_ID_NAME = string.Empty;
		[DataMember]
		public System.String TEMPLET_ID_NAME{get{ return  _TEMPLET_ID_NAME;}set{ _TEMPLET_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_B_BUDGET_DATA")]
	public partial class EntityObject_BGT_B_BUDGET_DATA:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _TEMPLET_ID;
		[DataMember]
		public System.String  TEMPLET_ID{get{ return  _TEMPLET_ID;}set{ _TEMPLET_ID = value;}}
		System.String  _BUDGET_CPN_ID;
		[DataMember]
		public System.String  BUDGET_CPN_ID{get{ return  _BUDGET_CPN_ID;}set{ _BUDGET_CPN_ID = value;}}
		System.String  _BUDGET_CONTENTS_ID;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}

		#endregion 
	}	
}
