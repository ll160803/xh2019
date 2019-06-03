using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Collections.Generic;

namespace Ipedf.Web.Entity
{
    public partial class DisplayObject_SCM_B_QUOTEDPRICE
    {
        [DataMember]
        public List<DisplayObject_SCM_B_QUOTEDPRICE_D> Hospitals = new List<DisplayObject_SCM_B_QUOTEDPRICE_D>();
    }
}
