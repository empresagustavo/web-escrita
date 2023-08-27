using Escrita.Api.Server.Configurations.Migrations;
using Escrita.Api.Server.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escrita.Api.Server.Configurations.Tenant
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ITenantProvider tenantProvider, IMigrationss migationss)
        {
            var tenant = httpContext.Request.Headers.FirstOrDefault(x => x.Key == "");
            var customer = tenantProvider.GetCurrentTenant("");

            if (customer != null)
            {
                using (var scope = httpContext.RequestServices.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<EsctritaContext>();

                    var migrationsExecute = dbContext
                        .Database
                        .GetMigrations()
                        .Where(migration => !migration.Contains("EscritaDbConfiguration"));

                    await migationss.ApplyMigrationsAsync(customer.ConnectionString, scope, migrationsExecute);
                    //foreach (var migration in migrationsExecute)
                    //{
                    //    await migrator.MigrateAsync(migration);
                    //}
                }
            }

            await _next(httpContext);
        }
    }
}
