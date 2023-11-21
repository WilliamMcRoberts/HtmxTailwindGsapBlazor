using LanguageExt.Common;

namespace HtmxTailwindGsapBlazor.DataAccess
{
    public interface ISqlConnection
    {
        Task<Result<IEnumerable<T>>> LoadData<T, U>(string sqlQuery, U parameters, string connectionId = "DefaultConnection");
        Task SaveData<T>(string sqlQuery, T parameters, string connectionId = "DefaultConnection");
    }
}