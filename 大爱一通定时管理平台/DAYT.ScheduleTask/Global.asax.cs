using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DAYT.ScheduleTask
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            TaskManager.Instance.Initialize();
            TaskManager.Instance.Start();
        }
    }
}
