using Npgsql;
using System.Data;

namespace ControleVendas.repositorio;
public class DbContext : IDisposable
{
    private readonly IDbConnection connection;

    public DbContext()
    {
        connection = new NpgsqlConnection(
            "Host=127.0.0.1;Port=5432;Username=postgres;Password=admin123;Database=empresax");
    }

    public IDbConnection GetConnection()
    {
        if (connection.State != ConnectionState.Open)
            connection.Open();

        return connection;
    }

    public void Dispose()
    {
        connection.Dispose();
    }
}
