using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Core;
using Models;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SysDepartmentController : Controller
    {
        //
        // GET: /System/SysDepartment/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取树形列表的数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetAllMetadata(Guid? id)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_COM_DEPART cause = new CauseObject_COM_DEPART();
            var dataSource = BizLogicObject_COM_DEPART.Proxy.Query(cause, paging, OrderByPara);

            var rows = dataSource.Select(s =>
                        new
                        {
                            ID = s.ID.Trim()
                            ,
                            s.NAME
                            ,
                            _parentId = s.PARENT_ID == null ? null : s.PARENT_ID.Trim()
                            ,
                            state = string.Empty
                            ,
                            s.PARENT_ID_NAME,
                            s.PHONE,
                            s.POST_CODE,
                            s.STATE,
                            s.TYPE,
                            s.TYPE_NAME,
                            s.SUMMARY,
                            s.FAX,
                            s.DROP_DATE,
                            s.COMMENTS,
                            s.CODE
                        }
                        ).OrderBy(o => o.ID);
            return Json(new treegrid() { rows = rows.ToList() });
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_COM_DEPART entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                BizLogicObject_COM_DEPART.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_DEPART> deleteDetailEntities = new List<EntityObject_COM_DEPART>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_DEPART entity = new EntityObject_COM_DEPART();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_DEPART.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            //EntityObject_COM_DEPART curObj = new EntityObject_COM_DEPART();
            //curObj.ID = id;
           DisplayObject_COM_DEPART curObj = BizLogicObject_COM_DEPART.Proxy.Query(new CauseObject_COM_DEPART {  ID=id}).FirstOrDefault();
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_DEPART curObj = new EntityObject_COM_DEPART();
            curObj.ID = id;
            curObj = BizLogicObject_COM_DEPART.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_DEPART>(curObj, from);
            var msg = BizLogicObject_COM_DEPART.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


        }
        public ActionResult GetZZData()
        {
            Type t = typeof(Ipedf.Common.组织类型);
            return Json(Enum.GetNames(t).Select(s => new
                 {
                     text = s,
                     value = s == "单位" ? 1 : 2
                 }
                 ));
        }
    }
}
