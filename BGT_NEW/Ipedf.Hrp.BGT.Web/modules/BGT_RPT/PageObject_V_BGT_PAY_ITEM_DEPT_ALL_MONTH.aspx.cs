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
	public partial class PageObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH : ComQueryPage
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
            return "ITEM_ID_NAME";
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ITEM_ID" };
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH cause = (CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH)parameter;
			dataSource = BizLogicObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH.Proxy.Query(cause,paging,orderBy);
            return dataSource;
        }           
        protected override object PrepareQueryParameter()
        {
			CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH cause = new CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_V_BGT_PAY_ITEM_DEPT_ALL_MONTH_PARAM.aspx", 500, 500);
            return scripts;
        }
	}
}

