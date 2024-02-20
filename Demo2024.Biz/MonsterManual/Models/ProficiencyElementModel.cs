using Newtonsoft.Json;

namespace Demo2024.Biz.MonsterManual.Models;

public class ProficiencyElementModel
{
    [JsonProperty("name")]
    public string Name { get; set; }
}