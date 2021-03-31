using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ResourceFul.People.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPeopleApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
