using Microsoft.Extensions.DependencyInjection;
using WebMotors.Domain.Core.Interfaces.Repositories;
using WebMotors.Domain.Core.Interfaces.Services;
using WebMotors.Domain.Core.Shared;
using WebMotors.Domain.Services.Services;
using WebMotors.InfraStructure.AntiCorruption.WebMotors;
using WebMotors.InfraStructure.Data.Repositories;

namespace WebMotors.InfraStructure.Ioc
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionServices(this IServiceCollection services)
        {
            services.AddTransient<IAnnouncementWebMotorsService, AnnouncementWebMotorsService>();
            services.AddTransient<IWebMotorsFacade, WebMotorsFacade>();
        }
        public static void DependencyInjectionRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncementWebMotorsRepository, AnnouncementWebMotorsRepository>();
        }
    }
}