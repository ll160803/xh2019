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
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R")]
	public partial class CauseObject_BGT_D_BUDGET_DEPT_YEAR_R:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_CONTENTS_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _BUDGET_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R")]
	public partial class DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R:EntityObject_BGT_D_BUDGET_DEPT_YEAR_R
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BUDGET_CONTENTS_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_CONTENTS_ID_NAME{get{ return  _BUDGET_CONTENTS_ID_NAME;}set{ _BUDGET_CONTENTS_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}
		 System.String _BUDGET_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_DEPT_ID_NAME{get{ return  _BUDGET_DEPT_ID_NAME;}set{ _BUDGET_DEPT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_DEPT_YEAR_R")]
	public partial class EntityObject_BGT_D_BUDGET_DEPT_YEAR_R:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_CONTENTS_ID;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _BUDGET_DEPT_ID;
		[DataMember]
		public System.String  BUDGET_DEPT_ID{get{ return  _BUDGET_DEPT_ID;}set{ _BUDGET_DEPT_ID = value;}}

		#endregion 
	}	
}
