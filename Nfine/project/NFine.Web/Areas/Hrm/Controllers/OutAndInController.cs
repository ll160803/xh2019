using NFine.Application.Hrm;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class OutAndInController : ControllerBase
    {
        private RoleAuthorizeApp roleAuthorizeApp = new RoleAuthorizeApp();
        private ViewOutAndInApp app = new ViewOutAndInApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewOutAndInEntity, bool>> expression = ExtLinq.True<ViewOutAndInEntity>();

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewOutAndInEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
           // var authorizedata = new List<RoleAuthorizeEntity>();
            var userId = OperatorProvider.Provider.GetCurrent().UserId;
            expression = expression.And(t => t.F_CreatorUserId == userId);
            //if (!string.IsNullOrEmpty(userId))
            //{
            //    authorizedata = roleAuthorizeApp.GetOrganizeList(userId);
            //}
            //if (authorizedata.Count == 0)
            //{
            //    var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            //    expression = expression.And(p => p.OrganizeId == orgId);
            //}
            //else
            //{
            //    var orgIds = "," + string.Join(",", authorizedata.Select(u => u.F_ItemId)) + ",";
            //    expression = expression.And(p => orgIds.Contains("," + p.OrganizeId + ","));
            //}
            var data = new
            {
                rows = app.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
    }
}
