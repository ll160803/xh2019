using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAP.Middleware.Connector;
using Ipedf.App.Codes;
using Ipedf.App.Models;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Common;

namespace Ipedf.App.Controllers
{
    public class SAPDataController : Controller
    {
        //
        // GET: /SAP/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string I_WERKS, string I_LGORT, string I_CARDNO, string I_DATEL, string I_DATEH)
        {
            RfcDestination destination;
            RfcNOC rfc = new RfcNOC();
            var list = new List<KSLYCX_ENTITY>();
            if (!string.IsNullOrEmpty(I_LGORT))
            {
                I_LGORT = I_LGORT.Substring(2);
            }
            if (I_WERKS == "全部")
            {
                I_WERKS = "";
            }
            try
            {
                destination = rfc.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZMM00_FM_KSLYCX");
                myfun.SetValue("I_WERKS", I_WERKS);
                myfun.SetValue("I_LGORT", I_LGORT);//SAP里面的传入参数
                myfun.SetValue("I_CARDNO", I_CARDNO);//SAP里面的传入参数
                myfun.SetValue("I_DATEL", I_DATEL);//SAP里面的传入参数
                myfun.SetValue("I_DATEH", I_DATEH);//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZMM00_FM_KXLYCX is NULL");
                    return null;
                }
                IRfcTable IrfTable_OT_KSLYCX = myfun.GetTable("OT_KSLYCX");
                myfun.SetValue("OT_KSLYCX", IrfTable_OT_KSLYCX);
                myfun.Invoke(destination);//执行
                for (int i = 0; i < IrfTable_OT_KSLYCX.Count; i++)
                {
                    IrfTable_OT_KSLYCX.CurrentIndex = i;
                    list.Add(new KSLYCX_ENTITY
                    {
                        BRTWR = IrfTable_OT_KSLYCX.GetDecimal("BRTWR"),
                        CPUDT = IrfTable_OT_KSLYCX.GetString("CPUDT"),
                        BWART = IrfTable_OT_KSLYCX.GetString("BWART"),
                        CPUTM = IrfTable_OT_KSLYCX.GetString("CPUTM"),
                        ID = Guid.NewGuid().ToString(),
                        DMBTR = IrfTable_OT_KSLYCX.GetDecimal("DMBTR"),
                        KOSTL = IrfTable_OT_KSLYCX.GetString("KOSTL"),
                        LTEXT = IrfTable_OT_KSLYCX.GetString("LTEXT"),
                        MAKTX = IrfTable_OT_KSLYCX.GetString("MAKTX"),
                        MATNR = IrfTable_OT_KSLYCX.GetString("MATNR"),
                        MEINS = IrfTable_OT_KSLYCX.GetString("MEINS"),
                        MSEHL = IrfTable_OT_KSLYCX.GetString("MSEHL"),
                        MENGE = IrfTable_OT_KSLYCX.GetDecimal("MENGE"),
                        EBELN = IrfTable_OT_KSLYCX.GetString("MBLNR"),
                        NORMT = IrfTable_OT_KSLYCX.GetString("NORMT")
                    });
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                destination = null;
            }

            var total = list.Count;
            var queryData = list;
            var listFooter = new List<KSLYCX_ENTITY> {
              new KSLYCX_ENTITY{ CPUDT="总计：", DMBTR=list.Sum(p=>p.DMBTR), MENGE=list.Sum(p=>p.MENGE) }
            };
            return Json(new
            {
                total = total,
                rows = queryData,
                footer = listFooter
            });
        }

        [HttpPost]
        public ActionResult GetDataExport(Guid? id,string I_WERKS, string I_LGORT, string I_CARDNO, string I_DATEL, string I_DATEH)
        {
            RfcDestination destination;
            RfcNOC rfc = new RfcNOC();
            var list = new List<KSLYCX_ENTITY>();
            if (!string.IsNullOrEmpty(I_LGORT))
            {
                I_LGORT = I_LGORT.Substring(2);
            }
            if (I_WERKS == "全部")
            {
                I_WERKS = "";
            }
            try
            {
                destination = rfc.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZMM00_FM_KSLYCX");
                myfun.SetValue("I_WERKS", I_WERKS);
                myfun.SetValue("I_LGORT", I_LGORT);//SAP里面的传入参数
                myfun.SetValue("I_CARDNO", I_CARDNO);//SAP里面的传入参数
                myfun.SetValue("I_DATEL", I_DATEL);//SAP里面的传入参数
                myfun.SetValue("I_DATEH", I_DATEH);//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZMM00_FM_KXLYCX is NULL");
                    return null;
                }
                IRfcTable IrfTable_OT_KSLYCX = myfun.GetTable("OT_KSLYCX");
                myfun.SetValue("OT_KSLYCX", IrfTable_OT_KSLYCX);
                myfun.Invoke(destination);//执行
                for (int i = 0; i < IrfTable_OT_KSLYCX.Count; i++)
                {
                    IrfTable_OT_KSLYCX.CurrentIndex = i;
                    list.Add(new KSLYCX_ENTITY
                    {
                        BRTWR = IrfTable_OT_KSLYCX.GetDecimal("BRTWR"),
                        CPUDT = IrfTable_OT_KSLYCX.GetString("CPUDT"),
                        BWART = IrfTable_OT_KSLYCX.GetString("BWART"),
                        CPUTM = IrfTable_OT_KSLYCX.GetString("CPUTM"),
                        ID = Guid.NewGuid().ToString(),
                        DMBTR = IrfTable_OT_KSLYCX.GetDecimal("DMBTR"),
                        KOSTL = IrfTable_OT_KSLYCX.GetString("KOSTL"),
                        LTEXT = IrfTable_OT_KSLYCX.GetString("LTEXT"),
                        MAKTX = IrfTable_OT_KSLYCX.GetString("MAKTX"),
                        MATNR = IrfTable_OT_KSLYCX.GetString("MATNR"),
                        MEINS = IrfTable_OT_KSLYCX.GetString("MEINS"),
                        MSEHL = IrfTable_OT_KSLYCX.GetString("MSEHL"),
                        MENGE = IrfTable_OT_KSLYCX.GetDecimal("MENGE"),
                        EBELN = IrfTable_OT_KSLYCX.GetString("MBLNR"),
                        NORMT = IrfTable_OT_KSLYCX.GetString("NORMT")
                    });
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                destination = null;
            }

            var total = list.Count;


            list.Add(new KSLYCX_ENTITY { CPUDT = "总计：", DMBTR = list.Sum(p => p.DMBTR), MENGE = list.Sum(p => p.MENGE) });
            var queryData = list;
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //string[] Liststring = new string[] { "ID", "TXZ01", "MATNR", "CHARG", "VFDAT", "PKG_AMOUNT", "PKG_NUMBER", "MENGE", "ORDER_MENGE", "GYSNAME", "CODE", "MSEHT", "OUT_CAUSE", "OUT_DATE" };
            string[] Liststring = new string[] { "EBELN", "CPUDT", "CPUTM", "MATNR", "MAKTX", "NORMT", "MSEHL", "MENGE", "BRTWR", "DMBTR"};
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<KSLYCX_ENTITY>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1,"~/up/科室领用.xls","up/","科室领用"));

        }
        [HttpPost]
        public JsonResult GetKFDataForCombobox()
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_COM_TYPE cause = new CauseObject_COM_TYPE();
            cause.PARENT_ID = "SCM_SAP_KF_001";
            var dataSource = BizLogicObject_COM_TYPE.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_TYPE> queryData = dataSource.ToList();

            return Json(
                queryData.Select(s => new
                {
                    text = s.NAME,
                    value = s.CODE

                })
                );

        }
    }
}
