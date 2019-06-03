﻿using System.Web.Mvc;
using System.Collections.Generic;
using Models;
using System;
using System.Linq;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Web.UI;
using System.Text;
using Ipedf.App.Models;
using Ipedf.Core;
using ThoughtWorks.QRCode.Codec;
using Ipedf.App.Codes;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Web.Script.Serialization;
namespace Ipedf.App.Controllers
{
    public class HomeController : BaseController
    {


        public ActionResult Index()
        {
            //Account account = GetCurrentAccount();

            //if (account == null)
            //{
            //    return RedirectToAction("Index", "Account");
            //}
            //else
            //{
            //    var currentPerson = GetCurrentPersonObj();
            //    if (currentPerson == null)
            //    {
            //       // Response.Redirect(authUrl);
            //        return RedirectToAction("Index", "Account");
            //      //  return View();
            //    }
            //    ViewData["PersonName"] = currentPerson.MyName;
            //    ViewData["Department"] = currentPerson.SysDepartment.Name;
            //    IHomeBLL home = new HomeBLL();
            //    ViewData["Menu"] = home.GetMenuByAccount(ref account);// 获取菜单
            //}
            //  string systemId = Page.Request["systemid"];
            DisplayObject_COM_USER user = SystemLogic.Proxy.CurrentUser;
            ViewData["PersonName"] = user.NAME;
            ViewData["Department"] = user.DEPART_ID_NAME;
            // ViewData["RightMenu"] = GetRightMenu().RightMenu;
            ViewData["FirstMenu"] = SystemLogic.Proxy.GetSystemMenuByUser_S(GetRightMenu().FirstMenuID, user);// GetRightMenu().FirstMenuID;
            // string menu = SystemLogic.Proxy.GetSystemMenuByUser(systemId, user, ResolveClientUrl("~/xsl/xp.menu.xslt"));
            return View();
        }



        /// <summary>
        /// 获取列表中的按钮导航
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public ActionResult GetToolbar(Guid id)
        //{
        //    //if (string.IsNullOrWhiteSpace(id) && id == "undefined")
        //    //{
        //    //    return null;
        //    //}
        //    var account = GetCurrentAccount();

        //    if (account == null)
        //    {
        //        return Content(" <script type='text/javascript'> window.top.location='Account'; </script>");
        //    }

        //    ISysMenuSysRoleSysOperationBLL sro = new SysMenuSysRoleSysOperationBLL();
        //    var sysOperations = sro.GetByRefSysMenuIdAndSysRoleId(id, account.RoleIds);
        //    var toolbars = sysOperations.Select(item => new toolbar() {handler = item.Function, iconCls = item.Iconic, text = item.Name}).ToList();
        //    return Json(toolbars, JsonRequestBehavior.AllowGet);
        //}
        /// <summary>
        /// 返回右侧应用列表模块
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRightApp()
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                DisplayObject_COM_SYSTEM[] entities = SystemLogic.Proxy.GetSystemByUser(SystemLogic.Proxy.CurrentUser.ID);
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < entities.Length; i++)
                {
                    if (result.Length == 0)
                    {
                        result.Append(entities[i].ID + "," + entities[i].NAME);
                    }
                    else
                    {
                        result.Append("^" + entities[i].ID + "," + entities[i].NAME);
                    }
                }
                return Json(new { SYSID = result.ToString(), FirstID = entities[0].ID });
            }
            return Json(new { SYSID = "", FirstID = "" });
        }
        /// <summary>
        /// 直接生成右侧菜单
        /// </summary>
        /// <returns></returns>
        public MenuModel GetRightMenu()
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                DisplayObject_COM_SYSTEM[] entities = SystemLogic.Proxy.GetSystemByUser(SystemLogic.Proxy.CurrentUser.ID);
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < entities.Length; i++)
                {
                    result.Append("<a href=\"javascript:void(0)\"  style=\"width:60px;\"  onclick=\"javascript:CallBackByID('" + entities[i].ID + "')\">" + entities[i].NAME + "</a>");
                }
                return new MenuModel { RightMenu = result.ToString(), FirstMenuID = entities[0].ID };
            }
            return null;
        }
        [HttpPost]
        public ActionResult GetLeftMenu(string SYSID)
        {

            DisplayObject_COM_USER user = SystemLogic.Proxy.CurrentUser;
            string menu = SystemLogic.Proxy.GetSystemMenuByUser_S(SYSID, user);//, Server.MapPath("~/xsl/xp.menu.xslt"));
            return Json(menu);
        }
        /// <summary>
        /// 加载左侧列表方法 此方法真的很渣 最好是加载json数据 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CreateItem(string id)
        {
            DisplayObject_COM_USER user = SystemLogic.Proxy.CurrentUser;
            string menu = SystemLogic.Proxy.GetSystemMenuByUser_S(id, user);//, Server.MapPath("~/xsl/xp.menu.xslt"));
            ViewData["Menu"] = menu;
            return PartialView("CreateItem");
        }
        /// <summary>
        /// 删除附件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult FileDelete(FormCollection collection)
        {
            if (!string.IsNullOrEmpty(collection["ID"]))
            {
                var msg = BizLogicObject_COM_FILE.Proxy.Delete(new CauseObject_COM_FILE
                 {
                     ID = collection["ID"]
                 });
                if (msg.Succeed)
                {
                    return Json("OK");
                }
            }
            return Json("Fail");
        }

        public ActionResult Welcome()
        {
            return View();
        }
        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(EntityObject_MDM_D_DEPT entity, FormCollection form)
        {
            entity.SHORT_NAME = Guid.NewGuid().ToString();

            var list = BizLogicObject_MDM_D_DEPT.Proxy.Query(new CauseObject_MDM_D_DEPT
             {
                 DEPT_TYPE_ID = "SCM00340001",
                 NAME = entity.NAME
             });
            if (list.Length > 0)
            {
                return Json(new
                {
                    Msg = "F:创建失败，此用户名已经注册！",
                    BackValue = ""
                }, "text/html");
            }
            if (entity != null && ModelState.IsValid)
            {
                entity.DEPT_TYPE_ID = "SCM00340001";
                var msg = BizLogicObject_MDM_D_DEPT.Proxy.Save(entity);
                if (msg.Succeed)
                {
                    try //上传附件出现问题 
                    {
                        var hide_BANK_NAME = form["hide_BANK_NAME"];//工商营业执照 ID

                        var hide_BANK_ADDRESS = form["hide_BANK_ADDRESS"];//组织机构代码
                        var hide_BANK_NUMBER = form["hide_BANK_NUMBER"];//税务登记证
                        var Hide_SERVICES = form["Hide_SERVICES"];//药品

                        List<EntityObject_COM_FILE> list_file = new List<EntityObject_COM_FILE>();
                        if (!string.IsNullOrEmpty(hide_BANK_NAME))
                        {
                            EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                            file.ID = hide_BANK_NAME;
                            list_file.Add(BizLogicObject_COM_FILE.Proxy.Get(file));
                        }
                        if (!string.IsNullOrEmpty(hide_BANK_ADDRESS))
                        {
                            EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                            file.ID = hide_BANK_ADDRESS;
                            list_file.Add(BizLogicObject_COM_FILE.Proxy.Get(file));
                        }
                        if (!string.IsNullOrEmpty(hide_BANK_NUMBER))
                        {
                            EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                            file.ID = hide_BANK_NUMBER;
                            list_file.Add(BizLogicObject_COM_FILE.Proxy.Get(file));
                        }
                        if (!string.IsNullOrEmpty(Hide_SERVICES))
                        {
                            EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                            file.ID = Hide_SERVICES;
                            list_file.Add(BizLogicObject_COM_FILE.Proxy.Get(file));
                        }
                        for (int k = 1; k <= 14; k++)
                        {
                            var hid_ID = form["Hidden" + k.ToString()];
                            if (!string.IsNullOrEmpty(hid_ID))
                            {
                                EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                                file.ID = hid_ID;
                                list_file.Add(BizLogicObject_COM_FILE.Proxy.Get(file));
                            }
                        }

                        foreach (var item in list_file)
                        {
                            item.REF_TAB_NAME = "MDM_D_DEPT";
                            item.REF_TAB_ID = entity.ID;
                        }

                        BizLogicObject_COM_FILE.Proxy.BatchUpdate(list_file.ToArray());

                    }
                    catch
                    {

                    }

                    return Json(new
                    {
                        Msg = "S:创建成功",
                        BackValue = entity.SHORT_NAME
                    }, "text/html");

                }
            }
            //  return Json("F:创建失败，请核对输入的数据的格式");
            return Json(new
            {
                Msg = "F:创建失败，请核对输入的数据的格式",
                BackValue = ""
            }, "text/html");
        }
        /// <summary>
        /// 供应商编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RegisterEdit(string id)
        {
            EntityObject_MDM_D_DEPT entity = new EntityObject_MDM_D_DEPT();
            #region 附件
            var fName = "";
            var fID = "";
            var SName = "";
            var SID = "";
            var TName = "";
            var TID = "";
            var fouthName = "";
            var fouthID = "";

            var Name_5 = "";
            var ID_5 = "";

            var Name_6 = "";
            var ID_6 = "";

            var Name_7 = "";
            var ID_7 = "";

            var Name_8 = "";
            var ID_8 = "";

            var Name_10 = "";
            var ID_10 = "";

            var Name_11 = "";
            var ID_11 = "";

            var Name_12 = "";
            var ID_12 = "";

            var Name_13 = "";
            var ID_13 = "";

            var Name_14 = "";
            var ID_14 = "";

            var Name_15 = "";
            var ID_15 = "";

            var Name_16 = "";
            var ID_16 = "";

            var Name_17 = "";
            var ID_17 = "";

            var Name_18 = "";
            var ID_18 = "";


            var Name_19 = "";
            var ID_19 = "";
            #endregion

            if (id.Length < 36)
            {
                return View(entity);
            }
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = 1;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT
            {
                DEPT_TYPE_ID = "SCM00340001",
                SHORT_NAME = id
            };
            var dataSource = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause, paging, OrderByPara);

            #region 附件显示
            if (dataSource.Length > 0)
            {
                entity = dataSource.FirstOrDefault();
                var list_Entity = GetAttachFile(entity.ID);
                var en_1 = list_Entity.Where(p => p.IS_COMPRESS == 1).FirstOrDefault();
                if (en_1 != null)
                {
                    fName = en_1.CLIENT_NAME;
                    fID = en_1.ID;
                }
                var en_2 = list_Entity.Where(p => p.IS_COMPRESS == 2).FirstOrDefault();
                if (en_2 != null)
                {
                    SName = en_2.CLIENT_NAME;
                    SID = en_2.ID;
                }
                var en_3 = list_Entity.Where(p => p.IS_COMPRESS == 3).FirstOrDefault();
                if (en_3 != null)
                {
                    TName = en_3.CLIENT_NAME;
                    TID = en_3.ID;
                }
                var en_4 = list_Entity.Where(p => p.IS_COMPRESS == 4).FirstOrDefault();
                if (en_4 != null)
                {
                    fouthName = en_4.CLIENT_NAME;
                    fouthID = en_4.ID;
                }
                var en_5 = list_Entity.Where(p => p.IS_COMPRESS == 5).FirstOrDefault();
                if (en_5 != null)
                {
                    Name_5 = en_5.CLIENT_NAME;
                    ID_5 = en_5.ID;
                }

                var en_6 = list_Entity.Where(p => p.IS_COMPRESS == 6).FirstOrDefault();
                if (en_6 != null)
                {
                    Name_6 = en_6.CLIENT_NAME;
                    ID_6 = en_6.ID;
                }
                var en_7 = list_Entity.Where(p => p.IS_COMPRESS == 7).FirstOrDefault();
                if (en_7 != null)
                {
                    Name_7 = en_7.CLIENT_NAME;
                    ID_7 = en_7.ID;
                }
                var en_8 = list_Entity.Where(p => p.IS_COMPRESS == 8).FirstOrDefault();
                if (en_8 != null)
                {
                    Name_8 = en_8.CLIENT_NAME;
                    ID_8 = en_8.ID;
                }
                var en_10 = list_Entity.Where(p => p.IS_COMPRESS == 10).FirstOrDefault();
                if (en_10 != null)
                {
                    Name_10 = en_10.CLIENT_NAME;
                    ID_10 = en_10.ID;
                }
                var en_11 = list_Entity.Where(p => p.IS_COMPRESS == 11).FirstOrDefault();
                if (en_11 != null)
                {
                    Name_11 = en_11.CLIENT_NAME;
                    ID_11 = en_11.ID;
                }
                var en_12 = list_Entity.Where(p => p.IS_COMPRESS == 12).FirstOrDefault();
                if (en_12 != null)
                {
                    Name_12 = en_12.CLIENT_NAME;
                    ID_12 = en_12.ID;
                }
                var en_13 = list_Entity.Where(p => p.IS_COMPRESS == 13).FirstOrDefault();
                if (en_13 != null)
                {
                    Name_13 = en_13.CLIENT_NAME;
                    ID_13 = en_13.ID;
                }
                var en_14 = list_Entity.Where(p => p.IS_COMPRESS == 14).FirstOrDefault();
                if (en_14 != null)
                {
                    Name_14 = en_14.CLIENT_NAME;
                    ID_14 = en_14.ID;
                }
                var en_15 = list_Entity.Where(p => p.IS_COMPRESS == 15).FirstOrDefault();
                if (en_15 != null)
                {
                    Name_15 = en_15.CLIENT_NAME;
                    ID_15 = en_15.ID;
                }
                var en_16 = list_Entity.Where(p => p.IS_COMPRESS == 16).FirstOrDefault();
                if (en_16 != null)
                {
                    Name_16 = en_16.CLIENT_NAME;
                    ID_16 = en_16.ID;

                }
                var en_17 = list_Entity.Where(p => p.IS_COMPRESS == 17).FirstOrDefault();
                if (en_17 != null)
                {
                    Name_17 = en_17.CLIENT_NAME;
                    ID_17 = en_17.ID;
                }
                var en_18 = list_Entity.Where(p => p.IS_COMPRESS == 18).FirstOrDefault();
                if (en_18 != null)
                {
                    Name_18 = en_18.CLIENT_NAME;
                    ID_18 = en_18.ID;
                }
                var en_19 = list_Entity.Where(p => p.IS_COMPRESS == 19).FirstOrDefault();
                if (en_19 != null)
                {
                    Name_19 = en_19.CLIENT_NAME;
                    ID_19 = en_19.ID;
                }
            }
            ViewBag.FName = fName;
            ViewBag.FID = fID;

            ViewBag.SName = SName;
            ViewBag.SID = SID;

            ViewBag.TName = TName;
            ViewBag.TID = TID;

            ViewBag.fouthName = fouthName;
            ViewBag.fouthID = fouthID;

            ViewBag.Name_5 = Name_5;
            ViewBag.ID_5 = ID_5;

            ViewBag.Name_6 = Name_6;
            ViewBag.ID_6 = ID_6;

            ViewBag.Name_7 = Name_7;
            ViewBag.ID_7 = ID_7;

            ViewBag.Name_8 = Name_8;
            ViewBag.ID_8 = ID_8;

            ViewBag.Name_10 = Name_10;
            ViewBag.ID_10 = ID_10;



            ViewBag.Name_11 = Name_11;
            ViewBag.ID_11 = ID_11;

            ViewBag.Name_12 = Name_12;
            ViewBag.ID_12 = ID_12;

            ViewBag.Name_13 = Name_13;
            ViewBag.ID_13 = ID_13;

            ViewBag.Name_14 = Name_14;
            ViewBag.ID_14 = ID_14;

            ViewBag.Name_15 = Name_15;
            ViewBag.ID_15 = ID_15;

            ViewBag.Name_16 = Name_16;
            ViewBag.ID_16 = ID_16;

            ViewBag.Name_17 = Name_17;
            ViewBag.ID_17 = ID_17;

            ViewBag.Name_18 = Name_18;
            ViewBag.ID_18 = ID_18;

            ViewBag.Name_19 = Name_19;
            ViewBag.ID_19 = ID_19;
            #endregion
            return View(entity);
        }
        /// <summary>
        /// 临时使用的功能  供应商可以在审核成功后修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RegisterEdit_Pre(string id)
        {
            EntityObject_MDM_D_DEPT entity = new EntityObject_MDM_D_DEPT();
            #region 附件
            var fName = "";
            var fID = "";
            var SName = "";
            var SID = "";
            var TName = "";
            var TID = "";
            var fouthName = "";
            var fouthID = "";

            var Name_5 = "";
            var ID_5 = "";

            var Name_6 = "";
            var ID_6 = "";

            var Name_7 = "";
            var ID_7 = "";

            var Name_8 = "";
            var ID_8 = "";

            var Name_10 = "";
            var ID_10 = "";

            var Name_11 = "";
            var ID_11 = "";

            var Name_12 = "";
            var ID_12 = "";

            var Name_13 = "";
            var ID_13 = "";

            var Name_14 = "";
            var ID_14 = "";

            var Name_15 = "";
            var ID_15 = "";

            var Name_16 = "";
            var ID_16 = "";

            var Name_17 = "";
            var ID_17 = "";

            var Name_18 = "";
            var ID_18 = "";

            var Name_19 = "";
            var ID_19 = "";
            #endregion


            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = 1;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT
            {
                 DEPT_TYPE_ID="SCM00340001",
                CODE = SystemLogic.Proxy.CurrentUser.ACCOUNT
            };
            var dataSource = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause, paging, OrderByPara);

            #region 附件显示
            if (dataSource.Length > 0)
            {
                entity = dataSource.FirstOrDefault();
                var list_Entity = GetAttachFile(entity.ID);
                var en_1 = list_Entity.Where(p => p.IS_COMPRESS == 1).FirstOrDefault();
                if (en_1 != null)
                {
                    fName = en_1.CLIENT_NAME;
                    fID = en_1.ID;
                }
                var en_2 = list_Entity.Where(p => p.IS_COMPRESS == 2).FirstOrDefault();
                if (en_2 != null)
                {
                    SName = en_2.CLIENT_NAME;
                    SID = en_2.ID;
                }
                var en_3 = list_Entity.Where(p => p.IS_COMPRESS == 3).FirstOrDefault();
                if (en_3 != null)
                {
                    TName = en_3.CLIENT_NAME;
                    TID = en_3.ID;
                }
                var en_4 = list_Entity.Where(p => p.IS_COMPRESS == 4).FirstOrDefault();
                if (en_4 != null)
                {
                    fouthName = en_4.CLIENT_NAME;
                    fouthID = en_4.ID;
                }
                var en_5 = list_Entity.Where(p => p.IS_COMPRESS == 5).FirstOrDefault();
                if (en_5 != null)
                {
                    Name_5 = en_5.CLIENT_NAME;
                    ID_5 = en_5.ID;
                }

                var en_6 = list_Entity.Where(p => p.IS_COMPRESS == 6).FirstOrDefault();
                if (en_6 != null)
                {
                    Name_6 = en_6.CLIENT_NAME;
                    ID_6 = en_6.ID;
                }
                var en_7 = list_Entity.Where(p => p.IS_COMPRESS == 7).FirstOrDefault();
                if (en_7 != null)
                {
                    Name_7 = en_7.CLIENT_NAME;
                    ID_7 = en_7.ID;
                }
                var en_8 = list_Entity.Where(p => p.IS_COMPRESS == 8).FirstOrDefault();
                if (en_8 != null)
                {
                    Name_8 = en_8.CLIENT_NAME;
                    ID_8 = en_8.ID;
                }
                var en_10 = list_Entity.Where(p => p.IS_COMPRESS == 10).FirstOrDefault();
                if (en_10 != null)
                {
                    Name_10 = en_10.CLIENT_NAME;
                    ID_10 = en_10.ID;
                }
                var en_11 = list_Entity.Where(p => p.IS_COMPRESS == 11).FirstOrDefault();
                if (en_11 != null)
                {
                    Name_11 = en_11.CLIENT_NAME;
                    ID_11 = en_11.ID;
                }
                var en_12 = list_Entity.Where(p => p.IS_COMPRESS == 12).FirstOrDefault();
                if (en_12 != null)
                {
                    Name_12 = en_12.CLIENT_NAME;
                    ID_12 = en_12.ID;
                }
                var en_13 = list_Entity.Where(p => p.IS_COMPRESS == 13).FirstOrDefault();
                if (en_13 != null)
                {
                    Name_13 = en_13.CLIENT_NAME;
                    ID_13 = en_13.ID;
                }
                var en_14 = list_Entity.Where(p => p.IS_COMPRESS == 14).FirstOrDefault();
                if (en_14 != null)
                {
                    Name_14 = en_14.CLIENT_NAME;
                    ID_14 = en_14.ID;
                }
                var en_15 = list_Entity.Where(p => p.IS_COMPRESS == 15).FirstOrDefault();
                if (en_15 != null)
                {
                    Name_15 = en_15.CLIENT_NAME;
                    ID_15 = en_15.ID;
                }
                var en_16 = list_Entity.Where(p => p.IS_COMPRESS == 16).FirstOrDefault();
                if (en_16 != null)
                {
                    Name_16 = en_16.CLIENT_NAME;
                    ID_16 = en_16.ID;

                }
                var en_17 = list_Entity.Where(p => p.IS_COMPRESS == 17).FirstOrDefault();
                if (en_17 != null)
                {
                    Name_17 = en_17.CLIENT_NAME;
                    ID_17 = en_17.ID;
                }
                var en_18 = list_Entity.Where(p => p.IS_COMPRESS == 18).FirstOrDefault();
                if (en_18 != null)
                {
                    Name_18 = en_18.CLIENT_NAME;
                    ID_18 = en_18.ID;
                }
                var en_19 = list_Entity.Where(p => p.IS_COMPRESS == 19).FirstOrDefault();
                if (en_19 != null)
                {
                    Name_19 = en_19.CLIENT_NAME;
                    ID_19 = en_19.ID;
                }
            }
            ViewBag.FName = fName;
            ViewBag.FID = fID;

            ViewBag.SName = SName;
            ViewBag.SID = SID;

            ViewBag.TName = TName;
            ViewBag.TID = TID;

            ViewBag.fouthName = fouthName;
            ViewBag.fouthID = fouthID;

            ViewBag.Name_5 = Name_5;
            ViewBag.ID_5 = ID_5;

            ViewBag.Name_6 = Name_6;
            ViewBag.ID_6 = ID_6;

            ViewBag.Name_7 = Name_7;
            ViewBag.ID_7 = ID_7;

            ViewBag.Name_8 = Name_8;
            ViewBag.ID_8 = ID_8;

            ViewBag.Name_10 = Name_10;
            ViewBag.ID_10 = ID_10;



            ViewBag.Name_11 = Name_11;
            ViewBag.ID_11 = ID_11;

            ViewBag.Name_12 = Name_12;
            ViewBag.ID_12 = ID_12;

            ViewBag.Name_13 = Name_13;
            ViewBag.ID_13 = ID_13;

            ViewBag.Name_14 = Name_14;
            ViewBag.ID_14 = ID_14;

            ViewBag.Name_15 = Name_15;
            ViewBag.ID_15 = ID_15;

            ViewBag.Name_16 = Name_16;
            ViewBag.ID_16 = ID_16;

            ViewBag.Name_17 = Name_17;
            ViewBag.ID_17 = ID_17;

            ViewBag.Name_18 = Name_18;
            ViewBag.ID_18 = ID_18;

            ViewBag.Name_19 = Name_19;
            ViewBag.ID_19 = ID_19;

            var EditFlag = System.Web.Configuration.WebConfigurationManager.AppSettings["SupplierEdit"];//是否可编辑
            if (string.IsNullOrEmpty(EditFlag))
            {
                EditFlag = "0";
            }
            ViewBag.Edit = EditFlag.ToString();
            #endregion
            return View(entity);
        }
        public List<DisplayObject_COM_FILE> GetAttachFile(string ID)
        {

            return BizLogicObject_COM_FILE.Proxy.Query(new CauseObject_COM_FILE
                            {

                                REF_TAB_ID = ID
                            }).ToList();
        }

        [HttpPost]
        public ActionResult RegisterEdit(string id, FormCollection from)
        {
            EntityObject_MDM_D_DEPT curObj = new EntityObject_MDM_D_DEPT();
            curObj.ID = from["hidID"];//主键ID 防止与url中id冲突
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
        [HttpPost]
        public ActionResult PrintTest(FormCollection form)
        {
            var arrID = form["content"];
            var IDS = arrID.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();

            foreach (var id in IDS)
            {
                cause.SetINValue("ID", id);
            }
            var entitys = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < IDS.Length; i++)
            {
                var entity = entitys.Where(p => p.ID == IDS[i]).FirstOrDefault();
                var PKG_NUMBER = Convert.ToInt32(entity.PKG_NUMBER);
                var data = GenerateMark(entity.CODE);
                if (i == 0)
                {
                    GenerateCode(sb, data, entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT == null ? "" : entity.VFDAT.ToString("yyyy-MM-dd"), "", entity.GYSNAME, entity.CODE, "", entity.MSEHT, entity.PKG_AMOUNT == null ? "" : entity.PKG_AMOUNT.ToString(), entity.PKG_NUMBER == null ? "" : entity.PKG_NUMBER.ToString(), entity.MENGE.ToString(), entity.WERKST, entity.NAME);
                }
                else
                {
                    GenerateCode(sb, data, entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT == null ? "" : entity.VFDAT.ToString("yyyy-MM-dd"), "", entity.GYSNAME, entity.CODE, "page-break-before: always;", entity.MSEHT, entity.PKG_AMOUNT == null ? "" : entity.PKG_AMOUNT.ToString(), entity.PKG_NUMBER == null ? "" : entity.PKG_NUMBER.ToString(), entity.MENGE.ToString(), entity.WERKST, entity.NAME);
                }
            }
            ViewBag.PrintStr = new MvcHtmlString(sb.ToString());
            return View();
        }
        public ActionResult PrintTest(string id)
        {
            var entity = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(new EntityObject_SCM_D_SUPPLYPLAN { ID = id });
            var PKG_NUMBER = Convert.ToInt32(entity.PKG_NUMBER);
            //  var pkg_n = entity.PKG_AMOUNT * entity.PKG_NUMBER;
            var data = GenerateMark(entity.CODE);
            StringBuilder sb = new StringBuilder();
            //for (var i = 0; i < PKG_NUMBER; i++)
            //{
            //    if (i == 0)
            //    {
            GenerateCode(sb, data, entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT == null ? "" : entity.VFDAT.ToString("yyyy-MM-dd"), "", entity.GYSNAME, entity.CODE, "", entity.MSEHT, entity.PKG_AMOUNT == null ? "" : entity.PKG_AMOUNT.ToString(), entity.PKG_NUMBER == null ? "" : entity.PKG_NUMBER.ToString(), entity.MENGE.ToString(), entity.WERKST, entity.NAME);
            //  }
            //else
            //{
            //    GenerateCode(sb, data, entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT.ToString("yyyy-MM-dd"), (i + 1) + "/" + PKG_NUMBER, entity.GYSNAME, entity.CODE, "page-break-before: always;", entity.MSEHT, entity.PKG_AMOUNT.ToString(), entity.PKG_NUMBER.ToString(), pkg_n.ToString());
            //}

            //  }

            ////散装实现二维码打印
            //var unInformed_N = entity.MENGE - pkg_n;
            //var unData = GenerateMark(entity.CODE + ",0," + pkg_n.ToString());
            //if (unInformed_N > 0)
            //{
            //    if (PKG_NUMBER > 0)//分页
            //    {
            //        GenerateCode(sb,unData,entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT.ToString("yyyy-MM-dd"), "", entity.GYSNAME, entity.CODE, "page-break-before: always;", entity.MSEHT, entity.PKG_AMOUNT.ToString(), "0", unInformed_N.ToString());
            //    }
            //    else
            //    {
            //        GenerateCode(sb, unData, entity.TXZ01, entity.MATNR, entity.CHARG, entity.ORDER_MENGE.ToString(), entity.VFDAT.ToString("yyyy-MM-dd"), "", entity.GYSNAME, entity.CODE, "", entity.MSEHT, entity.PKG_AMOUNT.ToString(), "0", unInformed_N.ToString());
            //    }
            //}
            ViewBag.PrintStr = new MvcHtmlString(sb.ToString());
            return View();
        }
        public void GenerateCode(StringBuilder sb, string data, string TXZ01, string MATNR, string CHARG, string ORDER_MENGE, string VFDAT, string perPage, string CREATENAME, string GYJH, string fenPage, string MSEHT, string PKG_AMOUNT, string PKG_NUMBER, string NUMBER, string WERKST, string NAME)
        {
            var replaceStr = GenerateStr();
            var addTR = "";
            //if (fenPage != "")//第一张上面空有20px，所以在之后每一张之前加20px
            //{
            //    addTR = "<tr><td colspan=\"3\" style=\"width:340px;height:20px;\"></td></tr>";
            //}

            sb.AppendFormat(replaceStr, TXZ01, MATNR, data, CHARG, ORDER_MENGE, VFDAT, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), GYJH, CREATENAME, fenPage, MSEHT, PKG_AMOUNT, PKG_NUMBER, NUMBER, addTR, WERKST.Replace("武汉协和医院", "").Replace("-", ""), NAME);
        }
        public string GenerateStr()
        {
            var reStr = "<div style=\"width: 340px; margin: 0; padding: 0; font-family:宋体;font-size: 14px; {9}\"><table cellpadding=\"0\" cellspacing=\"0\">{14}" +
                "<tr>" +
                    "<td colspan=\"2\" style=\"width: 240px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "华中科技大学同济医学院附属协和医院" +
                    "</td>" +
                    "<td  style=\"width: 100px;height:16px;font-family:宋体;font-size: 12px;\">" +
                        "{6}" +
                    "</td>" +
                "</tr>" +
                 "<tr>" +
                    "<td style=\"width: 70px;height:30px;font-family:宋体;font-size: 14px;\">" +
                        "药品名称：" +
                    "</td>" +
                    "<td colspan=\"2\" style=\"width: 270px;height:30px;font-family:宋体;font-size: 12px;\">" +
                        "{0}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width: 70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "物料号：" +
                   " </td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{1}" +
                    "</td>" +
                    "<td rowspan=\"6\" style=\"width: 80px;height:80px;\">" +
                        "<img alt=\"显示出错\" id=\"im_1\" src=\"..{2}\"  style=\" width:80px; height:80px;\"/>" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "批号：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{3}" +
                    "</td>" +
                "</tr>" +

                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "有效日期：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{5}" +
                    "</td>" +
               " </tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "包装数量：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{11}{10}/箱" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "箱数：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{12}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                   " <td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "实收数量：" +
                    "</td>" +
                    "<td style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{13}{10}({15})" +
                   " </td>" +
                "</tr>" +
                "<tr>" +
                   " <td style=\"width:70px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "订单数量：" +
                    "</td>" +
                    "<td  style=\"width: 170px;height:16px;font-family:宋体;font-size: 14px;\">" +
                        "{4}{10}({16})" +
                   " </td>" +
                    "<td style=\"width:100px;height:16px;font-family:宋体;font-size: 12pt;\">" +
                       "{7}" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td style=\"width:70px;height:30px;font-family:宋体;vertical-align:top;font-size: 14px;\">" +
                        "供应商：" +
                    "</td>" +
                    "<td colspan=\"2\" style=\"width: 270px;height:30px;vertical-align:top;font-family:宋体;font-size: 12px;\">" +
                        "{8}" +
                    "</td>" +
                "</tr>" +
            "</table>" +
        "</div>";
            return reStr;

        }
        public string GenerateMark(string id)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //System.Drawing.Image image = qrCodeEncoder.Encode("4408810820 深圳－广州 小江");
            //global::System.Drawing.Image image = qrCodeEncoder.Encode(id);
            global::System.Drawing.Image image = CreateQRCode(id, QRCodeEncoder.ENCODE_MODE.BYTE, QRCodeEncoder.ERROR_CORRECTION.M, 0, 4, 64, 0,System.Drawing.Color.Black);
            string filename = Guid.NewGuid().ToString() + ".jpg";

            string fileMonthPath = Server.MapPath(@"~\UploadFile") + "\\" + DateTime.Now.ToString("MM");
            string filePreMonthPath = Server.MapPath(@"~\UploadFile") + "\\" + DateTime.Now.AddMonths(-1).ToString("MM");
            if (System.IO.Directory.Exists(filePreMonthPath))
            {
                System.IO.Directory.Delete(filePreMonthPath, true);
            }
            if (!System.IO.Directory.Exists(fileMonthPath))
            {
                System.IO.Directory.CreateDirectory(fileMonthPath);
            }

            string filepath = fileMonthPath + "\\" + filename;
            global::System.IO.FileStream fs = new global::System.IO.FileStream(filepath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
            image.Save(fs, global::System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();
            return @"/UploadFile/" + DateTime.Now.ToString("MM") + "/" + filename;
        }


        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="Content">内容文本</param>
        /// <param name="QRCodeEncodeMode">二维码编码方式</param>
        /// <param name="QRCodeErrorCorrect">纠错码等级</param>
        /// <param name="QRCodeVersion">二维码版本号 0-40</param>
        /// <param name="QRCodeScale">每个小方格的预设宽度（像素），正整数</param>
        /// <param name="size">图片尺寸（像素），0表示不设置</param>
        /// <param name="border">图片白边（像素），当size大于0时有效</param>
        /// <returns></returns>
        public System.Drawing.Image CreateQRCode(string Content, QRCodeEncoder.ENCODE_MODE QRCodeEncodeMode, QRCodeEncoder.ERROR_CORRECTION QRCodeErrorCorrect, int QRCodeVersion, int QRCodeScale, int size, int border, System.Drawing.Color codeEyeColor)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncodeMode;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeErrorCorrect;
            qrCodeEncoder.QRCodeScale = QRCodeScale;
            qrCodeEncoder.QRCodeVersion = QRCodeVersion;

            System.Drawing.Image image = qrCodeEncoder.Encode(Content);

            #region 根据设定的目标图片尺寸调整二维码QRCodeScale设置，并添加边框
            if (size > 0)
            {
                //当设定目标图片尺寸大于生成的尺寸时，逐步增大方格尺寸
                #region 当设定目标图片尺寸大于生成的尺寸时，逐步增大方格尺寸
                while (image.Width < size)
                {
                    qrCodeEncoder.QRCodeScale++;
                    System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                    if (imageNew.Width < size)
                    {
                        image = new System.Drawing.Bitmap(imageNew);
                        imageNew.Dispose();
                        imageNew = null;
                    }
                    else
                    {
                        qrCodeEncoder.QRCodeScale--; //新尺寸未采用，恢复最终使用的尺寸
                        imageNew.Dispose();
                        imageNew = null;
                        break;
                    }
                }
                #endregion

                //当设定目标图片尺寸小于生成的尺寸时，逐步减小方格尺寸
                #region 当设定目标图片尺寸小于生成的尺寸时，逐步减小方格尺寸
                while (image.Width > size && qrCodeEncoder.QRCodeScale > 1)
                {
                    qrCodeEncoder.QRCodeScale--;
                    System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                    image = new System.Drawing.Bitmap(imageNew);
                    imageNew.Dispose();
                    imageNew = null;
                    if (image.Width < size)
                    {
                        break;
                    }
                }
                #endregion

                //根据参数设置二维码图片白边的最小宽度（按需缩小）
                #region 根据参数设置二维码图片白边的最小宽度
                if (image.Width <= size && border > 0)
                {
                    while (image.Width <= size && size - image.Width < border * 2 && qrCodeEncoder.QRCodeScale > 1)
                    {
                        qrCodeEncoder.QRCodeScale--;
                        System.Drawing.Image imageNew = qrCodeEncoder.Encode(Content);
                        image = new System.Drawing.Bitmap(imageNew);
                        imageNew.Dispose();
                        imageNew = null;
                    }
                }
                #endregion

                //已经确认二维码图像，为图像染色修饰
                if (true)
                {
                    //定位点方块边长
                    int beSize = qrCodeEncoder.QRCodeScale * 3;

                    int bep1_l = qrCodeEncoder.QRCodeScale * 2;
                    int bep1_t = qrCodeEncoder.QRCodeScale * 2;

                    int bep2_l = image.Width - qrCodeEncoder.QRCodeScale * 5 - 1;
                    int bep2_t = qrCodeEncoder.QRCodeScale * 2;

                    int bep3_l = qrCodeEncoder.QRCodeScale * 2;
                    int bep3_t = image.Height - qrCodeEncoder.QRCodeScale * 5 - 1;

                    int bep4_l = image.Width - qrCodeEncoder.QRCodeScale * 7 - 1;
                    int bep4_t = image.Height - qrCodeEncoder.QRCodeScale * 7 - 1;

                    System.Drawing.Graphics graphic0 = System.Drawing.Graphics.FromImage(image);

                    // Create solid brush.
                    System.Drawing.SolidBrush blueBrush = new System.Drawing.SolidBrush(codeEyeColor);

                    // Fill rectangle to screen.
                    graphic0.FillRectangle(blueBrush, bep1_l, bep1_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep2_l, bep2_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep3_l, bep3_t, beSize, beSize);
                    graphic0.FillRectangle(blueBrush, bep4_l, bep4_t, qrCodeEncoder.QRCodeScale, qrCodeEncoder.QRCodeScale);
                }

                //当目标图片尺寸大于二维码尺寸时，将二维码绘制在目标尺寸白色画布的中心位置
                #region 如果目标尺寸大于生成的图片尺寸，将二维码绘制在目标尺寸白色画布的中心位置
                if (image.Width < size)
                {
                    //新建空白绘图
                    System.Drawing.Bitmap panel = new System.Drawing.Bitmap(size, size);
                    System.Drawing.Graphics graphic0 = System.Drawing.Graphics.FromImage(panel);
                    int p_left = 0;
                    int p_top = 0;
                    if (image.Width <= size) //如果原图比目标形状宽
                    {
                        p_left = (size - image.Width) / 2;
                    }
                    if (image.Height <= size)
                    {
                        p_top = (size - image.Height) / 2;
                    }

                    //将生成的二维码图像粘贴至绘图的中心位置
                    graphic0.DrawImage(image, p_left, p_top, image.Width, image.Height);
                    image = new System.Drawing.Bitmap(panel);
                    panel.Dispose();
                    panel = null;
                    graphic0.Dispose();
                    graphic0 = null;
                }
                #endregion
            }
            #endregion
            return image;
        }



        private static bool IsTrue() // 在Image类别对图片进行缩放的时候,需要一个返回bool类别的委托 
        {

            return true;

        }

        public ActionResult SctiptXUpgrade()
        {
            return View();
        }
        [HttpGet]
        public string DownFile()
        {
            var result = "";
            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);

            cause.STATUS = "0";

            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, null, OrderByPara).ToList();
            LogHelper.Info("获取到供应计划JSON数据", 1);
            MemoryStream Stream = new MemoryStream();
            JavaScriptSerializer serializer = new JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
            try
            {
                //序列化对象
                result = serializer.Serialize(dataSource);
            }
            catch (InvalidOperationException ex)
            {
                LogHelper.Error(ex);
            }



            return result;

        }
    }
}


