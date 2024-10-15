using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shoc.ApiCore;
using Shoc.ApiCore.Access;
using Shoc.ApiCore.Auth;
using Shoc.ApiCore.DataProtection;
using Shoc.ApiCore.Discovery;
using Shoc.ApiCore.ObjectAccess;
using Shoc.Package.Config;
using Shoc.Package.Services;

// start building web application
var builder = WebApplication.CreateBuilder(args);

// add environment variables
builder.Configuration.AddEnvironmentVariables();

// register services
builder.Services.AddDiscovery(builder.Configuration);
builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddSelf(builder.Configuration);
builder.Services.AddPersistenceDataProtection();
builder.Services.AddAuthenticationMiddleware(builder.Configuration);
builder.Services.AddAccessAuthorization();
builder.Services.AddAuthenticationClient(builder.Configuration);
builder.Services.AddGrpcClients();
builder.Services.AddObjectAccessEssentials();
builder.Services.AddSingleton<CommandRunner>();
builder.Services.AddSingleton<ContainerService>();
builder.Services.AddSingleton<RegistryHandlerService>();
builder.Services.AddSingleton<ValidationService>();
builder.Services.AddSingleton<SchemaProvider>();
builder.Services.AddSingleton<TemplateProvider>();
builder.Services.AddSingleton<TemplateBuildSpecGenerator>();
builder.Services.AddSingleton<BuildTaskService>();
builder.Services.AddSingleton<WorkspaceBuildTaskService>();
builder.Services.AddSingleton<PackageService>();
builder.Services.AddSingleton<WorkspacePackageService>();
builder.Services.AddAnyOriginCors(ApiDefaults.DEFAULT_CORS);
builder.Services.AddControllers();

// build the application
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();
app.UseAuthentication();
app.UseAccessEnrichment();
app.UseAuthorization();
app.MapControllers();
app.UseCors(ApiDefaults.DEFAULT_CORS);
app.Run();