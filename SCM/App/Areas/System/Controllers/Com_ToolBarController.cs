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
    public class Com_ToolBarController : BaseController
    {
        //
        // GET: /System/Modules/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DisplayObject_COM_TOOLBAR entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                BizLogicObject_COM_TOOLBAR.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_TOOLBAR> deleteDetailEntities = new List<EntityObject_COM_TOOLBAR>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_TOOLBAR entity = new EntityObject_COM_TOOLBAR();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_TOOLBAR.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_COM_TOOLBAR curObj = new EntityObject_COM_TOOLBAR();
            curObj.ID = id;
            curObj = BizLogicObject_COM_TOOLBAR.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_TOOLBAR curObj = new EntityObject_COM_TOOLBAR();
            curObj.ID = id;
            curObj = BizLogicObject_COM_TOOLBAR.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_TOOLBAR>(curObj, from);
            var msg = BizLogicObject_COM_TOOLBAR.Proxy.Update(curObj);
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
            //  CauseObject_COM_TOOLBAR cause = (CauseObject_COM_TOOLBAR)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_COM_TOOLBAR cause = new CauseObject_COM_TOOLBAR();
            var dataSource = BizLogicObject_COM_TOOLBAR.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_TOOLBAR> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
    }
}
