using Autofac;
using Demo2024.Biz.ActorCatalog.Interfaces;

namespace Demo2024.Biz.ActorCatalog.Services;

public class ActorFactoryService : IActorFactoryService
{
    private ILifetimeScope _scope;

    public ActorFactoryService(ILifetimeScope scope)
    {
        _scope = scope;
    }

    public IActorModel GetActor()
    {
        return _scope.Resolve<IActorModel>();
    }
}