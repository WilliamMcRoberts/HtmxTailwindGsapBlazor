using HtmxTailwindGsapBlazor.Repositories;

namespace HtmxTailwindGsapBlazor.Endpoints.api;

public static class ApplicationUserApi
{
    public static void ConfigureApplicationUserApi(this WebApplication app)
    {
        app.MapGet("/applicationUsers", GetApplicationUsers);
    }

    private static async ValueTask<IResult> GetApplicationUsers(IApplicationUserRepository userRepo)
    {
        var appUsers = await userRepo.GetApplicationUsers();
        return appUsers.Match<IResult>(
                 users => Results.Ok(users),
                 error => Results.Problem(error.Message));
    }
}
