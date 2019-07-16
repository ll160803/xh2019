using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
	public partial class PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS : ComQueryPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
           base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
		}
		protected override string PrepareOrderByColumn()
        {
            return "id";
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "id" };
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause = (CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS)parameter;
			dataSource = BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS.Proxy.Query(cause,paging,orderBy);
            return dataSource;
        }           
        protected override object PrepareQueryParameter()
        {
			CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause = new CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS_PARAM.aspx", 500, 500);
            return scripts;
        }
	}
}

