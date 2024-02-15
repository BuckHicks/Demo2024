using Autofac;
using Demo2024.Biz.MonsterManual.Interfaces;

namespace Demo2024.Biz.MonsterManual.Services
{
    public class MonsterFactoryService : IMonsterFactoryService
    {
        private ILifetimeScope _scope;
        private ISpeedFactoryService _speedFactory;

        public MonsterFactoryService(ILifetimeScope scope, ISpeedFactoryService speedFactory)
        {
            _scope = scope;
            _speedFactory = speedFactory;
        }

        public IMonsterModel GetMonster()
        {
            return _scope.Resolve<IMonsterModel>();
        }
    }
}
