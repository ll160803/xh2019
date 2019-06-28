using System.Web;
using System.Web.Mvc;
using Models;

namespace App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new GetUserSecurityContext());//检查SESSION过期问题
            filters.Add(new HandleErrorAttribute());
        }
    }
}