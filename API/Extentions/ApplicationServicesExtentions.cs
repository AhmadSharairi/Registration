
using Core.Interfaces;
using Core.Services;
using Infrastructure.Repositories;


namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
       
            services.AddScoped<IUserRepository, UserRepository>();

        
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

           
            return services;
        }
    }
}
