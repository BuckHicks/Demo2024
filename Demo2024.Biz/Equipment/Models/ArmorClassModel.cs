using Demo2024.Biz.Equipment.Interfaces;
using Newtonsoft.Json;

namespace Demo2024.Biz.Equipment.Models
{
    public class ArmorClassModel : IArmorClassModel
    {
        [JsonProperty("base")]
        public int? Base { get; set; }

        [JsonProperty("dex_bonus")]
        public bool DexBonus { get; set; }

        [JsonProperty("max_bonus")]
        public int? MaxBonus { get; set; }
    }
}
