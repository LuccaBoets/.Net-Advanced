using BLL.Interface;
using BLL.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonApi.Context;
using PersonApi.Interface;
using PersonApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Extension
{
    public static class DLLExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            
            return services;
        }
    }
}
