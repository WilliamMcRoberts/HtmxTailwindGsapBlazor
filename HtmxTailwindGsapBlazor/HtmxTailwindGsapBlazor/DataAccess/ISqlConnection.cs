
namespace HtmxTailwindGsapBlazor.DataAccess
{
    public interface ISqlConnection
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sqlQuery, U parameters, string connectionId = "DefaultConnection");
        Task SaveData<T>(string sqlQuery, T parameters, string connectionId = "DefaultConnection");
    }
}