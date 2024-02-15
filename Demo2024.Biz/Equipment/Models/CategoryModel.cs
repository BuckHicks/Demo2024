using Demo2024.Biz.Equipment.Interfaces;
using Newtonsoft.Json;

namespace Demo2024.Biz.Equipment.Models;

public class CategoryModel : ICategoryModel
{
    [JsonProperty("index")]
    public string Index { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}
