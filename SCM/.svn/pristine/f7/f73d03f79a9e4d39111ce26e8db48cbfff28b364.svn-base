using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Ipedf.Web.Entity;
using Ipedf.Core;
using Ipedf.Web.BizLogic;

namespace Ipedf.App.Areas.System.Controllers
{
    public class COM_FILEController : Controller
    {
        public JsonResult GetData(string id, int page, int rows, string order, string sort)
        {

            CauseObject_COM_FILE cause = new CauseObject_COM_FILE();
            cause.REF_TAB_ID = id;
            var pageIng = new PagingParamter { PageIndex = page - 1, PageSize = rows };


            var pageList = BizLogicObject_COM_FILE.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });

            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList


            });
        }
       
        public JsonResult Delete(string id)
        {
            var msg = BizLogicObject_COM_FILE.Proxy.Delete(new CauseObject_COM_FILE { ID = id });
            if (msg.Succeed == true)
            {
                return Json("OK");
            }
            else
            {
                return Json("F");
            }
        }
    }
}
