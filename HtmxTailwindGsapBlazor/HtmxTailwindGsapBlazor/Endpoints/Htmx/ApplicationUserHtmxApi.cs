using HtmxTailwindGsapBlazor.Components.Htmx;
using HtmxTailwindGsapBlazor.Processors;
using HtmxTailwindGsapBlazor.Repositories;

namespace HtmxTailwindGsapBlazor.Endpoints.Htmx;

public static class ApplicationUserHtmxApi
{
    public static void ConfigureApplicationUserHtmxApi(this WebApplication app)
    {
        app.MapGet("/htmx/applicationUsers", GetApplicationUsers);
    }

    private static async Task<IResult> GetApplicationUsers(
        IRender render, IApplicationUserRepository userRepo)
    {
        var appUsers = await userRepo.GetApplicationUsers();
        return appUsers.Match<IResult>(
                 users => render.Component<AppUser>(new { UserList = users }),
                 error => Results.Problem(error.Message));
    }
}
