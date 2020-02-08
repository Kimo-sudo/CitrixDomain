using System.Collections.Generic;
using Domain.Common;
using Domain.Entities.Battle;
using Domain.Enum;

namespace Domain.Entities
{
    public class FranchiseBattle

    {
        public FranchiseBattle()
        {
            RestaurantInput = new HashSet<BattleInput>();
        }
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public ICollection<BattleInput> RestaurantInput { get; set; }
    }
}