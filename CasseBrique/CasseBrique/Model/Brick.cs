﻿using CasseBrique;
using Microsoft.Xna.Framework;

namespace Breakout.Model
{
    public class Brick : Shape
    {
        public int Life { get; set; }

        public int XBrick { get; set; }

        public int YBrick { get; set; }

        public Brick() 
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = 0;

        }
        public Size Size { get; set; }

        public Brick(Vector2 position, int life, Size size)
            : base(position, Vector2.Zero, 0f)
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = life;
            this.Size = size;
        }
    }
}