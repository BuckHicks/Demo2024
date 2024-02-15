namespace Demo2024.Biz.Equipment.Interfaces;

public interface IEquipmentViewModel
{
    IEquipmentModel CurrentEquipment { get; set; }
    IList<IEquipmentModel> Equipment { get; set; }
}
