using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Tools;
using Core.Utilities.Exception;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.BusinessAutofac.Autofac
{
    public class SecureOperation : MethodInterceptors
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;
        public SecureOperation(string roles)
        {
            _roles = roles.Split(",");
            _httpContextAccessor = ServiceTool.Resolve<IHttpContextAccessor>();
        }
        protected override void OnBefore(IInvocation invocation)
        {
            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                throw new AuthException("AuthenticationDenied", "AuthenticationDeniedId");

            var roleClaim = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in roleClaim)
            {
                if (_roles.Contains(role))
                    return;
            }
            throw new AuthException("Authorizeation Denied","AuthorizeationDeniedId");

        }
    }
}
