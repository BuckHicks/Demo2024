using Demo2024.Biz.Equipment.Models;
using System;
using System.Linq;

namespace Demo2024.Biz.Equipment.Interfaces;

public interface IEquipmentDataAccessService
{
    Task<List<EquipmentModel>> GetAllEquipmentAsync();
    Task<EquipmentModel> GetEquipmentAsync(string name);
    IEquipmentModel GetEquipment(int id);
    IEquipmentModel GetEquipment(string name);
    IList<IEquipmentModel> GetAllEquipment();
    bool SaveEquipment(IEquipmentModel equipment);
    bool SaveEquipment(IList<IEquipmentModel> equipment);
    bool DeleteEquipment(IEquipmentModel equipment);
    bool DeleteEquipment(IList<IEquipmentModel> equipment);
}
