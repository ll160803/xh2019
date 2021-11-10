﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Domain.Entity.SystemSecurity;
using NFine.Application.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFine.Domain.Entity.SystemManage;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Application;

namespace NFine.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public virtual ActionResult Index()
        {
            //System.Net.NetworkCredential c = new System.Net.NetworkCredential("com_wsjk", "654321");
            //SapHrm.ZWS_KQRYXX gf = new SapHrm.ZWS_KQRYXX();
            //gf.Credentials = c;
            //SapHrm.Zhr00SKqryxx[] ty=new SapHrm.Zhr00SKqryxx[] { };
            //var ry = gf.Zhr00FmKqryxx(new SapHrm.Zhr00FmKqryxx {  TRyxx=ty});
            //ViewBag.Name = ry.TRyxx.FirstOrDefault().Name1;
            var test = string.Format("{0:E2}", 1);
            return View();
        }
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }
        [HttpGet]
        public ActionResult OutLogin()
        {
            try
            {
                new LogApp().WriteDbLog(new LogEntity
                {
                    F_ModuleName = "系统登录",
                    F_Type = DbLogType.Exit.ToString(),
                    F_Account = OperatorProvider.Provider.GetCurrent().UserCode,
                    F_NickName = OperatorProvider.Provider.GetCurrent().UserName,
                    F_Result = true,
                    F_Description = "安全退出系统",
                });
                Session.Abandon();
                Session.Clear();
                OperatorProvider.Provider.RemoveCurrent();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult CheckLogin(string username, string password, string code)
        {
            LogEntity logEntity = new LogEntity();
            logEntity.F_ModuleName = "系统登录";
            logEntity.F_Type = DbLogType.Login.ToString();
            try
            {
                //暂时注销验证码
                //if (Session["nfine_session_verifycode"].IsEmpty() || Md5.md5(code.ToLower(), 16) != Session["nfine_session_verifycode"].ToString())
                //{
                //    throw new Exception("验证码错误，请重新输入");
                //}

                UserEntity userEntity = new UserApp().CheckLogin(username, password);
                if (userEntity != null)
                {
                    OperatorModel operatorModel = new OperatorModel();
                    operatorModel.UserId = userEntity.F_Id;
                    operatorModel.UserCode = userEntity.F_Account;
                    operatorModel.UserName = userEntity.F_RealName;
                    operatorModel.CompanyId = userEntity.F_OrganizeId;
                    operatorModel.DepartmentId = userEntity.F_DepartmentId;
                    operatorModel.RoleId = userEntity.F_RoleId;
                    operatorModel.SubmitType = userEntity.F_WeChat ?? "";
                    operatorModel.AskTypeIds = userEntity.F_Description ?? "";
                    // operatorModel.LoginIPAddress = Net.Ip;
                    //operatorModel.LoginIPAddressName = Net.GetLocation(operatorModel.LoginIPAddress);
                    operatorModel.LoginTime = DateTime.Now;
                    operatorModel.LoginToken = DESEncrypt.Encrypt(Guid.NewGuid().ToString());
                    operatorModel.Is_Doctor = GetIs_Doctor(userEntity.F_DutyId);// (userEntity.F_DutyId == "23ED024E-0AAA-4C8D-9216-D1AB93348D26" ? "1" : "2");//医生1 护士2
                    if (userEntity.F_Account == "admin")
                    {
                        operatorModel.IsSystem = true;
                    }
                    else
                    {
                        operatorModel.IsSystem = false;
                    }
                    OperatorProvider.Provider.AddCurrent(operatorModel);
                    logEntity.F_Account = userEntity.F_Account;
                    logEntity.F_NickName = userEntity.F_RealName;
                    logEntity.F_Result = true;
                    logEntity.F_Description = "登录成功";
                    new LogApp().WriteDbLog(logEntity);
                }
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
            }
            catch (Exception ex)
            {
                logEntity.F_Account = username;
                logEntity.F_NickName = username;
                logEntity.F_Result = false;
                logEntity.F_Description = "登录失败，" + ex.Message;
                new LogApp().WriteDbLog(logEntity);
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message }.ToJson());
            }
        }

        private string GetIs_Doctor(string dutyId)
        {
            if (dutyId == "23ED024E-0AAA-4C8D-9216-D1AB93348D26")
            {
                return "1";//医生 
            }
            if (dutyId == "0b847d16-7c22-45c6-b228-0b214a28ad39")
            {
                return "2";//护士 
            }
            return "3";//全部
        }
    }
}
