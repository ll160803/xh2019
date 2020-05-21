using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Models;
using Ipedf.Web.DataAccess;
using System.IO;
using FO = System.IO.File;
using Ipedf.App.Models;
using Ipedf.App.Codes;
using Ipedf.Web.Common;
using System.Text;
namespace Ipedf.App.Areas.System.Controllers
{
    public class MDMController : BaseController
    {
        //
        // GET: /System/MDM/ 药品供应商

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 总务供应商
        /// </summary>
        /// <returns></returns>
        public ActionResult ZWIndex()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetData(Guid? id, int page, int rows, string order, string sort, string GysName, string GysAccount, string DEPT_TYPE_ID)
        {

            int total = 0;
            // object dataSource = null;

            //平台自动生成代码
            //  CauseObject_MDM_D_DEPT cause = (CauseObject_MDM_D_DEPT)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT();
            if (!string.IsNullOrEmpty(GysName))
            {
                cause.SetCustomCondition(" and MDM_D_DEPT.NAME like '%" + GysName + "%'");
            }
            if (!string.IsNullOrEmpty(GysAccount))
            {
                cause.CODE = GysAccount;
            }
            if (!string.IsNullOrEmpty(DEPT_TYPE_ID))
            {
                cause.DEPT_TYPE_ID = DEPT_TYPE_ID;
            }
            var dataSource = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_MDM_D_DEPT> queryData = dataSource.ToList();
            foreach (var item in queryData)
            {
                var en_comfiles = BizLogicObject_COM_FILE.Proxy.Query(new CauseObject_COM_FILE
                {

                    REF_TAB_ID = item.ID
                }).ToList();
                var en_1 = en_comfiles.Where(p => p.IS_COMPRESS == 1).FirstOrDefault();
                if (en_1 != null)
                {
                    item.FID = en_1.SERVER_NAME.Replace("\\", "/");
                }
                var en_2 = en_comfiles.Where(p => p.IS_COMPRESS == 2).FirstOrDefault();
                if (en_2 != null)
                {
                    item.SID = en_2.SERVER_NAME.Replace("\\", "/");
                }
                var en_3 = en_comfiles.Where(p => p.IS_COMPRESS == 3).FirstOrDefault();
                if (en_3 != null)
                {
                    item.TID = en_3.SERVER_NAME.Replace("\\", "/");
                }
                var en_4 = en_comfiles.Where(p => p.IS_COMPRESS == 4).FirstOrDefault();
                if (en_4 != null)
                {
                    item.FouthID = en_4.SERVER_NAME.Replace("\\", "/");
                }

                var en_5 = en_comfiles.Where(p => p.IS_COMPRESS == 5).FirstOrDefault();
                if (en_5 != null)
                {
                    item.ID_5 = en_5.SERVER_NAME.Replace("\\", "/");
                }
                var en_6 = en_comfiles.Where(p => p.IS_COMPRESS == 6).FirstOrDefault();
                if (en_6 != null)
                {
                    item.ID_6 = en_6.SERVER_NAME.Replace("\\", "/");
                }
                var en_7 = en_comfiles.Where(p => p.IS_COMPRESS == 7).FirstOrDefault();
                if (en_7 != null)
                {
                    item.ID_7 = en_7.SERVER_NAME.Replace("\\", "/");
                }
                var en_8 = en_comfiles.Where(p => p.IS_COMPRESS == 8).FirstOrDefault();
                if (en_8 != null)
                {
                    item.ID_8 = en_8.SERVER_NAME.Replace("\\", "/");
                }
                var en_10 = en_comfiles.Where(p => p.IS_COMPRESS == 10).FirstOrDefault();
                if (en_10 != null)
                {
                    item.ID_9 = en_10.SERVER_NAME.Replace("\\", "/");
                }
                var en_11 = en_comfiles.Where(p => p.IS_COMPRESS == 11).FirstOrDefault();
                if (en_11 != null)
                {
                    item.ID_11 = en_11.SERVER_NAME.Replace("\\", "/");
                }
                var en_12 = en_comfiles.Where(p => p.IS_COMPRESS == 12).FirstOrDefault();
                if (en_12 != null)
                {
                    item.ID_12 = en_12.SERVER_NAME.Replace("\\", "/");
                }
                var en_13 = en_comfiles.Where(p => p.IS_COMPRESS == 13).FirstOrDefault();
                if (en_13 != null)
                {
                    item.ID_13 = en_13.SERVER_NAME.Replace("\\", "/");
                }
                var en_14 = en_comfiles.Where(p => p.IS_COMPRESS == 14).FirstOrDefault();
                if (en_14 != null)
                {
                    item.ID_14 = en_14.SERVER_NAME.Replace("\\", "/");
                }
                var en_15 = en_comfiles.Where(p => p.IS_COMPRESS == 15).FirstOrDefault();
                if (en_15 != null)
                {
                    item.ID_15 = en_15.SERVER_NAME.Replace("\\", "/");
                }
                var en_16 = en_comfiles.Where(p => p.IS_COMPRESS == 16).FirstOrDefault();
                if (en_16 != null)
                {
                    item.ID_16 = en_16.SERVER_NAME.Replace("\\", "/");
                }

                var en_17 = en_comfiles.Where(p => p.IS_COMPRESS == 17).FirstOrDefault();
                if (en_17 != null)
                {
                    item.ID_17 = en_17.SERVER_NAME.Replace("\\", "/");
                }

                var en_18 = en_comfiles.Where(p => p.IS_COMPRESS == 18).FirstOrDefault();
                if (en_18 != null)
                {
                    item.ID_18 = en_18.SERVER_NAME.Replace("\\", "/");
                }

                var en_19 = en_comfiles.Where(p => p.IS_COMPRESS == 19).FirstOrDefault();
                if (en_19 != null)
                {
                    item.ID_19 = en_19.SERVER_NAME.Replace("\\", "/");
                    item.CONTRACT_DATE = DateTimeHelper.toString(item.CONTRACT_START, item.CONTRACT_END);
                }

                

                item.YH = SupplierLimit.IsSettingLimit(item.CODE) ? 1 : 0;//0是限制 1是不限制
            }

            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        public FileStreamResult DownFile(string SERVER_NAME,string CLIENT_NAME)
        {
            string absoluFilePath = Server.MapPath("~/UploadFile/BaseInfo/") + SERVER_NAME;
            if (string.IsNullOrEmpty(CLIENT_NAME))
            {
                CLIENT_NAME = SERVER_NAME;
            }
            var fileName = HttpUtility.UrlEncode(CLIENT_NAME, Encoding.GetEncoding("UTF-8"));
            return File(new FileStream(absoluFilePath, FileMode.Open), "application/octet-stream", fileName);
        }
        public JsonResult SaveCancelCode(string IDS, string SAPCODE, string DEPT_TYPE_ID)
        {
            string[] Ids = IDS.Split(',').ToArray();
            string[] aspCodes = SAPCODE.Split(',').ToArray();
            List<EntityObject_MDM_D_DEPT> updateDetailEntities = new List<EntityObject_MDM_D_DEPT>();
            BizLogicObject_MDM_D_DEPT logic = new BizLogicObject_MDM_D_DEPT();
            for (var i = 0; i < Ids.Length; i++)
            {
                EntityObject_MDM_D_DEPT entity = new EntityObject_MDM_D_DEPT();
                entity.ID = Ids[i];
                entity = logic.Get(entity);
                entity.CODE = aspCodes[i];
                entity.STATE = 1;//审核不通过 2 审核通过
                updateDetailEntities.Add(entity);
            }
            var msg = logic.BatchUpdate(updateDetailEntities.ToArray());
            if (msg.Succeed)
            {
                var cause = new CauseObject_COM_USER();
                foreach (var it in aspCodes)
                {
                    cause.SetINValue("ACCOUNT", it);
                }
                EntityObject_COM_USER[] dataPersonSource = BizLogicObject_COM_USER.Proxy.Query(cause);
                foreach (var en in dataPersonSource)
                {
                    en.IS_USABLE = 1;
                    en.SetUpdate("IS_USABLE");
                }
                msg = BizLogicObject_COM_USER.Proxy.BatchUpdate(dataPersonSource);
                if (msg.Succeed)
                {
                    return Json("OK");
                }
                else
                {
                    return Json(msg.Message);
                }
            }
            else
            {
                return Json(msg.Message, "text/html");
            };


        }
        /// <summary>
        /// 保存SAP的账号 
        /// </summary>
        /// <param name="IDS"></param>
        /// <param name="SAPCODE"></param>
        /// <param name="NAMEs"></param>
        /// <param name="flag">0是保存 1是保存并审核</param>
        /// <returns></returns>
        public ActionResult SaveSAPCode(string IDS, string SAPCODE, string NAMEs, int flag, string DEPT_TYPE_ID)
        {
            string[] Ids = IDS.Split(',').ToArray();
            string[] aspCodes = SAPCODE.Split(',').ToArray();
            string[] Names = NAMEs.Split(',').ToArray();
            List<EntityObject_MDM_D_DEPT> updateDetailEntities = new List<EntityObject_MDM_D_DEPT>();
            BizLogicObject_MDM_D_DEPT logic = new BizLogicObject_MDM_D_DEPT();
            RfcNOC rfc = new RfcNOC();
            for (var i = 0; i < Ids.Length; i++)
            {
                EntityObject_MDM_D_DEPT entity = new EntityObject_MDM_D_DEPT();
                entity.ID = Ids[i];
                entity = logic.Get(entity);
                entity.CODE = aspCodes[i];
                if (flag == 1)//审核 写入用户数据
                {
                    entity.STATE = 2;
                    AddPerson(Names[i], aspCodes[i], DEPT_TYPE_ID);//保存用户数据

                    //上传sap
                    rfc.SendVendorInfo_RFC(entity.CODE, entity.PHONE, entity.LINK_PERSON, entity.NAME);
                }
                updateDetailEntities.Add(entity);
            }
            var msg = logic.BatchUpdate(updateDetailEntities.ToArray());
            if (msg.Succeed)
            {
                return Json("OK");
            }
            else
            {
                return Json(msg.Message);
            };
        }
        public void AddPerson(string name, string sapCode, string DEPT_TYPE_ID)
        {
            var dataPersonSource_Exist = BizLogicObject_COM_USER.Proxy.Query(new CauseObject_COM_USER
                {
                    ACCOUNT = sapCode
                }, new PagingParamter
                {
                    PageIndex = 0,
                    PageSize = 10
                }, new OrderByParameter { Asc = true, OrderBy = "ID" });
            if (dataPersonSource_Exist.Count() > 0)//判断是否存在用户了
            {
                foreach (var en in dataPersonSource_Exist)
                {
                    en.IS_USABLE = 0;
                    en.SetUpdate("IS_USABLE");
                }
                BizLogicObject_COM_USER.Proxy.BatchUpdate(dataPersonSource_Exist);
                //当一个SAP账号对应两个供应商 需要设置两个角色
                var listRole = BizLogicObject_COM_ROLE_M_USER.Proxy.Query(new CauseObject_COM_ROLE_M_USER
                   {
                       USER_ID = dataPersonSource_Exist.FirstOrDefault().ID,
                       ROLE_ID = MDM_DEPT_TYPE.GetRoleByDeptType(DEPT_TYPE_ID)
                   });
                if (listRole == null || listRole.Length == 0)
                {
                    var msg = BizLogicObject_COM_ROLE_M_USER.Proxy.Save(new EntityObject_COM_ROLE_M_USER
                    {
                        ROLE_ID = MDM_DEPT_TYPE.GetRoleByDeptType(DEPT_TYPE_ID),//"2929640e-bedc-4a3d-a1ee-b628fe30d5ee",//药品供应商角色
                        USER_ID = dataPersonSource_Exist.FirstOrDefault().ID
                    });//保存
                }
            }
            else
            {
                EntityObject_COM_USER entity = new EntityObject_COM_USER();
                entity.PASSWORD = "k6mMNZqjupk=";
                entity.NAME = name;
                entity.IS_USABLE = 0;
                entity.ACCOUNT = sapCode;
                entity.DEPART_ID = "9678dcc1-bd78-4557-a662-141abad32f0a";//供应商部门
                var msg_User = BizLogicObject_COM_USER.Proxy.Save(entity);
                if (msg_User.Succeed)
                {
                    var msg = BizLogicObject_COM_ROLE_M_USER.Proxy.Save(new EntityObject_COM_ROLE_M_USER
                    {
                        ROLE_ID = MDM_DEPT_TYPE.GetRoleByDeptType(DEPT_TYPE_ID),//"2929640e-bedc-4a3d-a1ee-b628fe30d5ee",//药品供应商角色
                        USER_ID = entity.ID
                    });//保存
                }
            }
        }
        public ActionResult Edit(string id)
        {
            EntityObject_MDM_D_DEPT curObj = new EntityObject_MDM_D_DEPT();
            curObj.ID = id;
            curObj = BizLogicObject_MDM_D_DEPT.Proxy.Get(curObj);
            return View(curObj);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection from)
        {
            EntityObject_MDM_D_DEPT curObj = new EntityObject_MDM_D_DEPT();
            curObj.ID = id;
            curObj = BizLogicObject_MDM_D_DEPT.Proxy.Get(curObj);

            TryUpdateModel<EntityObject_MDM_D_DEPT>(curObj, from);
            var msg = BizLogicObject_MDM_D_DEPT.Proxy.Update(curObj);
            if (msg.Succeed)
            {
                return Json("S:保存成功", "text/html");
            }
            else
            {

                return Json("F:保存失败，请核对输入的数据的格式", "text/html");
            }


        }
        /// <summary>
        /// 打开或者关闭 供应商接口
        /// </summary>
        /// <param name="query"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OpenAndCloseInF(string query, string Status, string DEPT_TYPE_ID)
        {
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT();
            cause.SetCustomCondition(string.Format(" and ID in ({0})", "'" + query.Replace(",", "','") + "'"));
            cause.DEPT_TYPE_ID = DEPT_TYPE_ID;
            var entitys = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause);

            foreach (var item in entitys)
            {
                item.SetUpdate("FAX");
                item.FAX = Status;
            }
            var msg = BizLogicObject_MDM_D_DEPT.Proxy.BatchUpdate(entitys);
            if (msg.Succeed)
            {
                return Json("OK");
            }
            else
            {
                return Json("F:保存失败" + msg.Message);
            }
        }
        /// <summary>
        /// 关闭和打开验收合格证书限制
        /// </summary>
        /// <param name="query"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OpenAndCloseYH(string query, string Flag)
        {
            var msg = SupplierLimit.SettingLimit(query, Flag);

            if (msg)
            {
                return Json("OK");
            }
            else
            {
                return Json("F:保存失败");
            }
        }
        public ActionResult NewIdea()
        {
            return View();
        }
        public ActionResult SetVISIT(string ID, string Flag)
        {
            var entity = BizLogicObject_SCM_B_VISIT.Proxy.Get(new EntityObject_SCM_B_VISIT { ID = ID });
            if (Flag == "0")
            {
                entity.NONESS_COUNT += 1;
            }
            else
            {
                entity.NESS_COUNT += 1;
            }
            var msg = BizLogicObject_SCM_B_VISIT.Proxy.Update(entity);
            return Json("OK", "text/html");
        }


        public ActionResult DownImage(string IDS)
        {
            if (IDS == "")//全部下载 如果下载包已经存在，不再下载
            {
                if (FO.Exists(Server.MapPath("~/UploadFile/Attach.zip")))
                {
                    return Json("../../UploadFile/Attach.zip");
                }
            }
            try
            {
                var cause = new CauseObject_MDM_D_DEPT();
                if (IDS != "")
                {
                    cause.SetCustomCondition("And ID in ('" + IDS.Replace(",", "','") + "')");
                }
                var MDMList = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause).ToList();
                var cause_file = new CauseObject_COM_FILE();
                if (IDS != "")
                {
                    cause_file.SetCustomCondition("And REF_TAB_ID in ('" + IDS.Replace(",", "','") + "')");
                }

                var fileList = BizLogicObject_COM_FILE.Proxy.Query(cause_file).ToList();
                var filePath = Server.MapPath("~/UploadFile/ImportDocument/");
                if (IDS != "")
                {
                    filePath = Server.MapPath("~/UploadFile/GysDoc/");
                    if (!Directory.Exists(Server.MapPath("~/UploadFile/GysDoc")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/UploadFile/GysDoc"));
                    }
                    else
                    {
                        Directory.Delete(Server.MapPath("~/UploadFile/GysDoc"), true);
                        Directory.CreateDirectory(Server.MapPath("~/UploadFile/GysDoc"));
                    }

                }
                var fileTruePath = Server.MapPath("~/UploadFile/BaseInfo/");//资质文件存放地点
                Dictionary<int, string> dic = Ipedf.App.Models.AttachFileDic.GetAttachDic();

                foreach (var mdm in MDMList)
                {
                    if (!Directory.Exists(filePath + mdm.NAME.Trim()))
                    {
                        Directory.CreateDirectory(filePath + mdm.NAME.Trim());
                        foreach (var item in dic)
                        {
                            var filep = fileList.Where(p => p.IS_COMPRESS == item.Key && p.SERVER_NAME != null).FirstOrDefault();
                            if (filep != null)
                            {
                                var serverName = filep.SERVER_NAME;
                                var pt = fileTruePath + serverName;
                                if (FO.Exists(pt))
                                {
                                    FO.Copy(pt, filePath + mdm.NAME.Trim() + "//" + item.Value + serverName.Substring(serverName.LastIndexOf(".")));
                                }
                            }
                        }
                    }
                }
                var fileSaveName = "Attach.zip";//全部下载的名称
                if (IDS != "")
                {
                    fileSaveName = "GYSAttach.zip";
                    var fps = Server.MapPath("~/UploadFile/") + fileSaveName;
                    var fps2 = filePath + fileSaveName;
                    if (FO.Exists(fps))
                    {
                        FO.Delete(fps);
                    }
                }
                var fileDownPath = Server.MapPath("~/UploadFile/") + fileSaveName;
                var flag = SharpZip.PackFiles(Server.MapPath("~/UploadFile/") + fileSaveName, filePath);
                if (flag == true)
                {
                    return Json("OK", "text/html");
                }

            }
            catch (Exception ex)
            {
                return Json(ex.Message, "text/html");
            }
            return Json("F", "text/html");
        }

        public ActionResult CompleteIndex()
        {
            ViewBag.LastDay = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            ViewBag.NowDay = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }
        [HttpPost]
        public JsonResult GetCompleteData(Guid? id, int page, int rows, string order, string sort, string dtBeginTime, string dtEndtime, string GysAccount, string GysName)
        {
            DateTime startDate = DateTime.Now.AddMonths(-1);
            DateTime endDate = DateTime.Now;

            if (!string.IsNullOrEmpty(dtBeginTime))
            {
                startDate = Convert.ToDateTime(dtBeginTime);
            }
            if (!string.IsNullOrEmpty(dtEndtime))
            {
                endDate = Convert.ToDateTime(dtEndtime);
            }

            var dataSource = BizLogicObject_COMPLETEPERCENT.Proxy.List(startDate, endDate, GysAccount, GysName).ToList();
            var total = dataSource.Count;
            var queryData = dataSource.OrderBy(p => p.RANK_NUM).Skip((page - 1) * rows).Take(rows).ToList();


            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }

        [HttpPost]
        public ActionResult ExportRankNum(string order, string sort, string dtBeginTime, string dtEndtime, string GysAccount, string GysName)
        {
            DateTime startDate = DateTime.Now.AddMonths(-1);
            DateTime endDate = DateTime.Now;

            if (!string.IsNullOrEmpty(dtBeginTime))
            {
                startDate = Convert.ToDateTime(dtBeginTime);
            }
            if (!string.IsNullOrEmpty(dtEndtime))
            {
                endDate = Convert.ToDateTime(dtEndtime);
            }

            var dataSource = BizLogicObject_COMPLETEPERCENT.Proxy.List(startDate, endDate, GysAccount, GysName).ToList();

            List<EntityObject_COMPLETEPERCENT> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "CODE", "NAME", "RANK_NUM", "Per" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<EntityObject_COMPLETEPERCENT>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1, @"~/up/供应商排名.xls", @"uploadfile/" + DateTime.Now.ToString("yyyyMM") + "/", "供应商排名"));

        }

        [HttpPost]
        public JsonResult GetSupplyData(Guid? id, int page, int rows, string order, string sort, string dtBeginTime, string dtEndtime, string GysAccount, string matnr)
        {
            int total = 0;


            // object dataSource = null;

            //平台自动生成代码
            //  CauseObject_SCM_D_SUPPLYPLAN cause = (CauseObject_SCM_D_SUPPLYPLAN)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = page - 1;
            paging.PageSize = rows;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = order == "asc" ? true : false;
            OrderByPara.OrderBy = sort;
            CauseObject_V_SCM_D_PURCHARSEPLAN cause = new CauseObject_V_SCM_D_PURCHARSEPLAN();

            // cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);
            cause.CREATE_TIME = new DateSpan();

            if (!string.IsNullOrEmpty(dtBeginTime))
            {
                cause.CREATE_TIME.Begin = DateTime.Parse(dtBeginTime + " 00:00:00");
            }
            if (!string.IsNullOrEmpty(dtEndtime))
            {
                cause.CREATE_TIME.End = Convert.ToDateTime(dtEndtime + " 23:59:59");
            }
            if (!string.IsNullOrEmpty(GysAccount))
            {
                cause.GYSACCOUNT = GysAccount;
            }
            if (!string.IsNullOrEmpty(matnr.Trim()))
            {
                cause.MATNR = matnr.Trim();
            }

            var dataSource = BizLogicObject_V_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, paging, OrderByPara);

            List<DisplayObject_V_SCM_D_PURCHARSEPLAN> queryData = dataSource.ToList();

            total = paging.TotalRecords;
            return Json(new datagrid
            {
                total = total,
                rows = queryData
            });
        }
        public ActionResult CompleteSingleIndex()
        {
            ViewBag.LastDay = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            ViewBag.NowDay = DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.GysAccount = GetCurrentID();
            return View();
        }


        public ActionResult MatnrCompleteIndex()
        {
            ViewBag.LastDay = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            ViewBag.NowDay = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }

        [HttpPost]
        public JsonResult GetMatnrCompleteData(Guid? id, int page, int rows, string order, string sort, string dtBeginTime, string dtEndtime, string GysAccount, string GysName, string matnr, string txz01, string WERKST)
        {
            DateTime startDate = DateTime.Now.AddMonths(-1);
            DateTime endDate = DateTime.Now;

            if (string.IsNullOrEmpty(dtBeginTime))
            {
                dtBeginTime = startDate.ToString("yyyy-MM-dd");
            }
            if (string.IsNullOrEmpty(dtEndtime))
            {
                dtEndtime = endDate.ToString("yyyy-MM-dd");
            }
            int total = 0;
            var dataSource = BizLogicObject_COMPLETEPERCENT.Proxy.MaterList(dtBeginTime, dtEndtime, GysAccount == null ? "" : GysAccount.Trim(), GysName == null ? "" : GysName.Trim(), matnr == null ? "" : matnr.Trim(), txz01 == null ? "" : txz01.Trim(), WERKST == null ? "" : WERKST.Trim(), order, sort, out total, page, rows).ToList();

            return Json(new datagrid
            {
                total = total,
                rows = dataSource
            });
        }

        [HttpPost]
        public ActionResult Export(Guid? id, string order, string sort, string dtBeginTime, string dtEndtime, string GysAccount, string GysName, string matnr, string txz01, string WERKST)
        {
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;

            if (string.IsNullOrEmpty(dtBeginTime))
            {
                dtBeginTime = startDate.ToString("yyyy-MM-dd");
            }
            if (string.IsNullOrEmpty(dtEndtime))
            {
                dtEndtime = endDate.ToString("yyyy-MM-dd");
            }
            int total = 0;
            var dataSource = BizLogicObject_COMPLETEPERCENT.Proxy.MaterList(dtBeginTime, dtEndtime, GysAccount == null ? "" : GysAccount.Trim(), GysName == null ? "" : GysName.Trim(), matnr == null ? "" : matnr.Trim(), txz01 == null ? "" : txz01.Trim(), WERKST == null ? "" : WERKST.Trim(), order, sort, out total, 1, 5000).ToList();

            List<EntityObject_COMPLETEPERCENT> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "MATNR", "TXZ01", "CODE", "NAME", "MENGE", "DONE_Menge", "Per" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<EntityObject_COMPLETEPERCENT>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1, @"~/up/物料供货率.xls", @"uploadfile/" + DateTime.Now.ToString("yyyyMM") + "/", "物料供货率"));

        }

        [HttpPost]
        public ActionResult ExportDetail(string dtBeginTime, string dtEndtime, string GysAccount, string matnr)
        {
            //平台自动生成代码
            //  CauseObject_SCM_D_SUPPLYPLAN cause = (CauseObject_SCM_D_SUPPLYPLAN)search;
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = 500;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "BEDAT";
            CauseObject_V_SCM_D_PURCHARSEPLAN cause = new CauseObject_V_SCM_D_PURCHARSEPLAN();

            // cause.GYSACCOUNT = GetCurrentID();//只有当前供应商能看到自己的
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);
            cause.CREATE_TIME = new DateSpan();

            if (!string.IsNullOrEmpty(dtBeginTime))
            {
                cause.CREATE_TIME.Begin = DateTime.Parse(dtBeginTime + " 00:00:00");
            }
            if (!string.IsNullOrEmpty(dtEndtime))
            {
                cause.CREATE_TIME.End = Convert.ToDateTime(dtEndtime + " 23:59:59");
            }

            if (!string.IsNullOrEmpty(GysAccount))
            {
                cause.GYSACCOUNT = GysAccount;
            }
            if (!string.IsNullOrEmpty(matnr.Trim()))
            {
                cause.MATNR = matnr.Trim();
            }

            var dataSource = BizLogicObject_V_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, paging, OrderByPara);
            List<DisplayObject_V_SCM_D_PURCHARSEPLAN> queryData = dataSource.ToList();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] Liststring = new string[] { "MATNR", "TXZ01", "GYSACCOUNT", "GYSNAME", "BEDAT", "EBELN", "ORDER_MENGE", "MENGE" };
            for (int i = 0; i < Liststring.Length; i++)
            {
                dic.Add(i, Liststring[i]);
            }

            return Content(NPOIWriteExcel.WriteExcel<DisplayObject_V_SCM_D_PURCHARSEPLAN>(NPOIWriteExcel.GenerateRowAndWriteData, queryData, dic, 1, @"~/up/物料采购详情.xls", @"uploadfile/" + DateTime.Now.ToString("yyyyMM") + "/", "物料采购详情"));

        }
    }
}
