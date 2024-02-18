using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Demo2024.Biz.MonsterManual.Interfaces;
using Demo2024.Biz.MonsterManual.Models;

namespace Demo2024.Biz.MonsterManual.ViewModels
{
    public partial class MonsterManualViewModel : ObservableObject, IMonsterManualViewModel
    {
        //**************************************************\\
        //********************* Fields *********************\\
        //**************************************************\\

        [ObservableProperty] private IMonsterModel currentMonster;
        [ObservableProperty] private IList<IMonsterModel> monsters;
        [ObservableProperty] private int selectedMonsterIndex = -1;
        [ObservableProperty] private string editIconSource;
        [ObservableProperty] private string filter = "";
        [ObservableProperty] private bool isEditEnabled;

        private IMonsterFactoryService _monsterFactory;
        private IMonsterDataAccessService _monsterDataAccessObject;
        private IMonsterSearchAndFilterService _searchAndFilterService;
        private IList<IMonsterModel> _monstersRaw;        
       
        private const string UNLOCKED_IMAGE_PATH = "/Demo2024;component/Resources/Images/UnlockIcon.png";
        private const string LOCKED_IMAGE_PATH = "/Demo2024;component/Resources/Images/LockIcon.png";

        public MonsterManualViewModel(IMonsterFactoryService monsterFactory, IMonsterDataAccessService monsterDataAccessObject, IMonsterSearchAndFilterService searchAndFilterService)
        {
            _monsterFactory = monsterFactory;
            _monsterDataAccessObject = monsterDataAccessObject;
            _searchAndFilterService = searchAndFilterService;

            EditIconSource = LOCKED_IMAGE_PATH;

            Messenger.Default.Register<MessageWindowResponse>(this, "ReloadMonster", msg =>
            {
                if (msg.Response)
                {
                    GetMonsterDetails();
                }
            });

            GetMonsters();
        }

        //**************************************************\\
        //******************** Methods *********************\\
        //**************************************************\\
        private async void GetMonsters()
        {
            _monstersRaw = Monsters = (await _monsterDataAccessObject.GetAllMonsters())
                .Cast<IMonsterModel>()
                .ToList() as IList<IMonsterModel>;
        }

        private async void GetMonsterDetails()
        {
            CurrentMonster = Monsters[SelectedMonsterIndex];
            if (CurrentMonster.IsDataComplete == false)
            {
                Monsters[SelectedMonsterIndex] = (await _monsterDataAccessObject.GetMonster(Monsters[SelectedMonsterIndex].Name)) as IMonsterModel;

                // The monster api failed and returned null
                if (Monsters[SelectedMonsterIndex] == null)
                {
                    Monsters[SelectedMonsterIndex] = CurrentMonster;
                    Messenger.Default.Send(new MessageWindowConfiguration
                    {
                        Message = "An error occurred while getting " + CurrentMonster.Name + " data. Would you like to try again? " +
                        "Check you internet connection if you continue to see this message.",
                        IsOkVisible = false,
                        IsTrueFalseVisible = true,
                        Token = "ReloadMonster"
                    });
                }
                else
                {
                    Monsters[SelectedMonsterIndex].IsDataComplete = true;
                    CurrentMonster = Monsters[SelectedMonsterIndex];
                }
            }
        }

        [RelayCommand]
        private void ToggleEdit()
        {
            if (IsEditEnabled)
            {
                IsEditEnabled = false;
            }
            else
            {
                IsEditEnabled = true;
            }
        }

        [RelayCommand]
        private void AddMonster()
        {
            Monsters.Add(new MonsterModel
            {
                Name = "{{Name}}",
                MonsterType = "{{MonsterType}}",
                MonsterSubtype = "{{MonsterSubtype}}",
                Alignment = "{{Alignment}}",
                Size = "{{Size}}"
            });
        }

        //**************************************************\\
        //******************* Properties *******************\\
        //**************************************************\\
        //https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/generators/observableproperty
        
        partial void OnFilterChanged(string? value)
        {
            Monsters = _searchAndFilterService.Filter(_monstersRaw, Filter);
        }

        partial void OnIsEditEnabledChanged(bool value)
        {
            if (value)
            {
                EditIconSource = UNLOCKED_IMAGE_PATH;
            }
            else
            {
                EditIconSource = LOCKED_IMAGE_PATH;
            }
        }
    }
}