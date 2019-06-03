using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using Models;

namespace Ipedf.App.Areas.XJ.Controllers
{
    public class SCM_B_QUOTEDPRICEController : BaseController
    {
        //
        // GET: /XJ/SCM_B_QUOTEDPRICE/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 根据询价信息ID，获取某个供应商的报价请求
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetQuotedPriceByQueryIndex(string id)
        {
            var quotedList = BizLogicObject_SCM_B_QUOTEDPRICE.Proxy.Query(new CauseObject_SCM_B_QUOTEDPRICE { BASE_ID = id, GYSACCOUNT = GetCurrentID() }).OrderBy(p => p.DISPLAY_INDEX).ToList();
            if (quotedList.Count > 0)//供应商已经报价的情况下 
            {
                foreach (var item in quotedList)
                {
                    var hospitals = BizLogicObject_SCM_B_QUOTEDPRICE_D.Proxy.Query(new CauseObject_SCM_B_QUOTEDPRICE_D { BASE_ID = item.ID });
                    if (hospitals != null)
                    {
                        item.Hospitals = hospitals.ToList();
                    }

                }
                return Json(new { QuotedList = quotedList });
            }
            else //供应商没有做报价的情况下，获取默认生产厂家
            {
                DisplayObject_SCM_B_QUOTEDPRICE entity = new DisplayObject_SCM_B_QUOTEDPRICE();
                entity.DISPLAY_INDEX = 1;
                entity.COMMENTS = "";

                var productList = BizLogicObject_SCM_B_QUERYPRICE_PRODUCT.Proxy.Query(new CauseObject_SCM_B_QUERYPRICE_PRODUCT { BASE_ID = id });
                if (productList.Count() > 0)
                {
                    entity.PRODUCT_NAME = productList.FirstOrDefault().PRODUCT_NAME;
                }
                List<DisplayObject_SCM_B_QUOTEDPRICE_D> list_hispital = new List<DisplayObject_SCM_B_QUOTEDPRICE_D> { new DisplayObject_SCM_B_QUOTEDPRICE_D { DISPLAY_INDEX = 1, COMMENTS_D = "", HOSPITAL_NAME = "", PRICE = 0 } };
                entity.Hospitals = list_hispital;
                return Json(new { QuotedList = new List<DisplayObject_SCM_B_QUOTEDPRICE> { entity } });
            }
            //  return Json(new { QuotedList = new List<DisplayObject_SCM_B_QUOTEDPRICE>() });
        }

        public JsonResult SAVE(string ID, FormCollection form, int state = 1)
        {
            var jsonData = form["data"];
            List<DisplayObject_SCM_B_QUOTEDPRICE> list = new List<DisplayObject_SCM_B_QUOTEDPRICE>();
            list = JsonConvert.DeserializeObject<List<DisplayObject_SCM_B_QUOTEDPRICE>>(jsonData);
            var Msg = BizLogicObject_SCM_B_QUOTEDPRICE.Proxy.SaveQUOTEDPRICE(ID, list, state, GetCurrentID(), GetCurrentPerson());
            return Json(new
            {
                Success = Msg.Succeed == true ? "1" : "0",
                Message = Msg.Message
            });

        }
       
        public JsonResult DeleteByQueryID(string ID)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                var Msg = BizLogicObject_SCM_B_QUOTEDPRICE.Proxy.DeleteQUOTEDPRICE(ID, GetCurrentID(), GetCurrentPerson());
                return Json(new
                {
                    Success = Msg.Succeed == true ? "1" : "0",
                    Message = Msg.Message
                });
            }
            else
            {
                return Json(new
                {
                    Success =  "0",
                    Message = "不存在的询价信息！"
                });
            }
        }
    }
}
