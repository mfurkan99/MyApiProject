using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyApiProject.Coree.RedisCache
{
    
  
    public class RedisCacheService : IRedisCacheService
    {
        private readonly ConnectionMultiplexer redisconnection;
        private readonly IDatabase database;
        private readonly RedisCacheSettings redisCacheSettings;

        public RedisCacheService(IOptions<RedisCacheSettings> options)
        {
            redisCacheSettings = options.Value;
            var opt = ConfigurationOptions.Parse(redisCacheSettings.ConnectionString);
            redisconnection = ConnectionMultiplexer.Connect(opt);
            database = redisconnection.GetDatabase();
        }
        public async Task<T> GetAsync<T>(string key)
        {
            var value = await database.StringGetAsync(key);

            if (value.HasValue)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }

        public async Task SetAsync<T>(string key, T value, DateTime? expirationTime = null)
        {
            TimeSpan timeUnitExpression = expirationTime.Value - DateTime.Now;
            await database.StringSetAsync(key, JsonConvert.SerializeObject(value), timeUnitExpression);
        }
    }
}
