using System.Data;
using Npgsql;
using PetFamily.Application.Interfaces.Database;

namespace PetFamily.Infrastructure;

public class SqlConnectionFactory(string stringConnection) : ISqlConnectionFactory
{
    public IDbConnection GetConnection() =>
        new NpgsqlConnection(stringConnection);
}