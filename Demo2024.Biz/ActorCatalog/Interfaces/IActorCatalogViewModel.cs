using System;
using System.Linq;

namespace Demo2024.Biz.ActorCatalog.Interfaces;

public interface IActorCatalogViewModel
{
    IActorModel CurrentActor { get; set; }
    IList<IActorModel> Actors { get; set; }
}
