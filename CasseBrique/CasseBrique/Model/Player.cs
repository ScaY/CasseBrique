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

        public Player(String _name, Bar _bar, Ball _ball)
        {
            this.Name = _name;
            this.Bar = _bar;
            this.Ball = _ball;
        }
    }
}
