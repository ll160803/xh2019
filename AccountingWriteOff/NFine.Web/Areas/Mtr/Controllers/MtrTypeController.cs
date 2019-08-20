using NFine.Code;
using NFine.Domain.Entity.Mtr;
using NFine.Application.Mtr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using NFine.Domain.Entity.SystemManage;
using NFine.Application.SystemManage;

namespace NFine.Web.Areas.Mtr.Controllers
{
    public class MtrTypeController : ControllerBase
    {
        //
        // GET: /Mtr/MtrType/
        private MtrFund_MtrTypeApp mtrApp = new MtrFund_MtrTypeApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<MtrFund_MtrTypeEntity, bool>> expression = ExtLinq.True<MtrFund_MtrTypeEntity>();

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<MtrFund_MtrTypeEntity>();
                keyPress = keyPress.And(t => t.F_ItemName.Contains(keyword));
                keyPress = keyPress.Or(t => t.F_ItemCode.Contains(keyword));
                expression = expression.And(keyPress);
            }


            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = mtrApp.GetList(new Pagination { page = 1, rows = int.MaxValue }, expression);
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.F_IGortCode equals au.F_Id
                         select m;
            var data = new
            {
                rows = reData.Skip((pagination.page - 1) * pagination.rows).Take(pagination.rows),
                total = reData.Count(),
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = mtrApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {

            //var entity = mtrApp.GetForm(keyValue);
            //entity.F_DeleteMark = true;
            new MtrFund_MtrTypeApp().Delete(new MtrFund_MtrTypeEntity { F_Id = keyValue });
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(MtrFund_MtrTypeEntity userEntity, string keyValue)
        {
            userEntity.F_Id = userEntity.F_ItemCode;
            mtrApp.SubmitForm(userEntity, keyValue);
            return Success("操作成功。");
        }
    }
}
