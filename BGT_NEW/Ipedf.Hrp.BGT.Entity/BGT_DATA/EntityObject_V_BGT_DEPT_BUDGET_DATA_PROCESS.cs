using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataObject("V_BGT_DEPT_BUDGET_DATA_PROCESS")]
	public partial class CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _DEPT_NAME = string.Empty;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.String _STATUS = string.Empty;
		[DataMember]
		public System.String  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _TEMPLET_ID = string.Empty;
		[DataMember]
		public System.String  TEMPLET_ID{get{ return  _TEMPLET_ID;}set{ _TEMPLET_ID = value;}}
		System.String _BUDGET_CONTENTS_ID = string.Empty;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS:EntityObject_V_BGT_DEPT_BUDGET_DATA_PROCESS
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_BGT_DEPT_BUDGET_DATA_PROCESS:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _DEPT_NAME;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.String  _STATUS;
		[DataMember]
		public System.String  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _TEMPLET_ID;
		[DataMember]
		public System.String  TEMPLET_ID{get{ return  _TEMPLET_ID;}set{ _TEMPLET_ID = value;}}
		System.String  _BUDGET_CONTENTS_ID;
		[DataMember]
		public System.String  BUDGET_CONTENTS_ID{get{ return  _BUDGET_CONTENTS_ID;}set{ _BUDGET_CONTENTS_ID = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}

		#endregion 
	}	
}
