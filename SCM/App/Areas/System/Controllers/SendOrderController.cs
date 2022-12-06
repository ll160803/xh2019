﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.App.Codes;
using Ipedf.App.Models;
using Ipedf.Core;
using System.IO;
using ThoughtWorks.QRCode.Codec;
using Ipedf.Web.Common;
using System.Text;
using NPOI.SS.UserModel;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SendOrderController : BaseController
    {
        //
        // GET: /System/SupplyPlan/

        public ActionResult Index()
        {
            ViewBag.LastDay = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            ViewBag.NowDay = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }
        public ActionResult AdminIndex()
        {
            ViewBag.LastDay = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            ViewBag.NowDay = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }




        /// <summary>
        /// 获取采购订单列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="order"></param>
        /// <param name="sort"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string txtName, string txtEBELN, string WERKST, string txtSEND_DEPART_NAME)
        {
            // RfcNOC rnc = new RfcNOC(); 
            if (string.IsNullOrEmpty(startDate))
            {
                startDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            }
            if (string.IsNullOrEmpty(endDate))
            {
                endDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            LogHelper.Info("网站搜索数据：账号：" + GetUserID() + ",名字:" + GetCurrentPerson());
            //  var List = rnc.GetPurcharseList(GetUserID(), GetCurrentID(), GetCurrentPerson(), startDate, endDate);
            //  var pageList = List.OrderBy(p => p.EBELN).ThenBy(p => p.EBELP).Skip((page - 1) * rows).Take(rows).ToList();
            CauseObject_SCM_D_PURCHARSEPLAN cause = new CauseObject_SCM_D_PURCHARSEPLAN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and TXZ01 like '%" + txtName.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(txtSEND_DEPART_NAME) && !string.IsNullOrEmpty(txtSEND_DEPART_NAME.Trim()))
            {
                sb.Append(" and SEND_DEAPRT_NAME like '%" + txtSEND_DEPART_NAME.Trim() + "%' ");
            }
            cause.LIFNR = GetCurrentID();
            //   cause.STATUS = "0";
            sb.Append(string.Format(" and BEDAT >='{0}' and BEDAT<='{1}'", startDate, endDate));
            if (!string.IsNullOrEmpty(txtEBELN) && !string.IsNullOrEmpty(txtEBELN.Trim()))
            {
                sb.Append(" and EBELN like '%" + txtEBELN.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(WERKST) && WERKST != "全部")
            {
                cause.WERKST = "%" + WERKST;
            }
            cause.BSART = "Z003";
            var pageIng = new PagingParamter { PageIndex = page - 1, PageSize = rows };
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }

            var pageList = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });


            foreach (var item in pageList)
            {
               
                item.ALLMENGE = GetSubPlanStatistic(item.EBELN, item.EBELP).Sum(p => p.MENGE);
                item.SUREMENGE = GetSubPlanStatistic(item.EBELN, item.EBELP).Where(p => p.STATUS == "1").Sum(p => p.MENGE);

            }

            //var List = new List<Purchase>();
            //List.Add(new Purchase
            //{
            //    ID = Guid.NewGuid().ToString(),
            //    EBELN = "034234",
            //    EBELP = "eewewe",
            //    WERKS = "2eewdsfds",
            //    LIFNR = "100050"

            //});
            return Json(new datagrid
            {
                total = pageIng.TotalRecords,
                rows = pageList


            });
        }

        public JsonResult GetAllData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string txtName, string txtEBELN, string txtGysAccount, string WERKST)
        {
            RfcNOC rnc = new RfcNOC();
            if (string.IsNullOrEmpty(startDate))
            {
                startDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            }
            if (string.IsNullOrEmpty(endDate))
            {
                endDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            LogHelper.Info("网站搜索数据：账号：" + GetUserID() + ",名字:" + GetCurrentPerson());
            //  var List = rnc.GetPurcharseList(GetUserID(), GetCurrentID(), GetCurrentPerson(), startDate, endDate);
            //  var pageList = List.OrderBy(p => p.EBELN).ThenBy(p => p.EBELP).Skip((page - 1) * rows).Take(rows).ToList();
            CauseObject_SCM_D_PURCHARSEPLAN cause = new CauseObject_SCM_D_PURCHARSEPLAN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and TXZ01 like '%" + txtName.Trim() + "%' ");
            }

            if (!string.IsNullOrEmpty(txtEBELN) && !string.IsNullOrEmpty(txtEBELN.Trim()))
            {
                sb.Append(" and EBELN like '%" + txtEBELN.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(txtGysAccount) && !string.IsNullOrEmpty(txtGysAccount.Trim()))
            {
                sb.Append(" and lifnr like '%" + txtGysAccount.Trim() + "%' ");
            }

            //  cause.LIFNR = GetCurrentID();
            //   cause.STATUS = "0";
            sb.Append(string.Format(" and BEDAT >='{0}' and BEDAT<='{1}'", startDate, endDate));

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            if (!string.IsNullOrEmpty(WERKST) && WERKST != "全部")
            {
                cause.WERKST = "%" + WERKST;
            }
            cause.BSART = "Z003";
            var pageIng = new PagingParamter { PageIndex = page - 1, PageSize = rows };


            var pageList = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });


            foreach (var item in pageList)
            {
                item.ALLMENGE = GetSubPlanStatistic(item.EBELN, item.EBELP).Sum(p => p.MENGE);
                item.SUREMENGE = GetSubPlanStatistic(item.EBELN, item.EBELP).Where(p => p.STATUS == "1").Sum(p => p.MENGE);
            }

            //var List = new List<Purchase>();
            //List.Add(new Purchase
            //{
            //    ID = Guid.NewGuid().ToString(),
            //    EBELN = "034234",
            //    EBELP = "eewewe",
            //    WERKS = "2eewdsfds",
            //    LIFNR = "100050"

            //});
            return Json(new datagrid
            {
                total = pageIng.TotalRecords,
                rows = pageList


            });
        }
        /// <summary>
        /// 根据采购订单号和采购订单项目号获取供应计划信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="order"></param>
        /// <param name="sort"></param>
        /// <param name="EBELN"></param>
        /// <param name="EBELP"></param>
        /// <returns></returns>
        public JsonResult GetSubPlanData(Guid? id, int page, int rows, string order, string sort, string EBELN, string EBELP)
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
            cause.EBELN = EBELN;
            cause.GYJH = EBELP;//采购订单项目编号
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


        public List<DisplayObject_SCM_D_SUPPLYPLAN> GetSubPlanStatistic(string EBELN, string EBELP)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            cause.EBELN = EBELN;
            cause.GYJH = EBELP;//采购订单项目编号
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SUPPLYPLAN> queryData = dataSource.ToList();
            return queryData;
        }
        /// <summary>
        /// 采购订单查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="order"></param>
        /// <param name="sort"></param>
        /// <param name="EBELN"></param>
        /// <param name="EBELP"></param>
        /// <returns></returns>
        public JsonResult GetAllSubPlanData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string Code, string Status, string txtName, string txtFPHM, string WERKST)
        {
            int total = 0;

            //平台自动生成代码
            //  CauseObject_SCM_D_SUPPLYPLAN cause = (CauseObject_SCM_D_SUPPLYPLAN)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);
            cause.CREATE_TIME = new DateSpan();

            if (!string.IsNullOrEmpty(startDate))
            {
                cause.CREATE_TIME.Begin = DateTime.Parse(startDate + " 00:00:00");
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                cause.CREATE_TIME.End = Convert.ToDateTime(endDate + " 23:59:59");
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.CODE = Code;
            }
            if (!string.IsNullOrEmpty(Status) && Status != "2")
            {
                cause.STATUS = Status;
            }
            if (!string.IsNullOrEmpty(WERKST) && WERKST != "全部")
            {
                cause.WERKST = "%" + WERKST;
            }
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and TXZ01 like '%" + txtName.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(txtFPHM) && !string.IsNullOrEmpty(txtFPHM.Trim()))
            {
                sb.Append(" and FPHM like '%" + txtFPHM.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> queryData = dataSource.ToList();



            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }

        [HttpPost]
        public ActionResult Export(Guid? id, string startDate, string endDate, string Code, string Status, string txtName, string txtFPHM)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();

            cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);
            cause.CREATE_TIME = new DateSpan();

            if (!string.IsNullOrEmpty(startDate))
            {
                cause.CREATE_TIME.Begin = DateTime.Parse(startDate + " 00:00:00");
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                cause.CREATE_TIME.End = Convert.ToDateTime(endDate + " 23:59:59");
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.CODE = Code;
            }
            if (!string.IsNullOrEmpty(Status) && Status != "2")
            {
                cause.STATUS = Status;
            }
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and TXZ01 like '%" + txtName.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(txtFPHM) && !string.IsNullOrEmpty(txtFPHM.Trim()))
            {
                sb.Append(" and FPHM like '%" + txtFPHM.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SUPPLYPLAN> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "ID", "TXZ01", "MATNR", "CHARG", "VFDAT", "PKG_AMOUNT", "PKG_NUMBER", "MENGE", "ORDER_MENGE", "GYSNAME", "CODE", "MSEHT" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<DisplayObject_SCM_D_SUPPLYPLAN>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1));

        }

        public JsonResult GetAllSubPlanData_admin(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string Code, string GysAccount, string Status, string txtName, string txtFPHM)
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
            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            // cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);
            cause.CREATE_TIME = new DateSpan();

            if (!string.IsNullOrEmpty(startDate))
            {
                cause.CREATE_TIME.Begin = DateTime.Parse(startDate + " 00:00:00");
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                cause.CREATE_TIME.End = Convert.ToDateTime(endDate + " 23:59:59");
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.CODE = Code;
            }
            if (!string.IsNullOrEmpty(GysAccount))
            {
                cause.GYSACCOUNT = GysAccount;
            }
            if (!string.IsNullOrEmpty(Status) && Status != "2")
            {
                cause.STATUS = Status;
            }
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and TXZ01 like '%" + txtName.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(txtFPHM) && !string.IsNullOrEmpty(txtFPHM.Trim()))
            {
                sb.Append(" and FPHM like '%" + txtFPHM.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.BSART = "Z003";
            var dataSource = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> queryData = dataSource.ToList();

            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SubPlan()
        {
            return View();
        }
        /// <summary>
        /// 超级管理员的 权限  可以查看所供应计划有
        /// </summary>
        /// <returns></returns>
        public ActionResult AllSubPlan()
        {
            return View();
        }
        public ActionResult SubPlanPrint()
        {
            return View();
        }
        public ActionResult Scan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_D_SUPPLYPLAN entity, FormCollection form)
        {

            if (entity != null && ModelState.IsValid)
            {

                var mengeNumber = GetSupplyPlan(entity.EBELN, entity.GYJH, "") + entity.MENGE;
                if (mengeNumber > decimal.Parse(form["ORDER_MENGE"]))
                {
                    return Json("F:创建失败，超出采购订单数量！", "text/html");
                }
                entity.GYSACCOUNT = GetCurrentID();//供应商ID
                entity.GYSNAME = GetCurrentPerson();//供应商名称
                entity.EEIND = entity.EEIND.Replace("-", "");
                entity.BEDAT = entity.BEDAT.Replace("-", "");
                //  var Name = Guid.NewGuid().ToString();
                entity.NAME = form["LGORTNAME"];
                entity.STATUS = "0";//0新建 1确认
                entity.INFORMED_STATE = "0";//整包装 初始状态为0
                entity.UNINFORMED_STATE = "0";//散包装 初始状态为0
                entity.FPJR = Convert.ToDecimal(entity.NETPR) * entity.MENGE;//后台重新计算发票金额
                entity.ID = Guid.NewGuid().ToString();
                entity.BSART = "Z003";
                entity.SEND_DEPART = entity.SEND_DEPART.Trim();
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Save(entity);

                if (msg.Succeed)
                {
                    //创建送货单
                    if (string.IsNullOrEmpty(entity.FREEUSE2))//如果是从送货单过来的,则不再生成送货单
                    {
                        BizLogicObject_SCM_B_SENDINFO.Proxy.Save(new EntityObject_SCM_B_SENDINFO
                        {
                            TXZ01 = entity.TXZ01,
                            MSEHT = entity.MSEHT,
                            MATNR = entity.MATNR,
                            MEINS = entity.MEINS,
                            PRICE = Convert.ToDecimal(entity.NETPR),
                            GYSACCOUNT = entity.GYSACCOUNT,
                            GYSNAME = entity.GYSNAME,
                            AMOUNT = entity.MENGE,
                            LINK_PERSON = entity.LINK_PERSON,
                            LINK_TELEPHONE = entity.LINK_TELEPHONE,
                            MATER_CODE = entity.MATER_CODE,
                            MONEY = entity.FPJR,
                            SEND_DEPART = entity.SEND_DEPART,
                            NAME = entity.ID,
                            WERKS = entity.WERKS,
                             CODE =entity.CODE
                        });
                    }
                    // return Json("S:创建成功", "text/html");
                    //   string GYJH = entity.CODE;
                    RfcNOC rnc = new RfcNOC();
                    var list = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                    //   entity.CODE = GYJH;
                    list.Add(entity);
                    // var List = rnc.SendSupplyPlan(list, GetCurrentID(), GetCurrentPerson(), "0", "C");
                    var List_Back = rnc.SendSupplyPlan(GetCurrentID(), list, GetCurrentID(), GetCurrentPerson(), "0", "C");//SAP返回的列表
                    if (List_Back[0].MSTYPE == "S")
                    {
                        return Json("S:创建成功", "text/html");
                    }
                    else
                    {//发送SAP失败，需要回滚，也就是删除
                        CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
                        cause.ID = entity.ID;
                        BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(cause);
                        return Json("F:创建失败，CODE:" + entity.CODE + "发送SAP：" + List_Back[0].MESS, "text/html");
                    }
                }
                else
                {
                    return Json("F:创建失败，CODE:" + entity.CODE + "发送SAP：" + msg.Message, "text/html");
                }
                // }

            }
            return Json("F:创建失败，请核对输入的数据的格式", "text/html");
        }

        public decimal GetSupplyPlan(string ebeln, string EBELP, string id)
        {
            var list = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(new CauseObject_SCM_D_SUPPLYPLAN
            {
                EBELN = ebeln,
                GYJH = EBELP,
                BSART = "Z003"
            });
            if (string.IsNullOrEmpty(id))
            {
                return list.Sum(p => p.MENGE);//创建使用
            }
            else
            {
                return list.Where(p => p.ID != id).Sum(p => p.MENGE);//编辑使用
            }
        }
        /// <summary>
        /// 获取供应计划号
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string GetCodeByName(string Name)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 01;
            paging.PageSize = 1;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            cause.NAME = Name;

            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);
            if (dataSource.Count() > 0)
            {
                return dataSource.FirstOrDefault().CODE;
            }
            return "";
        }
        public ActionResult GetSUPPLYPLANBYGYJH(string GYJH)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = 1;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);

            cause.CODE = GYJH;

            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);
            if (dataSource.Length > 0)
            {

                return Json(dataSource.FirstOrDefault());
            }
            return Json("F");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_D_SUPPLYPLAN> deleteDetailEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            CauseObject_SCM_B_SENDINFO info = new CauseObject_SCM_B_SENDINFO();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_D_SUPPLYPLAN entity = new EntityObject_SCM_D_SUPPLYPLAN();
                entity.ID = item;
                entity = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(entity);
                if (entity.STATUS != "1")
                {
                    deleteDetailEntities.Add(entity);
                    if (string.IsNullOrEmpty(entity.FREEUSE2))
                    {
                        info.SetINValue("NAME", entity.ID);
                    }

                }
            }
            RfcNOC rnc = new RfcNOC();
            var List_Back = rnc.SendSupplyPlan(GetCurrentID(), deleteDetailEntities, GetCurrentID(), GetCurrentPerson(), "0", "D");//SAP返回的列表
            if (List_Back[0].MSTYPE == "S")
            {
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                if (msg.Succeed)
                {
                    if (!string.IsNullOrEmpty(info.NAME))
                    {
                        BizLogicObject_SCM_B_SENDINFO.Proxy.Delete(info);//删除送货单
                    }
                    return Json("OK", "text/html");
                }
                else
                {
                    return Json(msg.Message, "text/html");
                }
            }
            return Json("F:删除失败！", "text/html");
        }

        public ActionResult Edit(string id)
        {
            EntityObject_SCM_D_SUPPLYPLAN curObj = new EntityObject_SCM_D_SUPPLYPLAN();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_D_SUPPLYPLAN curObj = new EntityObject_SCM_D_SUPPLYPLAN();
            curObj.ID = from["ID"];
            curObj = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(curObj);

            if (curObj.STATUS == "1")
            {
                return Json("F:保存失败，已经收货供应计划，不允许编辑！", "text/html");
            }
            int IsAllow = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.IsAllowAdd(curObj.EBELN, curObj.GYJH.Trim(), Convert.ToDecimal(from["MENGE"]), curObj.GYSACCOUNT, curObj.MATNR, "", 0, curObj.ID);
            if (IsAllow == 1)
            {
                TryUpdateModel<EntityObject_SCM_D_SUPPLYPLAN>(curObj, from);
                curObj.SEND_DEPART = curObj.SEND_DEPART.Trim();//去空格
                curObj.FPJR = Convert.ToDecimal(curObj.NETPR) * curObj.MENGE;
                curObj.SetNotUpdate("HSDAT");
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);
                var listUpdateEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                listUpdateEntities.Add(curObj);
                if (msg.Succeed)
                {
                    //修改送货单
                    if (string.IsNullOrEmpty(curObj.FREEUSE2))//不是从送货单 修改计划需要对应的送货单
                    {
                        var sendinfo = BizLogicObject_SCM_B_SENDINFO.Proxy.Query(new CauseObject_SCM_B_SENDINFO { NAME = curObj.ID }).FirstOrDefault();
                        if (sendinfo != null)
                        {
                            sendinfo.TXZ01 = curObj.TXZ01;
                            sendinfo.MSEHT = curObj.MSEHT;
                            sendinfo.MATNR = curObj.MATNR;
                            sendinfo.MEINS = curObj.MEINS;
                            sendinfo.GYSACCOUNT = curObj.GYSACCOUNT;
                            sendinfo.GYSNAME = curObj.GYSNAME;
                            sendinfo.AMOUNT = curObj.MENGE;
                            sendinfo.LINK_PERSON = curObj.LINK_PERSON;
                            sendinfo.LINK_TELEPHONE = curObj.LINK_TELEPHONE;
                            sendinfo.MATER_CODE = curObj.MATER_CODE;
                            sendinfo.MONEY = curObj.FPJR;
                            sendinfo.SEND_DEPART = curObj.SEND_DEPART;
                            sendinfo.WERKS = curObj.WERKS;
                            sendinfo.CODE = curObj.CODE;
                            BizLogicObject_SCM_B_SENDINFO.Proxy.Update(sendinfo);
                        }
                    }
                    //return Json("S:保存成功", "text/html");
                    RfcNOC rnc = new RfcNOC();
                    var List_Back = rnc.SendSupplyPlan(GetCurrentID(), listUpdateEntities, GetCurrentID(), GetCurrentPerson(), "0", "U");//SAP返回的列表
                    if (List_Back[0].MSTYPE == "S")
                    {
                        return Json("S:保存成功", "text/html");
                    }
                    else
                    {
                        LogHelper.Info("供应计划号:" + curObj.CODE + ":SCM保存成功,SAP保存失败", 1);
                        return Json("S:SCM保存成功,SAP保存失败！", "text/html");
                    }
                }
                else
                {

                    return Json("F:保存失败，请核对输入的数据的格式", "text/html");
                }
            }
            else
            {
                return Json("F:保存失败，超出采购订单数量", "text/html");
            }


        }
        [HttpPost]
        public ActionResult GenerateMark(string id)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //System.Drawing.Image image = qrCodeEncoder.Encode("4408810820 深圳－广州 小江");
            global::System.Drawing.Image image = qrCodeEncoder.Encode(id);
            string filename = Guid.NewGuid().ToString() + ".jpg";
            string filepath = Server.MapPath(@"~\UploadFile") + "\\" + filename;
            global::System.IO.FileStream fs = new global::System.IO.FileStream(filepath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
            image.Save(fs, global::System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();
            return Content(@"/UploadFile/" + filename);
        }

        [HttpPost]
        public ActionResult DoneSupply(string gyjh, string gysAccount, string gysName)
        {
            try
            {
                PagingParamter paging = new PagingParamter();

                paging.PageIndex = 0;
                paging.PageSize = 1;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = true;
                OrderByPara.OrderBy = "CODE";
                CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
                //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
                //c_Get.GenerateWhere(cause, search);

                cause.CODE = gyjh;

                var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

                var entity = dataSource.FirstOrDefault();
                if (entity == null)
                {
                    return Json(new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划不存在"
                    }, "text/html");
                }
                if (entity.STATUS == "1")//散装和整装都已经完成收货
                {
                    return Json(new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划已经收货"//在做扫描的时候，这种信息不再调用接口，或者显示已经收货
                    }, "text/html");
                }
                EntityObject_SCM_D_SUPPLYPLAN curObj = new EntityObject_SCM_D_SUPPLYPLAN();
                curObj.ID = entity.ID;
                curObj = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(curObj);

                curObj.STATUS = "1";//确认收货
                curObj.UNINFORMED_STATE = "1";//散装完成
                curObj.INFORMED_STATE = "1";//整装完成
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);
                if (msg.Succeed)
                {
                    RfcNOC rnc = new RfcNOC();
                    var listEntity = new List<EntityObject_SCM_D_SUPPLYPLAN>(); listEntity.Add(curObj);
                    var List_Back = rnc.SendSupplyPlan(GetCurrentID(), listEntity, gysAccount, gysName, "1", "U");//SAP返回的列表 1是确认
                    if (List_Back[0].MSTYPE == "S")
                    {

                        return Json(new Models.MessModel
                        {
                            IsSuccess = true,
                            Mess = "确认收货"

                        }, "text/html");

                    }
                    else
                    {
                        curObj.STATUS = "0";
                        BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);
                        return Json(new Models.MessModel
                        {
                            IsSuccess = false,
                            Mess = "上传SAP失败！"

                        }, "text/html");
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new Models.MessModel
                {
                    IsSuccess = false,
                    Mess = ex.Message

                }, "text/html");
            }
            return Json(new Models.MessModel
            {
                IsSuccess = false,
                Mess = "不明错误"

            }, "text/html");
        }

    }
}
