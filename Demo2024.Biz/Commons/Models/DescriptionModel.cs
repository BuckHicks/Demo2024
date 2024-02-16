using CommunityToolkit.Mvvm.ComponentModel;

namespace Demo2024.Biz.Commons.Models;

public partial class DescriptionModel : ObservableObject
{
    [ObservableProperty] private int id;
    [ObservableProperty] private string text;

    public DescriptionModel(string text)
    {
        Text = text;
    }

    public DescriptionModel(int id, string text)
    {
        Id = id;
        Text = text;
    }
}