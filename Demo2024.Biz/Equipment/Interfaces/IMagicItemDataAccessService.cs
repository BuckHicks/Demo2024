using Demo2024.Biz.Equipment.Models;

namespace Demo2024.Biz.Equipment.Interfaces;

public interface IMagicItemDataAccessService
{
    Task<List<MagicItemModel>> GetAllMagicItems();
    Task<MagicItemModel> GetMagicItem(string name);
}
