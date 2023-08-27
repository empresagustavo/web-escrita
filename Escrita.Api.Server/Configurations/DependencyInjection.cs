using Escrita.Api.Server.Configurations.Migrations;
using Escrita.Api.Server.Configurations.Tenant;

namespace Escrita.Api.Server.Configurations
{
    public static class DependencyInjection
    {
        public static void InjectScoped(this IServiceCollection services)
        {
            services.AddScoped<ITenantProvider, HttpHeaderTenantProvider>();
            services.AddScoped<IMigrationss, Migrationss>();
           

        }
    }
}
