
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Models;
using Ipedf.Web.BizLogic;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_D_HRPMATERController : Controller
    {
        //
        // GET: /System/SCM_D_HRPMATER/
        //物资
        public JsonResult GetComBoxData(int page, int rows, string order, string sort, string keyword)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_D_HRPMATER cause = new CauseObject_SCM_D_HRPMATER();
            //   cause.DELETEFLAG = 0;
            //cause.MTART = "1006";
            string strSql = " AND SCM_D_HRPMATER.MTART IN(SELECT MTART FROM V_SCMHRPMATER_TYPE WHERE TYPE = 2)";
            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(keyword.Trim()))
                {
                    strSql += " AND (SCM_D_HRPMATER.MAKTX like '%" + keyword.Trim() + "%' or  upper(SCM_D_HRPMATER.ZEINR) like '%" + keyword.Trim().ToUpper() + "%') ";
                }
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }
            var dataSource = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_HRPMATER> queryData = dataSource.ToList();


            return Json(new datagrid
            {
                total = paging.TotalRecords,
                rows = queryData
            });

        }
        //药品
        public JsonResult GetComBoxDataMedicine(int page, int rows, string order, string sort, string keyword)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_D_HRPMATER cause = new CauseObject_SCM_D_HRPMATER();
            //   cause.DELETEFLAG = 0;
            //cause.MTART = "1006";
            string strSql = " AND SCM_D_HRPMATER.MTART IN(SELECT MTART FROM V_SCMHRPMATER_TYPE WHERE TYPE = 1)";
            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(keyword.Trim()))
                {
                    strSql += " AND (SCM_D_HRPMATER.MAKTX like '%" + keyword.Trim() + "%' or  upper(SCM_D_HRPMATER.ZEINR) like '%" + keyword.Trim().ToUpper() + "%') ";
                }
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }
            var dataSource = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_HRPMATER> queryData = dataSource.ToList();


            return Json(new datagrid
            {
                total = paging.TotalRecords,
                rows = queryData
            });

        }

    }
}
