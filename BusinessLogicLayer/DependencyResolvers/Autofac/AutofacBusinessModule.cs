using Autofac;
using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Module = Autofac.Module;

namespace BusinessLogicLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
         var assembly = Assembly.GetExecutingAssembly();
         
         builder.RegisterAssemblyTypes(assembly)
             .AsImplementedInterfaces()
             .SingleInstance();
          // builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<IHtt>

        }
        public class MicrosoftBusinessModule
        {
            public void Load(IServiceCollection service)
            {
                service.AddSingleton<IAuthService, AuthManager>();
                service.AddSingleton<IEmployeeService, EmployeeManager>();
            }
        }
    }
}
