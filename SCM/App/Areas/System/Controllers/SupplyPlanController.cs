using System;
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
    public class SupplyPlanController : BaseController
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
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string txtName, string txtEBELN, string WERKST, string BKLAS)
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
            if (!string.IsNullOrEmpty(BKLAS) && BKLAS != "全部")
            {
                sb.Append(" and SCM_D_MATER_MATNR.BKLAS = '" + BKLAS.Trim() + "' ");
            }
            cause.BSART = "Z004";
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

        public JsonResult GetAllData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string txtName, string txtEBELN, string txtGysAccount, string WERKST, string BKLAS)
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
            if (!string.IsNullOrEmpty(BKLAS) && BKLAS != "全部")
            {
                sb.Append(" and SCM_D_MATER_MATNR.BKLAS = '" + BKLAS.Trim() + "' ");
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
            //if (!string.IsNullOrEmpty(BKLAS) && BKLAS != "全部")
            //{
            //    cause. = BKLAS;
            //}
            cause.BSART = "Z004";
            var pageIng = new PagingParamter { PageIndex = page - 1, PageSize = rows };


            var pageList = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });

            List<DisplayObject_SCM_D_PURCHARSEPLAN> queryData = pageList.ToList();

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
            cause.BSART = "Z004";
            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_SCM_D_SUPPLYPLAN> queryData = dataSource.ToList();
            foreach (var item in queryData)
            {
                var file_en = BizLogicObject_V_SCM_D_MATER_PIC_COM_FILE.Proxy.Query(new CauseObject_V_SCM_D_MATER_PIC_COM_FILE
                 {
                     GYSACCOUNT = item.GYSACCOUNT,
                     MATNR = item.MATNR,
                     CHARGE = item.CHARG
                 }).FirstOrDefault();
                if (file_en != null)
                {
                    item.FREEUSE3 = file_en.SERVER_NAME;
                }
            }
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
            cause.BSART = "Z004";
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
            cause.BSART = "Z004";
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
            cause.BSART = "Z004";
            var dataSource = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //string[] Liststring = new string[] { "ID", "TXZ01", "MATNR", "CHARG", "VFDAT", "PKG_AMOUNT", "PKG_NUMBER", "MENGE", "ORDER_MENGE", "GYSNAME", "CODE", "MSEHT", "OUT_CAUSE", "OUT_DATE" };
            string[] Liststring = new string[] { "CODE", "EBELN", "GYJH", "MATNR", "TXZ01", "WERKST", "GYSACCOUNT", "GYSNAME", "NAME", "ORDER_MENGE", "MSEHT", "NETPR", "EEIND", "BEDAT", "MENGE", "CHARG", "HSDAT", "VFDAT", "FPHM", "FPJR", "FPRQ", "CREATE_TIME", "STATUS_NAME", "OUT_CAUSE", "OUT_DATE" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<DisplayObject_V_SCM_D_SUPPLIERPLAN>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1));

        }

        [HttpPost]
        public ActionResult ExportAll(Guid? id, string startDate, string endDate, string Code, string Status, string txtName, string txtFPHM,string OutCause)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            //cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
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
            if (!string.IsNullOrEmpty(OutCause) && !string.IsNullOrEmpty(OutCause.Trim()))
            {
                sb.Append(" and Out_Cause like '%" + OutCause.Trim() + "%' ");
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.BSART = "Z004";
            var dataSource = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //string[] Liststring = new string[] { "ID", "TXZ01", "MATNR", "CHARG", "VFDAT", "PKG_AMOUNT", "PKG_NUMBER", "MENGE", "ORDER_MENGE", "GYSNAME", "CODE", "MSEHT", "OUT_CAUSE", "OUT_DATE" };
            string[] Liststring = new string[] { "CODE", "EBELN", "GYJH", "MATNR", "TXZ01", "WERKST", "GYSACCOUNT", "GYSNAME", "NAME", "ORDER_MENGE", "MSEHT", "NETPR", "EEIND", "BEDAT", "MENGE", "CHARG", "HSDAT", "VFDAT", "FPHM", "FPJR", "FPRQ", "CREATE_TIME", "STATUS_NAME", "OUT_CAUSE", "OUT_DATE" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<DisplayObject_V_SCM_D_SUPPLIERPLAN>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1));

        }

        public JsonResult GetAllSubPlanData_admin(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string Code, string GysAccount, string Status, string txtName, string txtFPHM, string BKLAS,string OUT_CAUSE)
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
            if (!string.IsNullOrEmpty(BKLAS) && BKLAS != "全部")
            {
                sb.Append(" and MATNR_BKLAS = '" + BKLAS.Trim() + "' ");
            }
            if (!string.IsNullOrEmpty(OUT_CAUSE) )
            {
                sb.Append(" and OUT_CAUSE = '" + OUT_CAUSE.Trim() + "' ");
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.BSART = "Z004";
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
        [HttpPost]
        public ActionResult PrintPlan(FormCollection form)
        {
            //string currentPerson = GetCurrentPerson();
            //ViewBag.PersonNamea = currentPerson;
            //string currentId = GetCurrentID();
            //ViewBag.PersonIda = currentId;
            var arrID = form["content"];
            var IDS = arrID.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            CauseObject_V_SCM_D_SUPPLIERPLAN c1 = new CauseObject_V_SCM_D_SUPPLIERPLAN();
            foreach (var id in IDS)
            {
                c1.SetINValue("ID", id);
            }
            c1.SetCustomCondition(" order by BEDAT desc");
            var e1 = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(c1);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(GenerateHeadStr(), e1[0].GYSACCOUNT, e1[0].GYSNAME, e1[0].WERKST);
            sb.AppendFormat(GenerateTabHeadStr(), "订单日期", "供应计划", "药品编码", "药品名称", "计划数量", "送货数量", "基本单位", "单价", "金额", "批次", "发票号码", "发票金额", "缺货原因", "预计补送日期");

           
            foreach (DisplayObject_V_SCM_D_SUPPLIERPLAN f2 in e1)
            {
                sb.AppendFormat(GenerateRowStr(), f2.BEDAT, f2.CODE, f2.MATNR, f2.TXZ01, f2.ORDER_MENGE, f2.MENGE, f2.MSEHT, f2.NETPR, Convert.ToDecimal(f2.NETPR) * f2.MENGE, f2.CHARG, f2.FPHM, f2.FPJR, f2.OUT_CAUSE, Convert.ToDateTime(f2.OUT_DATE).ToString() == DateTime.MinValue.ToString() ? "" : Convert.ToDateTime(f2.OUT_DATE).ToString("yyyy-MM-dd"));
            }
            sb.AppendFormat("<tr><td colspan=\"5\" style=\"height:30px;font-family:宋体;border-top:solid 1px black;text-align:left;font-size: 12px;\" >供应商(盖章)：{0}</td><td colspan=\"5\" style=\"height:30px;font-family:宋体;border-top:solid 1px black;font-size: 12px;\" >采购中心(签字)：</td><td colspan=\"4\" style=\"height:30px;border-top:solid 1px black;font-family:宋体;font-size: 12px;\" >打印日期：</td></tr>", e1[0].GYSNAME);
            sb.Append("</table>");
            ViewBag.PrintStr = new MvcHtmlString(sb.ToString());
            return View();
        }
        public void GenerateCodePlan(StringBuilder sb, string TXZ01)
        {
            var replaceStr = GenerateStr();
            var addTR = "";
            sb.AppendFormat(replaceStr, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01, TXZ01);
        }
        public void GenerateCode(StringBuilder sb, string data, string TXZ01, string MATNR, string CHARG, string ORDER_MENGE, string VFDAT, string perPage, string CREATENAME, string GYJH, string fenPage, string MSEHT, string PKG_AMOUNT, string PKG_NUMBER, string NUMBER, string WERKST, string NAME)
        {
            var replaceStr = GenerateStr();
            var addTR = "";
            //if (fenPage != "")//第一张上面空有20px，所以在之后每一张之前加20px
            //{
            //    addTR = "<tr><td colspan=\"3\" style=\"width:340px;height:20px;\"></td></tr>";
            //}

            sb.AppendFormat(replaceStr, TXZ01, MATNR, data, CHARG, ORDER_MENGE, VFDAT, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), GYJH, CREATENAME, fenPage, MSEHT, PKG_AMOUNT, PKG_NUMBER, NUMBER, addTR, WERKST.Replace("武汉协和医院", "").Replace("-", ""), NAME);
        }
        public string GenerateStr()
        {
            var reStr = "<div style=\"width: 340px; margin: 0; padding: 0; font-family:宋体;font-size: 14px; {9}\"><table cellpadding=\"0\" cellspacing=\"0\">{14}" +
                "<tr>" +
                    "<td colspan=\"2\" style=\"width: 240px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "华中科技大学同济医学院附属协和医院" +
                    "</td>" +
                    "<td  style=\"width: 100px;height:16px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                "</tr>" +
                 "<tr>" +
                    "<td style=\"width: 70px;height:30px;font-family:宋体;font-size: 14px;\">" +
                        "药品名称：" +
                    "</td>" +
                    "<td colspan=\"2\" style=\"width: 270px;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width: 70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "物料号：" +
                   " </td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td rowspan=\"6\" style=\"width: 80px;height:80px;\">" +
                        "<img alt=\"显示出错\" id=\"im_1\" src=\"..{2}\"  style=\" width:80px; height:80px;\"/>" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "批号：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{3}" +
                    "</td>" +
                "</tr>" +

                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "有效日期：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{5}" +
                    "</td>" +
               " </tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "包装数量：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{11}{10}/箱" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "箱数：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{12}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                   " <td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "实收数量：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{13}{10}({15})" +
                   " </td>" +
                "</tr>" +
                "<tr>" +
                   " <td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "订单数量：" +
                    "</td>" +
                    "<td  style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{4}{10}({16})" +
                   " </td>" +
                    "<td style=\"width:100px;height:16px;font-family:宋体;font-size: 12pt;\">" +
                       "{7}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:30px;font-family:宋体;vertical-align:top;font-size: 14px;\">" +
                        "供应商：" +
                    "</td>" +
                    "<td colspan=\"2\" style=\"width: 270px;height:30px;vertical-align:top;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                "</tr>" +
            "</table>" +
        "</div>";
            return reStr;

        }
        public string GenerateHeadStr()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table cellpadding=\"0\" cellspacing=\"0\">");
            sb.AppendFormat("<tr><td colspan=\"14\" style=\"height:50px;font-family:宋体;text-align:center;font-size: 20px;\" >{0}</td></tr>", "武汉协和医院药品送货清单");
            sb.Append("<tr><td colspan=\"3\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >供应商编码：{0}</td>");
            sb.Append("<td colspan=\"5\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >供应商名称：{1}</td>");
            sb.Append("<td colspan=\"4\" style=\"height:40px;font-family:宋体;text-align:left;font-size: 12px;\" >院区：{2}</td><tr>");
           
            return sb.ToString();

        }
        public string GenerateTabHeadStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
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
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{10}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{11}" +
                       "</td>" +
                      "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{12}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;border-right:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{13}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }
        /// <summary>
        /// 每行的数据设置
        /// </summary>
        /// <returns></returns>
        public string GenerateRowStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
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
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{10}" +
                    "</td>" +
                       "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{11}" +
                    "</td>" +

                       "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{12}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;border-right:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{13}" +
                    "</td>" +
                "</tr>";

            return reStr;

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
                #region 有效期检查
                DateTime now = DateTime.Now;
                if (entity.VFDAT < now.AddMonths(6))
                {
                    return Json("F:创建失败，药品剩余效期不足6个月！", "text/html");
                }
                #endregion

                #region 资质文件检查
                if (!SupplierLimit.IsSettingLimit(GetCurrentID()))
                {
                    var listFiles = BizLogicObject_V_SCM_D_MATER_PIC_COM_FILE.Proxy.Query(new CauseObject_V_SCM_D_MATER_PIC_COM_FILE
                    {
                        MATNR = entity.MATNR.Trim(),
                        CHARGE = entity.CHARG.Trim(),
                        GYSACCOUNT = GetCurrentID()
                    });
                    if (listFiles.Length <= 0)
                    {
                        return Json("F:创建失败，没有对应的药品验收报告文件！", "text/html");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(listFiles[0].SERVER_NAME))
                        {
                            return Json("F:创建失败，没有上传对应的药品验收报告文件！", "text/html");
                        }
                    }
                }
                #endregion
                   
                var mengeNumber = GetSupplyPlan(entity.EBELN, entity.GYJH, "") + entity.MENGE;
                if (mengeNumber > decimal.Parse(form["ORDER_MENGE"]))
                {
                    return Json("F:创建失败，超出采购订单数量！", "text/html");
                }
                //缺货验证
                var listFiles1 = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(new CauseObject_SCM_D_PURCHARSEPLAN
                {
                    EBELN = entity.EBELN,
                    EBELP = entity.GYJH

                });
                if (listFiles1.Length > 0)
                {
                    if (listFiles1[0].MENGE > entity.MENGE)
                    {
                        if (string.IsNullOrEmpty(entity.OUT_CAUSE))
                        {
                            return Json("F:创建失败，请选择缺货原因！", "text/html");
                        }
                        if (string.IsNullOrEmpty(entity.OUT_DATE.ToString()))
                        {
                            return Json("F:创建失败，请选择预计补货日期！", "text/html");
                        }
                    }
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
                entity.BSART = "Z004";
                entity.OUT_CAUSE = entity.OUT_CAUSE;
                entity.OUT_DATE = entity.OUT_DATE;
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Save(entity);

                if (msg.Succeed)
                {
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
                 BSART="Z004"
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
            foreach (var item in deleteId)
            {
                EntityObject_SCM_D_SUPPLYPLAN entity = new EntityObject_SCM_D_SUPPLYPLAN();
                entity.ID = item;
                entity = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(entity);
                if (entity.STATUS != "1")
                {
                    deleteDetailEntities.Add(entity);
                }
            }
            RfcNOC rnc = new RfcNOC();
            var List_Back = rnc.SendSupplyPlan(GetCurrentID(), deleteDetailEntities, GetCurrentID(), GetCurrentPerson(), "0", "D");//SAP返回的列表
            if (List_Back[0].MSTYPE == "S")
            {
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                if (msg.Succeed)
                {
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
            #region 资质文件 检查
            if (!SupplierLimit.IsSettingLimit(GetCurrentID()))
            {
                var listFiles = BizLogicObject_V_SCM_D_MATER_PIC_COM_FILE.Proxy.Query(new CauseObject_V_SCM_D_MATER_PIC_COM_FILE
                {
                    MATNR = curObj.MATNR,
                    CHARGE = from["CHARG"].ToString(),
                    GYSACCOUNT = curObj.GYSACCOUNT

                });
                if (listFiles.Length <= 0)
                {
                    return Json("F:保存失败，没有对应的药品验收报告文件！", "text/html");
                }
                else
                {
                    if (string.IsNullOrEmpty(listFiles[0].SERVER_NAME))
                    {
                        return Json("F:保存失败，没有上传对应的药品验收报告文件！", "text/html");
                    }
                }
            }
            #endregion
            //缺货验证
            var listFiles1 = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(new CauseObject_SCM_D_PURCHARSEPLAN
            {
                EBELN = curObj.EBELN,
                EBELP = curObj.GYJH

            });
            if (listFiles1.Length > 0)
            {
                if (listFiles1[0].MENGE > Convert.ToDecimal(from["MENGE"]))
                {
                    if (string.IsNullOrEmpty(from["OUT_CAUSE"]))
                    {
                        return Json("F:更新失败，请选择缺货原因！", "text/html");
                    }
                    if (string.IsNullOrEmpty(from["OUT_DATE"].ToString()))
                    {
                        return Json("F:更新失败，请选择预计补货日期！", "text/html");
                    }
                }
            }
            if (curObj.STATUS == "1")
            {
                return Json("F:保存失败，已经收货供应计划，不允许编辑！", "text/html");
            }
            int IsAllow = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.IsAllowAdd(curObj.EBELN, curObj.GYJH.Trim(), Convert.ToDecimal(from["MENGE"]),curObj.GYSACCOUNT,curObj.MATNR,from["CHARG"].ToString(),0, curObj.ID);
            if (IsAllow == 1)
            {
                TryUpdateModel<EntityObject_SCM_D_SUPPLYPLAN>(curObj, from);
                curObj.FPJR = Convert.ToDecimal(curObj.NETPR) * curObj.MENGE;
                curObj.OUT_DATE = curObj.OUT_DATE == null ? DateTime.MinValue : curObj.OUT_DATE;
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);
                var listUpdateEntities = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                listUpdateEntities.Add(curObj);
                if (msg.Succeed)
                {
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
