using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Application.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class AskForLeaveController : ControllerBase
    {

        private ViewAskForLeaveApp viewApp = new ViewAskForLeaveApp();
        private AskForLeaveApp askApp = new AskForLeaveApp();
        // GET: /Hrm/AskForLeave/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">医生是1护士是2</param>
        /// <returns></returns>
        public ActionResult AskIndex(string id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewAskForLeaveEntity, bool>> expression = ExtLinq.True<ViewAskForLeaveEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.OrganizeId == orgId);
            if (!string.IsNullOrEmpty(id))
            {
                expression = expression.And(p => p.RYLB == id);//医生还是护士
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewAskForLeaveEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = viewApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = viewApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(AskForLeaveEntity userEntity, string keyValue)
        {
            if (string.IsNullOrEmpty(keyValue))
            {
                userEntity.State = 1;//草稿状态
                userEntity.IsNew = true;//激活的请假
                userEntity.AskSort = 1;//默认是1
            }
            else
            {
                if (userEntity.State != 1 || userEntity.IsNew == false)
                {
                    return Error("错误操作。");
                }
            }
            // userEntity.OrganizeId= OperatorProvider.Provider.GetCurrent().CompanyId;//当前科室
            var hasList = askApp.GetLeaveList(userEntity.HrmUserId, userEntity.StartDate.Value, userEntity.EndDate.Value, keyValue);
            if (hasList.Count > 0)
            {
                return Error("此员工在请假时间区间内，已经有请假记录，请核实后重新提交");
            }
            askApp.InsertForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitFormModify(AskForLeaveEntity userEntity, string keyValue)
        {

            userEntity.State = 1;//草稿状态
            userEntity.IsNew = true;//激活的请假
            userEntity.AskSort = userEntity.AskSort+1;//默认是增加1个
            userEntity.Ref_Id = userEntity.Ref_Id;//请假和请假改登之间的唯一标识
            // userEntity.OrganizeId= OperatorProvider.Provider.GetCurrent().CompanyId;//当前科室
            var hasList = askApp.GetLeaveList(userEntity.HrmUserId, userEntity.StartDate.Value, userEntity.EndDate.Value, keyValue);
            if (hasList.Count > 0)
            {
                return Error("此员工在请假时间区间内，已经有请假记录，请核实后重新提交");
            }
            var oldEntity = askApp.GetForm(keyValue);
            oldEntity.IsNew = false;//之前的请假记录不激活
            userEntity.F_Id = Guid.NewGuid().ToString();
            askApp.SubmitForm(oldEntity, keyValue);//之前的请假记录不激活
            askApp.SubmitForm(userEntity, "");
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假不能删除，具体请联系管理员。");
            }
            askApp.Delete(entity);
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLeave(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假已经提交，请勿重复操作，具体请联系管理员。");
            }
            entity.State = 2;
            askApp.SubmitForm(entity, keyValue);
            return Success("提交成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAudit(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假已经提交，请勿重复操作，具体请联系管理员。");
            }
            entity.State = 3;
            askApp.SubmitForm(entity, keyValue);
            return Success("审核成功。");
        }
    }
}
