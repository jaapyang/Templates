using AR.WCFServer.Authorization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Activation;
using System.Web.Routing;

namespace AR.WCFServer
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {       
        public static void RegisterRoutes()
        {
            var securewebServiceHostFactory = new SecureWebServiceHostFactory();
            RouteTable.Routes.Add(new ServiceRoute("UserSvc", securewebServiceHostFactory, typeof(UserSvc)));            
        }

        protected void Application_Start()
        {
            RegisterRoutes();          
        }
    }
}