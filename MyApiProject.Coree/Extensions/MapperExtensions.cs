using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Extensions
{
    public static class MapperExtensions
    {
        public static void AddMapperExtensions(this IServiceCollection services)
        {
            services.AddSingleton<AutoMapperFolder.IMapper, AutoMapperFolder.CustomMapper>();
        }
    }
}
