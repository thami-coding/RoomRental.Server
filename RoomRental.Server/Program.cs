using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using NLog;
using Repository;
using RoomRental.Server;
using RoomRental.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup()
    .LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
    //cfg.LicenseKey = builder.Configuration["AutoMapper:LicenseKey"]; local configuration
    cfg.LicenseKey = File.ReadAllText("/run/secrets/automapper_license").Trim(); //docker configuration
});

builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
    config.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
}).AddApplicationPart(typeof(RoomRental.Presentation.AssemblyReference).Assembly);

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigurationExceptionHandler(logger);

if (app.Environment.IsProduction())
{
    app.UseHsts();
    app.UseHttpsRedirection();
}

// Configure the HTTP request pipeline.

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase().Run();
NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() =>
    new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson()
    .Services.BuildServiceProvider()
    .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
    .OfType<NewtonsoftJsonPatchInputFormatter>().First();