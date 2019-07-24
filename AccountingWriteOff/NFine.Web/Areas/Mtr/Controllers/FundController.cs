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
            entity.OperateTime = DateTime.Now;


            if (entity.Werks == "" || entity.Lgort == "")
            {
                return Error("请选择院区");
            }
            if (entity.FundNumber == "" || entity.CardNumber == "")
            {
                return Error("请输入卡号");
            }
            //从SAP接口中获取经费的金额
            var ListFund = SAPHandle.GetFundByCardNumberSap(entity.CardNumber.Trim(), entity.WerksId.Trim(), entity.password.Trim(), entity.Lgort.Trim());
            if (ListFund.Count < 0)
            {
                return Error("密码或者卡号有误,请核实");
            }
            var fundEn = ListFund.Where(p => p.FundCode == entity.FundNumber.Trim()).FirstOrDefault();
            if (fundEn == null)
            {
                return Error("不存在的经费代码,请核实");
            }
            entity.FundAmount = fundEn.FundAmound;
            var amount = listD.Sum(p => p.Money);
            if (amount.Value > entity.FundAmount)
            {
                return Error("经费余额不足");
            }
            string F_Id = Guid.NewGuid().ToString();
            entity.F_Id = F_Id;
            mtrApp.SubmitForm(entity, "");
            int codeNUM = 1;

            MtrFund_D_MtrApp mapp = new MtrFund_D_MtrApp();
            var mtrIds = new List<string>();
            foreach (var item in listD)
            {
                item.Base_Id = F_Id;
                item.Is_New = true;
                item.ItemCode = codeNUM.ToString().PadLeft(4, '0');
                dApp.SubmitForm(item, "");
                if (!mtrIds.Contains(item.Mtr_Id))
                {
                    mapp.Update(item.Mtr_Price.Value, item.Mtr_Id);//更新物资的价格
                    mtrIds.Add(item.Mtr_Id);
                }
                codeNUM++;
            }
            SAPHandle.InsertValueToSap(entity, listD);//发送数据到SAP
            return Success("操作成功。");
        }

        public ActionResult FundUseRecord()
        {
            return View();
        }


        public ActionResult FundSap()
        {
            return View();
        }

        public ActionResult GetFundSapJson(string WerksId, string LgortId, string CardNumber, string password)
        {
            var data2 = new List<FundSapEntity>();
            if (!string.IsNullOrEmpty(CardNumber))
            {
                data2 = SAPHandle.GetFundByCardNumberSap(CardNumber, WerksId, password, LgortId);
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
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword, string startTime, string endTime,string cardNumber, int state = -1)
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
            if (!string.IsNullOrEmpty(startTime))
            {
                var st = Convert.ToDateTime(startTime);
                expression = expression.And(t => t.OperateTime.Value >= st);
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                var et = Convert.ToDateTime(endTime).AddDays(1);
                expression = expression.And(t => t.OperateTime.Value <= et);
            }
            if(!string.IsNullOrEmpty(cardNumber))
            {
                expression = expression.And(k => k.CardNumber == cardNumber.Trim());
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
        public ActionResult GetGridJsonExport(string id, Pagination pagination, string keyword, string titleAndField,string startTime, string endTime, string cardNumber, int state = -1)
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
            if (!string.IsNullOrEmpty(startTime))
            {
                var st = Convert.ToDateTime(startTime);
                expression = expression.And(t => t.OperateTime.Value >= st);
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                var et = Convert.ToDateTime(endTime).AddDays(1);;
                expression = expression.And(t => t.OperateTime.Value <= et);
            }
            if (!string.IsNullOrEmpty(cardNumber.Trim()))
            {
                expression = expression.And(k => k.CardNumber == cardNumber.Trim());
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
        public ActionResult AccountingWriteOff(string keyValue, string password)
        {
            var accountingD_Entity = dApp.GetForm(keyValue);
            if (accountingD_Entity.Is_New == false)
            {
                return Error("此记录已经做过冲销,禁止二次操作。");
            }
            accountingD_Entity.Is_New = false;

            var accountingEntity = mtrApp.GetForm(accountingD_Entity.Base_Id);

            var ListFund = SAPHandle.GetFundByCardNumberSap(accountingEntity.CardNumber.Trim(), accountingEntity.WerksId.Trim(), password.Trim(), accountingEntity.Lgort.Trim());
            if (ListFund.Count < 0)
            {
                return Error("密码或者卡号有误,请核实");
            }
            var fundEn = ListFund.Where(p => p.FundCode == accountingEntity.FundNumber.Trim()).FirstOrDefault();
            if (fundEn == null)
            {
                return Error("不存在的经费代码,请核实");
            }
            if (fundEn.FundAmound < -accountingD_Entity.Money)
            {
                return Error("经费金额不足，请核实后操作");
            }

            new Fund_B_Consume_DApp().SubmitForm(accountingD_Entity, keyValue);//修改为已经做过记账
                                                                               //从SAP接口中获取经费的金额
            accountingEntity.Ref_Code = accountingEntity.Code;
            accountingEntity.F_Id = Guid.NewGuid().ToString();
            accountingEntity.UserCode = OperatorProvider.Provider.GetCurrent().UserCode;
            accountingEntity.UserId = OperatorProvider.Provider.GetCurrent().UserId;
            accountingEntity.UserName = OperatorProvider.Provider.GetCurrent().UserName;
            new Fund_B_ConsumeApp().SubmitForm(accountingEntity, "");
            accountingD_Entity.Base_Id = accountingEntity.F_Id;

            accountingD_Entity.ItemCode = "0001";
            accountingD_Entity.F_Id = Guid.NewGuid().ToString();
            accountingD_Entity.num = -accountingD_Entity.num;
            accountingD_Entity.Money = -accountingD_Entity.Money;
            accountingD_Entity.Is_New = true;
            new Fund_B_Consume_DApp().SubmitForm(accountingD_Entity, "");

            SAPHandle.InsertValueToSap(accountingEntity, new List<Fund_B_Consume_DEntity> { accountingD_Entity });//发送数据到SAP

            return Success("操作成功。");
        }
    }
}
