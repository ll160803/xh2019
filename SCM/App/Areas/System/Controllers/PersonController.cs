using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;

namespace Ipedf.App.Areas.System.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /System/Person/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonIndex()
        {
            return View();
        }
        public ActionResult Create_Person()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create_Person(EntityObject_COM_USER entity, FormCollection form)
        {
            if (entity != null && ModelState.IsValid)
            {
                var userType = form["UserType"].ToString();

                if (string.IsNullOrEmpty(userType))
                {
                    userType = "0"; //0 管理员  1是PDA  2 是供应商
                }
                entity.PASSWORD = "wWoCilomkOPpJ3+whHkNnA==";//"111"
                var departID = "10001                               ";
                var Role_ID = "";
                switch (userType)
                {
                    case "1":
                        departID = "9678dcc1-bd78-4557-a662-141abad32f0a";
                        Role_ID = "2f52f1f1-650c-4612-9b96-41746c29cc36";
                        break;
                    case "2":
                        departID = "9678dcc1-bd78-4557-a662-141abad32f0a";
                        Role_ID = "2929640e-bedc-4a3d-a1ee-b628fe30d5ee";
                        break;
                    default:
                        departID = "10001                               ";
                        Role_ID = "1                                   ";
                        break;
                }

                entity.DEPART_ID = departID;
                var Msg = BizLogicObject_COM_USER.Proxy.Save(entity);
                if (Msg.Succeed)
                {
                    EntityObject_COM_ROLE_M_USER ROLE = new EntityObject_COM_ROLE_M_USER
                    {
                        ROLE_ID = Role_ID,
                        USER_ID = entity.ID
                    };
                    var _MSG = BizLogicObject_COM_ROLE_M_USER.Proxy.Save(ROLE);
                    if (_MSG.Succeed)
                    {
                        return Json("S:创建成功");
                    }
                }
                else
                {
                    return Json("F:创建失败，请核对输入的数据的格式");
                }

                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }

        public ActionResult Edit_Person(string id)
        {
            EntityObject_COM_USER curObj = new EntityObject_COM_USER();
            curObj.ID = id;
            curObj = BizLogicObject_COM_USER.Proxy.Get(curObj);

            EntityObject_COM_ROLE_M_USER curRole = new EntityObject_COM_ROLE_M_USER();
            CauseObject_COM_ROLE_M_USER cause = new CauseObject_COM_ROLE_M_USER { USER_ID = id };
            var list = BizLogicObject_COM_ROLE_M_USER.Proxy.Query(cause);
            var UserType = "0";
            if (list.Length > 0)
            {
                var RoleID = list[0].ROLE_ID;
                if (RoleID == "2f52f1f1-650c-4612-9b96-41746c29cc36")
                {
                    UserType = "1";//PDA
                }
                if (RoleID == "2929640e-bedc-4a3d-a1ee-b628fe30d5ee")
                {
                    UserType = "2";//供应商
                }
            }
            ViewBag.UserType = UserType;
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit_Person(string id, FormCollection from)
        {
            EntityObject_COM_USER curObj = new EntityObject_COM_USER();
            curObj.ID = id;
            curObj = BizLogicObject_COM_USER.Proxy.Get(curObj);
            var userType = from["UserType"].ToString();

            if (string.IsNullOrEmpty(userType))
            {
                userType = "0"; //0 管理员  1是PDA  2 是供应商
            }
            TryUpdateModel<EntityObject_COM_USER>(curObj, from);

            var departID = "10001                               ";
            var Role_ID = "";
            switch (userType)
            {
                case "1":
                    departID = "9678dcc1-bd78-4557-a662-141abad32f0a";
                    Role_ID = "2f52f1f1-650c-4612-9b96-41746c29cc36";
                    break;
                case "2":
                    departID = "9678dcc1-bd78-4557-a662-141abad32f0a";
                    Role_ID = "2929640e-bedc-4a3d-a1ee-b628fe30d5ee";
                    break;
                default:
                    departID = "10001                               ";
                    Role_ID = "1                                   ";
                    break;
            }

            curObj.DEPART_ID = departID;
            var msg = BizLogicObject_COM_USER.Proxy.Update(curObj);

            if (msg.Succeed)
            {
                CauseObject_COM_ROLE_M_USER causeROLE = new CauseObject_COM_ROLE_M_USER
                {
                    USER_ID = id
                };
                var arr_Entity_Role = BizLogicObject_COM_ROLE_M_USER.Proxy.Query(causeROLE);
                var entity = arr_Entity_Role.FirstOrDefault();
                entity.ROLE_ID = Role_ID;
                var _MSG = BizLogicObject_COM_ROLE_M_USER.Proxy.Update(entity);
                if (_MSG.Succeed)
                {
                    return Json("S:保存成功");
                }

            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }

            return Json("F:保存失败，请核对输入的数据的格式");
        }
        /// <summary>
        /// 获取树形列表的数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetAllMetadata()
        {
            #region 先获取部门信息
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = int.MaxValue;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_COM_DEPART cause = new CauseObject_COM_DEPART();
            var dataDepartmentSource = BizLogicObject_COM_DEPART.Proxy.Query(cause, paging, OrderByPara);
            #endregion
            CauseObject_COM_USER cause_p = new CauseObject_COM_USER();
            var dataPersonSource = BizLogicObject_COM_USER.Proxy.Query(cause_p, paging, OrderByPara);

            var rows = dataPersonSource.Select(s => new
                  {
                      ID = s.ID,
                      NAME = s.NAME,
                      DEPART_ID = s.DEPART_ID,
                      DEPART_ID_NAME = s.DEPART_ID_NAME,
                      ACCOUNT = s.ACCOUNT,
                      CODE = s.CODE,
                      _parentId = s.DEPART_ID == null ? null : s.DEPART_ID.Trim(),
                      PASSWORD = s.PASSWORD

                  }).Union(
              dataDepartmentSource.Select(s => new
                  {
                      ID = s.ID.Trim(),
                      NAME = s.NAME,
                      DEPART_ID = s.ID,
                      DEPART_ID_NAME = s.NAME,
                      ACCOUNT = "",
                      CODE = s.CODE,
                      _parentId = s.PARENT_ID == null ? null : s.PARENT_ID.Trim(),
                      PASSWORD = ""
                  }));


            var json = Json(new treegrid() { rows = rows });
            return json;
        }


        [HttpPost]
        public ActionResult GetData(Guid? id, int page, int rows, string order, string sort, string search)
        {
            CauseObject_V_GETPERSON cause_p = new CauseObject_V_GETPERSON();
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page-1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;

            cause_p.SetINValue("DEPARTMENTID", "9678dcc1-bd78-4557-a662-141abad32f0a");
            cause_p.SetINValue("DEPARTMENTID", "10001                               ");
            var dataPersonSource = BizLogicObject_V_GETPERSON.Proxy.Query(cause_p, paging, OrderByPara).ToList();
            var total = paging.TotalRecords;

            return Json(new datagrid
            {
                total = total,
                rows = dataPersonSource
            });


        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_COM_USER entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.PASSWORD = "wWoCilomkOPpJ3+whHkNnA==";//"scm@0610"
                BizLogicObject_COM_USER.Proxy.Save(entity);
                return Json("S:创建成功");
            }
            return Json("F:创建失败，请核对输入的数据的格式");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_COM_USER> deleteDetailEntities = new List<EntityObject_COM_USER>();
            foreach (var item in deleteId)
            {
                EntityObject_COM_USER entity = new EntityObject_COM_USER();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_COM_USER.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (msg.Succeed)
            {
                return Json("OK");
            }
            else
            {
                return Json(msg.Message);
            }
        }

        [HttpPost]
        public ActionResult ResetPassword(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();
            CauseObject_COM_USER p = new CauseObject_COM_USER();
            foreach (var item in deleteId)
            {
                p.SetINValue("ID",item);
            }
            DisplayObject_COM_USER[] users = BizLogicObject_COM_USER.Proxy.Query(p);
            foreach (DisplayObject_COM_USER user in users)
            {
                user.PASSWORD = SystemLogic.Proxy.Encrypt("scm@0610");
                user.SetUpdate("PASSWORD");
            }
            var msg = BizLogicObject_COM_USER.Proxy.BatchUpdate(users);
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
            EntityObject_COM_USER curObj = new EntityObject_COM_USER();
            curObj.ID = id;
            curObj = BizLogicObject_COM_USER.Proxy.Get(curObj);

            EntityObject_COM_DEPART curDepartObj = new EntityObject_COM_DEPART();
            curDepartObj.ID = curObj.DEPART_ID;
            ViewBag.DepartmentName = BizLogicObject_COM_DEPART.Proxy.Get(curDepartObj).NAME;
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_COM_USER curObj = new EntityObject_COM_USER();
            curObj.ID = id;
            curObj = BizLogicObject_COM_USER.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_COM_USER>(curObj, from);
            var msg = BizLogicObject_COM_USER.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式");
            }


        }
        public ActionResult SetRole(string id, string Name)
        {
            ViewData["myid"] = id;
            ViewData["myname"] = Name;
            return View();
        }
    }
}
