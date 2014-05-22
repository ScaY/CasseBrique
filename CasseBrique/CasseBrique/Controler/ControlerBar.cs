using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public abstract class ControlerBar : ControlerShape
    {
        public ControlerBar(Bar bar) : base(bar)
        {
        }

        public abstract void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame);
    }
}
