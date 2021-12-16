using System;
using System.Threading.Tasks;

namespace Rajanell.RedisCache.Services
{
    public interface IRedisService
    {
        Task AddRecord<T>(string recordId, T data, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null);
        Task<T> GetRecord<T>(string recordId);
    }
}
