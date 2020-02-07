using Application.Common.Interfaces;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{

    public static class DependencyInjection
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<CitrixDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(CitrixDbContext).Assembly.FullName)));

                services.AddScoped<ICitrixDbContext>(provider => provider.GetService<CitrixDbContext>());

                return services;
            }
        }
    }

