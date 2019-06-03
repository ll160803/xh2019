using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Models;

namespace Ipedf.App.Areas.XJ.Controllers
{
    public class SCM_B_PRICEADJUSTController : BaseController
    {
        //
        // GET: /XJ/SCM_B_PRICEADJUST/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexAdit()
        {
            return View();
        }

        public ActionResult AdminIndex()
        {
            return View();
        }
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string STATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_SCM_B_PRICEADJUST cause = new CauseObject_SCM_B_PRICEADJUST();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and SCM_B_PRICEADJUST.TXZ01 like '%" + Name.ToUpper() + "%' ");
                //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }



            cause.GYSACCOUNT = GetCurrentID();


            if (!string.IsNullOrEmpty(STATE))
            {
                var st = decimal.Parse(STATE);
                if (st >= 0)
                {
                    cause.STATE = st;
                }
            }
            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }

            var pageList = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        public JsonResult GetDataAdit(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string GysName, string GysAccount,string IsQueryPrice)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_SCM_B_PRICEADJUST cause = new CauseObject_SCM_B_PRICEADJUST();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and SCM_B_PRICEADJUST.TXZ01 like '%" + Name.ToUpper() + "%' ");
                //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }

            if (!string.IsNullOrEmpty(GysName))
            {
                cause.GYSNAME = "%" + GysName + "%";
            }

            if (!string.IsNullOrEmpty(GysAccount))
            {
                cause.GYSACCOUNT = "%" + GysAccount + "%";
            }

            if (!string.IsNullOrEmpty(IsQueryPrice))
            {
                if (IsQueryPrice == "1")
                {
                    sb.Append(" and EXISTS(SELECT ID FROM SCM_B_QUERYPRICE WHERE ADJUSTPRICE_ID = SCM_B_PRICEADJUST.ID) ");
                }
                else
                {
                    sb.Append(" and NOT EXISTS(SELECT ID FROM SCM_B_QUERYPRICE WHERE ADJUSTPRICE_ID = SCM_B_PRICEADJUST.ID) ");
                }
            }

            cause.STATE = 2;
            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }

            var pageList = BizLogicObject_SCM_B_PRICEADJUST.Proxy.QueryPost(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        public JsonResult GetAdminData(Guid? id, int page, int rows, string order, string sort, string Name, string Code, string STATE)
        {
            var pageIng = new PagingParamter
            {
                PageIndex = page - 1,
                PageSize = rows
            };
            CauseObject_SCM_B_PRICEADJUST cause = new CauseObject_SCM_B_PRICEADJUST();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" and SCM_B_PRICEADJUST.TXZ01 like '%" + Name.ToUpper() + "%' ");
                //  cause.TXZ01 = "%" + Name + "%";
            }
            if (!string.IsNullOrEmpty(Code))
            {
                cause.MATNR = "%" + Code + "%";
            }





            cause.STATE = 2;

            if (sb.ToString() != "")
            {
                cause.SetCustomCondition(sb.ToString());
            }

            var pageList = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new
            {
                total = pageIng.TotalRecords,
                rows = pageList
            });
        }

        public ActionResult Create()
        {
            ViewBag.ID = Guid.NewGuid();
            var en = new DisplayObject_SCM_B_PRICEADJUST();
            return View(en);
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_B_PRICEADJUST entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.STATE = 1;
                entity.CREATE_DATE = DateTime.Now;
                entity.GYSACCOUNT = GetCurrentID();
                entity.GYSNAME = GetCurrentPerson();
                BizLogicObject_SCM_B_PRICEADJUST.Proxy.Save(entity);
                return Json("S:创建成功", "text/html");
            }
            return Json("F:创建失败，请核对输入的数据的格式", "text/html");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_B_PRICEADJUST> deleteDetailEntities = new List<EntityObject_SCM_B_PRICEADJUST>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_B_PRICEADJUST entity = new EntityObject_SCM_B_PRICEADJUST();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_SCM_B_PRICEADJUST.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (msg.Succeed)
            {
                return Json("OK", "text/html");
            }
            else
            {
                return Json(msg.Message, "text/html");
            }
        }

        [HttpPost]
        public JsonResult QueryPriceAdjust(string id)
        {
            EntityObject_SCM_B_PRICEADJUST curObj = new EntityObject_SCM_B_PRICEADJUST();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Get(curObj);
            return Json(curObj);
        }

        public ActionResult Edit(string id)
        {
            EntityObject_SCM_B_PRICEADJUST curObj = new EntityObject_SCM_B_PRICEADJUST();
            curObj.ID = id;
            ViewBag.ID = id;
            curObj = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_B_PRICEADJUST curObj = new EntityObject_SCM_B_PRICEADJUST();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_SCM_B_PRICEADJUST>(curObj, from);
            var msg = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功", "text/html");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式", "text/html");
            }


        }
        public ActionResult UpdateState(string id, string state)
        {
            EntityObject_SCM_B_PRICEADJUST curObj = new EntityObject_SCM_B_PRICEADJUST();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Get(curObj);
            curObj.STATE = decimal.Parse(state);
            curObj.SetUpdate("STATE");
            var msg = BizLogicObject_SCM_B_PRICEADJUST.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("OK", "text/html");
            }
            else
            {

                return Json("更改状态失败！", "text/xml");
            }
        }


        //新增询价信息
        [HttpPost]
        public JsonResult CreateQueryPrice(string ids)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (!string.IsNullOrEmpty(ids))
            {
                string[] arrID = ids.Split(',');
                CauseObject_SCM_B_PRICEADJUST cause = new CauseObject_SCM_B_PRICEADJUST();
                foreach (string id in arrID)
                {
                    cause.SetINValue("ID", id);
                }
                DisplayObject_SCM_B_PRICEADJUST[] disItem = BizLogicObject_SCM_B_PRICEADJUST.Proxy.QueryPost(cause);
                List<DisplayObject_SCM_B_QUERYPRICE_E> resultDisplay = new List<DisplayObject_SCM_B_QUERYPRICE_E>();
                if (disItem.Length >0)
                {
                    List<EntityObject_SCM_B_QUERYPRICE_U> list = new List<EntityObject_SCM_B_QUERYPRICE_U>();
                    foreach (DisplayObject_SCM_B_PRICEADJUST display in disItem)
                    {
                        if (display.IS_QUERYPRICE == 0)
                        {
                            EntityObject_SCM_B_QUERYPRICE_U obj = new EntityObject_SCM_B_QUERYPRICE_U();
                            obj.MATNR = display.MATNR;//物料编码
                            obj.MATNR_ID = display.MATNR_ID;//物料ID
                            obj.MSEHT = display.MSEHT;//物料单位
                            obj.TXZ01 = display.TXZ01;//物料描述
                            obj.SPEC = display.SPEC;//规格
                            obj.QUERY_DATE = DateTime.Now;
                            obj.ADJUSTPRICE_ID = display.ID;
                            
                            list.Add(obj);
                        }
                    }

                    if (list.Count > 0)
                    {

                        msg = BizLogicObject_SCM_B_QUERYPRICE.Proxy.UpdatePost(list, false, resultDisplay);
                        if (resultDisplay.Count > 0)
                        {
                            msg.Succeed = true;
                            msg.Message = resultDisplay[0].ID;
                        }
                    }
                    else
                    {
                        msg.Succeed = false;
                        msg.Message = "未选择有效的调价信息!";
                    }
                }
                else
                {
                    msg.Succeed = false;
                    msg.Message = "未选择有效的调价信息!";
                }
            }
            else
            {
                msg.Succeed = false;
                msg.Message = "未选择调价信息!";
            }

            return Json(new
            {
                Success = msg.Succeed == true ? "1" : "0",
                Message = msg.Message
            });

        }
    }
}
