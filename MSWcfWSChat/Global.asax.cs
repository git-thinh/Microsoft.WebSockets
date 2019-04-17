using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.ServiceModel.Activation;
using Microsoft.ServiceModel.WebSockets;

namespace MSWcfWSChat
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute(
                "Echo", new MyWebSocketServiceFactory(), typeof(EchoWSService)));
        }
    }
}