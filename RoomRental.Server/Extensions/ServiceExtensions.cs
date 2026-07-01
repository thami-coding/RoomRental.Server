using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

using Contracts;
using LoggerService;
using Repository;
using Service;
using Service.Contracts;

namespace RoomRental.Server.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
      services.AddDbContext<RepositoryContext>(opts =>
      opts.UseNpgsql(configuration.GetConnectionString("postgresConnection"),
          b => b.MigrationsAssembly("RoomRental.Server")).UseSnakeCaseNamingConvention());

    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();

    public static void ConfigureVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(opt =>
        {
            opt.ReportApiVersions = true;
            opt.AssumeDefaultVersionWhenUnspecified = true;
            opt.DefaultApiVersion = new ApiVersion(1, 0);
            opt.ApiVersionReader = new HeaderApiVersionReader("api-version");
        }).AddApiExplorer(opt =>
        {
            opt.GroupNameFormat = "'v'VVV";
        });
    }

    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Room Rental API",
                Version = "v1",
                Description = "Room Rental API by Thami",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Thami Gumede",
                    Email = "thamig125@gmail.com",
                    Url = new Uri("https://www.linkedin.com/in/thamsanqa-gumede-5aa461319/")
                }
            });
            //s.SwaggerDoc("v2", new OpenApiInfo
            //{
            //    Title = "Room Rental API",
            //    Version = "v2"
            //});
            var xmlFile = $"{typeof(Presentation.AssemblyReference).Assembly.GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            s.IncludeXmlComments(xmlPath);
        });
    }

}
