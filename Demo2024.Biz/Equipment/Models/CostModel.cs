using CommunityToolkit.Mvvm.ComponentModel;
using Demo2024.Biz.Commons.Models;
using Demo2024.Biz.Equipment.Interfaces;
using Newtonsoft.Json;

namespace Demo2024.Biz.Equipment.Models;

public class CostModel : ObservableObject, ICostModel
{
    private long _quantity;
    private string _unit;
    private List<string> _unitTypes = new List<string> { "cp", "sp", "gp", "pp", "ep" };

    [JsonProperty("quantity")]
    public long Quantity
    {
        get { return _quantity; }
        set
        {
            if (_quantity != value)
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
    }

    [JsonProperty("unit")]
    public string Unit
    {
        get { return _unit; }
        set
        {
            if (_unit != value)
            {
                _unit = value;
                OnPropertyChanged();
            }
        }
    }

    public List<string> UnitTypes 
    {
        get { return _unitTypes; }
        set
        {
            if(_unitTypes != value)
            {
                _unitTypes = value;
                OnPropertyChanged();
            }
        }
    }
}
