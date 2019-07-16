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
	[DataObject("BGT_D_BUDGET_MONTH")]
	public partial class CauseObject_BGT_D_BUDGET_MONTH:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BUDGET_MONTH = string.Empty;
		[DataMember]
		public System.String  BUDGET_MONTH{get{ return  _BUDGET_MONTH;}set{ _BUDGET_MONTH = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_MONTH")]
	public partial class DisplayObject_BGT_D_BUDGET_MONTH:EntityObject_BGT_D_BUDGET_MONTH
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("BGT_D_BUDGET_MONTH")]
	public partial class EntityObject_BGT_D_BUDGET_MONTH:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BUDGET_MONTH;
		[DataMember]
		public System.String  BUDGET_MONTH{get{ return  _BUDGET_MONTH;}set{ _BUDGET_MONTH = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
