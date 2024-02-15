namespace Demo2024.Biz.MonsterManual.Interfaces;

public interface IMonsterManualViewModel
{
    IMonsterModel CurrentMonster { get; set; }
    IList<IMonsterModel> Monsters { get; set; }
}
