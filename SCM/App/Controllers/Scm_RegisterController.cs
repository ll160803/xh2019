using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Core;

namespace Ipedf.App.Controllers
{
    public class Scm_RegisterController : Controller
    {
        //
        // GET: /Scm_Register/

        public ActionResult Index()
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
                DEPT_TYPE_ID = "SCM00340002",
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

            var hidden_ID = form["Hidden19"];
            if (!string.IsNullOrEmpty(hidden_ID))
            {
                EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                file.ID = hidden_ID;

                if (BizLogicObject_COM_FILE.Proxy.Get(file) != null)
                {
                    if ((entity.CONTRACT_START == null || entity.CONTRACT_END == null))
                    {
                        return Json(new
                        {
                            Msg = "F:创建失败，采购合同有效期未填写完整！",
                            BackValue = ""
                        }, "text/html");
                    }
                    else if (entity.CONTRACT_START >= entity.CONTRACT_END)
                    {
                        return Json(new
                        {
                            Msg = "F:创建失败，采购合同有效期填写错误，结束日期必须大于开始日期！",
                            BackValue = ""
                        }, "text/html");
                    }
                    else if (entity.CONTRACT_END <= System.DateTime.Now)
                    {
                        return Json(new
                        {
                            Msg = "F:创建失败，采购合同有效期填写错误，结束日期必须大于当前日期！",
                            BackValue = ""
                        }, "text/html");
                    }
                }
            }

            if (entity != null && ModelState.IsValid)
            {
                entity.DEPT_TYPE_ID = "SCM00340002";
                var msg = BizLogicObject_MDM_D_DEPT.Proxy.Save(entity);
                if (msg.Succeed)
                {
                    try //上传附件出现问题 
                    {
                        var hide_BANK_NAME = form["hide_BANK_NAME"];//工商营业执照 ID

                        var hide_BANK_ADDRESS = form["hide_BANK_ADDRESS"];//组织机构代码
                        var hide_BANK_NUMBER = form["hide_BANK_NUMBER"];//税务登记证
                       

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
                       
                        for (int k = 1; k <= 19; k++)
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
            
            var Name_7 = "";
            var ID_7 = "";

            var Name_8 = "";
            var ID_8 = "";


            var Name_11 = "";
            var ID_11 = "";

            var Name_12 = "";
            var ID_12 = "";

           

            var Name_14 = "";
            var ID_14 = "";

           

            var Name_18 = "";
            var ID_18 = "";


           
            #endregion

            //if (id.Length < 36)
            //{
            //    return View(entity);
            //}
            PagingParamter paging = new PagingParamter();

            paging.PageIndex = 0;
            paging.PageSize = 1;

            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "ID";
            CauseObject_MDM_D_DEPT cause = new CauseObject_MDM_D_DEPT

            {
                DEPT_TYPE_ID = "SCM00340002",
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
                
                var en_14 = list_Entity.Where(p => p.IS_COMPRESS == 14).FirstOrDefault();
                if (en_14 != null)
                {
                    Name_14 = en_14.CLIENT_NAME;
                    ID_14 = en_14.ID;
                }
               
               
                var en_18 = list_Entity.Where(p => p.IS_COMPRESS == 18).FirstOrDefault();
                if (en_18 != null)
                {
                    Name_18 = en_18.CLIENT_NAME;
                    ID_18 = en_18.ID;
                }
                
            }
            ViewBag.FName = fName;
            ViewBag.FID = fID;

            ViewBag.SName = SName;
            ViewBag.SID = SID;

            ViewBag.TName = TName;
            ViewBag.TID = TID;

           

            ViewBag.Name_7 = Name_7;
            ViewBag.ID_7 = ID_7;

            ViewBag.Name_8 = Name_8;
            ViewBag.ID_8 = ID_8;

            


            ViewBag.Name_11 = Name_11;
            ViewBag.ID_11 = ID_11;

            ViewBag.Name_12 = Name_12;
            ViewBag.ID_12 = ID_12;

           

            ViewBag.Name_14 = Name_14;
            ViewBag.ID_14 = ID_14;

            

            ViewBag.Name_18 = Name_18;
            ViewBag.ID_18 = ID_18;

           
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
          

           

            var Name_7 = "";
            var ID_7 = "";

            var Name_8 = "";
            var ID_8 = "";

          

            var Name_11 = "";
            var ID_11 = "";

            var Name_12 = "";
            var ID_12 = "";

           

            var Name_14 = "";
            var ID_14 = "";

           

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
                DEPT_TYPE_ID = "SCM00340002",
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
                
                var en_14 = list_Entity.Where(p => p.IS_COMPRESS == 14).FirstOrDefault();
                if (en_14 != null)
                {
                    Name_14 = en_14.CLIENT_NAME;
                    ID_14 = en_14.ID;
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

           

            ViewBag.Name_7 = Name_7;
            ViewBag.ID_7 = ID_7;

            ViewBag.Name_8 = Name_8;
            ViewBag.ID_8 = ID_8;

           



            ViewBag.Name_11 = Name_11;
            ViewBag.ID_11 = ID_11;

            ViewBag.Name_12 = Name_12;
            ViewBag.ID_12 = ID_12;

            

            ViewBag.Name_14 = Name_14;
            ViewBag.ID_14 = ID_14;

            
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

            if (TryUpdateModel<EntityObject_MDM_D_DEPT>(curObj, from))
            {
                var hidden_ID = from["Hidden19"];
                if (!string.IsNullOrEmpty(hidden_ID))
                {
                    EntityObject_COM_FILE file = new EntityObject_COM_FILE();
                    file.ID = hidden_ID;

                    if (BizLogicObject_COM_FILE.Proxy.Get(file) != null)
                    {
                        if ((curObj.CONTRACT_START == null || curObj.CONTRACT_END == null))
                        {
                            return Json(new
                            {
                                Msg = "F:创建失败，采购合同有效期未填写完整！",
                                BackValue = ""
                            }, "text/html");
                        }
                        else if (curObj.CONTRACT_START >= curObj.CONTRACT_END)
                        {
                            return Json(new
                            {
                                Msg = "F:创建失败，采购合同有效期填写错误，结束日期必须大于开始日期！",
                                BackValue = ""
                            }, "text/html");
                        }
                        else if (curObj.CONTRACT_END <= System.DateTime.Now)
                        {
                            return Json(new
                            {
                                Msg = "F:创建失败，采购合同有效期填写错误，结束日期必须大于当前日期！",
                                BackValue = ""
                            }, "text/html");
                        }
                    }
                }

                var msg = BizLogicObject_MDM_D_DEPT.Proxy.Update(curObj);
                if (msg.Succeed)
                {
                    try //上传附件出现问题 
                    {
                        var hide_BANK_NAME = from["hide_BANK_NAME"];//工商营业执照 ID

                        var hide_BANK_ADDRESS = from["hide_BANK_ADDRESS"];//组织机构代码
                        var hide_BANK_NUMBER = from["hide_BANK_NUMBER"];//税务登记证


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

                        for (int k = 1; k <= 19; k++)
                        {
                            var hid_ID = from["Hidden" + k.ToString()];
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
                            item.REF_TAB_ID = curObj.ID;
                        }

                        BizLogicObject_COM_FILE.Proxy.BatchUpdate(list_file.ToArray());

                    }
                    catch
                    {

                    }

                    return Json(new
                    {
                        Msg = "S:创建成功",
                        BackValue = ""
                    }, "text/html");
                }
                else
                {

                    return Json(new
                    {
                        Msg = "F:创建失败，请核对输入的数据的格式",
                        BackValue = ""
                    }, "text/html");
                }
            }else
            {
                return Json(new
                {
                    Msg = "F:创建失败，请核对输入的数据的格式",
                    BackValue = ""
                }, "text/html");
            }
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
    }
}
