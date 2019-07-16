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
    public class Mtr_D_MtrController : ControllerBase
    {
        private MtrFund_D_MtrApp mtrApp = new MtrFund_D_MtrApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<MtrFund_D_MtrEntity, bool>> expression = ExtLinq.True<MtrFund_D_MtrEntity>();



            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<MtrFund_D_MtrEntity>();
                keyPress = keyPress.And(t => t.Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = mtrApp.GetList(pagination, expression);
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.StockId equals au.F_Id
                         select m;
            var data = new
            {
                rows = reData,
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpPost]
        [HandlerAjaxOnly]
        public JsonResult GetComboGridJson(string id, string order, string sort, string keyword, int page = 1, int rows = int.MaxValue)
        {
            Pagination pagination = new Pagination { page = page, rows = rows, sidx = order, sord = sort };
            System.Linq.Expressions.Expression<Func<MtrFund_D_MtrEntity, bool>> expression = ExtLinq.True<MtrFund_D_MtrEntity>();



            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<MtrFund_D_MtrEntity>();
                keyPress = keyPress.And(t => t.Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = mtrApp.GetList(pagination, expression);
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.StockId equals au.F_Id
                         select m;
            return Json(new
            {
                rows = reData,
                total = pagination.total
            });
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

            var entity = mtrApp.GetForm(keyValue);
            entity.F_DeleteMark = true;
            new MtrFund_D_MtrApp().SubmitForm(entity, keyValue);
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult GetGridJsonExport(string id, Pagination pagination, string keyword, string titleAndField, int state = -1)
        {
            System.Linq.Expressions.Expression<Func<MtrFund_D_MtrEntity, bool>> expression = ExtLinq.True<MtrFund_D_MtrEntity>();


            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<MtrFund_D_MtrEntity>();
                keyPress = keyPress.And(t => t.Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            pagination.page = 1;
            pagination.rows = int.MaxValue;
            var rows = mtrApp.GetList(pagination, expression);

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel(rows, dicFields, new ExcelCaption { CaptionName = "物资表", Height = 24 });

            return Success("下载成功", downUrl);
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(MtrFund_D_MtrEntity userEntity, string keyValue)
        {
            if(!mtrApp.IsExist(userEntity,keyValue))
            {
                return Error("已经存在相同名称和规格的物资。");
            }
            userEntity.AbbreviationName = PinYin.GetCodstring(userEntity.Name);
            mtrApp.SubmitForm(userEntity, keyValue);
            return Success("操作成功。");
        }
       
    }
}
