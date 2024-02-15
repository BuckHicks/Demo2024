using Autofac;
using Demo2024.Biz.Commons.Models;
using Demo2024.Biz.Equipment.Interfaces;
using Demo2024.Biz.Equipment.Models;

namespace Demo2024.Biz.Equipment.Services
{
    public class EquipmentFactoryService : IEquipmentFactoryService
    {
        private ILifetimeScope _scope;

        public EquipmentFactoryService(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IEquipmentModel GetEquipment()
        {
            //return _scope.Resolve<IEquipmentModel>();
            IEquipmentModel equipmentModel = new EquipmentModel();
            equipmentModel.Name = "Name";
            equipmentModel.Description.Add(new DescriptionModel("Description") );
            return equipmentModel;
        }
    }
}
