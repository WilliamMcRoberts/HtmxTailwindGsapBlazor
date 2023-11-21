using HtmxTailwindGsapBlazor.Data;
using LanguageExt.Common;

namespace HtmxTailwindGsapBlazor.Repositories
{
    public interface IApplicationUserRepository
    {
        ValueTask<Result<IEnumerable<ApplicationUser>>> GetApplicationUsers();
    }
}