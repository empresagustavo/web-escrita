using Escrita.Api.Server.Entities;
using Microsoft.AspNetCore.Components.Forms;

namespace Escrita.Api.Server.Configurations.Tenant
{
    public class HttpHeaderTenantProvider : ITenantProvider
    {
        public MonthlyCustomer GetCurrentTenant(string tenant)
        {
            string connectionBase =
                "Server=LAPTOP-GFPGVOU1\\SQLEXPRESS;DataBase=EscritaDbTENANT;User ID=MinhaEmpresa;Password=1996;TrustServerCertificate=True;"; ;
            var t1 = "C757EB94-BF69-4C0F-85C1-38269D492D78";
            var t2 = "8E09CB0D-E39B-4FE2-A84A-944C2A4D2B2C";

            switch (tenant)
            {
                case "C757EB94-BF69-4C0F-85C1-38269D492D78":
                    {
                        return new MonthlyCustomer 
                        {
                            Id = Guid.NewGuid(),
                            ConnectionString = connectionBase.Replace(
                                "TENANT",
                                t1.Replace("-", null)),
                        };
                    }
                
                case "8E09CB0D-E39B-4FE2-A84A-944C2A4D2B2C":
                    {
                        return new MonthlyCustomer 
                        {
                            Id = Guid.NewGuid(),
                            ConnectionString = connectionBase.Replace(
                                "TENANT",
                                t2.Replace("-", null)),
                        };
                    }

                default: { return null; }
            }
        }
    }
}
