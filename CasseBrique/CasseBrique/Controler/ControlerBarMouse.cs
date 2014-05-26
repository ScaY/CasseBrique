using Breakout.Controler;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique.Controler
{
    public class ControlerBarMouse : ControlerBar
    {
        public ControlerBarMouse(Bar bar)
            : base(bar)
        {

        }

        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame)
        {
            Bar Bar = (Bar)Shape;
            if ( (mouseSate.X - Bar.Size.Width / 2) >= 0 && mouseSate.X <= widthFrame)
            {
                Bar.Position = new Vector2(mouseSate.X - Bar.Size.Width / 2, Bar.Position.Y);
            }
        }
    }
}
