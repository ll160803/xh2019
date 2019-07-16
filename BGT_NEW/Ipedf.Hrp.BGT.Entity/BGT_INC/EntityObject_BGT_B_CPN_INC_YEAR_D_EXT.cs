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
    public partial class DisplayObject_BGT_B_CPN_INC_YEAR_D_EXT : DisplayObject_BGT_B_CPN_INC_YEAR_D
    {
        public string UNIT_ID { get; set; }
        public string UNIT_ID_NAME { get; set; }
    }
}
