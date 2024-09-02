using BookStore.Services;
using FitnessTracker.Repositories;
using FitnessTracker.Services;

namespace FitnessTracker.Extensions
{
    public static class AppServiceExtensions
    {
        public static IServiceCollection AddDependencyGroup(this IServiceCollection services,
        IConfiguration config)
        {
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
            services.AddScoped<IRunningActivityRepository, RunningActivityRepository>();
            services.AddScoped<IUserProfileService, UserProfileService>();
            services.AddScoped<IRunningActivityService, RunningActivityService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
