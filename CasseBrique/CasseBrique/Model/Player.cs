using Breakout.Bonus;
using CasseBrique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class Player
    {
        public Player()
        {


        }

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

        public Ball Ball
        {
            get;
            set;
        }
        public int Life
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

        public Player(String _name, Ball _ball)
        {
            this.Name = _name;
            this.Bar = new Bar();
            this.Ball = _ball;
            this.Bonuses = new List<AbstractBonus>();
        }
    }
}
