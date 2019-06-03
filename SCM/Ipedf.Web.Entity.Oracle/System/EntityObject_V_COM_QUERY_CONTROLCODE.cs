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
	[DataObject("V_COM_QUERY_CONTROLCODE")]
	public partial class CauseObject_V_COM_QUERY_CONTROLCODE:CauseBase
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有
		System.String _CONTROL_CODE = string.Empty;
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String _DEFAULT_PAGE_URL = string.Empty;
		public System.String  DEFAULT_PAGE_URL{get{ return  _DEFAULT_PAGE_URL;}set{ _DEFAULT_PAGE_URL = value;}}
		System.String _USER_ID = string.Empty;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_COM_QUERY_CONTROLCODE:EntityObject_V_COM_QUERY_CONTROLCODE
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_COM_QUERY_CONTROLCODE:EntityBase
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有
		System.String  _CONTROL_CODE;
		public System.String  CONTROL_CODE{get{ return  _CONTROL_CODE;}set{ _CONTROL_CODE = value;}}
		System.String  _DEFAULT_PAGE_URL;
		public System.String  DEFAULT_PAGE_URL{get{ return  _DEFAULT_PAGE_URL;}set{ _DEFAULT_PAGE_URL = value;}}
		System.String  _USER_ID;
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}

		#endregion 
	}	
}
