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
	public partial class DisplayObject_SCM_B_PRICEADJUST
	{
        System.Decimal _IS_QUERYPRICE;
        [DataMember]
        public System.Decimal IS_QUERYPRICE { get { return _IS_QUERYPRICE; } set { _IS_QUERYPRICE = value; } }
	}
}
