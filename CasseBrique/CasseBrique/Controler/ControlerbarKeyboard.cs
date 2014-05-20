using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace CasseBrique
{
    public class ControlerbarKeyboard : ControlerBar
    {
        public ControlerbarKeyboard(Bar bar) : base(bar)
        {

        }

        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame)
        {
            if (keyBoardState.IsKeyDown(Keys.Right) && (Bar.Position.X + Bar.Size.Width < widthFrame))
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            else if (keyBoardState.IsKeyDown(Keys.Left) && Bar.Position.X > 0)
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(-1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }
    }
}
