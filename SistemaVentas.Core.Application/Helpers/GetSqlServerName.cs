using Microsoft.Extensions.Configuration;

namespace SistemaVentas.Core.Application.Helpers
{
    public static class GetSqlServerName
    {
        public static string GetConnection(this IConfiguration config, string section)
        {
            var server = Environment.GetEnvironmentVariable("SQL_SERVER_NAME", EnvironmentVariableTarget.User);
            var connectionString = config.GetConnectionString(section)!;

            var connectionInPart = connectionString.Split('.');
            connectionInPart[0] += server;

            return string.Join("", connectionInPart);
        }
    }
}
