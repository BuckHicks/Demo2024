using Demo2024.Biz.ActorCatalog.Interfaces;
using Demo2024.Biz.Commons.Models;
using Demo2024.Biz.MonsterManual.Interfaces;
using System;
using System.Linq;

namespace Demo2024.Biz.ActorCatalog.Models
{
    public class ActorModel : ObservableObject, IActorModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IMonsterModel StatBlock { get; set; }
    }
}
