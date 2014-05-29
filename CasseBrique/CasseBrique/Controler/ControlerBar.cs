using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Breakout.Controler
{
    public abstract class ControlerBar : AbstractControler
    {
        public ControlerBar()
        {
        }

        public ControlerBar(BreakoutModel model) : base(model)
        {

        }

        public abstract void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame, Player player);
    }
}
