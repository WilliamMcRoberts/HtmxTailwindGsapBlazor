using HtmxTailwindGsapBlazor.Repositories;

namespace HtmxTailwindGsapBlazor.Endpoints.api;

public static class ApplicationUserApi
{
    public static void ConfigureApplicationUserApi(this WebApplication app)
    {
        app.MapGet("/applicationUsers", GetApplicationUsers);
    }

    private static async Task<IResult> GetApplicationUsers(IApplicationUserRepository userRepo)
    {
        try
        {
            var appUsers = await userRepo.GetApplicationUsers();
            return Results.Ok(appUsers);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
