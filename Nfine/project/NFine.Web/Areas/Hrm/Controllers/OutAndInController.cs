using NFine.Application.Hrm;
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class OutAndInController : ControllerBase
    {
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
