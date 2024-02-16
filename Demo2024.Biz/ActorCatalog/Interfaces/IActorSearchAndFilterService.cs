namespace Demo2024.Biz.ActorCatalog.Interfaces;

public interface IActorSearchAndFilterService
{
    IList<IActorModel> Filter(IList<IActorModel> list, string filter);
}
