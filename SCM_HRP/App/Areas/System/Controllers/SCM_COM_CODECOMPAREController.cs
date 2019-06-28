using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Models;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_COM_CODECOMPAREController : BaseController
    {
        //
        // GET: /System/SCM_COM_CODECOMPARE/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string Name, string Code)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_V_GETSCM_COM_DRUG cause = new CauseObject_V_GETSCM_COM_DRUG();
            if (!string.IsNullOrEmpty(Name))
            {
                cause.NAME = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.CODE = "%" + Code + "%";
            }
            cause.GYSACCOUNT = GetCurrentID();
            var pageList = BizLogicObject_V_GETSCM_COM_DRUG.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new datagrid
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }
        public JsonResult DoCompare(string ID, string His_ID)
        {
            var entity = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Get(new EntityObject_SCM_COM_CODECOMPARE { ID = ID });
            entity.BASE_ID = His_ID;
            var msg = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Update(entity);
            if (msg.Succeed)
            {
                return Json("OK");
            }
            else
            {
                return Json(msg.Message);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_COM_CODECOMPARE entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.GYSACCOUNT = GetCurrentID();
                BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_COM_CODECOMPARE> deleteDetailEntities = new List<EntityObject_SCM_COM_CODECOMPARE>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_COM_CODECOMPARE entity = new EntityObject_SCM_COM_CODECOMPARE();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_SCM_COM_CODECOMPARE curObj = new EntityObject_SCM_COM_CODECOMPARE();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_COM_CODECOMPARE curObj = new EntityObject_SCM_COM_CODECOMPARE();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_SCM_COM_CODECOMPARE>(curObj, from);
            var msg = BizLogicObject_SCM_COM_CODECOMPARE.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


        }
    }
}
