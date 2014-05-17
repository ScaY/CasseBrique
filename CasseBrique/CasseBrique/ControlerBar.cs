using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique
{
    public class ControlerBar
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

        public void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime)
        {
            if (keyBoardState.IsKeyDown(Keys.Right))
            {
                bar.Deplacement = Vector2.Normalize(new Vector2(1, 0));
                bar.Position += bar.Deplacement * bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            else if (keyBoardState.IsKeyDown(Keys.Left))
            {
                bar.Deplacement = Vector2.Normalize(new Vector2(-1, 0));
                bar.Position += bar.Deplacement * bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }


        }
    }
}
