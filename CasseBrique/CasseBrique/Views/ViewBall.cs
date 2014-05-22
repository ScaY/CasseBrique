using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBall : ShapeView
    {
        public ViewBall(Ball ball, Texture2D texture) : base(ball, texture)
        {  
        }
    }

}
