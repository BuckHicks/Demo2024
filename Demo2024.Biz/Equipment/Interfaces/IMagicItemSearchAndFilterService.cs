namespace Demo2024.Biz.Equipment.Interfaces;

public interface IMagicItemSearchAndFilterService
{
    IList<IMagicItemModel> Filter(IList<IMagicItemModel> list, string filter);
}
