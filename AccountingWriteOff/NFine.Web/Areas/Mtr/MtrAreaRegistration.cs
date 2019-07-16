using System.Web.Mvc;

namespace NFine.Web.Areas.Mtr
{
    public class MtrAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mtr";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mtr_default",
                "Mtr/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
