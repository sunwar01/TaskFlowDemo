using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskFlowDemo.Infrastructure.Persistence;

namespace TaskFlowDemo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<TaskFlowDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

      
        // - repositories
        // - token services
        // - email services osv.
   
       

        return services;
    }
}