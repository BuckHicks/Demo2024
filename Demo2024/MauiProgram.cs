using Demo2020.Biz.Equipment.Services;
using Demo2024.Biz;
using Demo2024.Biz.ActorCatalog.Services;
using Demo2024.Biz.ActorCatalog.ViewModels;
using Demo2024.Biz.Equipment.Services;
using Demo2024.Biz.Equipment.ViewModels;
using Demo2024.Biz.MonsterManual.Interfaces;
using Demo2024.Biz.MonsterManual.Services;
using Demo2024.Biz.MonsterManual.ViewModels;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Demo2024
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<EquipmentService>();

            builder.Services.AddSingleton<LootTableFactoryService>();
            builder.Services.AddSingleton<LootTableSearchAndFilterService>();
            builder.Services.AddSingleton<LootTableDataAccessService>();
            builder.Services.AddSingleton<LootTableViewModel>();

            builder.Services.AddSingleton<MonsterFactoryService>();
            builder.Services.AddSingleton<MonsterSearchAndFilterService>();
            builder.Services.AddSingleton<MonsterDataAccessService>();
            builder.Services.AddSingleton<MonsterManualViewModel>();

            builder.Services.AddSingleton<EquipmentFactoryService>();
            builder.Services.AddSingleton<EquipmentSlotFactoryService>();
            builder.Services.AddSingleton<EquipmentSearchAndFilterService>();
            builder.Services.AddSingleton<EquipmentDataAccessService>();
            builder.Services.AddSingleton<EquipmentViewModel>();

            builder.Services.AddSingleton<MagicItemFactoryService>();
            builder.Services.AddSingleton<MagicItemSearchAndFilterService>();
            builder.Services.AddSingleton<MagicItemDataAccessService>();
            builder.Services.AddSingleton<MagicItemViewModel>();

            builder.Services.AddSingleton<ActorFactoryService>();
            builder.Services.AddSingleton<ActorCatalogViewModel>();

            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
