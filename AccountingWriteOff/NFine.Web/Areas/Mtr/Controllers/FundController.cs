using NFine.Code;
using NFine.Application.Mtr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using NFine.Domain.Entity.SystemManage;
using NFine.Application.SystemManage;
using NFine.Domain.Entity.Mtr;
using NFine.Web.Code;

namespace NFine.Web.Areas.Mtr.Controllers
{
    public class FundController : ControllerBase
    {
        private Fund_B_ConsumeApp mtrApp = new Fund_B_ConsumeApp();
        private Fund_B_Consume_DApp dApp = new Fund_B_Consume_DApp();
        //
        // GET: /Mtr/Fund/
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = new Fund_B_ConsumeEntity();
            if (string.IsNullOrEmpty(keyValue))
            {
                data.UserCode = OperatorProvider.Provider.GetCurrent().UserCode;
                data.OperateTime = DateTime.Now;
                data.FundAmount = 1000;
                data.FundName = "测试数据";
                data.FundNumber = "测试数据";
                data.CardNumber = "1233223";
                data.F_Id = Guid.NewGuid().ToString();
            }
            else
            {
                data = mtrApp.GetForm(keyValue);
            }

            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(string data, string fund_b_consume)
        {
            var listD = NFine.Code.Json.ToObject<List<Fund_B_Consume_DEntity>>(data);
            var entity = NFine.Code.Json.ToObject<Fund_B_ConsumeEntity>(fund_b_consume);

            entity.UserCode = OperatorProvider.Provider.GetCurrent().UserCode;
            entity.UserId = OperatorProvider.Provider.GetCurrent().UserId;
            entity.UserName = OperatorProvider.Provider.GetCurrent().UserName;
            if (entity.Werks == "" || entity.Lgort == "")
            {
                return Error("请选择院区");
            }
            if (entity.FundName == "" || entity.CardNumber == "")
            {
                return Error("请输入卡号");
            }
            var amount = listD.Sum(p => p.Money);
            if (amount.Value > entity.FundAmount)
            {
                return Error("经费余额不足");
            }
            string F_Id = Guid.NewGuid().ToString();
            entity.F_Id = F_Id;
            mtrApp.SubmitForm(entity, "");
            int codeNUM = 1;
            foreach (var item in listD)
            {
                item.Base_Id = F_Id;
                item.Is_New = true;
                item.ItemCode = codeNUM.ToString().PadLeft(4, '0');
                dApp.SubmitForm(item, "");
                codeNUM++;
            }
            return Success("操作成功。");
        }

        public ActionResult FundUseRecord()
        {
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult FundSap()
        {
            return View();
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetFundSapJson(string keyword)
        {
            var data2 = new List<FundSapEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                data2 = SAPHandle.GetFundByCardNumberSap(keyword);
            }
            var data = new
            {
                rows = data2,
                total = data2.Count
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword, int state = -1)
        {
            System.Linq.Expressions.Expression<Func<View_Fund_B_Consume_DEntity, bool>> expression = ExtLinq.True<View_Fund_B_Consume_DEntity>();


            var userId = OperatorProvider.Provider.GetCurrent().UserId;

            expression = expression.And(t => t.user_Id == userId);

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<View_Fund_B_Consume_DEntity>();
                keyPress = keyPress.And(t => t.Mtr_Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var viewApp = new View_Fund_B_Consume_DApp();
            var data = new
            {
                rows = viewApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult GetGridJsonExport(string id, Pagination pagination, string keyword, string titleAndField, int state = -1)
        {
            System.Linq.Expressions.Expression<Func<View_Fund_B_Consume_DEntity, bool>> expression = ExtLinq.True<View_Fund_B_Consume_DEntity>();


            pagination.page = 1;
            pagination.rows = int.MaxValue;
            var roleId = OperatorProvider.Provider.GetCurrent().UserId;

            expression = expression.And(t => t.user_Id == roleId);

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<View_Fund_B_Consume_DEntity>();
                keyPress = keyPress.And(t => t.Mtr_Name.Contains(keyword));
                keyPress = keyPress.Or(t => t.AbbreviationName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var viewApp = new View_Fund_B_Consume_DApp();
            var rows = viewApp.GetList(pagination, expression);

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel<View_Fund_B_Consume_DEntity>(rows, dicFields, new ExcelCaption
            {
                CaptionName = "单据记录表" +
                "",
                Height = 24
            });

            return Success("下载成功", downUrl);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult AccountingWriteOff(string keyValue)
        {
            var accountingD_Entity = dApp.GetForm(keyValue);
            if (accountingD_Entity.Is_New == false)
            {
                return Error("此记录已经做过冲销,禁止二次操作。");
            }
            accountingD_Entity.Is_New = false;
            new Fund_B_Consume_DApp().SubmitForm(accountingD_Entity, keyValue);//修改为已经做过记账

            var accountingEntity = mtrApp.GetForm(accountingD_Entity.Base_Id);
            accountingEntity.F_Id = Guid.NewGuid().ToString();
            accountingEntity.UserCode = OperatorProvider.Provider.GetCurrent().UserCode;
            accountingEntity.UserId = OperatorProvider.Provider.GetCurrent().UserId;
            accountingEntity.UserName = OperatorProvider.Provider.GetCurrent().UserName;
            new Fund_B_ConsumeApp().SubmitForm(accountingEntity, "");
            accountingD_Entity.Base_Id = accountingEntity.F_Id;
            accountingD_Entity.F_Id = Guid.NewGuid().ToString();
            accountingD_Entity.num = -accountingD_Entity.num;
            accountingD_Entity.Money = -accountingD_Entity.Money;
            accountingD_Entity.Is_New = true;
            new Fund_B_Consume_DApp().SubmitForm(accountingD_Entity, "");


            return Success("操作成功。");
        }
    }
}
