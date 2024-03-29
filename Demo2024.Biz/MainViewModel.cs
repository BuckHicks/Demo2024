﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Demo2024.Biz.ActorCatalog.Interfaces;
using Demo2024.Biz.Commons.Interfaces;
using Demo2024.Biz.Equipment.Interfaces;
using Demo2024.Biz.MonsterManual.Interfaces;
using System.Windows.Input;

namespace Demo2024.Biz;

public class MainViewModel : ObservableObject, IMainViewModel
{
    //**************************************************\\
    //********************* Fields *********************\\
    //**************************************************\\
    private ObservableObject _currentViewModel;
    private IMonsterManualViewModel _monsterManualViewModel;
    private IEquipmentViewModel _equipmentViewModel;
    private IMagicItemViewModel _magicItemViewModel;
    private ILootTableViewModel _lootTableViewModel;
    private IActorCatalogViewModel _actorCatalogViewModel;

    public MainViewModel(/*IMonsterManualViewModel monsterManualViewModel, IEquipmentViewModel equipmentViewModel, IMagicItemViewModel magicItemViewModel,
        ILootTableViewModel lootTableViewModel, IActorCatalogViewModel actorCatalogViewModel*/)
    {
        //_monsterManualViewModel = monsterManualViewModel;
        //_equipmentViewModel = equipmentViewModel;
        //_magicItemViewModel = magicItemViewModel;
        //_lootTableViewModel = lootTableViewModel;
        //_actorCatalogViewModel = actorCatalogViewModel;

        MonsterManualCommand = new RelayCommand<ObservableObject>(x => ChangeView((ObservableObject)_monsterManualViewModel));
        EquipmentCommand = new RelayCommand<ObservableObject>(x => ChangeView((ObservableObject)_equipmentViewModel));
        MagicItemCommand = new RelayCommand<ObservableObject>(x => ChangeView((ObservableObject)_magicItemViewModel));
        LootCommand = new RelayCommand<ObservableObject>(x => ChangeView((ObservableObject)_lootTableViewModel));
        ActorCatalogCommand = new RelayCommand<ObservableObject>(x => ChangeView((ObservableObject)_actorCatalogViewModel));

        CurrentViewModel = (ObservableObject)_lootTableViewModel;
    }

    private void ChangeView(ObservableObject newView)
    {
        CurrentViewModel = newView;
    }

    //**************************************************\\
    //******************* Properties *******************\\
    //**************************************************\\
    public ObservableObject CurrentViewModel
    {
        get { return _currentViewModel; }
        set
        {
            if (_currentViewModel != value)
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand MonsterManualCommand { get; set; }
    public ICommand EquipmentCommand { get; set; }
    public ICommand MagicItemCommand { get; set; }
    public ICommand LootCommand { get; set; }
    public ICommand ActorCatalogCommand { get; set; }
}
