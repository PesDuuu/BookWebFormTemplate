using BookWebForm.App_Code.Interface;
using BookWebForm.App_Code.Service;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Lifetime;

namespace BookWebForm
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterUnity();
        }

        private void RegisterUnity()
        {
            var container = new UnityContainer();

            // Register types
            container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            // Optionally register other dependencies

            // Store the container in the application state
            Application["UnityContainer"] = container;
        }

        public IUnityContainer GetUnityContainer()
        {
            return (IUnityContainer)Application["UnityContainer"];
        }
    }
}