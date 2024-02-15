using Autofac;
using Demo2024.Biz.Equipment.Interfaces;

namespace Demo2024.Biz.Equipment.Services
{
    public class MagicItemFactoryService : IMagicItemFactoryService
    {
        private ILifetimeScope _scope;

        public MagicItemFactoryService(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IMagicItemModel GetMagicItem()
        {
            return _scope.Resolve<IMagicItemModel>();
        }
    }
}
