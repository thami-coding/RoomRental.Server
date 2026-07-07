using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi;
using NLog;
using Repository;
using RoomRental.Presentation.ActionFilters;
using RoomRental.Server;
using RoomRental.Server.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var licenseKey = File.Exists("/run/secrets/automapper_license")
    ? File.ReadAllText("/run/secrets/automapper_license").Trim()
    : builder.Configuration["AutoMapper:LicenseKey"];

LogManager.Setup()
    .LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureVersioning();
builder.Services.ConfigureSwagger();
builder.Services.AddScoped<ValidationFilterAttribute>();
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
    cfg.LicenseKey = licenseKey;
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

}

// Configure the HTTP request pipeline.
app.UseSwagger();

//app.UseSwaggerUI(s =>
//{
//    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Room Rental API v1");
//    //s.SwaggerEndpoint("/swagger/v2/swagger.json", "Room Rental API v2");
//});
app.MapScalarApiReference(options=>{
    options.OpenApiRoutePattern = "/swagger/{documentName}/swagger.json";
});

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

if (Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true")
{
    app.MigrateDatabase();
}

app.Run();

NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() =>
    new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson()
    .Services.BuildServiceProvider()
    .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
    .OfType<NewtonsoftJsonPatchInputFormatter>().First();