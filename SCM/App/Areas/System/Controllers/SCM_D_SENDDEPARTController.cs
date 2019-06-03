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
    public class SCM_D_SENDDEPARTController : BaseController
    {
        //
        // GET: /System/SCM_D_SENDDEPART/

        public JsonResult GetComBoxData(int page, int rows, string order, string sort, string keyword,string type)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_D_SENDDEPART cause = new CauseObject_SCM_D_SENDDEPART();
            string vwhere = "";
            //   cause.DELETEFLAG = 0;
            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(keyword.Trim()))
                {
                    vwhere += (" and (SCM_D_SENDDEPART.NAME like '%" + keyword.Trim() + "%' or  upper(SCM_D_SENDDEPART.SPELL_CODE) like '%" + keyword.Trim().ToUpper() + "%') ");
                }
            }
            if (!string.IsNullOrEmpty(type.Trim()))
            {
                switch (type.Trim())
                {
                    case "2200":
                        vwhere += (" and upper(substr(trim(SCM_D_SENDDEPART.CODE),-1)) ='X' ");
                        break;
                    case "2100":
                        vwhere += (" and upper(substr(trim(SCM_D_SENDDEPART.CODE),-1)) ='Z'");
                        break;
                    default:
                        vwhere += (" and  upper(substr(trim(SCM_D_SENDDEPART.CODE),-1)) !='X' and upper(substr(trim(SCM_D_SENDDEPART.CODE),-1)) !='Z' ");
                        break;
                }
            }
            cause.SetCustomCondition(vwhere);
            var dataSource = BizLogicObject_SCM_D_SENDDEPART.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SENDDEPART> queryData = dataSource.ToList();
           

            return Json(new datagrid
            {
                total = paging.TotalRecords,
                rows = queryData
            }, JsonRequestBehavior.AllowGet);

        }
    }
}
