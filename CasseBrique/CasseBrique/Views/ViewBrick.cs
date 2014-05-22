using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBrick : ShapeView
    {
        public Brick Brick { get; set; }

        public ViewBrick(Brick brick, Texture2D texture) : base(brick, texture)
        {
        }
    }
}
