using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBoilerplate.App_Start
{
    public class ControllerConfig
    {
        public static void RegisterDependencies()
        {
            var container = new UnityContainer();
            container.AddNewExtension<UnityDepenencyExtension>();

            var controllerFactory = new UnityControllerFactory(container);

            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}