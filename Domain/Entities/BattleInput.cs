using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Battle;

namespace Domain.Entities
{
    public class BattleInput
    {
        public int Id { get; set; }

        // Change this when Battle changes..
        public KoffieBattle Gegevens { get; set; }

    }
}
