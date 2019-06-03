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
    public partial class EntityObject_SCM_D_SUPPLYPLAN 
    {
        System.DateTime? _HSDAT;
        [DataMember]
        public System.DateTime? HSDAT { get { return _HSDAT; } set { _HSDAT = value; } }

        System.DateTime? _FPRQ;
        [DataMember]
        public System.DateTime? FPRQ { get { return _FPRQ; } set { _FPRQ = value; } }
    }
}
