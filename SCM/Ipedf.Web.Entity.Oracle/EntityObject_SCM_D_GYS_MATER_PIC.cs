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
	[DataObject("SCM_D_GYS_MATER_PIC")]
	public partial class CauseObject_SCM_D_GYS_MATER_PIC:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _FREEUSE1 = string.Empty;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String _FREEUSE3 = string.Empty;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String _CHARGE = string.Empty;
		[DataMember]
		public System.String  CHARGE{get{ return  _CHARGE;}set{ _CHARGE = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _MATER_ID = string.Empty;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _FREEUSE2 = string.Empty;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_D_GYS_MATER_PIC")]
	public partial class DisplayObject_SCM_D_GYS_MATER_PIC:EntityObject_SCM_D_GYS_MATER_PIC
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _MATER_ID_NAME = string.Empty;
		[DataMember]
		public System.String MATER_ID_NAME{get{ return  _MATER_ID_NAME;}set{ _MATER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("SCM_D_GYS_MATER_PIC")]
	public partial class EntityObject_SCM_D_GYS_MATER_PIC:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _FREEUSE1;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String  _FREEUSE3;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.String  _CHARGE;
		[DataMember]
		public System.String  CHARGE{get{ return  _CHARGE;}set{ _CHARGE = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _MATER_ID;
		[DataMember]
		public System.String  MATER_ID{get{ return  _MATER_ID;}set{ _MATER_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _FREEUSE2;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
