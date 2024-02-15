namespace Demo2024.Biz.Equipment.Interfaces;

public interface ILootTableViewModel
{
    ILootTableModel CurrentLootTable { get; set; }
    IList<ILootTableModel> LootTables { get; set; }
}
