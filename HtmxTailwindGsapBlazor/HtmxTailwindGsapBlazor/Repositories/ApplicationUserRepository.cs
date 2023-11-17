using HtmxTailwindGsapBlazor.Data;
using HtmxTailwindGsapBlazor.DataAccess;

namespace HtmxTailwindGsapBlazor.Repositories;

public class ApplicationUserRepository(ISqlConnection db) : IApplicationUserRepository
{
    private readonly ISqlConnection _db = db;

    public Task<IEnumerable<ApplicationUser>> GetApplicationUsers() =>
        _db.LoadData<ApplicationUser, dynamic>("SELECT * FROM AspNetUsers", new { });
}
