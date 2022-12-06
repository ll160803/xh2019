﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Web.Entity;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using System.Text;
using Models;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_D_REPORTController : BaseController
    {
        //
        // GET: /System/SCM_D_REPORT/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetData(Guid? id, int page, int rows, string order, string sort, string dtBeginTime, string dtEndtime, string NAME)
        {
            string rolename = GetUserRoleName();
            if (rolename != "总务供应商" && rolename != "总务管理员")
            {
                CauseObject_SCM_D_REPORT cause = new CauseObject_SCM_D_REPORT();
                cause.CREATE_TIME = new DateSpan();

                if (!string.IsNullOrEmpty(dtBeginTime))
                {
                    cause.CREATE_TIME.Begin = DateTime.Parse(dtBeginTime + " 00:00:00");
                }
                if (!string.IsNullOrEmpty(dtEndtime))
                {
                    cause.CREATE_TIME.End = Convert.ToDateTime(dtEndtime + " 23:59:59");
                }
                if (!string.IsNullOrEmpty(NAME) && !string.IsNullOrEmpty(NAME.Trim()))
                {
                    cause.NAME = "%" + NAME.Trim() + "%";
                }

                PagingParamter paging = new PagingParamter();

                paging.PageIndex = page - 1;
                paging.PageSize = rows;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = order == "asc" ? true : false;
                OrderByPara.OrderBy = sort;
                var dataPersonSource = BizLogicObject_SCM_D_REPORT.Proxy.Query(cause, paging, OrderByPara).ToList();
                var total = paging.TotalRecords;

                return Json(new
                {
                    total = total,
                    rows = dataPersonSource.Select(p => new { NAME = p.NAME, CREATE_TIME = p.CREATE_TIME, ID = p.ID })
                });

            }
            else
            {
                return Json(new
                {
                    total = 0,
                    rows = string.Empty
                });
            }
        }
        public ActionResult Create()
        {
            EntityObject_SCM_D_REPORT entity = new EntityObject_SCM_D_REPORT { ID = Guid.NewGuid().ToString() };
            ViewBag.ID = entity.ID;
            return View(entity);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(EntityObject_SCM_D_REPORT entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(entity.COMMENTS))
                {
                    entity.COMMENTS = Server.HtmlEncode(entity.COMMENTS);
                }
                BizLogicObject_SCM_D_REPORT.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_D_REPORT> deleteDetailEntities = new List<EntityObject_SCM_D_REPORT>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_D_REPORT entity = new EntityObject_SCM_D_REPORT();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_SCM_D_REPORT.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_SCM_D_REPORT curObj = new EntityObject_SCM_D_REPORT();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_D_REPORT.Proxy.Get(curObj);
            if (!string.IsNullOrEmpty(curObj.COMMENTS))
            {
                curObj.COMMENTS = Server.HtmlDecode(curObj.COMMENTS);
            }
            ViewBag.ID = id;
            return View(curObj);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_D_REPORT curObj = new EntityObject_SCM_D_REPORT();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_D_REPORT.Proxy.Get(curObj);

            //  TryUpdateModel<EntityObject_SCM_D_REPORT>(curObj, from);
            if (!string.IsNullOrEmpty(from["COMMENTS"]))
            {
                curObj.COMMENTS = Server.HtmlEncode(from["COMMENTS"]);
            }
            if (!string.IsNullOrEmpty(from["NAME"]))
            {
                curObj.NAME = from["NAME"];
            }
            curObj.SetUpdate("COMMENTS", "NAME");
            var msg = BizLogicObject_SCM_D_REPORT.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


        }
        public ActionResult ListIndex()
        {
            return View();
        }
        public ActionResult Detail(string id)
        {
            var en = BizLogicObject_SCM_D_REPORT.Proxy.Get(new EntityObject_SCM_D_REPORT { ID = id });
            if (!string.IsNullOrEmpty(en.COMMENTS))
            {
                en.COMMENTS = Server.HtmlDecode(en.COMMENTS);
            }
            else
            {
                en.COMMENTS = "";
            }
            var fileList = BizLogicObject_COM_FILE.Proxy.Query(new CauseObject_COM_FILE { REF_TAB_ID = id });
            StringBuilder sb = new StringBuilder();
            foreach (var item in fileList)
            {
                sb.Append("<a href='#' onclick='DownFile(\"" + item.SERVER_NAME + "\")'>" + item.CLIENT_NAME + "</a>   ");
            }
            ViewBag.FileStr = sb.ToString();
            return View(en);
        }

        public JsonResult GetCharge(string id)
        {
            var listFiles = BizLogicObject_V_SCM_D_MATER_PIC_COM_FILE.Proxy.Query(new CauseObject_V_SCM_D_MATER_PIC_COM_FILE
            {
                GYSACCOUNT = GetCurrentID(),
                MATNR = id
            });
            if (listFiles.Length > 0)
            {
                return Json(listFiles.Select(p => new { id = p.CHARGE, text = p.CHARGE }));
            }
            return Json(new { id = "", text = "" });
        }

    }
}
