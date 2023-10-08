using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Infrastructure.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {     
            services.AddScoped<IProgramDetailService, ProgramDetailService>();
            services.AddScoped<IApplicationService, ApplicationFormService>();
            services.AddScoped<IPreviewService, PreviewService>();
            return services;
        }
    }
}
