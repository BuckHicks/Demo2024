namespace Demo2024.Biz.Equipment.Interfaces;

public interface ILootTableSearchAndFilterService
{
    IList<ILootTableModel> Filter(IList<ILootTableModel> list, string filter);
}
