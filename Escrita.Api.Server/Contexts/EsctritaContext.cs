using Escrita.Api.Server.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Escrita.Api.Server.Contexts
{
    public class EsctritaContext : DbContext
    {
        private readonly MonthlyCustomer _monthlyCustomer;
        public EsctritaContext(DbContextOptions<EsctritaContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("EscritaDbConfiguration");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.HasSequence<int>("TestTenant");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MonthlyCustomer> MonthlyCustomers { get; set; }
    }
}
