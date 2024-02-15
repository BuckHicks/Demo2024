using Autofac;
using Demo2024.Biz.MonsterManual.Interfaces;

namespace Demo2024.Biz.MonsterManual.Services
{
    public class SpeedFactoryService : ISpeedFactoryService
    {
        private ILifetimeScope _scope;

        public SpeedFactoryService(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public ISpeedModel GetSpeed()
        {
            return _scope.Resolve<ISpeedModel>();
        }
    }
}
