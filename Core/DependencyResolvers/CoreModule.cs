using System;
using System.Collections.Generic;
using Autofac;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Core.EntityFramework;
using Core.DataAccess;

namespace Core.DependencyResolvers
{
    public class CoreModule:Module
    {
        public class AutofacCoreModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                // Core Layer Dependencies
                builder.RegisterGeneric(typeof(EfEntityRepositoryBase<,>)).As(typeof(IEntityRepository<>));
               // builder.RegisterGeneric(typeof(EmployeeManager<,>)).As(typeof(IEmployeeService<>));
              // builder.RegisterGeneric(typeof(EfQueryableRepositoryBase<>)).As(typeof(IQueryableRepository<>));
            }
        }
    }
}
