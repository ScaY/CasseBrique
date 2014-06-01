using Breakout.Controler;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CasseBrique.Controler
{
    /// <summary>
    /// This is a class that represents a controler of the bar, that operates with the mouse.
    /// </summary>
    public class ControlerBarMouse : ControlerBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBarMouse"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ControlerBarMouse(BreakoutModel model)
            : base(model)
        {

        }

        /// <summary>
        /// Handles the different actions of the player, and changes the position of the bar.
        /// </summary>
        /// <param name="keyBoardState">State of the key board.</param>
        /// <param name="mouseSate">The mouse sate.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="widthFrame">The width frame.</param>
        /// <param name="player">The player.</param>
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
