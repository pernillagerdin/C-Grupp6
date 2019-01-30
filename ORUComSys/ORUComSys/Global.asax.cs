using Datalayer.Repositories;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ORUComSys {
    public class MvcApplication : HttpApplication {
        protected void Application_Start() {
            Database.SetInitializer(new ApplicationDbContextInitializer());
            // GlobalConfiguration.Configure(WebApiConfig.Register); // Enable this to make WebApi work.

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
