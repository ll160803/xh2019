using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Models;
using Newtonsoft.Json;
using Ipedf.Web.Common;

namespace Ipedf.App.Areas.XJ.Controllers
{
    public class SCM_B_QUERYPRICEController : BaseController
    {
        //
        // GET: /XJ/SCM_B_QUERYPRICE/z

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string M_NAME, string M_STANDARD, string BJ_STATE,string XJ_STATE,
            string xj_from, string xj_to, string jz_from, string jz_to)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_V_SCM_B_QUERYPRICE_GYS cause = new CauseObject_V_SCM_B_QUERYPRICE_GYS();

            string strSql = "";
            if (!string.IsNullOrEmpty(M_NAME))
            {
                //strSql += " AND V_SCM_B_QUERYPRICE_GYS.TXZ01 like '%" + M_NAME + "%'";
                cause.TXZ01 = "%" + M_NAME + "%";
            }
            
            if (!string.IsNullOrEmpty(M_STANDARD))
            {
                cause.SPEC = "%" + M_STANDARD + "%";
            }

            if (!string.IsNullOrEmpty(XJ_STATE))
            {
                cause.QUERY_STATE = XJ_STATE;
            }

            if (!string.IsNullOrEmpty(BJ_STATE))
            {
                cause.QUOTEDPRICE_STATE = decimal.Parse(BJ_STATE);
            }
            //未询价不可以被供应商看到
            strSql += " AND V_SCM_B_QUERYPRICE_GYS.QUERY_STATE !='SCM000101' ";

            if (!string.IsNullOrEmpty(xj_from))
            {
                strSql += GetDateSql("V_SCM_B_QUERYPRICE_GYS.QUERY_DATE", xj_from, ">=");
            }

            if (!string.IsNullOrEmpty(xj_to))
            {
                strSql += GetDateSql("V_SCM_B_QUERYPRICE_GYS.QUERY_DATE", xj_to, "<=");
            }

            if (!string.IsNullOrEmpty(jz_from))
            {
                strSql += GetDateSql("V_SCM_B_QUERYPRICE_GYS.END_DATE", jz_from, ">=");
            }

            if (!string.IsNullOrEmpty(jz_to))
            {
                strSql += GetDateSql("V_SCM_B_QUERYPRICE_GYS.END_DATE", jz_to, "<=");
            }

            cause.GYSACCOUNT = GetCurrentID();
            //strSql += string.Format(" and V_SCM_B_QUERYPRICE_GYS.ID in (select BASE_ID from SCM_B_QUERYPRICE_D where GYSACCOUNT='{0}')", GetCurrentID());

            //GetDateSql
            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }
            var pageList = BizLogicObject_V_SCM_B_QUERYPRICE_GYS.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }
        /// <summary>
        /// 通过询价信息ID返回默认生产厂家名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetProductsByQueryIndex(string id)
        {
            var productList = BizLogicObject_SCM_B_QUERYPRICE_PRODUCT.Proxy.Query(new CauseObject_SCM_B_QUERYPRICE_PRODUCT { BASE_ID = id });
            if (productList.Count() > 0)
            {
                return Json(new { PRODUCT_NAME = productList.FirstOrDefault().PRODUCT_NAME });
            }
            return Json(new { PRODUCT_NAME = "" });
        }
        
        /// <summary>
        /// 获取询价状态
        /// </summary>
        /// <returns></returns>
        public JsonResult GetQuotedStateCombobox()
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_COM_TYPE cause = new CauseObject_COM_TYPE();
            cause.PARENT_ID = "SCM0001";
            var dataSource = BizLogicObject_COM_TYPE.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_TYPE> queryData = dataSource.ToList();

            return Json(
                queryData.Select(s => new
                {
                    text = s.NAME,
                    value = s.ID

                })
                );

        }

        //获取询价编辑数据
        public JsonResult GetDataEditList(string id, string order, string sort)
        {
            DisplayObject_SCM_B_QUERYPRICE_E[] itemDisplay = null;
            if (!string.IsNullOrEmpty(id))
            {
                string[] arrID = id.Split(',');
                CauseObject_SCM_B_QUERYPRICE cause = new CauseObject_SCM_B_QUERYPRICE();
                foreach (string strId in arrID)
                {
                    cause.SetINValue("ID", strId);
                }

                OrderByParameter orders = GetOrder(order, sort);

                itemDisplay = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Query_E(cause, null, orders);
            }
            else
            {
                itemDisplay = new DisplayObject_SCM_B_QUERYPRICE_E[0];
            }
            return Json(new
            {
                total = itemDisplay.Length,
                rows = itemDisplay
            });
        }

        //获取询价编辑供应商数据
        public JsonResult GetDataEditSubData(string id, string order, string sort)
        {
            DisplayObject_SCM_B_QUERYPRICE_D[] itemDisplay = null;
            if (!string.IsNullOrEmpty(id))
            {
                CauseObject_SCM_B_QUERYPRICE_D cause = new CauseObject_SCM_B_QUERYPRICE_D();
                cause.BASE_ID = id;

                OrderByParameter orders = GetOrder(order, sort);

                itemDisplay = BizLogicObject_SCM_B_QUERYPRICE_D.Proxy.Query(cause, null, orders);
            }
            else
            {
                itemDisplay = new DisplayObject_SCM_B_QUERYPRICE_D[0]; 
            }
            return Json(new
            {
                total = itemDisplay.Length,
                rows = itemDisplay
            });
        }

        //获取药品信息
        public JsonResult GetMaterData(Guid? id, int page, int rows, string order, string sort, string name)
        {
            CauseObject_SCM_D_HRPMATER cause = new CauseObject_SCM_D_HRPMATER();
            string strSql = " AND SCM_D_HRPMATER.MTART IN(SELECT MTART FROM V_SCMHRPMATER_TYPE WHERE TYPE = 1)";
            if (!string.IsNullOrEmpty(name))
            {
                strSql += " AND (SCM_D_HRPMATER.MAKTX like '%" + name + "%' OR SCM_D_HRPMATER.ZEINR like '%" + name.ToUpper() + "%') ";
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }

            OrderByParameter orders = GetOrder(order, sort);

            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };

            var itemDisplay = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(cause, pageIng, orders);
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = itemDisplay
            });
        }

        //获取供应商信息
        public JsonResult GetMdmDeptData(Guid? id, string order, string sort, string name)
        {
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT();
            cause.DEPT_TYPE_ID = "SCM00340001";
            if (!string.IsNullOrEmpty(name))
                cause.SetCustomCondition(" AND (MDM_D_DEPT.NAME like '%" + name + "%' OR MDM_D_DEPT.CODE like '%" + name + "%')");

            OrderByParameter orders = GetOrder(order, sort);

            var itemDisplay = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause, null, orders);
            return Json(new
            {
                total = itemDisplay.Length,
                rows = itemDisplay
            });
        }

        //默认排序
        private OrderByParameter GetOrder(string order, string sort)
        {
            OrderByParameter orders = new OrderByParameter();

            if (string.IsNullOrEmpty(order))
            {
                order = "desc";
            }

            //QUOTED_PRICE_MIN desc,QUOTED_PRICE desc,PRICE
            if (string.IsNullOrEmpty(sort))
            {
                sort = "ID";
            }

            order = order.ToLower();

            orders.Asc = order == "desc" ? true : false;
            orders.OrderBy = sort;

            return orders;
        }

        //获取询价列表显示
        public JsonResult GetDataList(Guid? id, int page, int rows, string order, string sort, string TXZ01, string SPEC, string QUERY_STATE, string BEGIN_QUERY_DATE,
string END_QUERY_DATE, string BEGIN_END_DATE, string END_END_DATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_SCM_B_QUERYPRICE cause = new CauseObject_SCM_B_QUERYPRICE();

            if (!string.IsNullOrEmpty(SPEC))
            {
                cause.SPEC = "%" + SPEC + "%";
            }

            if (!string.IsNullOrEmpty(QUERY_STATE))
            {
                cause.QUERY_STATE = QUERY_STATE;
            }

            string strSql = "";
            if (!string.IsNullOrEmpty(TXZ01))
            {
                strSql += " AND (SCM_B_QUERYPRICE.TXZ01 like '%" + TXZ01 + "%' OR SCM_D_HRPMATER.ZEINR like '%" + TXZ01.ToUpper() + "%')";
            }
            if (!string.IsNullOrEmpty(BEGIN_QUERY_DATE))
            {
                strSql += GetDateSql("SCM_B_QUERYPRICE.QUERY_DATE",BEGIN_QUERY_DATE,">=");
            }

            if (!string.IsNullOrEmpty(END_QUERY_DATE))
            {
                strSql += GetDateSql("SCM_B_QUERYPRICE.QUERY_DATE", END_QUERY_DATE, "<=");
            }

            if (!string.IsNullOrEmpty(BEGIN_END_DATE))
            {
                strSql += GetDateSql("SCM_B_QUERYPRICE.END_DATE", BEGIN_END_DATE, ">=");
            }

            if (!string.IsNullOrEmpty(END_END_DATE))
            {
                strSql += GetDateSql("SCM_B_QUERYPRICE.END_DATE", END_END_DATE, "<=");
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }
            OrderByParameter orders = GetOrder(order, sort);
            var pageList = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Query_I(cause, pageIng, orders);
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        //更新询价状态
        [HttpPost]
        public JsonResult UpdateType(string id, string date, string ids, int type)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (!string.IsNullOrEmpty(ids))
            {
                string[] itemIds = ids.Split(',');
                
                if (itemIds.Length > 0)
                {
                    msg = BizLogicObject_SCM_B_QUERYPRICE.Proxy.UpdateState(date, itemIds, type);
                }
                else
                {
                    msg.Succeed = false;
                    msg.Message = "未传入有效的数据!";
                }
            }
            else
            {
                msg.Succeed = false;
                msg.Message = "传入的参数有误!";
            }
            return Json(new
            {
                Success = msg.Succeed == true ? "1" : "0",
                Message = msg.Message
            });
        }

        //批量新增、编辑询价信息
        [HttpPost]
        public JsonResult Update(string ID, FormCollection form,string Submit)
        {
            var jsonData = form["data"];
            List<DisplayObject_SCM_B_QUERYPRICE_E> resultDisplay = new List<DisplayObject_SCM_B_QUERYPRICE_E>();
            if (jsonData != null)
            {
                bool IsSubmit = false;
                if (!string.IsNullOrEmpty(Submit))
                {
                    if (Submit.Trim().ToLower() == "true")
                    {
                        IsSubmit = true;
                    }
                }
                List<EntityObject_SCM_B_QUERYPRICE_U> list = new List<EntityObject_SCM_B_QUERYPRICE_U>();
                list = JsonConvert.DeserializeObject<List<EntityObject_SCM_B_QUERYPRICE_U>>(jsonData);
                BizLogicMsg msg = BizLogicObject_SCM_B_QUERYPRICE.Proxy.UpdatePost(list, IsSubmit, resultDisplay);
            }
            return Json(new
            {
                total = resultDisplay.Count,
                rows = resultDisplay
            });

        }

        //批量删除询价信息
        [HttpPost]
        public JsonResult Delete(string id, string ids)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (!string.IsNullOrEmpty(ids))
            {
                string[] itemId = ids.Split(',');

                EntityObject_SCM_B_QUERYPRICE[] itemEntity = new EntityObject_SCM_B_QUERYPRICE[itemId.Length];
                for (int i = 0; i < itemId.Length; i++)
                {
                    EntityObject_SCM_B_QUERYPRICE entity = new EntityObject_SCM_B_QUERYPRICE();
                    entity.ID = itemId[i];
                    itemEntity[i] = entity;
                }

                if (itemEntity != null && itemEntity.Length > 0)
                {
                    msg = BizLogicObject_SCM_B_QUERYPRICE.Proxy.DeletePost(itemEntity);
                }
            }
            else
            {
                msg.Succeed = false;
                msg.Message = "传入的参数有误!"; 
            }
            return Json(new
            {
                Success = msg.Succeed == true ? "1" : "0",
                Message = msg.Message
            });
        }

        //询价详情页面模糊搜索
        private string GetQuotedDetailWhere(string GYSNAME, string PRODUCT_NAME, string HOSPITAL_NAME, string strSql)
        {
            if (!string.IsNullOrEmpty(GYSNAME))
            {
                strSql += " AND V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME like '%" + GYSNAME + "%'";
            }
            if (!string.IsNullOrEmpty(PRODUCT_NAME))
            {
                strSql += " AND V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME like '%" + PRODUCT_NAME + "%'";
            }
            if (!string.IsNullOrEmpty(HOSPITAL_NAME))
            {
                strSql += " AND V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME like '%" + HOSPITAL_NAME + "%'";
            }
            return strSql;
        }

        //查询拼接DATE数据
        private string GetDateSql(string filed,string val,string zf)
        {
            return " AND " + filed + " " + zf + " to_date('" + val + "','yyyy/mm/dd')";
        }

        //新增药品询价页面跳转
        public ActionResult Create(string id)
        {
            ViewBag.ID = id == null ? "" : id;
            return View();
        }

        //查询ID询价数据
        public JsonResult GetDataID(string id)
        {
            DisplayObject_SCM_B_QUERYPRICE_E entity = new DisplayObject_SCM_B_QUERYPRICE_E();
            entity.ID = id;
            entity = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Get_U(entity);

            return Json(entity);
        }

        //询价详情页面跳转
        public ActionResult QuotedDetailList(string id)
        {
            GetBagID(id);
            return View();
        }

        //询价信息报价详情
        public JsonResult GetQuotedDetail(string id, int page, int rows, string order, string sort, string GYSNAME, string PRODUCT_NAME, string HOSPITAL_NAME)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            OrderByParameter orders = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause = new CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL();
            cause.MID = id;

            string strSql = "";
            strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }

            var itemDisplay = BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL.Proxy.Query_U(cause,true, pageIng, orders);

            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = itemDisplay
            });
        }

        //询价信息报价详情导出
        [HttpPost]
        public ActionResult ExportQuotedDetail(string id, string GYSNAME, string PRODUCT_NAME, string HOSPITAL_NAME)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            ///OrderByParameter OrderByPara = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause = new CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL();
            cause.MID = id.ToString();

            string strSql = "";
            strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            if (!string.IsNullOrEmpty(strSql))
            {
                cause.SetCustomCondition(strSql);
            }

            var dataSource = BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL.Proxy.Query_U(cause,true, paging, null);
            DisplayObject_SCM_B_QUERYPRICE dispaly = new DisplayObject_SCM_B_QUERYPRICE();
            dispaly.ID = id;
            dispaly = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Get(dispaly);
            List<DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "GYSNAME", "GYSACCOUNT", "CREATE_TIMES", "PRODUCT_NAME", "QUOTED_PRICE_MSEHT", "SUPPLY_AMOUNT_MSEHT", "HOSPITAL_NAME", "PRICE_MSEHT" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            Dictionary<int, int[]> dicRange = new Dictionary<int, int[]>();
            dicRange.Add(0, new int[] { 0, 1, 2 });
            dicRange.Add(1, new int[] { 3, 4, 5 });
            string arrStr = "  药品名称：" + (string.IsNullOrEmpty(dispaly.TXZ01) ? "" : dispaly.TXZ01.Trim()) + "    物料号：" + (string.IsNullOrEmpty(dispaly.MATNR) ? "" : dispaly.MATNR.Trim()) +
                "   规格：" + (string.IsNullOrEmpty(dispaly.SPEC) ? "" : dispaly.SPEC.Trim()) + "   计量单位：" + (string.IsNullOrEmpty(dispaly.MSEHT) ? "" : dispaly.MSEHT.Trim()) + "   采购数量：" + (dispaly.AMOUNT == null ? "" : dispaly.AMOUNT.ToString()) +
                "   询价时间：" + (dispaly.QUERY_DATE == null ? "" : dispaly.QUERY_DATE.ToString("yyyy-MM-dd"));
            int nPathNum = 3;//Request.UrlReferrer.Segments.Length - 2;
            return Content(NPOIWriteExcel.WriteExcelU<DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL>(NPOIWriteExcel.GenerateRowAndWriteDataU, queryData, arrStr, dic, dicRange, 2, @"~/up/供应商询价明细.xls", @"up/", nPathNum, "供应商询价明细"));

        }

        //市场价格报表跳转
        public ActionResult BazaarQuotedDetail(string id)
        {
            GetBagID(id);
            return View();
        }

        //市场价格报表详情
        public JsonResult GetBazaarQuotedDetail(string id, int page, int rows, string order, string sort)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            OrderByParameter orders = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE cause = new CauseObject_V_SCM_B_QUOTEDPRICE();
            cause.MID = id;

            //string strSql = "";
            //strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            //if (!string.IsNullOrEmpty(strSql))
            //{
            //    cause.SetCustomCondition(strSql);
            //}

            var itemDisplay = BizLogicObject_V_SCM_B_QUOTEDPRICE.Proxy.Query_U(cause, pageIng, orders);

            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = itemDisplay
            });
        }

        //市场价格报表导出
        public ActionResult ExportBazaarQuotedDetail(string id, string order, string sort)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE cause = new CauseObject_V_SCM_B_QUOTEDPRICE();
            cause.MID = id.ToString();

            //string strSql = "";
            //strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            //if (!string.IsNullOrEmpty(strSql))
            //{
            //    cause.SetCustomCondition(strSql);
            //}

            var dataSource = BizLogicObject_V_SCM_B_QUOTEDPRICE.Proxy.Query_U(cause, paging, OrderByPara);
            DisplayObject_SCM_B_QUERYPRICE dispaly = new DisplayObject_SCM_B_QUERYPRICE();
            dispaly.ID = id;
            dispaly = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Get(dispaly);
            List<DisplayObject_V_SCM_B_QUOTEDPRICE> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "TXZ01", "SPEC", "PRODUCT_NAME", "GYSNAME", "QUOTED_PRICE_MSEHT", "SUPPLY_AMOUNT_MSEHT", "COMMENTS" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }
            Dictionary<int, int[]> dicRange = new Dictionary<int, int[]>();
            dicRange.Add(0, new int[] { 0, 1 });
            string arrStr = "  药品名称：" + (string.IsNullOrEmpty(dispaly.TXZ01) ? "" : dispaly.TXZ01.Trim()) + "    物料号：" + (string.IsNullOrEmpty(dispaly.MATNR) ? "" : dispaly.MATNR.Trim()) +
                "   规格：" + (string.IsNullOrEmpty(dispaly.SPEC) ? "" : dispaly.SPEC.Trim()) + "   计量单位：" + (string.IsNullOrEmpty(dispaly.MSEHT) ? "" : dispaly.MSEHT.Trim()) + "   采购数量：" + (dispaly.AMOUNT == null ? "" : dispaly.AMOUNT.ToString()) +
                "   询价时间：" + (dispaly.QUERY_DATE == null ? "" : dispaly.QUERY_DATE.ToString("yyyy-MM-dd"));
            int nPathNum = 3;// Request.UrlReferrer.Segments.Length - 2;
            return Content(NPOIWriteExcel.WriteExcelU<DisplayObject_V_SCM_B_QUOTEDPRICE>(NPOIWriteExcel.GenerateRowAndWriteDataU, queryData, arrStr, dic, dicRange, 2, @"~/up/市场价格报表.xls", @"up/", nPathNum, "市场价格报表"));

        }

        //医院价格报表跳转
        public ActionResult HospitaQuotedDetail(string id)
        {
            GetBagID(id);
            return View();
        }

        //医院价格报表详情
        public JsonResult GetHospitaQuotedDetail(string id, int page, int rows, string order, string sort)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            OrderByParameter orders = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause = new CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL();
            cause.MID = id;
            cause.SetCustomCondition(" AND (V_SCM_B_QUOTEDPRICE_DETAIL.ID IS NOT NULL OR V_SCM_B_QUOTEDPRICE_DETAIL.STATE = 2)");
            //string strSql = "";
            //strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            //if (!string.IsNullOrEmpty(strSql))
            //{
            //    cause.SetCustomCondition(strSql);
            //}

            var itemDisplay = BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL.Proxy.Query_U(cause,false, pageIng, orders);

            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = itemDisplay
            });
        }

        //医院价格报表导出
        public ActionResult ExportHospitaQuotedDetail(string id, string order, string sort)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = GetOrder(order, sort);

            CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause = new CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL();
            cause.MID = id.ToString();
            cause.SetCustomCondition(" AND (V_SCM_B_QUOTEDPRICE_DETAIL.ID IS NOT NULL OR V_SCM_B_QUOTEDPRICE_DETAIL.STATE = 2)");
            //string strSql = "";
            //strSql = GetQuotedDetailWhere(GYSNAME, PRODUCT_NAME, HOSPITAL_NAME, strSql);

            //if (!string.IsNullOrEmpty(strSql))
            //{
            //    cause.SetCustomCondition(strSql);
            //}

            var dataSource = BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL.Proxy.Query_U(cause,false, paging, OrderByPara);
            DisplayObject_SCM_B_QUERYPRICE dispaly = new DisplayObject_SCM_B_QUERYPRICE();
            dispaly.ID = id;
            dispaly = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Get(dispaly);
            List<DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "HOSPITAL_NAME", "PRODUCT_NAME", "PRICE_MSEHT", "COMMENTS_D" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }
            string arrStr = "  药品名称：" + (string.IsNullOrEmpty(dispaly.TXZ01) ? "" : dispaly.TXZ01.Trim()) + "    物料号：" + (string.IsNullOrEmpty(dispaly.MATNR) ? "" : dispaly.MATNR.Trim()) +
                "   规格：" + (string.IsNullOrEmpty(dispaly.SPEC) ? "" : dispaly.SPEC.Trim()) + "   计量单位：" + (string.IsNullOrEmpty(dispaly.MSEHT) ? "" : dispaly.MSEHT.Trim()) + "   采购数量：" + (dispaly.AMOUNT == null ? "" : dispaly.AMOUNT.ToString()) +
                "   询价时间：" + (dispaly.QUERY_DATE == null ? "" : dispaly.QUERY_DATE.ToString("yyyy-MM-dd"));

            int nPathNum = 3;// Request.UrlReferrer.Segments.Length - 2;
            return Content(NPOIWriteExcel.WriteExcelU<DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL>(NPOIWriteExcel.GenerateRowAndWriteDataU, queryData, arrStr, dic,null, 2, @"~/up/各医院价格报表.xls", @"up/",nPathNum, "各医院价格报表"));

        }

        public ActionResult PriceAdjustDetail(string id)
        {
            GetBagID(id);
            return View();
        }

        private void GetBagID(string id)
        {
            EntityObject_SCM_B_QUERYPRICE entity = new EntityObject_SCM_B_QUERYPRICE();
            entity.ID = id;
            entity = BizLogicObject_SCM_B_QUERYPRICE.Proxy.Get(entity);
            if (entity != null)
            {
                ViewBag.ID = entity.ID;
                ViewBag.ADJUSTPRICE_ID = entity.ADJUSTPRICE_ID == null ? "" : entity.ADJUSTPRICE_ID;
            }
            else
            {
                ViewBag.ID = "";
                ViewBag.ADJUSTPRICE_ID = "";
            }
        }
    }
}
