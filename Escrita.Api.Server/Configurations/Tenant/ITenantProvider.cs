using Escrita.Api.Server.Entities;

namespace Escrita.Api.Server.Configurations.Tenant
{
    public interface ITenantProvider
    {
        MonthlyCustomer GetCurrentTenant(string tenant);
    }
}
