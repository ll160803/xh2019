using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Models;
using System.Text;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_B_SALERETURNController : BaseController
    {
        //
        // GET: /System/SCM_B_SALERETURN/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GysIndex()
        {
            return View();
        }
        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult CWIndex()
        {
            return View();
        }
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string GYSAccount, string CHARGE, string GYSNAME, string STATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_V_SCM_D_SALERETURN cause = new CauseObject_V_SCM_D_SALERETURN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and V_SCM_D_SALERETURN.TXZ01||upper(V_SCM_D_SALERETURN.SPELL_CODE) like '%" + Name.ToUpper() + "%' ");
              //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }
            if (!string.IsNullOrEmpty(CHARGE))
            {
                //cause.CHARGE = "%" + CHARGE + "%";
                sb.Append(" AND V_SCM_D_SALERETURN.CHARG LIKE '%" + CHARGE + "%' ");
            }
            if (!string.IsNullOrEmpty(GYSNAME))
            {
                cause.GYSNAME = "%" + GYSNAME + "%";
            }
            if (!string.IsNullOrEmpty(GYSAccount))
            {
                cause.GYSACCOUNT = GYSAccount;
            }
           
            if (!string.IsNullOrEmpty(STATE))
            {
                var st = decimal.Parse(STATE);
                if (st > 0)
                {
                    cause.STATE = st;
                }
            }
            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }
            cause.DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            var pageList = BizLogicObject_V_SCM_D_SALERETURN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }
        public JsonResult GetAdminData(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string GYSAccount, string CHARGE, string GYSNAME, string STATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_V_SCM_D_SALERETURN cause = new CauseObject_V_SCM_D_SALERETURN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and V_SCM_D_SALERETURN.TXZ01||upper(V_SCM_D_SALERETURN.SPELL_CODE) like '%" + Name.ToUpper() + "%' ");
                //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }
            if (!string.IsNullOrEmpty(CHARGE))
            {
                cause.CHARG = "%" + CHARGE + "%";
                // cause.SetCustomCondition(" AND V_SCM_D_SALERETURN.CHARG LIKE '%" + CHARGE + "%' ");
            }
            if (!string.IsNullOrEmpty(GYSNAME))
            {
                cause.GYSNAME = "%" + GYSNAME + "%";
            }
            if (!string.IsNullOrEmpty(GYSAccount))
            {
                cause.GYSACCOUNT = GYSAccount;
            }
            if (!string.IsNullOrEmpty(STATE))
            {
                var st = decimal.Parse(STATE);
                if (st > 0)
                {
                    cause.STATE = st;
                }
            }
            sb.Append(" AND V_SCM_D_SALERETURN.STATE>1 ");
            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }
            var pageList = BizLogicObject_V_SCM_D_SALERETURN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "desc" ? true : false, OrderBy = sort == "" ? "STATE" : sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }
        public JsonResult GetDataWithGys(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string CHARGE, string STATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_V_SCM_D_SALERETURN cause = new CauseObject_V_SCM_D_SALERETURN();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and V_SCM_D_SALERETURN.TXZ01||upper(V_SCM_D_SALERETURN.SPELL_CODE) like '%" + Name.ToUpper() + "%' ");
                //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }
            if (!string.IsNullOrEmpty(CHARGE))
            {
                cause.CHARG = "%" + CHARGE + "%";
                // cause.SetCustomCondition(" AND V_SCM_D_SALERETURN.CHARG LIKE '%" + CHARGE + "%' ");
            }
            if (!string.IsNullOrEmpty(STATE))
            {
                var st = decimal.Parse(STATE);
                if (st > 0)
                {
                    cause.STATE = st;
                }
            }
            sb.Append(" AND V_SCM_D_SALERETURN.STATE>2 ");
            cause.GYSACCOUNT = GetCurrentID();
            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }
            //  cause.GYSACCOUNT = GetCurrentID();
            var pageList = BizLogicObject_V_SCM_D_SALERETURN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        public ActionResult Create()
        {
            ViewBag.FName = "";
            ViewBag.FID = "";
            EntityObject_SCM_B_SALERETURN entity = new EntityObject_SCM_B_SALERETURN
            {
                ID = Guid.NewGuid().ToString()
            };
            return View(entity);
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_B_SALERETURN entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.STATE = 1;//未提交
                entity.CHARG = entity.CHARG.Trim();//去除空格
                //var list = BizLogicObject_V_SCM_D_SUPPLYPLAN_MATER.Proxy.Query(new CauseObject_V_SCM_D_SUPPLYPLAN_MATER
                //{
                //    CHARG = entity.CHARG,
                //    MATER_ID = entity.MATNR_ID
                //});
                //if (list.Count() > 0)
                //{
                entity.DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;//存储药房信息
                var msg = BizLogicObject_SCM_B_SALERETURN.Proxy.Save(entity);
                if (msg.Succeed)
                {
                    return Json("S:创建成功", "text/html");
                }
                else
                    return Json("F:" + msg.Message, "text/html");
                //}
                //else
                //{
                //    return Json("F:创建失败,此批次的药品不存在！！！", "text/html");
                //}
            }
            return Json("F:创建失败，请核对输入的数据的格式", "text/html");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_B_SALERETURN> deleteDetailEntities = new List<EntityObject_SCM_B_SALERETURN>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_B_SALERETURN entity = new EntityObject_SCM_B_SALERETURN();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_SCM_B_SALERETURN.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (msg.Succeed)
            {
                return Json("OK", "text/html");
            }
            else
            {
                return Json(msg.Message, "text/html");
            }
        }

        public ActionResult Edit(string id)
        {
            EntityObject_SCM_B_SALERETURN curObj = new EntityObject_SCM_B_SALERETURN();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SALERETURN.Proxy.Get(curObj);

            var mater = BizLogicObject_SCM_D_MATER.Proxy.Get(new EntityObject_SCM_D_MATER { ID = curObj.MATNR_ID });

            ViewBag.MaterName = mater.TXZ01;

            return View(curObj);
        }
        public ActionResult CreateCopy(string id)
        {//可以优化数据的部分
            EntityObject_SCM_B_SALERETURN curObj = new EntityObject_SCM_B_SALERETURN();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SALERETURN.Proxy.Get(curObj);
            var en = new EntityObject_SCM_B_SALERETURN { AMOUNT = 0, CHARG = curObj.CHARG, DEPT_ID = curObj.DEPT_ID, MATNR_ID = curObj.MATNR_ID, STATE = 1, COMMENTS=curObj.COMMENTS };
            BizLogicObject_SCM_B_SALERETURN.Proxy.Save(en); 

            var mater = BizLogicObject_SCM_D_MATER.Proxy.Get(new EntityObject_SCM_D_MATER { ID = curObj.MATNR_ID });

            ViewBag.MaterName = mater.TXZ01;

            return View("Edit",en);
        }
        
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_B_SALERETURN curObj = new EntityObject_SCM_B_SALERETURN();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SALERETURN.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_SCM_B_SALERETURN>(curObj, from);
            curObj.CHARG = curObj.CHARG.Trim();//去除空格

            //var list = BizLogicObject_V_SCM_D_SUPPLYPLAN_MATER.Proxy.Query(new CauseObject_V_SCM_D_SUPPLYPLAN_MATER
            //   {
            //       CHARG = curObj.CHARG,
            //       MATER_ID = curObj.MATNR_ID
            //   });
            //if (list.Count() > 0)
            //{
            var msg = BizLogicObject_SCM_B_SALERETURN.Proxy.Update(curObj);
            if (msg.Succeed)
            {

                return Json("S:保存成功", "text/html");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式", "text/html");
            }
            //}
            //else
            //{
            //    return Json("F:保存失败,此批次的药品不存在！！！", "text/html");
            //}


        }

        public JsonResult UpdateState(string id, string Sid, int state)
        {
            EntityObject_SCM_B_SALERETURN curObj = new EntityObject_SCM_B_SALERETURN();
            curObj.ID = Sid;
            curObj = BizLogicObject_SCM_B_SALERETURN.Proxy.Get(curObj);
            curObj.STATE = state;
            // curObj.SetUpdate("STATE");
            var msg = BizLogicObject_SCM_B_SALERETURN.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("OK", "application/json");
            }
            else
            {
                return Json("Fail", "application/json");
            }
        }
    }
}
