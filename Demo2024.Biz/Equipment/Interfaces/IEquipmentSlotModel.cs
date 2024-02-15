namespace Demo2024.Biz.Equipment.Interfaces;

public interface IEquipmentSlotModel
{
    int Id { get; set; }
    int Index { get; set; }
    IEquipmentModel Equipment { get; set; }
    int Multiplier { get; set; }
    int LootTableId { get; set; }
}
