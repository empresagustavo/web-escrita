namespace Escrita.Api.Server.Configurations.Migrations
{
    public interface IMigrationss
    {
        Task ApplyMigrationsAsync(string connectionString, IServiceScope scope, IEnumerable<string> migrations);
    }
}
