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

    private static async Task<IResult> GetApplicationUsers(IRender render, IApplicationUserRepository userRepo)
    {
        try
        {
            var appUsers = await userRepo.GetApplicationUsers();
            return render.Component<AppUser>(new { UserList = appUsers });
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
