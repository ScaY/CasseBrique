using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBar : ShapeView
    {
        public ViewBar(Bar bar,  Texture2D texture) : base(bar, texture)
        {
        }
    }
}
