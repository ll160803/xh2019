using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Ipedf.Web.ServiceContract
{
    public partial interface ServiceContract_SCM_D_PURCHARSEPLAN
    {
        [OperationContract]
        int IsAllowAdd(string EBELN, string EBELP, decimal MENGE, string gysaccount, string matnr, string charge, decimal Flag, string ID);
    }
}
