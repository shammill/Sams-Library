﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsLibrary.csharp.Experiments.RPG.Models.Actors
{
    public class Goblin : Actor
    {
        public Goblin()
        {
            Health = 5;
            BaseDamageReduction = 0;
            BaseSpeed = 5;
            CanDie = true;
            IsAlive = true;
            IsInvulnerable = false;
            IsMobile = true;
        }

    }
}
