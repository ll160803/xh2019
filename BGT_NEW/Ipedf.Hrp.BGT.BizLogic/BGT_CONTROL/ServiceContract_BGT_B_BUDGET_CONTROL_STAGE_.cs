
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
	public partial interface ServiceContract_BGT_B_BUDGET_CONTROL_STAGE
	{
        BizLogicMsg Action_NewYear(string old_year_id, string new_year_id);
	}
}
