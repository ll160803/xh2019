/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Application.Hrm;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace NFine.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult Default()
        {
            ViewBag.IsView = OperatorProvider.Provider.GetCurrent().RoleId == "d9ad2ffb-7c8c-4e77-80c6-5959d17ecc8b";//只有科室主任显示
            var authorizedata = new List<RoleAuthorizeEntity>();
            RoleAuthorizeApp roleAuthorizeApp = new RoleAuthorizeApp();
            AttendanceRecordApp app = new AttendanceRecordApp();
            System.Linq.Expressions.Expression<Func<AttendanceRecordEntity, bool>> expression = ExtLinq.True<AttendanceRecordEntity>();
            var userId = OperatorProvider.Provider.GetCurrent().UserId;
            if (!string.IsNullOrEmpty(userId))
            {
                authorizedata = roleAuthorizeApp.GetOrganizeList(userId);
            }
            if (authorizedata.Count == 0)
            {
                ViewBag.Count = 0;
            }
            else
            {
                var orgIds = "," + string.Join(",", authorizedata.Select(u => u.F_ItemId)) + ",";
                expression = expression.And(p => orgIds.Contains("," + p.OrganizeId + ","));
            }
            expression = expression.And(t => t.State == 2);
            Pagination pagination = new Pagination { page = 1, rows = 10, sidx = "F_CreatorTime", sord = "asc" };
            app.GetList(pagination, expression);
            ViewBag.Count = pagination.records;
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
    }
}
