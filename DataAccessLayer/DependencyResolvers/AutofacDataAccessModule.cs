using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;
namespace DataAccessLayer.DependencyResolvers
{
    public class AutofacDataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly)
              .AsImplementedInterfaces()
              .SingleInstance();

            //builder.RegisterType<EfCountryDal>().As<ICountryDal>().SingleInstance();
            //builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

        }
    }
}
