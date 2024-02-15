using Demo2024.Biz.Equipment.Interfaces;
using Newtonsoft.Json;

namespace Demo2024.Biz.Equipment.Models;

public class RangeModel : IRangeModel
{
    [JsonProperty("normal")]
    public int? Normal { get; set; }

    [JsonProperty("long")]
    public int? Long { get; set; }
}
