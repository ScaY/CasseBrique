using Breakout.Controler;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CasseBrique.Controler
{
    public class ControlerBarMouse : ControlerBar
    {
        public ControlerBarMouse(BreakoutModel model)
            : base(model)
        {

        }

        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame, Player player)
        {
            Bar Bar = player.Bar;

            if ((mouseSate.X - Bar.Size.Width / 2) >= 0 && (mouseSate.X + Bar.Size.Width / 2) <= widthFrame)
            {
                Bar.Position = new Vector2(mouseSate.X - Bar.Size.Width / 2, Bar.Position.Y);
            }

            if (!Model.GameLauch)
            {
                Bar.StartBall.Position = new Vector2(Bar.Position.X + Bar.Size.Width / 2 - Bar.StartBall.Size.Width / 2, Bar.Position.Y - Bar.StartBall.Size.Height);
            }
        }
    }
}
