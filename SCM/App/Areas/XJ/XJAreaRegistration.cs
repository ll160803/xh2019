using System.Web.Mvc;

namespace Ipedf.App.Areas.XJ
{
    public class XJAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "XJ";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "XJ_default",
                "XJ/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
