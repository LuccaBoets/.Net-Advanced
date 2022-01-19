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

namespace DAL.Extension
{
    public static class DALExtension
    {
        public static IServiceCollection RegisterDataAccessServices(this IServiceCollection services)
        {
            services.RegisterContexts();
            services.RegisterRepositories();
            services.RegisterUnitOfWork();

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            
            return services;
        }

        public static IServiceCollection RegisterContexts(this IServiceCollection services)
        {
            services.AddDbContext<PersonContext>(options => options.UseSqlServer("name=ConnectionStrings:Person"));

            return services;
        }

        public static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
