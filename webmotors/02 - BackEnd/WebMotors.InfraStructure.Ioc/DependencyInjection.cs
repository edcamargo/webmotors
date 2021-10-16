﻿using Microsoft.Extensions.DependencyInjection;
using WebMotors.Domain.Core.Interfaces.Repositories;
using WebMotors.Domain.Core.Interfaces.Services;
using WebMotors.Domain.Services.Services;
using WebMotors.InfraStructure.Data.Repositories;

namespace WebMotors.InfraStructure.Ioc
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionServices(ref IServiceCollection services)
        {
            services.AddScoped<IAnnouncementWebMotorsService, AnnouncementWebMotorsService>();
        }
        public static void DependencyInjectionRepositories(ref IServiceCollection services)
        {
            services.AddScoped<IAnnouncementWebMotorsRepository, AnnouncementWebMotorsRepository>();
        }
    }
}