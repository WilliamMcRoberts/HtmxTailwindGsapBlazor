using HtmxTailwindGsapBlazor.Data;

namespace HtmxTailwindGsapBlazor.Repositories
{
    public interface IApplicationUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetApplicationUsers();
    }
}