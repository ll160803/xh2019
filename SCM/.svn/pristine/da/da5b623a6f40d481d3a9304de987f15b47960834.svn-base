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
    public class FORMController : Controller
    {
        //
        // GET: /System/FORM/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_COM_FORM entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.AS_MENU = 1;
                BizLogicObject_COM_FORM.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_FORM> deleteDetailEntities = new List<EntityObject_COM_FORM>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_FORM entity = new EntityObject_COM_FORM();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_FORM.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_COM_FORM curObj = new EntityObject_COM_FORM();
            curObj.ID = id;
            curObj = BizLogicObject_COM_FORM.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_FORM curObj = new EntityObject_COM_FORM();
            curObj.ID = id;
            curObj = BizLogicObject_COM_FORM.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_FORM>(curObj, from);
            var msg = BizLogicObject_COM_FORM.Proxy.Update(curObj);
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
            CauseObject_COM_FORM cause = new CauseObject_COM_FORM();
            var dataSource = BizLogicObject_COM_FORM.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_FORM> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        /// <summary>
        /// 支持下拉框
        /// </summary>
        /// <returns></returns>
        public JsonResult GetAppDataForCombobox()
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "DISPLAY_INDEX";
            CauseObject_COM_FORM cause = new CauseObject_COM_FORM();
            var dataSource = BizLogicObject_COM_FORM.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_FORM> queryData = dataSource.ToList();

            return Json(
                queryData.Select(s => new
                {
                    text = s.NAME,
                    value = s.ID

                })
                );

        }
        /// <summary>
        /// 通过角色ID获取该角色所有菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetFormDataByRoleID(string id)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_COM_FORM cause = new CauseObject_COM_FORM();
            var dataSource = BizLogicObject_COM_FORM.Proxy.Query(cause, paging, OrderByPara);

            int total = paging.TotalRecords;

            var role_ID = id.PadRight(36);
            CauseObject_COM_ROLE_M_FORM causeRU = new CauseObject_COM_ROLE_M_FORM
            {
                ROLE_ID = role_ID
            };
            var dataRoleSource = BizLogicObject_COM_ROLE_M_FORM.Proxy.Query(causeRU, paging, OrderByPara);
            return Json(new datagrid
            {

                total = total,
                rows = dataSource.Select(s => new
                {
                    s.ID,
                    s.NAME,
                    s.AS_MENU_NAME,
                    IsCheck = dataRoleSource.Where(p => p.ROLE_ID == role_ID && p.FORM_ID == s.ID).Count() > 0 ? 1 : 0

                })
            }

                );


        }
        /// <summary>
        /// 保存角色菜单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="formIds"></param>
        /// <returns></returns>
        public JsonResult SaveRoleForm(string id, string formIds)
        {
            string[] form_IDs = formIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var role_Id = id.PadRight(36);
            CauseObject_COM_ROLE_M_FORM cause = new CauseObject_COM_ROLE_M_FORM
            {
                ROLE_ID = role_Id
            };
            var msg_D = BizLogicObject_COM_ROLE_M_FORM.Proxy.Delete(cause);//先删除此用户之前所有记录
            if (msg_D.Succeed)
            {
                if (form_IDs.Length > 0)
                {
                    List<EntityObject_COM_ROLE_M_FORM> users = new List<EntityObject_COM_ROLE_M_FORM>();
                    foreach (var r_id in form_IDs)
                    {
                        users.Add(new EntityObject_COM_ROLE_M_FORM
                        {
                            FORM_ID = r_id,
                            ROLE_ID = role_Id
                        });
                    }
                    var msg = BizLogicObject_COM_ROLE_M_FORM.Proxy.BatchSave(users.ToArray());//保存
                    if (msg.Succeed)
                    {
                        return Json("OK");
                    }
                    else
                    {
                        return Json(msg.Message);
                    }
                }
            }
            else
            {
                return Json(msg_D.Message);
            }
            return Json("OK");
        }
    }
}
