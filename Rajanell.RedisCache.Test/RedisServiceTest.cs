using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rajanell.RedisCache.Model;
using Rajanell.RedisCache.Services;
using System;
using System.Threading.Tasks;

namespace Rajanell.Test
{
    [TestClass]
    public class RedisServiceTest
    {
        private IRedisService _redisService;
        private IServiceProvider _serviceProvider;
        [TestInitialize]
        public void Initialize()
        {
            _serviceProvider = ServicesProvider.GetServiceProvider();
            _redisService = _serviceProvider.GetService<IRedisService>();
        }
        [TestMethod]
        public async Task GetConfigurationTest()
        {
            var profileId = Guid.NewGuid();
            var data = new Profile
            {
                ProfileId = profileId,
                Username = "TestName"
            };

            await _redisService.AddRecord(profileId.ToString(), data);

            var result = await _redisService.GetRecord<Profile>(profileId.ToString());
            Assert.AreEqual(result.ProfileId, profileId);
        }
    }
}
