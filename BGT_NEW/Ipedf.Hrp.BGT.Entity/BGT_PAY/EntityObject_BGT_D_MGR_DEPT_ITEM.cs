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
	[DataObject("BGT_D_MGR_DEPT_ITEM")]
	public partial class CauseObject_BGT_D_MGR_DEPT_ITEM:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MGR_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MGR_DEPT_ID{get{ return  _MGR_DEPT_ID;}set{ _MGR_DEPT_ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MGR_DEPT_ITEM")]
	public partial class DisplayObject_BGT_D_MGR_DEPT_ITEM:EntityObject_BGT_D_MGR_DEPT_ITEM
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}
		 System.String _MGR_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String MGR_DEPT_ID_NAME{get{ return  _MGR_DEPT_ID_NAME;}set{ _MGR_DEPT_ID_NAME = value;}}
		 System.String _BUDGET_YEAR_NAME = string.Empty;
		[DataMember]
		public System.String BUDGET_YEAR_NAME{get{ return  _BUDGET_YEAR_NAME;}set{ _BUDGET_YEAR_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_MGR_DEPT_ITEM")]
	public partial class EntityObject_BGT_D_MGR_DEPT_ITEM:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MGR_DEPT_ID;
		[DataMember]
		public System.String  MGR_DEPT_ID{get{ return  _MGR_DEPT_ID;}set{ _MGR_DEPT_ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}

		#endregion 
	}	
}
