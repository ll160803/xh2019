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
    [DataObject("SCM_B_QUOTEDPRICE_D")]
    public partial class DisplayObject_SCM_B_QUOTEDPRICE_D : EntityObject_SCM_B_QUOTEDPRICE_D
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _COM_FILE_ID_NAME = string.Empty;
        [DataMember]
        public System.String COM_FILE_ID_NAME { get { return _COM_FILE_ID_NAME; } set { _COM_FILE_ID_NAME = value; } }


        System.String _COM_FILE_ID_S_NAME = string.Empty;
        [DataMember]
        public System.String COM_FILE_ID_S_NAME { get { return _COM_FILE_ID_S_NAME; } set { _COM_FILE_ID_S_NAME = value; } }
        #endregion
    }
}
