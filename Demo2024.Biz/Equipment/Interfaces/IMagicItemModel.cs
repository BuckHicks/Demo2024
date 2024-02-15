using Demo2024.Biz.Commons.Models;

namespace Demo2024.Biz.Equipment.Interfaces;

public interface IMagicItemModel
{
    Guid Id { get; set; }

    string Name { get; set; }

    IList<DescriptionModel> Description { get; set; }

    ICategoryModel EquipmentCategory { get; set; }

    bool IsDataComplete { get; set; }
}
