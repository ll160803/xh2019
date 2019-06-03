using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Core;

namespace Ipedf.App.Areas.System.Controllers
{
    public class FunctionsController : Controller
    {
        //
        // GET: /System/Functions/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_COM_FUNCTION entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                BizLogicObject_COM_FUNCTION.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_FUNCTION> deleteDetailEntities = new List<EntityObject_COM_FUNCTION>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_FUNCTION entity = new EntityObject_COM_FUNCTION();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_FUNCTION.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_COM_FUNCTION curObj = new EntityObject_COM_FUNCTION();
            curObj.ID = id;
            curObj = BizLogicObject_COM_FUNCTION.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_FUNCTION curObj = new EntityObject_COM_FUNCTION();
            curObj.ID = id;
            curObj = BizLogicObject_COM_FUNCTION.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_FUNCTION>(curObj, from);
            var msg = BizLogicObject_COM_FUNCTION.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


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
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string search)
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
            CauseObject_COM_FUNCTION cause = new CauseObject_COM_FUNCTION();
            var dataSource = BizLogicObject_COM_FUNCTION.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_FUNCTION> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        public JsonResult GetAppDataForCombobox()
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "DISPLAY_INDEX";
            CauseObject_COM_FUNCTION cause = new CauseObject_COM_FUNCTION();
            var dataSource = BizLogicObject_COM_FUNCTION.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_FUNCTION> queryData = dataSource.ToList();

            return Json(
                queryData.Select(s => new
                {
                    text = s.NAME,
                    value = s.ID

                })
                );

        }
    }
}
