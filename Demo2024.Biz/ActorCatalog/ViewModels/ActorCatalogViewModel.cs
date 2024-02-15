﻿using Demo2024.Biz.ActorCatalog.Interfaces;
using Demo2024.Biz.Commons.Models;

namespace Demo2024.Biz.ActorCatalog.ViewModels;

public class ActorCatalogViewModel : ObservableObject, IActorCatalogViewModel
{
    //**************************************************\\
    //********************* Fields *********************\\
    //**************************************************\\
    //private IActorFactory _monsterFactory;
    //private IActorDataAccessObject _monsterDataAccessObject;
    private IActorModel _currentActor;
    private IList<IActorModel> _actors;
    private int _selectedActorIndex = -1;

    //**************************************************\\
    //******************** Methods *********************\\
    //**************************************************\\
    private void GetActorDetails()
    {
        throw new NotImplementedException();
    }

    //**************************************************\\
    //******************* Properties *******************\\
    //**************************************************\\
    public int SelectedActorIndex
    {
        get { return _selectedActorIndex; }
        set
        {
            if (_selectedActorIndex != value)
            {
                _selectedActorIndex = value;
                if (_selectedActorIndex > -1)
                {
                    GetActorDetails();
                }
                OnPropertyChanged();
            }
        }
    }
    public IActorModel CurrentActor 
    { 
        get { return _currentActor; }
        set 
        {
            if (_currentActor != value)
            {
                _currentActor = value;
                OnPropertyChanged();
            }
        }
    }

    public IList<IActorModel> Actors
    {
        get { return _actors; }
        set
        {
            if (_actors != value)
            {
                _actors = value;
                OnPropertyChanged();
            }
        }
    }
}