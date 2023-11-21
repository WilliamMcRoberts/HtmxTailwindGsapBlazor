using HtmxTailwindGsapBlazor.Data;
using HtmxTailwindGsapBlazor.DataAccess;
using LanguageExt.Common;

namespace HtmxTailwindGsapBlazor.Repositories;

public class ApplicationUserRepository(ISqlConnection db) : IApplicationUserRepository
{
    private readonly ISqlConnection _db = db;

    public async ValueTask<Result<IEnumerable<ApplicationUser>>> GetApplicationUsers() =>
       await _db.LoadData<ApplicationUser, dynamic>("SELECT * FROM AspNetUsers", new { });
}
