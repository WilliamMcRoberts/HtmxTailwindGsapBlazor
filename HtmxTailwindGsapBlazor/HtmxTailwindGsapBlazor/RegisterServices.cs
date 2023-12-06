using HtmxTailwindGsapBlazor.Components.Account;
using HtmxTailwindGsapBlazor.Data;
using HtmxTailwindGsapBlazor.DataAccess;
using HtmxTailwindGsapBlazor.Processors;
using HtmxTailwindGsapBlazor.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HtmxTailwindGsapBlazor;

public static class RegisterServices
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {

        builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents().AddHubOptions(options =>
        {
            options.MaximumReceiveMessageSize = 4000000000;
        })
        .AddInteractiveWebAssemblyComponents();

        builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", policy =>
        {
            policy.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader();
        }));

        builder.Services.Configure<FormOptions>(options =>
        {

            options.ValueLengthLimit = int.MaxValue;
            options.MultipartBodyLengthLimit = int.MaxValue;
            options.MultipartHeadersLengthLimit = int.MaxValue;
        });

        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddScoped<IdentityUserAccessor>();
        builder.Services.AddScoped<IdentityRedirectManager>();
        builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();

        builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddIdentityCookies();

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
        builder.Services.AddSingleton<IRender, Render>();
        builder.Services.AddTransient<IApplicationUserRepository, ApplicationUserRepository>();
        builder.Services.AddSingleton<ISqlConnection, SqlConnection>();
        builder.Services.AddScoped<IVideoFileProcessor, VideoFileProcessor>();


    }
}
