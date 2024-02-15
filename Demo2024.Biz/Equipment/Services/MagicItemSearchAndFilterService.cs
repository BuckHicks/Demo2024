using Demo2024.Biz.Equipment.Interfaces;

namespace Demo2024.Biz.Equipment.Services
{
    public class MagicItemSearchAndFilterService : IMagicItemSearchAndFilterService
    {
        public IList<IMagicItemModel> Filter(IList<IMagicItemModel> list, string filter)
        {
            IList<IMagicItemModel> results = new List<IMagicItemModel>();
            foreach (IMagicItemModel magicItem in list)
            {
                string buffer = magicItem.Name.ToLower();
                if (buffer.Contains(filter.ToLower()))
                {
                    results.Add(magicItem);
                }
            }

            return results;
        }
    }
}
