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
    public class SysRoleController : Controller
    {
        //
        // GET: /System/SysRole/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_COM_ROLE entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                BizLogicObject_COM_ROLE.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_ROLE> deleteDetailEntities = new List<EntityObject_COM_ROLE>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_ROLE entity = new EntityObject_COM_ROLE();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_ROLE.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            EntityObject_COM_ROLE curObj = new EntityObject_COM_ROLE();
            curObj.ID = id;
            curObj = BizLogicObject_COM_ROLE.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_ROLE curObj = new EntityObject_COM_ROLE();
            curObj.ID = id;
            curObj = BizLogicObject_COM_ROLE.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_ROLE>(curObj, from);
            var msg = BizLogicObject_COM_ROLE.Proxy.Update(curObj);
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
            CauseObject_COM_ROLE cause = new CauseObject_COM_ROLE();
            var dataSource = BizLogicObject_COM_ROLE.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_COM_ROLE> queryData = dataSource.ToList();
            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        /// <summary>
        /// 通过用户ID获取该用户所有的角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetRoleDataByUserID(string id)
        {
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_COM_ROLE cause = new CauseObject_COM_ROLE();
            var dataSource = BizLogicObject_COM_ROLE.Proxy.Query(cause, paging, OrderByPara);

            int total = paging.TotalRecords;

            CauseObject_COM_ROLE_M_USER causeRU = new CauseObject_COM_ROLE_M_USER
            {
                USER_ID = id
            };
            var dataRoleSource = BizLogicObject_COM_ROLE_M_USER.Proxy.Query(causeRU, paging, OrderByPara);
            return Json(new datagrid
            {

                total = total,
                rows = dataSource.Select(s => new
                {
                    s.ID,
                    s.NAME,
                    s.DISCRIPTION,
                    IsCheck = dataRoleSource.Where(p => p.USER_ID == id && p.ROLE_ID == s.ID).Count() > 0 ? 1 : 0

                })
            }

                );


        }
        /// <summary>
        /// 保存用户的角色设置
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public JsonResult SaveRoleSubject(string id, string roleIds)
        {
            string[] role_IDs = roleIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            CauseObject_COM_ROLE_M_USER cause = new CauseObject_COM_ROLE_M_USER
            {
                USER_ID = id
            };
           var msg_D= BizLogicObject_COM_ROLE_M_USER.Proxy.Delete(cause);//先删除此用户之前所有记录
           if (msg_D.Succeed)
           {
               if (role_IDs.Length > 0)
               {
                   List<EntityObject_COM_ROLE_M_USER> users = new List<EntityObject_COM_ROLE_M_USER>();
                   foreach (var r_id in role_IDs)
                   {
                       users.Add(new EntityObject_COM_ROLE_M_USER
                           {
                               ROLE_ID = r_id,
                               USER_ID = id
                           });
                   }
                   var msg = BizLogicObject_COM_ROLE_M_USER.Proxy.BatchSave(users.ToArray());//保存
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

        /// <summary>
        /// 设置页面权限
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public ActionResult SetFormRole(string id, string Name)
        {
            ViewData["myid"] = id.PadRight(36);
            ViewData["myname"] = Name;
            return View();
        }
    }
}
