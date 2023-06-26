using DataAccess.Interfaces;
using DataAccess.ObjectAccess;
using DataAccess.SqlAccess;

namespace Api.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static IServiceCollection AddDataBaseServices(this IServiceCollection services)
        {
            services.AddTransient<ISqlAccess, SqlAccess>();
            services.AddTransient<IUserAccess, UserAccess>();
            services.AddTransient<IAffiliateProgramAccess, AffiliateProgramAccess>();
            return services;
        }
    }
}
