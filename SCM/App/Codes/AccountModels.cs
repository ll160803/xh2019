using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

using System.Globalization;
using System.Runtime.Serialization;


namespace Models
{

    /// <summary>
    /// 当前登陆者
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// 获取当前登陆者
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentPerson()
        {
            //Account account = GetCurrentAccount();
            //if (account != null && !string.IsNullOrWhiteSpace(account.PersonName))
            //{
            //    return account.PersonName;
            //}
            return string.Empty;
        }
        ///// <summary>
        ///// 获取当前登陆者的账户信息
        ///// </summary>
        ///// <returns>账户信息</returns>
        //public static Account GetCurrentAccount()
        //{
        //    if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Session != null && System.Web.HttpContext.Current.Session["account"] != null)
        //    {
        //        return (Account)System.Web.HttpContext.Current.Session["account"];

        //    }
        //    return null;
        //}
    }
    #region 模型

    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "请填写当前密码")]
        [DataType(DataType.Password)]
        [DisplayName("当前密码")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "请填写新密码")]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 2)]
        [DataType(DataType.Password)]
        [DisplayName("新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("确认密码")]
        [Compare("NewPassword", ErrorMessage = "两次密码不一致")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required(ErrorMessage = "请填写用户名")]
        [DisplayName("用户名")]
        public string PersonName { get; set; }

        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 2)]
        [Required(ErrorMessage = "请填写密码")]
        [DataType(DataType.Password)]
        [DisplayName("密码")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "请填写验证码")]
        [DisplayName("验证码")]
        public string ValidateCode { get; set; }

        [DisplayName("记住我?")]
        public bool RememberMe { get; set; }
    }
    #endregion

}

