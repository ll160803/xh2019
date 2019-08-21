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
        private MtrFund_MtrTypeApp mtrTypeApp = new MtrFund_MtrTypeApp();
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
            var mtrData = mtrApp.GetList(new Pagination { page = 1, rows = int.MaxValue }, expression);
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.StockId equals au.F_Id
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


        public ActionResult HistoryIndex()
        {
            return View();
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson_history(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<Mtr_Fund_D_Mtr_HistoryEntity, bool>> expression = ExtLinq.True<Mtr_Fund_D_Mtr_HistoryEntity>();

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<Mtr_Fund_D_Mtr_HistoryEntity>();
                keyPress = keyPress.And(t => t.Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                keyPress = keyPress.Or(t => t.Ref_Id.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = new Mtr_Fund_D_Mtr_HistoryApp().GetList(pagination, expression);
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
        public JsonResult GetComboGridJson(string id, string order, string sort, string keyword, string Lgort, int page = 1, int rows = int.MaxValue)
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
            if (!string.IsNullOrEmpty(Lgort))
            {
                expression = expression.And(g => g.StockId == Lgort);
            }
            expression = expression.And(s => s.F_DeleteMark == false||s.F_DeleteMark==null);
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
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTypeGridJson(string keyword)
        {
            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = mtrTypeApp.GetList(new Pagination { page = 1, rows = int.MaxValue }, "");
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.F_IGortCode equals au.F_Id
                         select m;
            return Content(reData.ToJson());
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {

            var userEntity = mtrApp.GetForm(keyValue);
            userEntity.F_DeleteMark = true;
            new MtrFund_D_MtrApp().SubmitForm(userEntity, keyValue);
            new Mtr_Fund_D_Mtr_HistoryApp().SubmitForm(//增加一条历史记录
                new Mtr_Fund_D_Mtr_HistoryEntity
                {
                    Code = userEntity.Code,
                    StockId = userEntity.StockId,
                    AbbreviationName = userEntity.AbbreviationName,
                    Name = userEntity.Name,
                    Ref_Id = userEntity.F_Id,
                    Spec = userEntity.Spec,
                    StockName = userEntity.StockName,
                    TypeId = userEntity.TypeId,
                    TypeName = userEntity.TypeName,
                    UnitId = userEntity.UnitId,
                    UnitName = userEntity.UnitName,
                    F_DeleteMark = true
                }, ""
               );
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
            var authorizedata = new OrganizeApp().GetListByUserId(OperatorProvider.Provider.GetCurrent().UserId);
            var mtrData = mtrApp.GetList(pagination, expression);
            var reData = from m in mtrData
                         join au in authorizedata
                         on m.StockId equals au.F_Id
                         select m;
            //  var rows = mtrApp.GetList(pagination, expression);

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel(reData.ToList(), dicFields, new ExcelCaption { CaptionName = "物资表", Height = 24 });

            return Success("下载成功", downUrl);
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(MtrFund_D_MtrEntity userEntity, string keyValue)
        {
            if (!mtrApp.IsExist(userEntity, keyValue))
            {
                return Error("已经存在相同名称和规格的物资。");
            }
            userEntity.AbbreviationName = PinYin.GetCodstring(userEntity.Name);
            var stockId = mtrTypeApp.GetForm(userEntity.TypeId).F_IGortCode;
            var stockName = mtrTypeApp.GetForm(userEntity.TypeId).F_IGortName;
            userEntity.StockId = stockId;
            userEntity.StockName = stockName;
            mtrApp.SubmitForm(userEntity, keyValue);
            new Mtr_Fund_D_Mtr_HistoryApp().SubmitForm(//增加一条历史记录
                 new Mtr_Fund_D_Mtr_HistoryEntity
                 {
                     Code = userEntity.Code,
                     StockId = userEntity.StockId,
                     AbbreviationName = userEntity.AbbreviationName,
                     Name = userEntity.Name,
                     Ref_Id = userEntity.F_Id,
                     Spec = userEntity.Spec,
                     StockName = userEntity.StockName,
                     TypeId = userEntity.TypeId,
                     TypeName = userEntity.TypeName,
                     UnitId = userEntity.UnitId,
                     UnitName = userEntity.UnitName
                 }, ""
                );
            return Success("操作成功。");
        }

    }
}
