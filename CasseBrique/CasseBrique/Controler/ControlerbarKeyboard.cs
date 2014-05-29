using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace Breakout.Controler
{
    public class ControlerBarKeyboard : ControlerBar
    {
        public ControlerBarKeyboard(BreakoutModel model)
            : base(model)
        {

        }

        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame, Player player)
        {
            Bar Bar = player.Bar;

            if (keyBoardState.IsKeyDown(player.MoveRightKey) && (Bar.Position.X + Bar.Size.Width < widthFrame))
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            else if (keyBoardState.IsKeyDown(player.MoveLeftKey) && Bar.Position.X > 0)
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(-1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }

            if (!Model.GameLauch)
            {
                Bar.StartBall.Position = new Vector2(Bar.Position.X + Bar.Size.Width / 2 - Bar.StartBall.Size.Width/2 , Bar.Position.Y - Bar.StartBall.Size.Height -160);
            }
        }
    }
}
