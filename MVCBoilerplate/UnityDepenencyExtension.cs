using Microsoft.Practices.Unity;
using MVCBoilerplate.Models;
using MVCBoilerplate.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCBoilerplate
{
    public class UnityDepenencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            Container.RegisterType<INewsRepository, SqlNewsRepository>(new PerResolveLifetimeManager(), new InjectionConstructor(connectionString));
        }
    }
}