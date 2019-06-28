using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Web.BizLogic;
using Ipedf.Core;
using Models;
using Ipedf.Web.Entity;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_COM_DRUGController : BaseController
    {
        //
        // GET: /System/SCM_COM_DRUG/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string Name, string Code)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_SCM_COM_DRUG cause = new CauseObject_SCM_COM_DRUG();
            cause.DELETEFLAG = 0;
            if (!string.IsNullOrEmpty(Name))
            {
                if (!string.IsNullOrEmpty(Name.Trim()))
                    cause.NAME = "%" + Name.Trim() + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                if (!string.IsNullOrEmpty(Code.Trim()))
                    cause.CODE = "%" + Code.Trim() + "%";
            }
            var pageList = BizLogicObject_SCM_COM_DRUG.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new datagrid
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        public JsonResult GetComBoxData(int page, int rows, string order, string sort, string keyword)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_COM_DRUG cause = new CauseObject_SCM_COM_DRUG();
            cause.DELETEFLAG = 0;
            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(keyword.Trim()))
                    cause.NAME = "%" + keyword.Trim() + "%";
            }
            var dataSource = BizLogicObject_SCM_COM_DRUG.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_COM_DRUG> queryData = dataSource.ToList();

            return Json(new datagrid
            {
                total = paging.TotalRecords,
                rows = queryData
            });

        }
    }
}
