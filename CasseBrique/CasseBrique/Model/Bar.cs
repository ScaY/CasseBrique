﻿using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace CasseBrique
{
    public class Bar : Shape
    {

        public Size Size { get; set; }

        public Bar() : base()
        {
            Size = new Size(0, 0);
        }

        public Bar(Vector2 position, Vector2 deplacement, float speed, int width, int height) : base(position, deplacement, speed)
        {
            Size = new Size(width, height);
        }

        public Rectangle getRectangle()
        {
                return new Rectangle((int)Position.X, (int)Position.Y, Size.Width, Size.Height);
            
        }

    }
}