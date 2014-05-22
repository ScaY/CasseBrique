using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public abstract class ControlerBar
    {
        private Bar bar;

        public Bar Bar
        {
            get { return bar; }
            set { bar = value; }
        }

        public ControlerBar(Bar bar)
        {
            this.Bar = bar;
        }

        public abstract void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame);
    }
}
