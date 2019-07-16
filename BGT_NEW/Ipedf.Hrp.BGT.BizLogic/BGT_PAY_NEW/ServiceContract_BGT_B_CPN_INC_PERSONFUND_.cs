using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.ServiceContract
{
    public partial interface ServiceContract_BGT_B_CPN_INC_PERSONFUND
    {
        [OperationContract]
        BizLogicMsg CommitSaveExt(EntityObject_BGT_B_CPN_INC_PERSONFUND entity, EntityObject_BGT_B_CPN_INC_PF_D pfD1, EntityObject_BGT_B_CPN_INC_PF_D pfD2, EntityObject_BGT_B_CPN_INC_PF_D_D[] detail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] detail2);
        [OperationContract]
        BizLogicMsg CommitUpdateExt(EntityObject_BGT_B_CPN_INC_PERSONFUND entity, EntityObject_BGT_B_CPN_INC_PF_D pfD1, EntityObject_BGT_B_CPN_INC_PF_D pfD2, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] updateDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] deleteDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetail2, EntityObject_BGT_B_CPN_INC_PF_D_D[] updateDetail2, EntityObject_BGT_B_CPN_INC_PF_D_D[] deleteDetail2);
    }
}
