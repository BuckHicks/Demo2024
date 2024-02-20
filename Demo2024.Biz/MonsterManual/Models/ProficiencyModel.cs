using Newtonsoft.Json;

namespace Demo2024.Biz.MonsterManual.Models;

public class ProficiencyModel
{

    [JsonProperty("value")]
    public long Value { get; set; }

    [JsonProperty("proficiency")]
    public ProficiencyElementModel Element { get; set; }
}
