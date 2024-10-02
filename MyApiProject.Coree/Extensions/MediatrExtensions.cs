using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApiProject.Coree.Beheviors;
using MyApiProject.Coree.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Extensions
{
    public static class MediatrExtensions
    {
        public static void AddMediatrExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(config=>config.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new System.Globalization.CultureInfo("en-US");

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RedisCacheBehevior<,>));

            services.Configure<RedisCacheSettings>(configuration.GetSection("RedisCacheSettings"));
            services.AddTransient<IRedisCacheService, RedisCacheService>();
        }
    }
}
