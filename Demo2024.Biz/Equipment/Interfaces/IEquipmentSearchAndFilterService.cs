namespace Demo2024.Biz.Equipment.Interfaces;

public interface IEquipmentSearchAndFilterService
{
    IList<IEquipmentModel> Filter(IList<IEquipmentModel> list, string filter);
}
