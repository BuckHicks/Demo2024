using System;
using System.Linq;

namespace Demo2024.Biz.ActorCatalog.Interfaces;

public interface IActorFactoryService
{
    IActorModel GetActor();
}
