using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PreciseiChamei.Domain.Interfaces;
using PreciseiChamei.Persistence.Context;
using PreciseiChamei.Persistence.Repositories;

namespace PreciseiChamei.Persistence;

public static class ServicePersistenceApp
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(("Database"));
        services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

        services.AddScoped<IUnityOfWork, IUnityOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
    
}