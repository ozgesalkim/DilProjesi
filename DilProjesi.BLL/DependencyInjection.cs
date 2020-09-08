using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DilProjesi.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IDilService, DilManager>();
            services.AddScoped<IProjeService, ProjeManager>();
            services.AddScoped<ISozcukService, SozcukManager>();
            services.AddScoped<ITercumeService, TercumeManager>();

            return services;
        }
    }
}
