using Escrita.Api.Server.Contexts;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Escrita.Api.Server.Configurations.Migrations
{
    public class Migrationss : IMigrationss
    {
        private readonly EsctritaContext _contextFactory;

        public Migrationss(EsctritaContext contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task ApplyMigrationsAsync(string connectionString, IServiceScope scope, IEnumerable<string> migrations)
        {
            _contextFactory.Database.GetDbConnection().ConnectionString = connectionString;
            //_contextFactory.Database.OpenConnection();

            var migrator = scope.ServiceProvider.GetRequiredService<IMigrator>();

        }
    }
}
