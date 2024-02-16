using CommunityToolkit.Mvvm.ComponentModel;
using Demo2024.Biz.ActorCatalog.Interfaces;

namespace Demo2024.Biz.ActorCatalog.ViewModels;

public partial class ActorCatalogViewModel : ObservableObject, IActorCatalogViewModel
{
    [ObservableProperty] private IActorModel currentActor;
    [ObservableProperty] private IList<IActorModel> actors;
    [ObservableProperty] private int selectedActorIndex = -1;

    private void GetActorDetails()
    {
        throw new NotImplementedException();
    }
}