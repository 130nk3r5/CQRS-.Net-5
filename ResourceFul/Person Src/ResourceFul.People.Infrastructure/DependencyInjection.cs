using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResourceFul.People.Application.Common.Interfaces;
using ResourceFul.People.Infrastructure.Persistence;

namespace ResourceFul.People.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PersonContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPersonDbContext>(provider => provider.GetService<PersonContext>());

            return services;
        }
    }
}
