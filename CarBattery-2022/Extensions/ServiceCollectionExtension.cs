namespace CarBattery_2022.Extensions
{
    //using CarBattery_2022.Core.Services;
    using CarBattery_2022.Core.Contracts;
    using CarBattery_2022.Infrastructure.Data;
    using CarBattery_2022.Infrastructure.Data.Repositories;
    using Microsoft.EntityFrameworkCore;
    using CarBattery_2022.Core.Service;

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
