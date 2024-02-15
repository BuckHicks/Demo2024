namespace Demo2024.Biz.Equipment.Interfaces;

public interface IDamageModel
{
    string DamageDice { get; set; }

    ICategoryModel DamageType { get; set; }
}
