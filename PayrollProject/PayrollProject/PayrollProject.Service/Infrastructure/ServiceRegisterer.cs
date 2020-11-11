using Microsoft.Extensions.DependencyInjection;
using PayrollProject.Service.Abstract;
using PayrollProject.Service.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollProject.Service.Infrastructure
{
    public static class ServiceRegisterer
    {
        /// <summary>
        /// Servisleri register eder.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPayrollService, PayrollService>();
            return services;
        }
    }
}
