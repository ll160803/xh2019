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
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_BUDGET_DATA_CPN_2
    {
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_V_BGT_INC_BUDGET_DATA_EXT), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;
            //平台自动生成代码
            CauseObject_V_BGT_INC_BUDGET_DATA cause = new CauseObject_V_BGT_INC_BUDGET_DATA();
            if (ViewState["CUR_OBJ"] != null)
                cause.BUDGET_DATA_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_BUDGET_DATA).ID;
            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = true;
            orderBy.OrderBy = "ITEM_ID_NAME";
            dataSource = BizLogicObject_V_BGT_INC_BUDGET_DATA.Proxy.QueryExt(cause, null, orderBy);
            System.Collections.Generic.List<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT> list = new System.Collections.Generic.List<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT>();
            list.AddRange((DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_V_BGT_INC_BUDGET_DATA_EXT>(5));
            dataSource = list.ToArray();
            return dataSource;
        } 
        protected override string PrepareResultOrderByColumn()
        {
            return "id";
        }
        protected override string[] PrepareDetailGridKeyNames()
        {
            return new string[] { "item_id" };
        }
    }
}
