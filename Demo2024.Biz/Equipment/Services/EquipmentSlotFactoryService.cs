using Autofac;
using Demo2024.Biz.Equipment.Interfaces;
using Demo2024.Biz.Equipment.Models;

namespace Demo2024.Biz.Equipment.Services
{
    public class EquipmentSlotFactoryService : IEquipmentSlotFactoryService
    {
        private ILifetimeScope _scope;
        private IEquipmentService _equipmentService;

        public EquipmentSlotFactoryService(ILifetimeScope scope, IEquipmentService equipmentService)
        {
            _scope = scope;
            _equipmentService = equipmentService;
        }

        public IEquipmentSlotModel GetEquipmentSlot()
        {
            return new EquipmentSlotModel(_equipmentService);
        }
    }
}
