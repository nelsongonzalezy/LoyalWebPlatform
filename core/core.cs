using core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace core
{
    public static class Core
    {
        public static IServiceCollection InitializerCore(this IServiceCollection services) =>

        services.AddScoped<ILogin, LoginService>()
                       .AddScoped<IClaimsServ, ClaimsService>()
                       .AddScoped<IProvider, ProviderService>()
                       .AddScoped<IClaimsReports, ClaimsReportsService>()
                       .AddScoped<IBoardService, BoardService>()
                       .AddScoped<ICountries, CountriesServices>()
                       .AddScoped<IMenu, MenuService>()
                       .AddScoped<IProduct, ProductService>()
                       .AddScoped<IDraft, DraftService>()
                       .AddScoped<IRequestMonitor, RequestMonitorService>()
                       .AddScoped<HttpClient>()
                       .AddScoped<HttpClientConfig>()
                       .AddScoped<IHttpServicesAuthorized, HttpServices>()
                       .AddScoped<IHttpServicesUnAuthorized, HttpServices>()
            


                       //.AddScoped<IHttpServicesAuthorized, HttpServices>()
                       //.AddScoped<IHttpServicesUnAuthorized, HttpServices>()
                        ;
    }
}