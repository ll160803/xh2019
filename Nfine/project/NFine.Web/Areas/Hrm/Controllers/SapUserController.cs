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
    public class SapUserController : ControllerBase
    {
        //
        // GET: /Hrm/SapUser/
        private HrmUserApp userApp = new HrmUserApp();
        public ActionResult Out(string id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult In(string id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        [HandlerAjaxOnly]
        public JsonResult GetComboGridJson(string id,  string order, string sort, string keyword, int page = 1, int rows = int.MaxValue)
        {
            Pagination pagination = new Pagination { page = page, rows = rows, sidx = order, sord = sort };
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.OrganizeId == orgId);
            if (!string.IsNullOrEmpty(id))
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
            return Json(new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total
                
            });
            //var data = new
            //{
            //    rows = userApp.GetList(pagination, expression),
            //    total = pagination.total,
            //    page = pagination.page,
            //    records = pagination.records
            //};
            //return Content(data.ToJson());
        }


        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.OrganizeId == orgId);
            if (!string.IsNullOrEmpty(id))
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJsonForIn(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();

            expression = expression.And(p => string.IsNullOrEmpty(p.OrganizeId));
            if (!string.IsNullOrEmpty(id))
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveUser(string keyValue)
        {
            var user = userApp.GetForm(keyValue);
            var orgId = user.OrganizeId;
            user.OrganizeId = "";
            userApp.SubmitForm(user, keyValue);
            AddOutAndInRecord(user, "科室移出", orgId);//移出时 增加移出科室
            return Success("移出成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult InUser(string keyValue)
        {
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            var user = userApp.GetForm(keyValue);
            user.OrganizeId = orgId;
            userApp.SubmitForm(user, keyValue);
            AddOutAndInRecord(user, "科室移入", orgId);
            return Success("移入成功。");
        }
        /// <summary>
        /// 添加移入和移出的记录
        /// </summary>
        /// <param name="hrmUser">员工</param>
        /// <param name="operateType">操作类型</param>
        private void AddOutAndInRecord(HrmUserEntity hrmUser, string operateType, string OrganizeId)
        {
            OutAndInEntity entity = new OutAndInEntity();
            entity.F_Id = Guid.NewGuid().ToString();
            entity.UserId = hrmUser.F_Id;
            entity.OperateTime = DateTime.Now;
            entity.OperateType = operateType;
            entity.OrganizeId = OrganizeId;
            OutAndInApp app = new OutAndInApp();
            app.SubmitForm(entity, "");//创建移入移出记录
        }
    }
}
