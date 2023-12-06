using HtmxTailwindGsapBlazor;
using HtmxTailwindGsapBlazor.Client.Pages;
using HtmxTailwindGsapBlazor.Components;
using HtmxTailwindGsapBlazor.Endpoints.api;
using HtmxTailwindGsapBlazor.Endpoints.Htmx;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}
app.UseWhen(context => context.Request.Path.StartsWithSegments("/"), appBuilder =>
{
    appBuilder.UseCors("CorsPolicy");

    var provider = new FileExtensionContentTypeProvider();

    provider.Mappings[".m3u8"] = "application/x-mpegURL";
    provider.Mappings[".ts"] = "video/MP2T";

    //appBuilder.UseStaticFiles(new StaticFileOptions
    //{
    //    ContentTypeProvider = provider,
    //    FileProvider = new PhysicalFileProvider("C:\\VideoStorage"),
    //    RequestPath = "/VideoStorage"
    //});
});

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.ConfigureApplicationUserApi();
app.ConfigureApplicationUserHtmxApi();

app.Run();
