using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.Mvc;
using Models;
using Ipedf.App.Codes;
using Ipedf.Web.Entity;
using System.Text;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using ThoughtWorks.QRCode.Codec;

namespace Ipedf.App.Areas.System.Controllers
{
    public class SCM_B_SENDINFOController : BaseController
    {
        //
        // GET: /System/SCM_B_SENDINFO/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="order"></param>
        /// <param name="sort"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="txtName">物料名称</param>
        /// <param name="MATNR">物料号</param>
        /// <param name="IsInfo">是否显示由供应计划生成的送货单</param>
        /// <returns></returns>
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string startDate, string endDate, string txtName, string MATNR, string IsInfo, string WERKS, string txtSEND_DEPART_NAME)
        {
            // RfcNOC rnc = new RfcNOC(); 

            LogHelper.Info("网站搜索数据：账号：" + GetUserID() + ",名字:" + GetCurrentPerson());
            //  var List = rnc.GetPurcharseList(GetUserID(), GetCurrentID(), GetCurrentPerson(), startDate, endDate);
            //  var pageList = List.OrderBy(p => p.EBELN).ThenBy(p => p.EBELP).Skip((page - 1) * rows).Take(rows).ToList();
            CauseObject_SCM_B_SENDINFO cause = new CauseObject_SCM_B_SENDINFO();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(txtName) && !string.IsNullOrEmpty(txtName.Trim()))
            {
                sb.Append(" and SCM_B_SENDINFO.TXZ01 like '%" + txtName.Trim() + "%' ");
            }
            cause.GYSACCOUNT = GetCurrentID();
            //   cause.STATUS = "0";
            if (!string.IsNullOrEmpty(startDate))
            {
                sb.Append(string.Format(" and SCM_B_SENDINFO.CREATE_TIME >=to_date('{0}','yyyy/mm/dd') ", startDate));
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                sb.Append(string.Format(" and SCM_B_SENDINFO.CREATE_TIME<=to_date('{0}','yyyy/mm/dd')", endDate));
            }
            if (!string.IsNullOrEmpty(MATNR))
            {
                cause.MATNR = MATNR;
            }
            if (!string.IsNullOrEmpty(IsInfo))//由供应计划生成的送货单不显示
            {
                sb.Append(string.Format(" and SCM_B_SENDINFO.NAME is  NULL "));
            }
            if (!string.IsNullOrEmpty(txtSEND_DEPART_NAME) && !string.IsNullOrEmpty(txtSEND_DEPART_NAME.Trim()))
            {
                sb.Append(" and SCM_B_SENDINFO.send_depart in ( select code from SCM_D_SENDDEPART where name  like '%" + txtSEND_DEPART_NAME.Trim() + "%') ");
            }
            if (!string.IsNullOrEmpty(WERKS))
            {
                sb.Append(string.Format(" and SCM_B_SENDINFO.WERKS ='" + WERKS + "' "));
            }
            var pageIng = new PagingParamter { PageIndex = page - 1, PageSize = rows };
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                cause.SetCustomCondition(sb.ToString());
            }

            var pageList = BizLogicObject_SCM_B_SENDINFO.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = order == "asc" ? true : false, OrderBy = sort });
            return Json(new datagrid
            {
                total = pageIng.TotalRecords,
                rows = pageList


            });
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EntityObject_SCM_B_SENDINFO entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                entity.GYSACCOUNT = GetCurrentID();
                entity.GYSNAME = GetCurrentPerson();
                if (!string.IsNullOrEmpty(entity.MATNR))
                {
                    var mater = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(new CauseObject_SCM_D_HRPMATER { MATNR = entity.MATNR }).FirstOrDefault();
                    if (mater != null)
                    {
                        entity.MEINS = mater.MEINS;
                        entity.MSEHT = mater.MSEHT;
                        entity.TXZ01 = mater.MAKTX.Replace("\n", "").Trim();
                    }
                }

                BizLogicObject_SCM_B_SENDINFO.Proxy.Save(entity);
                return Json("S:创建成功", "text/html");
            }
            return Json("F:创建失败，请核对输入的数据的格式", "text/html");
        }
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            string returnValue = string.Empty;
            string[] deleteId = collection["query"].Split(',').ToArray();

            List<EntityObject_SCM_B_SENDINFO> deleteDetailEntities = new List<EntityObject_SCM_B_SENDINFO>();
            foreach (var item in deleteId)
            {
                EntityObject_SCM_B_SENDINFO entity = new EntityObject_SCM_B_SENDINFO();
                entity.ID = item;
                deleteDetailEntities.Add(entity);
            }

            var msg = BizLogicObject_SCM_B_SENDINFO.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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
            DisplayObject_SCM_B_SENDINFO curObj = new DisplayObject_SCM_B_SENDINFO();
            // curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SENDINFO.Proxy.Query(new CauseObject_SCM_B_SENDINFO { ID = id }).FirstOrDefault();
            curObj.TXZ01 = curObj.TXZ01.Trim();
            ViewData["WERKS"] = curObj.WERKS;
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_SCM_B_SENDINFO curObj = new EntityObject_SCM_B_SENDINFO();
            curObj.ID = id;
            curObj = BizLogicObject_SCM_B_SENDINFO.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_SCM_B_SENDINFO>(curObj, from);
            if (!string.IsNullOrEmpty(curObj.MATNR))
            {
                var mater = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(new CauseObject_SCM_D_HRPMATER { MATNR = curObj.MATNR }).FirstOrDefault();
                if (mater != null)
                {
                    curObj.MEINS = mater.MEINS;
                    curObj.MSEHT = mater.MSEHT;
                    curObj.TXZ01 = mater.MAKTX.Replace("\n", "").Trim();
                }
            }
            var msg = BizLogicObject_SCM_B_SENDINFO.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功", "text/html");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式", "text/html");
            }


        }


        [HttpPost]
        public ActionResult PrintSendInfo(FormCollection form)
        {
            var arrID = form["hide_content"];
            String[] IDS = arrID.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            EntityObject_MDM_D_DEPT entityObject_MDM_D_DEPT = BizLogicObject_MDM_D_DEPT.Proxy.Query(new CauseObject_MDM_D_DEPT
            {
                CODE = GetCurrentID()
            }
               ).FirstOrDefault();
            String gysTel = entityObject_MDM_D_DEPT.PHONE;

            CauseObject_SCM_B_SENDINFO cause = new CauseObject_SCM_B_SENDINFO();

            foreach (var id in IDS)
            {
                cause.SetINValue("ID", id);
            }
            var entitys = BizLogicObject_SCM_B_SENDINFO.Proxy.Query(cause).ToList();


             entitys.Add(new DisplayObject_SCM_B_SENDINFO
            {
                ID = "heji",
                AMOUNT = entitys.Sum(p => p.AMOUNT),
                MONEY = entitys.Sum(p => p.MONEY),
                CODE = "",
                GYSACCOUNT = "",
                GYSNAME = "",
                LINK_PERSON = "",
                LINK_TELEPHONE = "",
                MATER_CODE = "",
                MATNR = "合计",
                MEINS = "",
                MSEHT = "",
                NAME = "",
                PRICE = 0,
                SEND_DEPART = "",
                STATE = 1,
                SEND_DEPART_NAME = "",
                TXZ01 = "",
                WERKS = "",
                WERKST = ""

            });
             var idList=IDS.ToList();
            idList.Add("heji");
            IDS = idList.ToArray();
            StringBuilder sb = new StringBuilder();

            sb.Append("<table cellpadding=\"0\" cellspacing=\"0\" style=\"margin-left:60px;\">");
            var gysName = "";
           // var gysTel = "";
            int page = 1;
            int pageCount = Convert.ToInt32(WebConfigurationManager.AppSettings["pageCount"]); //每页可以打印数量  20 
            int firstCount = Convert.ToInt32(WebConfigurationManager.AppSettings["firstCount"]); //第一页可以打印数量  15
            int XCount = Convert.ToInt32(WebConfigurationManager.AppSettings["XCount"]); ;//下边签字部分的高度 6
            for (int i = 0; i < IDS.Length; i++)
            {
                var entity = entitys.Where(p => p.ID == IDS[i]).FirstOrDefault();
                if (i == 0)
                {
                    gysName = entity.GYSNAME;
                 //   gysTel = entity.LINK_TELEPHONE;
                    sb.AppendFormat("<tr><td colspan=\"13\" style=\"height:50px;font-family:宋体;text-align:center;font-size: 20px;\" >{0}</td></tr>", "协和医院物资供应管理中心送货单");
                    sb.AppendFormat("<tr><td colspan=\"10\" style=\"height:30px;font-family:宋体;text-align:left;font-size: 12px;\" >送货科室：{0}({1})</td><td colspan=\"3\" style=\"height:30px;font-family:宋体;font-size: 12px;\" >打印日期：{2}</td><td></td></tr>", entity.SEND_DEPART_NAME, entity.SEND_DEPART.Trim(),DateTime.Now.ToString("yyyy-MM-dd"));
                    GenerateHeadCode(sb, "序号", "物资编码", "供应计划号", "物资名称", "数量", "单位", "单价</br>（元）", "总价</br>（元）", "联系人", "联系方式");
                }
                // style = "page-break-before:always"
                if (i == (firstCount + (page - 1) * pageCount)) //第一行加 分页
                {
                    GenerateHeadCode(sb, "序号", "物资编码", "供应计划号", "物资名称", "数量", "单位", "单价</br>（元）", "总价</br>（元）", "联系人", "联系方式",1);
                    // sb.AppendFormat("<tr><td colspan=\"13\" style=\"page-break-before:always;height:50px;font-family:宋体;text-align:center;font-size: 20px;\" >    </td></tr>");
                    page += 1;
                    GenerateCode(sb, (i + 1).ToString(), entity.TXZ01, entity.MATNR.Trim(), entity.AMOUNT.ToString(), entity.MSEHT, entity.PRICE==0?"":entity.PRICE.ToString(), entity.MONEY.ToString(), entity.CODE, entity.LINK_PERSON, entity.LINK_TELEPHONE, 0);
                }
                else
                {
                    if ((i == (firstCount + (page - 1) * pageCount) - 1) || (i == IDS.Length-1 && (IDS.Length + XCount > (firstCount + (page - 1) * pageCount))))// 最后一行加底边
                    {
                        GenerateBottomCode(sb, (i + 1).ToString(), entity.TXZ01, entity.MATNR.Trim(), entity.AMOUNT.ToString(), entity.MSEHT, entity.PRICE == 0 ? "" : entity.PRICE.ToString(), entity.MONEY.ToString(), entity.CODE, entity.LINK_PERSON, entity.LINK_TELEPHONE);
                    }
                    else
                    {
                        GenerateCode(sb, (i + 1).ToString(), entity.TXZ01, entity.MATNR.Trim(), entity.AMOUNT.ToString(), entity.MSEHT, entity.PRICE == 0 ? "" : entity.PRICE.ToString(), entity.MONEY.ToString(), entity.CODE, entity.LINK_PERSON, entity.LINK_TELEPHONE, 0);
                    }
                }
                // var data = GenerateMark(entity.CODE);
            }
            if (true) //
            {
                if (IDS.Length + XCount > firstCount + (page - 1) * pageCount)
                {
                   // sb.AppendFormat("<tr><td colspan=\"13\" style=\"page-break-before:always;height:50px;font-family:宋体;text-align:center;font-size: 20px;\" >     </td></tr>");
                    sb.AppendFormat("<tr><td colspan=\"13\" style=\"page-break-before:always;height:30px;font-family:宋体;border-top:solid 1px black;border-right:solid 1px black;border-left:solid 1px black;text-align:center;font-size: 12px;\">请使用科室确认产品无误后再进行签收。</td></tr>");
                }
                else
                {
                    sb.AppendFormat("<tr><td colspan=\"13\" style=\"height:30px;font-family:宋体;border-top:solid 1px black;border-right:solid 1px black;border-left:solid 1px black;text-align:center;font-size: 12px;\">请使用科室确认产品无误后再进行签收。</td></tr>");
                }
                sb.AppendFormat("<tr><td  colspan=\"4\" style=\"width: 300px;height:150px;font-family:宋体;border-left:solid 1px black;border-top:solid 1px black;border-bottom:solid 1px black;text-align:left;font-size: 12px;\">");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">主管部门：</p>");
                sb.AppendFormat("<p style=\"width:100%;text-align:center;\">物资供应管理中心</p>");
                sb.AppendFormat("<p style=\"width:100%;text-align:center;\">（027-85726772、352）</p></td>");

                sb.AppendFormat("<td colspan=\"4\" style=\"width: 250px;height:150px;font-family:宋体;border-left:solid 1px black;border-top:solid 1px black;border-bottom:solid 1px black;border-bottom:text-align:left;font-size: 12px;\">");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">签收意见： <input type=\"checkbox\">合格</input>      <input type=\"checkbox\">不合格</input></p>");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">签收人：</p>");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">联系方式：</p>");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">签收方式： <input type=\"checkbox\">本人签收</input>      <input type=\"checkbox\">他人代签</input></p>");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">签收日期：</p></td>");


                sb.AppendFormat("<td colspan=\"5\" style=\"width: 330px;height:150px;font-family:宋体;border-left:solid 1px black;border-top:solid 1px black;border-bottom:solid 1px black;border-right:solid 1px black;border-bottom:text-align:left;font-size: 12px;\">");
                sb.AppendFormat("<p style=\"width:100%;padding-left:5px;\">供应商： </p>");
                sb.AppendFormat("<p style=\"width:100%;text-align:center;\">{0}</p>", gysName);
                sb.AppendFormat("<p style=\"width:100%;text-align:center;\">（{0}）</p>", gysTel);
                sb.AppendFormat("<p style=\"width:100%;text-align:center;\">（盖章）</p></td></tr>");
            }

            //GenerateBottomCode(sb, "", "", "", "", "", "", "", "");//最后一行空着
            sb.Append("</table>");
            ViewBag.PrintStr = new MvcHtmlString(sb.ToString());
            return View();
        }

        public ActionResult PrintSendInfo(string id)
        {
            ViewBag.PrintStr = "";
            return View();
        }
        public void GenerateCode(StringBuilder sb, string k, string TXZ01, string MATNR, string MENGE, string MSEHT, string PRICE, string MONEY, String gyjh, String linkPerson, String linkTel, int fenPage)
        {
            var replaceStr = GenerateStr();
            sb.AppendFormat(replaceStr, k, gyjh, MATNR, TXZ01, MENGE, MSEHT, PRICE, MONEY, linkPerson, linkTel, fenPage == 0 ? "" : "page-break-before:always;");
        }
        public void GenerateBottomCode(StringBuilder sb, string k, string TXZ01, string MATNR, string MENGE, string MSEHT, string PRICE, string MONEY, String gyjh, String linkPerson, String linkTel)
        {
            var replaceStr = GenerateBottomStr();
            sb.AppendFormat(replaceStr, k, gyjh, MATNR, TXZ01, MENGE, MSEHT, PRICE, MONEY, linkPerson, linkTel);
        }
        /// <summary>
        /// 表底部的样式
        /// </summary>
        /// <returns></returns>
        public string GenerateBottomStr()
        {
            var reStr =
                 "<tr>" +
                    "<td style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;height:30px;text-align:center;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 80px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;text-align:center;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td colspan=\"3\" style=\"width: 240px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td colspan=\"2\" style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:right;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:right;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-bottom:solid 1px black;border-left:solid 1px black;border-top:solid 1px black;text-align:center;border-right:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }
        /// <summary>
        /// 每行的数据设置
        /// </summary>
        /// <returns></returns>
        public string GenerateStr()
        {
            var reStr =
                 "<tr style=\"{10}\">" +
                    "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:30px;text-align:center;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;text-align:center;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td colspan=\"3\" style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td colspan=\"2\" style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:right;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:right;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;border-right:solid 1px black;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }
        /// <summary>
        /// 表头数据生成
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="k"></param>
        /// <param name="TXZ01"></param>
        /// <param name="MATNR"></param>
        /// <param name="MENGE"></param>
        /// <param name="MSEHT"></param>
        /// <param name="PRICE"></param>
        /// <param name="MONEY"></param>
        /// <param name="COMMENTS"></param>
        public void GenerateHeadCode(StringBuilder sb, string k, string TXZ01, string MATNR, string MENGE, string MSEHT, string PRICE, string MONEY, String gyjh, String linkPerson, String linkTel ,int fenye=0)
        {
            var replaceStr = GenerateHeadStr();
            sb.AppendFormat(replaceStr, k, MATNR, TXZ01, MENGE, MSEHT, PRICE, MONEY, gyjh, linkPerson, linkTel, fenye == 0 ? "" : "page-break-before:always;");
        }
        public string GenerateHeadStr()
        {
            var reStr =
                 "<tr style=\"{10}\">" +
                    "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:60px;text-align:center;font-family:宋体;font-size: 12px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;height:60px;font-family:宋体;text-align:center;font-size: 12px;\">" +
                        "{2}" +
                    "</td>" +
                      "<td colspan=\"3\" style=\"width: 240px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{3}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{4}" +
                    "</td>" +
                     "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{5}" +
                    "</td>" +
                     "<td colspan=\"2\" style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                     "<td style=\"width: 80px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{7}" +
                    "</td>" +
                      "<td style=\"width: 60px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                      "<td style=\"width: 100px;border-left:solid 1px black;border-top:solid 1px black;text-align:center;border-right:solid 1px black;height:60px;font-family:宋体;font-size: 12px;\">" +
                        "{9}" +
                    "</td>" +
                "</tr>";

            return reStr;

        }
    }
}
