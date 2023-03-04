using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WatchTowerWebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["quantity1"] = 0;
            Application["quantity2"] = 0;
            Application["quantity3"] = 0;
            Application["total"] = 0;
            Application["subtotal1"] = 0;
            Application["subtotal2"] = 0;
            Application["subtotal3"] = 0;
            Application["grandTotal"] = 7;
        }
    }
}