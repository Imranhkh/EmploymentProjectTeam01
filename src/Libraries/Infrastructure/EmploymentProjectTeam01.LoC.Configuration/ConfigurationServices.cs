using EmploymentProjectTeam01.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmploymentProjectTeam01.LoC.Configuration;

public static class ConfigurationServices
{
    public static IServiceCollection AddExtention(this IServiceCollection services, IConfiguration configuraion)
    {

        services.AddDbContext<EmploymentDbContext>(Options=>Options.UseSqlServer(configuraion.GetConnectionString("Conn")));
        return services;
    }
}
