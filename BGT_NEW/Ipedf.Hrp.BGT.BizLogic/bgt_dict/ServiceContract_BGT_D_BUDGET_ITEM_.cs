
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using System.Collections.Generic;
namespace Ipedf.Web.ServiceContract
{
	
	public partial interface ServiceContract_BGT_D_BUDGET_ITEM
	{	
		[OperationContract]
        BizLogicMsg AppendByAccountItem(string parentId, string[] account);
        [OperationContract]
        BizLogicMsg ImportDataService(string budgetYear, string parentID, DataTable data);
        [OperationContract]
        List<string> CheckImportService(DataTable data);
	}
}
