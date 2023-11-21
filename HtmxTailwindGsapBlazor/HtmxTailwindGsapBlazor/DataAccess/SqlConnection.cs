using Dapper;
using LanguageExt.Common;
using System.Data;

namespace HtmxTailwindGsapBlazor.DataAccess;

public class SqlConnection(IConfiguration configuration) : ISqlConnection
{
    private readonly IConfiguration _configuration = configuration;

    public async Task<Result<IEnumerable<T>>> LoadData<T, U>(
        string sqlQuery, U parameters, string connectionId = "DefaultConnection")
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                       _configuration.GetConnectionString(connectionId));

        var results = await connection.QueryAsync<T>(sqlQuery, parameters);
        return results is null ?
            new(new Exception("No data was returned."))
            : new(results);
    }

    public async Task SaveData<T>(
        string sqlQuery, T parameters, string connectionId = "DefaultConnection")
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                                  _configuration.GetConnectionString(connectionId));

        await connection.ExecuteAsync(sqlQuery, parameters);
    }
}
