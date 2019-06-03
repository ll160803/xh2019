using System;
using System.Data;
using System.Linq;
using System.Collections;
using System.ServiceModel;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.ServiceContract;
using Ipedf.Web.DataAccess;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Web.BizLogic
{
	public partial class BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL
	{

        public DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query_U(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,bool IsOrder, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {

                //平台自动生成代码
                return Query_Update(HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Query(cause, paging, order), IsOrder);
            }
            else
            {
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Query_U(cause,IsOrder, paging, order);
                }
            }
        }

        private DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query_Update(DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] itemDisplay, bool IsOrder)
        {
            if (itemDisplay.Length > 0)
            {
                var itemRes =
                    from p in itemDisplay
                    group p by p.GYSACCOUNT into g
                    select new
                    {
                        g.Key,
                        QUOTED_PRICE_MIN = g.Min(p => p.QUOTED_PRICE)
                    };
                DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] retItemDisplay = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[itemDisplay.Length];
                int nCount = 0;
                foreach (DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL display in itemDisplay)
                {
                    var queryRes = itemRes.Where(m => m.Key == display.GYSACCOUNT).ToArray();
                    display.QUOTED_PRICE_MIN = queryRes[0].QUOTED_PRICE_MIN;
                    if (display.QUOTED_PRICE != 0)
                    {
                        display.QUOTED_PRICE_MSEHT = display.QUOTED_PRICE.ToString() + "元/" + display.MSEHT;
                    }
                    else
                    {
                        display.QUOTED_PRICE_MSEHT = "0";
                    }
                    if (display.SUPPLY_AMOUNT != 0)
                    {
                        display.SUPPLY_AMOUNT_MSEHT = display.SUPPLY_AMOUNT.ToString() + display.MSEHT;
                    }
                    else
                    {
                        display.SUPPLY_AMOUNT_MSEHT = "0";
                    }

                    if (display.QUOTED_PRICE == 0 && display.SUPPLY_AMOUNT == 0)
                    {
                        display.QUOTED_PRICE_MSEHT = "暂无报价价格";
                        display.SUPPLY_AMOUNT_MSEHT = "暂无可供货数量";
                    }
                    if (display.PRICE != 0)
                    {
                        display.PRICE_MSEHT = display.PRICE.ToString() + "元/" + display.MSEHT;
                    }
                    else
                    {
                        display.PRICE_MSEHT = "暂无进货价格";
                    }

                    if (display.ID == null || display.ID == "" || display.STATE==1)
                    {
                        display.CREATE_TIMES = "未报价";
                        display.PRODUCT_NAME = "　";
                        display.HOSPITAL_NAME = "　";
                        display.QUOTED_PRICE_MSEHT = "　";
                        display.PRICE_MSEHT = "　";
                        display.SUPPLY_AMOUNT_MSEHT = "　";
                        display.IS_TRUE = 2;
                    }
                    else
                    {
                        display.IS_TRUE = 1;
                        display.CREATE_TIMES = display.CREATE_TIME != null && display.CREATE_TIME != Ipedf.Common.Template.UndefineDatetime ? display.CREATE_TIME.ToString("yyyy-MM-dd") : "";
                    }
                    retItemDisplay[nCount] = display;
                    nCount++;
                }
                //QUOTED_PRICE_MIN desc,QUOTED_PRICE desc,PRICE
                if (IsOrder)
                {
                    return retItemDisplay.OrderBy(t => t.PRICE).OrderBy(o => o.QUOTED_PRICE).OrderBy(p => p.QUOTED_PRICE_MIN).OrderBy(p => p.IS_TRUE).ToArray();
                }
                else
                {
                    return retItemDisplay;
                }
            }
            else
            {
                return itemDisplay;
            }
        }
		
	}
}
