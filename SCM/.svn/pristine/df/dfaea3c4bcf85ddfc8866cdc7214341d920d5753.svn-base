using System;
using System.Data;
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
	public partial class BizLogicObject_V_SCM_B_QUOTEDPRICE
	{
        public DisplayObject_V_SCM_B_QUOTEDPRICE[] Query_U(CauseObject_V_SCM_B_QUOTEDPRICE cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {

                //平台自动生成代码
                return Query_Update(HelperObject_V_SCM_B_QUOTEDPRICE.Query(cause, paging, order));
            }
            else
            {
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.Query_U(cause, paging, order);
                }
            }
        }

        private DisplayObject_V_SCM_B_QUOTEDPRICE[] Query_Update(DisplayObject_V_SCM_B_QUOTEDPRICE[] itemDisplay)
        {
            if (itemDisplay.Length > 0)
            {
                DisplayObject_V_SCM_B_QUOTEDPRICE[] retItemDisplay = new DisplayObject_V_SCM_B_QUOTEDPRICE[itemDisplay.Length];
                int nCount = 0;
                foreach (DisplayObject_V_SCM_B_QUOTEDPRICE display in itemDisplay)
                {
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
                        display.QUOTED_PRICE_MSEHT = "暂无报价数量";
                        display.SUPPLY_AMOUNT_MSEHT = "暂无可供货数量";
                    }

                    retItemDisplay[nCount] = display;
                    nCount++;
                }

                return retItemDisplay;
            }
            else
            {
                return itemDisplay;
            }
            
        }
	}
}
