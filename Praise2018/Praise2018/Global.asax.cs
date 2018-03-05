using Praise2018.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace Praise2018
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //告诉mvc使用自定义d类来创建控制器对象
            ControllerBuilder.Current.SetControllerFactory(new
                NinjectControllerFactory());
        }
    }
}
