﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Core;

namespace Ipedf.Web.BizLogic
{
    [ServiceContract]
    [ServiceKnownType(typeof(EntityObject_COMPLETEPERCENT))]
    public partial interface ServiceContract_COMPLETEPERCENT : IServiceContractLocal<EntityObject_COMPLETEPERCENT,CauseObject_COMPLETEPERCENT>
    {
        EntityObject_COMPLETEPERCENT[] List(DateTime dtBegin, DateTime dtEnd, string gysAccount,string gysName);
        EntityObject_COMPLETEPERCENT[] MaterList(string dtBegin, string dtEnd, string gysAccount, string gysName, string matnr, string txz01, string WERKST, string order, string sort, out int totalRecord, int page, int pageSize);
    }
}
