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
	[DataObject("V_COM_QUERY_STRATEGIES")]
	public partial class CauseObject_V_COM_QUERY_STRATEGIES:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _DATA_LIMIT = string.Empty;
		public System.String  DATA_LIMIT{get{ return  _DATA_LIMIT;}set{ _DATA_LIMIT = value;}}
		System.String _STRATEGY_TYPE = string.Empty;
		public System.String  STRATEGY_TYPE{get{ return  _STRATEGY_TYPE;}set{ _STRATEGY_TYPE = value;}}
		System.String _USER_ID = string.Empty;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _DATAOBJECT = string.Empty;
		public System.String  DATAOBJECT{get{ return  _DATAOBJECT;}set{ _DATAOBJECT = value;}}
		System.String _STRATEGY_CUSTOMCONDITION = string.Empty;
		public System.String  STRATEGY_CUSTOMCONDITION{get{ return  _STRATEGY_CUSTOMCONDITION;}set{ _STRATEGY_CUSTOMCONDITION = value;}}

		#endregion 
	}
	[Serializable]
	[DataObject("V_COM_QUERY_STRATEGIES")]
	public partial class DisplayObject_V_COM_QUERY_STRATEGIES:EntityObject_V_COM_QUERY_STRATEGIES
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataObject("V_COM_QUERY_STRATEGIES")]
	public partial class EntityObject_V_COM_QUERY_STRATEGIES:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _DATA_LIMIT;
		public System.String  DATA_LIMIT{get{ return  _DATA_LIMIT;}set{ _DATA_LIMIT = value;}}
		System.String  _STRATEGY_TYPE;
		public System.String  STRATEGY_TYPE{get{ return  _STRATEGY_TYPE;}set{ _STRATEGY_TYPE = value;}}
		System.String  _USER_ID;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _DATAOBJECT;
		public System.String  DATAOBJECT{get{ return  _DATAOBJECT;}set{ _DATAOBJECT = value;}}
		System.String  _STRATEGY_CUSTOMCONDITION;
		public System.String  STRATEGY_CUSTOMCONDITION{get{ return  _STRATEGY_CUSTOMCONDITION;}set{ _STRATEGY_CUSTOMCONDITION = value;}}

		#endregion 
	}	
}
