
using System.Web.Mvc;
using Ipedf.Web.BizLogic;

namespace Models
{
    public class SupportFilter
    {
    }
    public class SupportFilterAttribute : ActionFilterAttribute
    {

        /// <summary>
        /// 当Action中标注了[SupportFilter]的时候会执行
        /// </summary>
        /// <param name="filterContext">请求上下文</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

    }
    public class GetUserSecurityContext : AuthorizeAttribute
    {
        //public static string LoginUrl = "http://" +
        //                               System.Web.HttpContext.Current.Request.ServerVariables["HTTP_HOST"].ToString(
        //                                   CultureInfo.InvariantCulture) + "/";
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string currentActionName = filterContext.ActionDescriptor.ActionName;
            string currentControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (currentControllerName == "Account" && currentActionName == "Index") return;
            if (currentControllerName == "Home" && currentActionName == "Register") return;
            if (currentControllerName == "Home" && currentActionName == "RegisterEdit") return;
            if (currentControllerName == "Home" && currentActionName == "FileDelete") return;
            if (currentControllerName == "Home" && currentActionName == "DownFile") return;
            if (currentControllerName.ToUpper()== "SAPDATA") return;//SAP页面 宫金辉
            if (currentControllerName == "Scm_Register" && currentActionName == "Register") return;
            if (currentControllerName == "Scm_Register" && currentActionName == "RegisterEdit") return;
            if (currentControllerName == "Scm_Register" && currentActionName == "FileDelete") return;
            if (currentControllerName == "Scm_Register" && currentActionName == "DownFile") return;
            if (currentControllerName == "Account" && currentActionName == "ValidateCode") return;

            if (SystemLogic.Proxy.CurrentUser == null)
            {
                var currRequest = filterContext.HttpContext.Request;
                var hostUrl = "http://" + currRequest.Url.Host;
                hostUrl += currRequest.Url.Port.ToString() == "80" ? "" : ":" + currRequest.Url.Port.ToString();
                // hostUrl += ":"+currRequest.Url.Port.ToString();
              //  hostUrl += currRequest.ApplicationPath;
                filterContext.HttpContext.Response.Write(" <script type='text/javascript'> window.top.location='" + hostUrl + "'; </script>");
                filterContext.Result = new EmptyResult();

                return;
                
            }
        }
    }
}
