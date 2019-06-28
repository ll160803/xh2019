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
	[DataObject("COM_CHINESE_SPELL")]
	public partial class CauseObject_COM_CHINESE_SPELL:CauseBase
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有
		System.String _CHINESE = string.Empty;
		public System.String  CHINESE{get{ return  _CHINESE;}set{ _CHINESE = value;}}
		System.String _ID = string.Empty;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _SPELL = string.Empty;
		public System.String  SPELL{get{ return  _SPELL;}set{ _SPELL = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_COM_CHINESE_SPELL:EntityObject_COM_CHINESE_SPELL
	{
		#region Attribute Block
		
			//试用版本,平纹软件,版权所有

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_COM_CHINESE_SPELL
	{
		#region Attribute Block:EntityBase
		
			//试用版本,平纹软件,版权所有
		System.String  _CHINESE;
		public System.String  CHINESE{get{ return  _CHINESE;}set{ _CHINESE = value;}}
		System.String  _ID;
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _SPELL;
		public System.String  SPELL{get{ return  _SPELL;}set{ _SPELL = value;}}

		#endregion 
	}	
}
