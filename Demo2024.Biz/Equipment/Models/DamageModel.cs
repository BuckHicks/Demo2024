using Demo2024.Biz.Equipment.Interfaces;
using Demo2024.Biz.Equipment.Models;
using Newtonsoft.Json;

namespace Demo2020.Biz.Equipment.Models;

public class DamageModel : IDamageModel
{
    public DamageModel()
    {
        DamageType = new CategoryModel();
    }

    [JsonProperty("damage_dice")]
    public string DamageDice { get; set; }

    [JsonProperty("damage_type")]
    public ICategoryModel DamageType { get; set; }
}
