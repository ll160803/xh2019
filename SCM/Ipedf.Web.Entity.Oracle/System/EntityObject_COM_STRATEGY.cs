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
	[DataObject("COM_STRATEGY")]
	public partial class CauseObject_COM_STRATEGY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _STRATEGY_NAME = string.Empty;
		[DataMember]
		public System.String  STRATEGY_NAME{get{ return  _STRATEGY_NAME;}set{ _STRATEGY_NAME = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _STRATEGY_TYPE = string.Empty;
		[DataMember]
		public System.String  STRATEGY_TYPE{get{ return  _STRATEGY_TYPE;}set{ _STRATEGY_TYPE = value;}}
		System.String _STRATEGY_CODE = string.Empty;
		[DataMember]
		public System.String  STRATEGY_CODE{get{ return  _STRATEGY_CODE;}set{ _STRATEGY_CODE = value;}}
		System.String _STRATEGY_CUSTOMCONDITION = string.Empty;
		[DataMember]
		public System.String  STRATEGY_CUSTOMCONDITION{get{ return  _STRATEGY_CUSTOMCONDITION;}set{ _STRATEGY_CUSTOMCONDITION = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_STRATEGY")]
	public partial class DisplayObject_COM_STRATEGY:EntityObject_COM_STRATEGY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("COM_STRATEGY")]
	public partial class EntityObject_COM_STRATEGY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _STRATEGY_NAME;
		[DataMember]
		public System.String  STRATEGY_NAME{get{ return  _STRATEGY_NAME;}set{ _STRATEGY_NAME = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _STRATEGY_TYPE;
		[DataMember]
		public System.String  STRATEGY_TYPE{get{ return  _STRATEGY_TYPE;}set{ _STRATEGY_TYPE = value;}}
		System.String  _STRATEGY_CODE;
		[DataMember]
		public System.String  STRATEGY_CODE{get{ return  _STRATEGY_CODE;}set{ _STRATEGY_CODE = value;}}
		System.String  _STRATEGY_CUSTOMCONDITION;
		[DataMember]
		public System.String  STRATEGY_CUSTOMCONDITION{get{ return  _STRATEGY_CUSTOMCONDITION;}set{ _STRATEGY_CUSTOMCONDITION = value;}}

		#endregion 
	}	
}
