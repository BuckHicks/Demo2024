using Demo2024.Biz.MonsterManual.Models;

namespace Demo2024.Biz.MonsterManual.Interfaces;

public interface IMonsterDataAccessService
{
    Task<List<MonsterModel>> GetAllMonsters();
    Task<MonsterModel> GetMonster(string name);
}
