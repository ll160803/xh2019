using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using System.Drawing;
using System;
using System.Drawing.Imaging;
using Models;
using System.Text.RegularExpressions;
using System.Collections;
using System.Configuration;
using Newtonsoft.Json;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.App.Codes;

namespace Ipedf.App.Controllers
{
    /// <summary>
    /// 用户账户信息
    /// </summary>
    [HandleError]
    public class AccountController : BaseController
    {


        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            return View();
        }






        /// <summary>
        /// 点击 登录系统 后返回
        /// </summary>
        /// <param name="model">登录信息</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(LogOnModel model)
        {
            #region 登陆验证   正式环境


            //if (Session["__VCode"] == null || (Session["__VCode"] != null && model.ValidateCode != Session["__VCode"].ToString()))
            //{
            //    ModelState.AddModelError("ValidateCode", "验证码错误！"); //return "";
            //    return View();
            //}

            if (ModelState.IsValid)
            {
                BizLogicMsg retMsg = SystemLogic.Proxy.Login(model.PersonName, model.Password);
                if (retMsg.Succeed)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("PersonName", "用户名或者密码出错。");
            return View();
            #endregion
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOff()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Index", "Account");

        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePassword()
        {
            string currentPerson = GetCurrentPerson();
            ViewBag.PersonNamea = currentPerson;
            if (string.IsNullOrWhiteSpace(currentPerson))
            {
                ModelState.AddModelError("", "对不起，请重新登陆");
            }
            return View();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="model">修改密码的模型</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            string currentPerson = GetCurrentPerson();
            ViewBag.PersonNamea = currentPerson;
            if (string.IsNullOrWhiteSpace(currentPerson))
            {
                ModelState.AddModelError("", "对不起，请重新登陆");
                return View();
            }
            if (ModelState.IsValid)
            {
                if (!checkPass(model.NewPassword))
                {
                    ModelState.AddModelError("", "密码必须包含小写或大写字母,必须包含数字，必须含有特殊字符（@，$,#等），8位以上！");
                    return View();
                }

                //IAccountBLL accountBLL = new AccountBLL();
                BizLogicMsg msg = SystemLogic.Proxy.ModifyPassword(System.Web.HttpContext.Current.Request, SystemLogic.Proxy.CurrentUser.ACCOUNT, model.OldPassword, model.NewPassword);
                if (msg.Succeed)
                {
                    ModelState.AddModelError("", "密码修改成功！");
                    return View();
                }
                else
                {
                    ModelState.AddModelError("", msg.Message);
                    return View();
                }
            }
            ModelState.AddModelError("", "密码修改失败，请核实数据");
            return View();
        }
        public bool checkPass(string password)
        {
            var regex = new Regex(@"
(?=.*[0-9])                     #必须包含数字
(?=.*[a-zA-Z])                  #必须包含小写或大写字母
(?=([\x21-\x7e]+)[^a-zA-Z0-9])  #必须包含特殊符号
.{8,30}                         #至少8个字符，最多30个字符
", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            if (!regex.IsMatch(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult NotFound()
        {
            return View();
        }

        //[SupportFilter]
        //public JsonResult GetInfo()
        //{
        //    var current = GetCurrentPersonObj();

        //    return Json(new
        //    {
        //        PersonEntity_Id = current.Id,
        //        DepartmentEntity_Id = current.SysDepartmentId.Value
        //    }, JsonRequestBehavior.AllowGet);
        //}

        public void ValidateCode()
        {
            // 在此处放置用户代码以初始化页面
            string vnum;
            vnum = GetByRndNum(4);
            Response.ClearContent(); //需要输出图象信息 要修改HTTP头 
            Response.ContentType = "image/jpeg";

            CreateValidateCode(vnum);

        }

        private void CreateValidateCode(string vnum)
        {
            Bitmap Img = null;
            Graphics g = null;
            Random random = new Random();
            int gheight = vnum.Length * 15;
            Img = new Bitmap(gheight, 26);
            g = Graphics.FromImage(Img);
            Font f = new Font("微软雅黑", 16, FontStyle.Bold);
            //Font f = new Font("宋体", 9, FontStyle.Bold);

            g.Clear(Color.White);//设定背景色
            Pen blackPen = new Pen(ColorTranslator.FromHtml("#e1e8f3"), 18);

            for (int i = 0; i < 128; i++)// 随机产生干扰线，使图象中的认证码不易被其它程序探测到
            {
                int x = random.Next(gheight);
                int y = random.Next(20);
                int xl = random.Next(6);
                int yl = random.Next(2);
                g.DrawLine(blackPen, x, y, x + xl, y + yl);
            }

            SolidBrush s = new SolidBrush(ColorTranslator.FromHtml("#411464"));
            g.DrawString(vnum, f, s, 1, 1);

            //画边框
            blackPen.Width = 1;
            g.DrawRectangle(blackPen, 0, 0, Img.Width - 1, Img.Height - 1);
            Img.Save(Response.OutputStream, ImageFormat.Jpeg);
            s.Dispose();
            f.Dispose();
            blackPen.Dispose();
            g.Dispose();
            Img.Dispose();

            //Response.End();
        }

        //-----------------给定范围获得随机颜色
        Color GetByRandColor(int fc, int bc)
        {
            Random random = new Random();

            if (fc > 255)
                fc = 255;
            if (bc > 255)
                bc = 255;
            int r = fc + random.Next(bc - fc);
            int g = fc + random.Next(bc - fc);
            int b = fc + random.Next(bc - bc);
            Color rs = Color.FromArgb(r, g, b);
            return rs;
        }

        //取随机产生的认证码(数字)
        public string GetByRndNum(int VcodeNum)
        {

            string VNum = "";

            Random rand = new Random();

            for (int i = 0; i < VcodeNum; i++)
            {
                VNum += VcArray[rand.Next(0, 9)];
            }
            Session["__VCode"] = VNum;
            return VNum;
        }
        private static readonly string[] VcArray = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    }
    public class LoginUser
    {
        public string username { get; set; }
    }
}

