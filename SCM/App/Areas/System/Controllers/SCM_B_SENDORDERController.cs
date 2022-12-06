using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Core;
using System.Text;
using Ipedf.App.Codes;
using ThoughtWorks.QRCode.Codec;
using System.IO;
using NPOI.SS.UserModel;
using Ipedf.Web.Common;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_B_SENDORDERController : BaseController
    {
        //
        // GET: /System/SCM_B_SENDORDER/


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_B_SENDORDER entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.FPHM = entity.FPHM.Trim();
                entity.GYSACCOUNT = GetCurrentID();
                entity.GYSNAME = GetCurrentPerson();
                BizLogicObject_SCM_B_SENDORDER.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult CreateFP(string FPHM)
        {
            EntityObject_SCM_B_SENDORDER entity = new EntityObject_SCM_B_SENDORDER();
            if (entity != null && ModelState.IsValid)
            {
                entity.FPHM = FPHM.Trim();
                entity.GYSACCOUNT = GetCurrentID();
                entity.GYSNAME = GetCurrentPerson();
                BizLogicMsg msg = BizLogicObject_SCM_B_SENDORDER.Proxy.Save(entity);
                EntityObject_SCM_B_SENDORDER entity1 = new EntityObject_SCM_B_SENDORDER();
                entity1.ID = msg.Message;
                EntityObject_SCM_B_SENDORDER entity2 = BizLogicObject_SCM_B_SENDORDER.Proxy.Get(entity1);
                return Json(entity2, JsonRequestBehavior.AllowGet);
            }
            return Json("F:创建失败，请核对输入的数据的格式",JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult CheckEditFP(EntityObject_SCM_B_SENDORDER entity)
        {
            CauseObject_SCM_B_SENDORDER cause = new CauseObject_SCM_B_SENDORDER();
            cause.FPHM = entity.FPHM;
            cause.SetCustomCondition(" and CODE != '" + entity.CODE + "' ");
            DisplayObject_SCM_B_SENDORDER[] sbs = BizLogicObject_SCM_B_SENDORDER.Proxy.Query(cause);
            if (sbs.Count() > 0)
            {
                return Json("F");
            }
            else
            {
                return Json("S");
            }
        }
        [HttpPost]
        public ActionResult CheckFP(EntityObject_SCM_B_SENDORDER entity)
        {
            CauseObject_SCM_B_SENDORDER cause = new CauseObject_SCM_B_SENDORDER();
            cause.FPHM = entity.FPHM;
            DisplayObject_SCM_B_SENDORDER[] sbs = BizLogicObject_SCM_B_SENDORDER.Proxy.Query(cause);
            if (sbs.Count() > 0)
            {
                return Json("F");
            }
            else
            {
                return Json("S");
            }
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_B_SENDORDER> deleteDetailEntities = new List<EntityObject_SCM_B_SENDORDER>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_B_SENDORDER entity = new EntityObject_SCM_B_SENDORDER();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }
            var msg = BizLogicObject_SCM_B_SENDORDER.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (msg.Succeed)
            {
                return Json("OK");
            }
            else
            {
                return Json(msg.Message);
            }
        }

        public ActionResult Edit(string id)
        {
            EntityObject_SCM_B_SENDORDER curObj = new EntityObject_SCM_B_SENDORDER();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SENDORDER.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_B_SENDORDER curObj = new EntityObject_SCM_B_SENDORDER();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SENDORDER.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_SCM_B_SENDORDER>(curObj, from);
            curObj.FPHM = curObj.FPHM.Trim();
            var msg = BizLogicObject_SCM_B_SENDORDER.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


        }
        [HttpPost]
        public ActionResult EidtFP(string FPHM,string ID)
        {
            EntityObject_SCM_B_SENDORDER curObj = new EntityObject_SCM_B_SENDORDER();
            curObj.ID = ID;
            curObj = BizLogicObject_SCM_B_SENDORDER.Proxy.Get(curObj);
            curObj.FPHM = FPHM.Trim();
            var msg = BizLogicObject_SCM_B_SENDORDER.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S");
            }
            else
            {

                return Json("F");
            }
            //EntityObject_SCM_B_SENDORDER entity = new EntityObject_SCM_B_SENDORDER();
            //if (entity != null && ModelState.IsValid)
            //{
            //    entity.FPHM = FPHM.Trim();
            //    entity.GYSACCOUNT = GetCurrentID();
            //    entity.GYSNAME = GetCurrentPerson();
            //    BizLogicMsg msg = BizLogicObject_SCM_B_SENDORDER.Proxy.Save(entity);
            //    EntityObject_SCM_B_SENDORDER entity1 = new EntityObject_SCM_B_SENDORDER();
            //    entity1.ID = msg.Message;
            //    EntityObject_SCM_B_SENDORDER entity2 = BizLogicObject_SCM_B_SENDORDER.Proxy.Get(entity1);
            //    return Json(entity2, JsonRequestBehavior.AllowGet);
            //}
            //return Json("F:创建失败，请核对输入的数据的格式", JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string FPHM, string WERKST)
        {

            int total = 0;
            // object dataSource = null;

            //平台自动生成代码
            //  CauseObject_COM_SYSTEM cause = (CauseObject_COM_SYSTEM)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_V_SCM_B_SENDORDER cause = new CauseObject_V_SCM_B_SENDORDER();
            if (!string.IsNullOrEmpty(FPHM))
            {
                cause.FPHM = "%" + FPHM + "%";
            }
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(startDate))
            {
                sb.Append(string.Format(" and V_SCM_B_SENDORDER.CREATE_TIME >=to_date('{0}','yyyy/mm/dd') ", startDate));
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                sb.Append(string.Format(" and V_SCM_B_SENDORDER.CREATE_TIME<=to_date('{0}','yyyy/mm/dd')", endDate));
            }
            if (!string.IsNullOrEmpty(WERKST))
            {
                sb.Append(string.Format(" and V_SCM_B_SENDORDER.WERKST ='{0}'", WERKST));
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            
            cause.GYSACCOUNT = GetCurrentID();//供应商选择
            var dataSource = BizLogicObject_V_SCM_B_SENDORDER.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_B_SENDORDER> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        [HttpPost]
        public JsonResult GetSubPlanData(Guid? id, int page, int rows, string order, string sort, string SEND_ORDER_CODE, string FPHM, string WERKST,string IsNull)
        {
            int total = 0;
            // object dataSource = null;

            //平台自动生成代码
            //  CauseObject_SCM_D_SUPPLYPLAN cause = (CauseObject_SCM_D_SUPPLYPLAN)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(SEND_ORDER_CODE))
            {
                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                    cause.STATUS = "0";//已经扫码入库的供应计划不能做更改
                    sb.Append(" and (length(SCM_D_SUPPLYPLAN.SEND_ORDER_CODE)=0 or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE is null) ");
                }
                else
                {
                    if (IsNull == "true")
                    {
                        sb.Append(" and (length(SCM_D_SUPPLYPLAN.SEND_ORDER_CODE)=0 or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE is null or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE = '" + SEND_ORDER_CODE + "' ) ");
                    }
                    else
                    {
                        cause.SEND_ORDER_CODE = SEND_ORDER_CODE;
                    }
                }
            }
            if (!string.IsNullOrEmpty(FPHM))
            {
                //cause.FPHM = "%" + FPHM + "%";

                //IsNull = "true";
                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                if (IsNull == "true")
                {
                    sb.Append(" and ((trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "') or (length(SCM_D_SUPPLYPLAN.FPHM)=0 or SCM_D_SUPPLYPLAN.FPHM IS NULL )) ");
                }
                else
                {
                    sb.Append(" and ((trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "' )) ");
                }
                }
                else
                {
                    sb.Append(" and trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "') ");
                }
            }
            if (!string.IsNullOrEmpty(WERKST))
            {
                //cause.FPHM = "%" + FPHM + "%";

                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                    sb.Append(" and (trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "' or ((length(SCM_D_SUPPLYPLAN.FPHM)=0 or SCM_D_SUPPLYPLAN.FPHM IS NULL ) and trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "')) ");
                }
                else
                {
                    sb.Append(" and trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "' ");
                }
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.GYSACCOUNT = GetCurrentID();//供应商筛选
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SUPPLYPLAN> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        [HttpPost]
        public JsonResult GetEditPlanData(Guid? id, int page, int rows, string order, string sort, string SEND_ORDER_CODE, string WERKST, string IsNull, string FPHM)
        {
            int total = 0;
            //rows = Int32.MaxValue;
            // object dataSource = null;

            //平台自动生成代码
            //  CauseObject_SCM_D_SUPPLYPLAN cause = (CauseObject_SCM_D_SUPPLYPLAN)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            StringBuilder sb = new StringBuilder();
            //cause.STATUS = "0";//已经扫码入库的供应计划不能做更改
            if (!string.IsNullOrEmpty(SEND_ORDER_CODE))
            {
                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                    sb.Append(" and (length(SCM_D_SUPPLYPLAN.SEND_ORDER_CODE)=0 or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE is null  or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE = '" + SEND_ORDER_CODE + "') ");
                }
                else
                {
                    if (IsNull == "true")
                    {
                        sb.Append(" and (length(SCM_D_SUPPLYPLAN.SEND_ORDER_CODE)=0 or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE is null  or SCM_D_SUPPLYPLAN.SEND_ORDER_CODE = '" + SEND_ORDER_CODE + "') ");
                    }
                    else
                    {
                        cause.SEND_ORDER_CODE = SEND_ORDER_CODE;
                    }
                }
            }
            if (!string.IsNullOrEmpty(WERKST))
            {
                //cause.FPHM = "%" + FPHM + "%";

                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                    sb.Append(" and (trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "' or ((length(SCM_D_SUPPLYPLAN.FPHM)=0 or SCM_D_SUPPLYPLAN.FPHM IS NULL ) and trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "' )) ");
                }
                else
                {
                    sb.Append(" and trim(SCM_D_SUPPLYPLAN.WERKST)='" + WERKST.Trim() + "' ");
                }
            }
            if (!string.IsNullOrEmpty(FPHM))
            {
                //cause.FPHM = "%" + FPHM + "%";

                //IsNull = "true";
                if (SEND_ORDER_CODE == "-1")//是送货清单选取供应计划
                {
                    if (IsNull == "true")
                    {
                        sb.Append(" and ((trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "') or (length(SCM_D_SUPPLYPLAN.FPHM)=0 or SCM_D_SUPPLYPLAN.FPHM IS NULL )) ");
                    }
                    else
                    {
                        sb.Append(" and ((trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "' )) ");
                    }
                }
                else
                {
                    if (IsNull == "true")
                    {
                        sb.Append(" and ((trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "' ) or (length(SCM_D_SUPPLYPLAN.FPHM)=0 or SCM_D_SUPPLYPLAN.FPHM IS NULL )) ");
                    }
                    else
                    {
                        sb.Append(" and trim(SCM_D_SUPPLYPLAN.FPHM)='" + FPHM.Trim() + "' ");
                    }
                }
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.GYSACCOUNT = GetCurrentID();//供应商筛选
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SUPPLYPLAN> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        /// <summary>
        /// 把送货清单号写入供应计划中 请鲲鹏做测试是否正确
        /// </summary>
        /// <param name="SupplyIDs"></param>
        /// <param name="SEND_ORDER_CODE"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SettingSupply(string SupplyIDs, string SEND_ORDER_CODE, string FPHM,string FPRQ)
        {
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            var ids = "('" + SupplyIDs.Replace(",", "','") + "') ";
            cause.SetCustomCondition("and SCM_D_SUPPLYPLAN.ID in " + ids);
            var supplyList = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause);
            var listUpdateEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            foreach (var item in supplyList)
            {
                item.SEND_ORDER_CODE = SEND_ORDER_CODE;
                item.FPHM = FPHM;
                item.FPRQ = Convert.ToDateTime(FPRQ);
                item.SetUpdate("SEND_ORDER_CODE", "FPHM", "FPRQ");
                listUpdateEntities.Add((EntityObject_SCM_D_SUPPLYPLAN)item);
            }
            var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchUpdate(supplyList);


            if (msg.Succeed)
            {
                if (listUpdateEntities.Count() == 0)
                {
                    return Json("OK");
                }
                RfcNOC rnc = new RfcNOC();
                var List_Back = rnc.SendSupplyPlan(GetCurrentID(), listUpdateEntities, GetCurrentID(), GetCurrentPerson(), "0", "U");//SAP返回的列表
                if (List_Back[0].MSTYPE == "S")
                {
                    return Json("OK");
                }
                else
                {
                    LogHelper.Info("通过送货清单修改供应计划号SCM成功,发送SAP保存失败", 1);
                    return Json("S:SCM保存成功,SAP保存失败！", "text/html");
                }
                return Json("OK");
            }
            else
            {
                return Json(msg.Message);
            }
        }
        [HttpPost]
        public JsonResult EditSupply(string SupplyIDs, string SEND_ORDER_CODE, string FPHM,string FPRQ)
        {
            string account = GetCurrentID();
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            cause.SEND_ORDER_CODE = SEND_ORDER_CODE;
            var supplyList = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause);
            var listUpdateEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            foreach (var item in supplyList)
            {
                item.SEND_ORDER_CODE = "";
                item.FPHM = FPHM;
                item.FPRQ = Convert.ToDateTime(FPRQ);
                item.SetUpdate("SEND_ORDER_CODE", "FPHM", "FPRQ");
                listUpdateEntities.Add((EntityObject_SCM_D_SUPPLYPLAN)item);
            }
            var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchUpdate(supplyList);


            if (msg.Succeed)
            {
                if (listUpdateEntities.Count() == 0)
                {
                    SettingSupply(SupplyIDs, SEND_ORDER_CODE, FPHM, FPRQ);
                    return Json("OK");
                }
                RfcNOC rnc = new RfcNOC();
                var List_Back = rnc.SendSupplyPlan(GetCurrentID(), listUpdateEntities, GetCurrentID(), GetCurrentPerson(), "0", "U");//SAP返回的列表
                if (List_Back[0].MSTYPE == "S")
                {
                    SettingSupply(SupplyIDs, SEND_ORDER_CODE, FPHM,FPRQ);
                    return Json("OK");
                }
                else
                {
                    SettingSupply(SupplyIDs, SEND_ORDER_CODE, FPHM,FPRQ);
                    LogHelper.Info("通过送货清单修改供应计划号SCM成功,发送SAP保存失败", 1);
                    return Json("S:SCM保存成功,SAP保存失败！", "text/html");
                }
                return Json("OK");
            }
            else
            {
                SettingSupply(SupplyIDs, SEND_ORDER_CODE, FPHM,FPRQ);
                return Json(msg.Message);
            }
        }
        /// <summary>
        /// 从送货清单中移除
        /// </summary>
        /// <param name="supplyID"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteSubPlan(string supplyID)
        {
            List<EntityObject_SCM_D_SUPPLYPLAN> deleteDetailEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            if (!string.IsNullOrEmpty(supplyID))
            {
                var entity = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(new EntityObject_SCM_D_SUPPLYPLAN { ID = supplyID });
                entity.SEND_ORDER_CODE = "";
                entity.SetUpdate("SEND_ORDER_CODE");
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(entity);
                var listUpdateEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                listUpdateEntities.Add(entity);
                if (msg.Succeed)
                {
                    if (listUpdateEntities.Count() == 0)
                    {
                        return Json("OK");
                    }
                    RfcNOC rnc = new RfcNOC();
                    var List_Back = rnc.SendSupplyPlan(GetCurrentID(), listUpdateEntities, GetCurrentID(), GetCurrentPerson(), "0", "U");//SAP返回的列表
                    if (List_Back[0].MSTYPE == "S")
                    {
                        return Json("OK");
                    }
                    else
                    {
                        LogHelper.Info("通过送货清单删除供应计划，SCM成功,发送SAP保存失败", 1);
                        return Json("S:SCM保存成功,SAP保存失败！", "text/html");
                    }
                    return Json("OK");
                }
                else
                {
                    return Json(msg.Message);
                }
            }


            return Json("未知错误请联系管理人员!");
        }

        public ActionResult PrintSendInfo(string id)
        {

            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            cause.SEND_ORDER_CODE = id;
          
            var entitys = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause).ToList();
            entitys = entitys.OrderBy(p => p.SEND_DEPART_NAME).ThenBy(t => t.CODE).ToList();
            StringBuilder sb = new StringBuilder();
            var markCode = GenerateMark(id);//生成送货清单二维码
            sb.Append("<table cellpadding=\"0\" cellspacing=\"0\">");

            var gysName = "";
            var FPJR = entitys.Sum(p => p.FPJR);
            for (int i = 0; i < entitys.Count; i++)
            {
                var entity = entitys[i];
                if (i == 0)
                {
                    gysName = entity.GYSNAME;
                    sb.AppendFormat("<tr><td colspan=\"14\" style=\"height:50px;font-family:宋体;text-align:center;font-size: 20px;\" >{0}</td></tr>",  "武汉协和医院总务物资送货清单");
                    sb.AppendFormat("<tr><td colspan=\"4\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >供应商：{0}</td>", entity.GYSACCOUNT);
                    sb.AppendFormat("<td colspan=\"1\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >院区：</td><td colspan=\"5\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >发票号码：{0}</td><td colspan=\"3\" style=\"height:40px;font-family:宋体;font-size: 12px;\" >送货清单号：</td><td style=\"height:40px;font-family:宋体;font-size: 12px;\" rowspan=\"2\"> <img alt=\"显示出错\" id=\"im_1\" src=\"{3}\"  style=\" width:80px; height:80px;\"/></td></tr>", entity.FPHM, FPJR.ToString("F2"), id, markCode, entity.WERKST);
                    sb.AppendFormat("<tr><td colspan=\"4\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >{0}</td>", entity.GYSNAME);
                    sb.AppendFormat("<td colspan=\"1\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >{4}</td><td colspan=\"5\" style=\"height:40px;font-family:宋体;font-size: 12px;\" >发票金额：{1}</td><td colspan=\"3\" style=\"height:40px;font-family:宋体;font-size: 12px;\" >{2}</td></tr>", entity.FPHM, FPJR.ToString("F2"), id, markCode, entity.WERKST);
                    GenerateHeadCode(sb, "序号", "订单日期", "供应计划号", "物资编码", "物资描述", "采购数量", "送货数量", "基本单位", "单价", "金额", "送达科室", "负责人", "联系电话", "商品条码");
                }
                // var data = GenerateMark(entity.CODE);
                GenerateCode(sb, (i+1).ToString(), entity.BEDAT, entity.CODE, entity.MATNR, entity.TXZ01, entity.ORDER_MENGE.ToString(), entity.MENGE.ToString(), entity.MSEHT, entity.NETPR, entity.FPJR.ToString(), entity.SEND_DEPART_NAME, entity.LINK_PERSON, entity.LINK_TELEPHONE, entity.MATER_CODE);
            }
            //GenerateBottomCode(sb, "", "", "", "", "", "", "", "", "", "", "", "", "", "");//最后一行空着
            sb.AppendFormat("<tr><td colspan=\"5\" style=\"height:30px;font-family:宋体;border-top:solid 1px black;text-align:left;font-size: 12px;\" >供应商(盖章)：{0}</td><td colspan=\"5\" style=\"height:30px;font-family:宋体;border-top:solid 1px black;font-size: 12px;\" >物资供应管理中心(签字)：</td><td colspan=\"4\" style=\"height:30px;border-top:solid 1px black;font-family:宋体;font-size: 12px;\" >打印日期：{1}</td></tr>", gysName,DateTime.Now.ToString("yyyy-MM-dd"));
            sb.Append("</table>");
            ViewBag.PrintStr = new MvcHtmlString(sb.ToString());
            return View();
        }

        [HttpPost]
        public ActionResult Export(string id)
        {
            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            cause.SEND_ORDER_CODE = id;
            var entitys = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause);

            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> queryData = entitys.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
           
            string[] Liststring = new string[] { "CODE", "EBELN", "GYJH", "MATNR", "TXZ01", "WERKST", "GYSACCOUNT", "GYSNAME", "NAME", "ORDER_MENGE", "MSEHT", "NETPR", "EEIND", "BEDAT", "MENGE", "CHARG", "HSDAT", "VFDAT", "FPHM", "FPJR", "FPRQ", "CREATE_TIME", "STATUS_NAME", "OUT_CAUSE", "OUT_DATE" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<DisplayObject_V_SCM_D_SUPPLIERPLAN>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1));

        }


        public void GenerateCode(StringBuilder sb, string BEDAT, string EBELN, string EBELP, string MATNR, string TXZ01, string order_menge, string MENGE, string MSEHT, string PRICE, string MONEY, string SEND_DEPART_NAME, string LINK_PERSON, string LINK_TELEPHONE, string MATER_CODE)
        {
            var replaceStr = GenerateStr();
            sb.AppendFormat(replaceStr, BEDAT, EBELN, EBELP, MATNR, TXZ01, order_menge, MENGE, MSEHT, PRICE, MONEY, SEND_DEPART_NAME, LINK_PERSON, LINK_TELEPHONE, MATER_CODE);
        }
        public void GenerateBottomCode(StringBuilder sb, string BEDAT, string EBELN, string EBELP, string MATNR, string TXZ01, string order_menge, string MENGE, string MSEHT, string PRICE, string MONEY, string SEND_DEPART_NAME, string LINK_PERSON, string LINK_TELEPHONE, string MATER_CODE)
        {
            var replaceStr = GenerateBottomStr();
            sb.AppendFormat(replaceStr, BEDAT, EBELN, EBELP, MATNR, TXZ01, order_menge, MENGE, MSEHT, PRICE, MONEY, SEND_DEPART_NAME, LINK_PERSON, LINK_TELEPHONE, MATER_CODE);
        }
        /// <summary>
        /// 表底部的样式
        /// </summary>
        /// <returns></returns>
        public string GenerateBottomStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 40px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width:80px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                      "<td style=\"width: 240px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{10}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{11}" +
                    "</td>" +
                    
                      "<td style=\"width: 80px;border-bottom:solid 1px black;text-align:center;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{12}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-right:solid 1px black;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{13}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }
        /// <summary>
        /// 每行的数据设置
        /// </summary>
        /// <returns></returns>
        public string GenerateStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 40px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:30px;text-align:center;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                      "<td style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                       "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{10}" +
                    "</td>" +
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{11}" +
                    "</td>" +
                      
                       "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{12}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;border-right:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{13}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }

        public void GenerateHeadCode(StringBuilder sb, string BEDAT, string EBELN, string EBELP, string MATNR, string TXZ01, string order_menge, string MENGE, string MSEHT, string PRICE, string MONEY, string SEND_DEPART_NAME, string LINK_PERSON, string LINK_TELEPHONE, string MATER_CODE)
        {
            var replaceStr = GenerateHeadStr();
            sb.AppendFormat(replaceStr, BEDAT, EBELN, EBELP, MATNR, TXZ01, order_menge, MENGE, MSEHT, PRICE, MONEY, SEND_DEPART_NAME, LINK_PERSON, LINK_TELEPHONE, MATER_CODE);
        }
        public string GenerateHeadStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 40px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                      "<td style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{10}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{11}" +
                       "</td>" +
                      "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{12}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;border-right:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{13}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }

        public string GenerateMark(string id)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //System.Drawing.Image image = qrCodeEncoder.Encode("4408810820 深圳－广州 小江");
            //global::System.Drawing.Image image = qrCodeEncoder.Encode(id);
            global::System.Drawing.Image image = CreateQRCode(id, QRCodeEncoder.ENCODE_MODE.BYTE, QRCodeEncoder.ERROR_CORRECTION.M, 0, 4, 64, 0, global::System.Drawing.Color.Black);
            string filename = Guid.NewGuid().ToString() + ".jpg";

            string fileMonthPath = Server.MapPath(@"~\UploadFile") + "\\" + DateTime.Now.ToString("MM");
            string filePreMonthPath = Server.MapPath(@"~\UploadFile") + "\\" + DateTime.Now.AddMonths(-1).ToString("MM");
            if (Directory.Exists(filePreMonthPath))
            {
                Directory.Delete(filePreMonthPath, true);
            }
            if (!Directory.Exists(fileMonthPath))
            {
                Directory.CreateDirectory(fileMonthPath);
            }

            string filepath = fileMonthPath + "\\" + filename;
            global::System.IO.FileStream fs = new global::System.IO.FileStream(filepath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
            image.Save(fs, global::System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();
            var path = Url.Content("~/");
            return path + @"UploadFile/" + DateTime.Now.ToString("MM") + "/" + filename;
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="Content">内容文本</param>
        /// <param name="QRCodeEncodeMode">二维码编码方式</param>
        /// <param name="QRCodeErrorCorrect">纠错码等级</param>
        /// <param name="QRCodeVersion">二维码版本号 0-40</param>
        /// <param name="QRCodeScale">每个小方格的预设宽度（像素），正整数</param>
        /// <param name="size">图片尺寸（像素），0表示不设置</param>
        /// <param name="border">图片白边（像素），当size大于0时有效</param>
        /// <returns></returns>
        public global::System.Drawing.Image CreateQRCode(string Content, QRCodeEncoder.ENCODE_MODE QRCodeEncodeMode, QRCodeEncoder.ERROR_CORRECTION QRCodeErrorCorrect, int QRCodeVersion, int QRCodeScale, int size, int border, global::System.Drawing.Color codeEyeColor)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncodeMode;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeErrorCorrect;
            qrCodeEncoder.QRCodeScale = QRCodeScale;
            qrCodeEncoder.QRCodeVersion = QRCodeVersion;

            global::System.Drawing.Image image = qrCodeEncoder.Encode(Content);

            #region 根据设定的目标图片尺寸调整二维码QRCodeScale设置，并添加边框
            if (size > 0)
            {
                //当设定目标图片尺寸大于生成的尺寸时，逐步增大方格尺寸
                #region 当设定目标图片尺寸大于生成的尺寸时，逐步增大方格尺寸
                while (image.Width < size)
                {
                    qrCodeEncoder.QRCodeScale++;
                    global::System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                    if (imageNew.Width < size)
                    {
                        image = new global::System.Drawing.Bitmap(imageNew);
                        imageNew.Dispose();
                        imageNew = null;
                    }
                    else
                    {
                        qrCodeEncoder.QRCodeScale--; //新尺寸未采用，恢复最终使用的尺寸
                        imageNew.Dispose();
                        imageNew = null;
                        break;
                    }
                }
                #endregion

                //当设定目标图片尺寸小于生成的尺寸时，逐步减小方格尺寸
                #region 当设定目标图片尺寸小于生成的尺寸时，逐步减小方格尺寸
                while (image.Width > size && qrCodeEncoder.QRCodeScale > 1)
                {
                    qrCodeEncoder.QRCodeScale--;
                    global::System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                    image = new global::System.Drawing.Bitmap(imageNew);
                    imageNew.Dispose();
                    imageNew = null;
                    if (image.Width < size)
                    {
                        break;
                    }
                }
                #endregion

                //根据参数设置二维码图片白边的最小宽度（按需缩小）
                #region 根据参数设置二维码图片白边的最小宽度
                if (image.Width <= size && border > 0)
                {
                    while (image.Width <= size && size - image.Width < border * 2 && qrCodeEncoder.QRCodeScale > 1)
                    {
                        qrCodeEncoder.QRCodeScale--;
                        global::System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                        image = new global::System.Drawing.Bitmap(imageNew);
                        imageNew.Dispose();
                        imageNew = null;
                    }
                }
                #endregion

                //已经确认二维码图像，为图像染色修饰
                if (true)
                {
                    //定位点方块边长
                    int beSize = qrCodeEncoder.QRCodeScale * 3;

                    int bep1_l = qrCodeEncoder.QRCodeScale * 2;
                    int bep1_t = qrCodeEncoder.QRCodeScale * 2;

                    int bep2_l = image.Width - qrCodeEncoder.QRCodeScale * 5 - 1;
                    int bep2_t = qrCodeEncoder.QRCodeScale * 2;

                    int bep3_l = qrCodeEncoder.QRCodeScale * 2;
                    int bep3_t = image.Height - qrCodeEncoder.QRCodeScale * 5 - 1;

                    int bep4_l = image.Width - qrCodeEncoder.QRCodeScale * 7 - 1;
                    int bep4_t = image.Height - qrCodeEncoder.QRCodeScale * 7 - 1;

                    global::System.Drawing.Graphics graphic0 = global::System.Drawing.Graphics.FromImage(image);

                    // Create solid brush.
                    global::System.Drawing.SolidBrush blueBrush = new global::System.Drawing.SolidBrush(codeEyeColor);

                    // Fill rectangle to screen.
                    graphic0.FillRectangle(blueBrush, bep1_l, bep1_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep2_l, bep2_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep3_l, bep3_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep4_l, bep4_t, qrCodeEncoder.QRCodeScale, qrCodeEncoder.QRCodeScale);
                }

                //当目标图片尺寸大于二维码尺寸时，将二维码绘制在目标尺寸白色画布的中心位置
                #region 如果目标尺寸大于生成的图片尺寸，将二维码绘制在目标尺寸白色画布的中心位置
                if (image.Width < size)
                {
                    //新建空白绘图
                    global::System.Drawing.Bitmap panel = new global::System.Drawing.Bitmap(size, size);
                    global::System.Drawing.Graphics graphic0 = global::System.Drawing.Graphics.FromImage(panel);
                    int p_left = 0;
                    int p_top = 0;
                    if (image.Width <= size) //如果原图比目标形状宽
                    {
                        p_left = (size - image.Width) / 2;
                    }
                    if (image.Height <= size)
                    {
                        p_top = (size - image.Height) / 2;
                    }

                    //将生成的二维码图像粘贴至绘图的中心位置
                    graphic0.DrawImage(image, p_left, p_top, image.Width, image.Height);
                    image = new global::System.Drawing.Bitmap(panel);
                    panel.Dispose();
                    panel = null;
                    graphic0.Dispose();
                    graphic0 = null;
                }
                #endregion
            }
            #endregion
            return image;
        }



        private static bool IsTrue() // 在Image类别对图片进行缩放的时候,需要一个返回bool类别的委托 
        {

            return true;

        }
    }
}
