﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }  //navigation property

        public int BattleId { get; set; }
        public Battle Battle { get; set; } //navigation property
    }
}
