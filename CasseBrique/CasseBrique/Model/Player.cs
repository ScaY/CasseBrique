﻿using Breakout.Bonus;
using CasseBrique.Controler;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Breakout.Model
{
    public class Player
    {
        public string Name
        {
            get;
            set;
        }
        public Bar Bar
        {
            get;
            set;
        }

        public int Life
        {
            get;
            set;
        }

        public NameControlerBar ControlGame
        {
            get;
            set;
        }

        public int Score
        {
            get;
            set;
        }

        public List<AbstractBonus> Bonuses { get; set; }

        public Keys MoveLeftKey { get; set; }

        public Keys MoveRightKey { get; set; }

        public Player() : this("")
        {
        }

        public Player(String _name)
        {
            this.Name = _name;
            this.Bar = new Bar();
            this.Bonuses = new List<AbstractBonus>();
        }
    }
}
