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
            return Success("操作成功。", Generate(entity, listD));
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
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword, string startTime, string endTime, string cardNumber, int state = -1)
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
            if (!string.IsNullOrEmpty(cardNumber))
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
        public ActionResult GetGridJsonExport(string id, Pagination pagination, string keyword, string titleAndField, string startTime, string endTime, string cardNumber, int state = -1)
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
                var et = Convert.ToDateTime(endTime).AddDays(1); ;
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

        public string Generate(Fund_B_ConsumeEntity main, List<Fund_B_Consume_DEntity> subList)
        {
          
            string caption = "武汉协和医院总务库房领物单";
            var styletable1= " style='width: 90%;height:110px;;margin: 0px;padding: 0px;border-collapse: collapse;table-layout: fixed;font-size: 14px;'";
            var styletable1_td_1 = "style='height: 40px;line-height: 40px;word-break: break-all;text-align: center;font-size: 20px;'";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div style='width:850px;'>");
            sb.AppendFormat("<table {1}><tr><td colspan='3' {2}>{0}</td></tr>", caption,styletable1,styletable1_td_1);
            var styletable2_td_1 = "style='height: 25px;line-height: 25px;word-break: break-all;text-align: left;font-size: 12px;'";
           // var styletable2_td_1_2 = "style='height: 25px;line-height: 25px;word-break: break-all;text-align: left;font-size: 14px;'";
            sb.AppendFormat("<tr><td {3}>经费类型： {0}</td><td {3}>出库日期： {1}</td><td {3}>领物单： {2}</td></tr>", main.FundName, main.OperateTime.Value.ToString("yyyyMMdd"), main.Code, styletable2_td_1);
            sb.AppendFormat("<tr><td  {2}>送货位置： {0}</td><td {2}>备注信息： {1}</td><td {2}></td></tr>", "", main.F_Description,styletable2_td_1);
            sb.AppendFormat("<tr><td {3}>经费卡号： {0}</td><td {3}>经费代码： {1}</td><td {3}>当前余额： {2}</td></tr></table>", main.CardNumber, main.FundNumber, main.FundAmount, styletable2_td_1);
            var styleTable2_2 = "style='width: 90%;margin: 0px;padding: 0px;border-left: 1px solid black;border-bottom: 1px solid black;border-collapse: collapse;table-layout: fixed;font-size: 14px;'";
            sb.AppendFormat("<table  {0}>",styleTable2_2);
            var styleTable2_3_1 = " style='width: 5%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_2 = " style='width: 15%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_3 = " style='width: 30%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_4 = " style='width: 5%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_5 = " style='width: 10%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_6 = " style='width: 10%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_7 = " style='width: 10%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_3_8 = " style='width: 15%;border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            sb.AppendFormat("<thead><tr><td {0}>序号</td><td {1}>物品编号</td><td {2}>物品品名</td><td {3}>单位</td><td {4}>批号</td><td {5}>数量</td><td {6}>单价</td><td {7}>金额</td></tr></thead>", styleTable2_3_1, styleTable2_3_2, styleTable2_3_3, styleTable2_3_4, styleTable2_3_5, styleTable2_3_6, styleTable2_3_7, styleTable2_3_8);
            var styleTable2_4 = "style='border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: center;'";
            var styleTable2_5 = "style='border-top: 1px solid black;border-right: 1px solid black;height: 25px;line-height: 25px;word-break: break-all;padding-left: 5px;text-align: right;'";
            var sortList = subList.OrderBy(p => p.ItemCode);
            foreach (var item in sortList)
            {
                sb.AppendFormat("<tr><td {8}>{0}</td><td {8}>{1}</td><td {8}>{2}</td><td {8}>{3}</td><td {8}>{4}</td><td {9}>{5}</td><td {9}>{6}</td><td {9}> {7}</td></tr>",
                    item.ItemCode.Trim('0'), item.Mtr_Id, item.Mtr_Name, item.Mtr_UnitName, "", String.Format("{0:N2}", item.num), String.Format("{0:N2}", item.Mtr_Price), String.Format("{0:N2}", item.Money),styleTable2_4, styleTable2_5);
            }
            sb.Append("</table>");
            var styleTable3 = "style='width: 90%;height:auto;margin: 0px;padding: 0px;border-collapse: collapse;table-layout: fixed;'";

            sb.AppendFormat("<table {0}>", styleTable3);
            var styleTable3_td = "style=' height: 35px;line-height: 35px;word-break: break-all;font-size: 14px;'";
            var styleTable3_td_1 = "style=' height: 35px;line-height: 35px;word-break: break-all;text-align:right;font-size: 14px;'";
            sb.AppendFormat("<tr><td {1}></td><td {1}></td><td {1}></td><td {1}></td><td {1}></td><td {1}></td><td {1}>金额合计</td><td {1}>{0}元</td></tr>", subList.Sum(p => p.Money), styleTable3_td);
            sb.AppendFormat("<tr><td colspan='2' {4}>{0}</td><td {4}>{1}</td><td {5}>{2}</td><td {4}></td><td {4}></td><td {4}>{3}</td><td {4}></td></tr>", "制单:", "库管员:", "记账:", "领物人:", styleTable3_td, styleTable3_td_1);
            sb.Append("</table>");
            sb.AppendFormat("</div");
            return sb.ToString();
        }
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult GetPrintDataByCode(string Code)
        {
            var main=mtrApp.GetList(new Pagination { page = 1, rows = int.MaxValue }, p => p.Code == Code).FirstOrDefault();
            if(main==null)
            {
                return Error("不存在的订单");
            }
            var subList = dApp.GetList(new Pagination { page = 1, rows = int.MaxValue }, p => p.Base_Id == main.F_Id);
            var printStr = Generate(main, subList);
            return Success("打印数据获取成功", printStr);
        }
    }
}
