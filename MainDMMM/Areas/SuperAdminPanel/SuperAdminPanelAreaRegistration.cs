using System.Web.Mvc;

namespace MainDMMM.Areas.SuperAdminPanel
{
    public class SuperAdminPanelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SuperAdminPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SuperAdminPanel_default",
                "SuperAdminPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}