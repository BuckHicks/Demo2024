using Demo2024.Biz.MonsterManual.Interfaces;

namespace Demo2024.Biz.ActorCatalog.Interfaces;

public interface IActorModel
{
    string Name { get; set; }
    string Description { get; set; }
    IMonsterModel StatBlock { get; set; }
}
