using Demo2024.Biz.Equipment.Interfaces;

namespace Demo2024.Biz.Equipment.Services
{
    public class EquipmentSearchAndFilterService : IEquipmentSearchAndFilterService
    {
        public IList<IEquipmentModel> Filter(IList<IEquipmentModel> list, string filter)
        {
            IList<IEquipmentModel> results = new List<IEquipmentModel>();
            foreach (IEquipmentModel equipment in list)
            {
                string buffer = equipment.Name.ToLower();
                if (buffer.Contains(filter.ToLower()))
                {
                    results.Add(equipment);
                }
            }

            return results;
        }
    }
}
