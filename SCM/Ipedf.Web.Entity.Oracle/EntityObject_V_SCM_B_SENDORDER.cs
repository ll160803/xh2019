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
	[DataObject("V_SCM_B_SENDORDER")]
	public partial class CauseObject_V_SCM_B_SENDORDER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _GYSACCOUNT = string.Empty;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.Decimal _FPJR = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  FPJR{get{ return  _FPJR;}set{ _FPJR = value;}}
		System.String _FPHM = string.Empty;
		[DataMember]
		public System.String  FPHM{get{ return  _FPHM;}set{ _FPHM = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _GYSNAME = string.Empty;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_B_SENDORDER")]
	public partial class DisplayObject_V_SCM_B_SENDORDER:EntityObject_V_SCM_B_SENDORDER
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_SCM_B_SENDORDER")]
	public partial class EntityObject_V_SCM_B_SENDORDER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
        System.String _WERKST;
        [DataMember]
        public System.String WERKST { get { return _WERKST; } set { _WERKST = value; } }
		System.String  _GYSACCOUNT;
		[DataMember]
		public System.String  GYSACCOUNT{get{ return  _GYSACCOUNT;}set{ _GYSACCOUNT = value;}}
		System.Decimal  _FPJR;
		[DataMember]
		public System.Decimal  FPJR{get{ return  _FPJR;}set{ _FPJR = value;}}
		System.String  _FPHM;
		[DataMember]
		public System.String  FPHM{get{ return  _FPHM;}set{ _FPHM = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _GYSNAME;
		[DataMember]
		public System.String  GYSNAME{get{ return  _GYSNAME;}set{ _GYSNAME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
        System.DateTime? _FPRQ;
        [DataMember]
        public System.DateTime? FPRQ { get { return _FPRQ; } set { _FPRQ = value; } }

		#endregion 
	}	
}
