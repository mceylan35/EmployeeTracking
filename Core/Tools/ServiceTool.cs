using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools
{
    public static class ServiceTool
    {
        private static IServiceProvider _serviceProvider { get; set; }
        public static IServiceCollection Create(IServiceCollection service)
        {
            _serviceProvider = service.BuildServiceProvider();
            return service;
        }
        public static T Resolve<T>() => _serviceProvider.GetService<T>();
    }
}
