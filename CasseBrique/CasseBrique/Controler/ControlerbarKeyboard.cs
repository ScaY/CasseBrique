using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace Breakout.Controler
{
    public class ControlerBarKeyboard : ControlerBar
    {
        public ControlerBarKeyboard(Bar bar) : base(bar)
        {

        }

        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame)
        {
            Bar Bar = (Bar)Shape;
/*
            if (keyBoardState.IsKeyDown(Keys.Right) && (Bar.Position.X  < widthFrame))
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            else if (keyBoardState.IsKeyDown(Keys.Left) && Bar.Position.X > 0)
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(-1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }*/
            /*else */if ( (mouseSate.X - Bar.Size.Width / 2) >= 0 && mouseSate.X <= widthFrame)
            {
                Bar.Position = new Vector2(mouseSate.X - Bar.Size.Width / 2, Bar.Position.Y);
            }
        }
    }
}
