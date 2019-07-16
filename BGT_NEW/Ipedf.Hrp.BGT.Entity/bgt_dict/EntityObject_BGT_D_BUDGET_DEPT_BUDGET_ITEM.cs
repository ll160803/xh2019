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
    [DataObject("BGT_D_BUDGET_DEPT_BUDGET_ITEM")]
    public partial class CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM : CauseBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _BUDGET_ITEM_ID = string.Empty;
        [DataMember]
        public System.String BUDGET_ITEM_ID { get { return _BUDGET_ITEM_ID; } set { _BUDGET_ITEM_ID = value; } }
        System.String _BASE_ID = string.Empty;
        [DataMember]
        public System.String BASE_ID { get { return _BASE_ID; } set { _BASE_ID = value; } }
        System.String _ID = string.Empty;
        [DataMember]
        public System.String ID { get { return _ID; } set { _ID = value; } }

        #endregion
    }
    [Serializable]
    [DataContract]
    [DataObject("BGT_D_BUDGET_DEPT_BUDGET_ITEM")]
    public partial class DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM : EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _BUDGET_ITEM_ID_NAME = string.Empty;
        [DataMember]
        public System.String BUDGET_ITEM_ID_NAME { get { return _BUDGET_ITEM_ID_NAME; } set { _BUDGET_ITEM_ID_NAME = value; } }

        #endregion
    }
    [Serializable]
    [DataContract]
    [DataObject("BGT_D_BUDGET_DEPT_BUDGET_ITEM")]
    public partial class EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _BUDGET_ITEM_ID;
        [DataMember]
        public System.String BUDGET_ITEM_ID { get { return _BUDGET_ITEM_ID; } set { _BUDGET_ITEM_ID = value; } }
        System.String _BASE_ID;
        [DataMember]
        public System.String BASE_ID { get { return _BASE_ID; } set { _BASE_ID = value; } }
        System.String _ID;
        [DataMember]
        public System.String ID { get { return _ID; } set { _ID = value; } }

        #endregion
    }

}
