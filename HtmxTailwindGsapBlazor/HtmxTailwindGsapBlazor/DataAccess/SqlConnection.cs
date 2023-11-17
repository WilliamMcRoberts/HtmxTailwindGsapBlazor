using Dapper;
using System.Data;

namespace HtmxTailwindGsapBlazor.DataAccess;

public class SqlConnection : ISqlConnection
{
    private readonly IConfiguration _configuration;

    public SqlConnection(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string sqlQuery, U parameters, string connectionId = "DefaultConnection")
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                       _configuration.GetConnectionString(connectionId));

        return await connection.QueryAsync<T>(sqlQuery, parameters);
    }

    public async Task SaveData<T>(
        string sqlQuery, T parameters, string connectionId = "DefaultConnection")
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                                  _configuration.GetConnectionString(connectionId));

        await connection.ExecuteAsync(sqlQuery, parameters);
    }
}
