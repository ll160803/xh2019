
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

	public partial interface ServiceContract_BGT_B_DEPT_HIS_DATA_D
	{

        DisplayObject_BGT_B_DEPT_HIS_DATA_D[] Query2(CauseObject_BGT_B_DEPT_HIS_DATA_D cause);
        DisplayObject_BGT_B_DEPT_HIS_DATA_D_EXT[] QueryPlanExt(CauseObject_BGT_B_DEPT_HIS_DATA_D cause, PagingParamter paging, OrderByParameter order);
        DisplayObject_BGT_B_DEPT_HIS_DATA_D_EXT[] QueryFinanceExt(CauseObject_BGT_B_DEPT_HIS_DATA_D cause, PagingParamter paging, OrderByParameter order);	
	}
}
