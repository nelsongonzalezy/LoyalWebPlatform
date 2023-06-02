using core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace core
{
    public static class Core
    {
        public static IServiceCollection InitializerCore(this IServiceCollection services) =>
           services.AddScoped<ILogin, LoginService>()
                   .AddScoped<IClaimsServ, ClaimsService>();
                //.AddScoped<IHttpServicesAuthorized, HttpServices>()
                //.AddScoped<IHttpServicesUnAuthorized, HttpServices>();
       

    }
}